using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasOchoAccionesAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_ocho_acciones",
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
                    table.PrimaryKey("pk_catalogo_ocho_acciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_preguntas_ocho_acciones",
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
                    table.PrimaryKey("pk_catalogo_preguntas_ocho_acciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    genero_id = table.Column<int>(type: "integer", nullable: false),
                    escolaridad_id = table.Column<int>(type: "integer", nullable: false),
                    motivo_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    estatus_registro_id = table.Column<int>(type: "integer", nullable: true),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_catalogo_estatus_voluntario_estatus_",
                        column: x => x.estatus_registro_id,
                        principalTable: "catalogo_estatus_voluntario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_entidad_federativa_entidad_federativ",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_escolaridad_escolaridad_id",
                        column: x => x.escolaridad_id,
                        principalTable: "escolaridad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_motivo_motivo_id",
                        column: x => x.motivo_id,
                        principalTable: "motivo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario_catalogo_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario_catalogo_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuario_catalogo_ocho_acciones_catalogo_ocho_acciones_catal",
                        column: x => x.catalogo_ocho_acciones_id,
                        principalTable: "catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones_catalogo_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones_catalogo_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_catalogo_ocho_acciones_catalogo_ocho",
                        column: x => x.catalogo_ocho_acciones_id,
                        principalTable: "catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_catalogo_ocho_acciones_registro_ocho",
                        column: x => x.registro_ocho_acciones_id,
                        principalTable: "registro_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones_habilidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    habilidad_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones_habilidad", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_habilidad_habilidad_habilidad_id",
                        column: x => x.habilidad_id,
                        principalTable: "habilidad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_habilidad_registro_ocho_acciones_reg",
                        column: x => x.registro_ocho_acciones_id,
                        principalTable: "registro_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro_ocho_acciones_interes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    interes_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_ocho_acciones_interes", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_interes_interes_interes_id",
                        column: x => x.interes_id,
                        principalTable: "interes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_ocho_acciones_interes_registro_ocho_acciones_regis",
                        column: x => x.registro_ocho_acciones_id,
                        principalTable: "registro_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas_ocho_acciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuestas_ocho_acciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_catalogo_preguntas_ocho_acciones_p",
                        column: x => x.pregunta_id,
                        principalTable: "catalogo_preguntas_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_registro_ocho_acciones_registro_oc",
                        column: x => x.registro_ocho_acciones_id,
                        principalTable: "registro_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas_ocho_acciones_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_catalogo_ocho_acciones_id = table.Column<int>(type: "integer", nullable: false),
                    pregunta_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuestas_ocho_acciones_usuario", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_usuario_catalogo_preguntas_ocho_ac",
                        column: x => x.pregunta_id,
                        principalTable: "catalogo_preguntas_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respuestas_ocho_acciones_usuario_usuario_catalogo_ocho_acci",
                        column: x => x.usuario_catalogo_ocho_acciones_id,
                        principalTable: "usuario_catalogo_ocho_acciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.InsertData(
                table: "catalogo_ocho_acciones",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6568), "El movimiento escucha" },
                    { 2, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6573), "La quincena" },
                    { 3, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6574), "Picnic naranja" },
                    { 4, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6575), "Pinta el futuro" },
                    { 5, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6575), "Escuela naranja" },
                    { 6, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6576), "Barrio naranja" },
                    { 7, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6577), "Mercadito naranja" },
                    { 8, true, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6578), "Casas naranjas" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "nombre" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6390), "Platícanos tus necesidades de capacitación o certifícate con CONOCER" });

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.InsertData(
                table: "catalogo_preguntas_ocho_acciones",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6602), "¿Cómo quieres participar?" },
                    { 2, null, new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6606), "¿Cómo propones hacerlo?" }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5972), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5973), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5977), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5981), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5982), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5989), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5990), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5992), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5993), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5998), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5999), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6249), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(4682), new DateTime(2023, 5, 9, 5, 42, 7, 706, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_entidad_federativa_id",
                table: "registro_ocho_acciones",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_escolaridad_id",
                table: "registro_ocho_acciones",
                column: "escolaridad_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_estatus_registro_id",
                table: "registro_ocho_acciones",
                column: "estatus_registro_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_genero_id",
                table: "registro_ocho_acciones",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_motivo_id",
                table: "registro_ocho_acciones",
                column: "motivo_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_catalogo_ocho_acciones_catalogo_ocho",
                table: "registro_ocho_acciones_catalogo_ocho_acciones",
                column: "catalogo_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_catalogo_ocho_acciones_registro_ocho",
                table: "registro_ocho_acciones_catalogo_ocho_acciones",
                column: "registro_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_habilidad_habilidad_id",
                table: "registro_ocho_acciones_habilidad",
                column: "habilidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_habilidad_registro_ocho_acciones_id",
                table: "registro_ocho_acciones_habilidad",
                column: "registro_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_interes_interes_id",
                table: "registro_ocho_acciones_interes",
                column: "interes_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_ocho_acciones_interes_registro_ocho_acciones_id",
                table: "registro_ocho_acciones_interes",
                column: "registro_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_pregunta_id",
                table: "respuestas_ocho_acciones",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_registro_ocho_acciones_id",
                table: "respuestas_ocho_acciones",
                column: "registro_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_usuario_pregunta_id",
                table: "respuestas_ocho_acciones_usuario",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "ix_respuestas_ocho_acciones_usuario_usuario_catalogo_ocho_acci",
                table: "respuestas_ocho_acciones_usuario",
                column: "usuario_catalogo_ocho_acciones_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuario_catalogo_ocho_acciones_catalogo_ocho_acciones_id",
                table: "usuario_catalogo_ocho_acciones",
                column: "catalogo_ocho_acciones_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_ocho_acciones_catalogo_ocho_acciones");

            migrationBuilder.DropTable(
                name: "registro_ocho_acciones_habilidad");

            migrationBuilder.DropTable(
                name: "registro_ocho_acciones_interes");

            migrationBuilder.DropTable(
                name: "respuestas_ocho_acciones");

            migrationBuilder.DropTable(
                name: "respuestas_ocho_acciones_usuario");

            migrationBuilder.DropTable(
                name: "registro_ocho_acciones");

            migrationBuilder.DropTable(
                name: "catalogo_preguntas_ocho_acciones");

            migrationBuilder.DropTable(
                name: "usuario_catalogo_ocho_acciones");

            migrationBuilder.DropTable(
                name: "catalogo_ocho_acciones");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "nombre" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9306), "¿Cuáles son tus necesidades de capacitación?" });

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8806), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8811), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8813), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8814), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8815), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8816), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8817), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8819), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8849), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8850), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8851), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8852), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8853), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8854), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8855), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8856), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8857), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8859), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8860), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8861), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8862), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8863), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8864), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8865), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8866), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8867), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8868), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8869), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8871), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8872), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9109), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(7644) });
        }
    }
}
