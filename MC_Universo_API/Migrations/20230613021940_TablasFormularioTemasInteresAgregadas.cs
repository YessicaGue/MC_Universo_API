using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasFormularioTemasInteresAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_causas_landing",
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
                    table.PrimaryKey("pk_catalogo_causas_landing", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formulario_temas_interes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_formulario_temas_interes", x => x.id);
                    table.ForeignKey(
                        name: "fk_formulario_temas_interes_entidad_federativa_entidad_federat",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "escucha_formulario_temas_interes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    escucha_id = table.Column<int>(type: "integer", nullable: false),
                    formulario_temas_interes_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_escucha_formulario_temas_interes", x => x.id);
                    table.ForeignKey(
                        name: "fk_escucha_formulario_temas_interes_escucha_escucha_id",
                        column: x => x.escucha_id,
                        principalTable: "escucha",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_escucha_formulario_temas_interes_formulario_temas_interes_f",
                        column: x => x.formulario_temas_interes_id,
                        principalTable: "formulario_temas_interes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formulario_temas_interes_catalogo_causas_landing",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    formulario_temas_interes_id = table.Column<int>(type: "integer", nullable: false),
                    catalogo_causas_landing_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_formulario_temas_interes_catalogo_causas_landing", x => x.id);
                    table.ForeignKey(
                        name: "fk_formulario_temas_interes_catalogo_causas_landing_catalogo_c",
                        column: x => x.catalogo_causas_landing_id,
                        principalTable: "catalogo_causas_landing",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_formulario_temas_interes_catalogo_causas_landing_formulario",
                        column: x => x.formulario_temas_interes_id,
                        principalTable: "formulario_temas_interes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.InsertData(
                table: "catalogo_causas_landing",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8968), "Mujeres" },
                    { 2, true, new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8973), "Jóvenes" },
                    { 3, true, new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8973), "Medio ambiente" },
                    { 4, true, new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8974), "Personas con discapacidad" },
                    { 5, true, new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8975), "Derechos humanos" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8142), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8145), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8146), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8151), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8155), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8157), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8158), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8162), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8164), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8168), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8170), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8436), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.CreateIndex(
                name: "ix_escucha_formulario_temas_interes_escucha_id",
                table: "escucha_formulario_temas_interes",
                column: "escucha_id");

            migrationBuilder.CreateIndex(
                name: "ix_escucha_formulario_temas_interes_formulario_temas_interes_id",
                table: "escucha_formulario_temas_interes",
                column: "formulario_temas_interes_id");

            migrationBuilder.CreateIndex(
                name: "ix_formulario_temas_interes_entidad_federativa_id",
                table: "formulario_temas_interes",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_formulario_temas_interes_catalogo_causas_landing_catalogo_c",
                table: "formulario_temas_interes_catalogo_causas_landing",
                column: "catalogo_causas_landing_id");

            migrationBuilder.CreateIndex(
                name: "ix_formulario_temas_interes_catalogo_causas_landing_formulario",
                table: "formulario_temas_interes_catalogo_causas_landing",
                column: "formulario_temas_interes_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "escucha_formulario_temas_interes");

            migrationBuilder.DropTable(
                name: "formulario_temas_interes_catalogo_causas_landing");

            migrationBuilder.DropTable(
                name: "catalogo_causas_landing");

            migrationBuilder.DropTable(
                name: "formulario_temas_interes");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(715), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(723), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(724), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(729), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(730), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(735), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(739), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(742), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(753), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(766), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(768), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1172), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 711, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 6, 13, 0, 22, 43, 711, DateTimeKind.Utc).AddTicks(8619) });
        }
    }
}
