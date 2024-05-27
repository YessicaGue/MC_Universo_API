using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasRegistroCausaAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registro_causa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    genero_id = table.Column<int>(type: "integer", nullable: false),
                    escolaridad_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_causa", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_causa_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_causa_escolaridad_escolaridad_id",
                        column: x => x.escolaridad_id,
                        principalTable: "escolaridad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_causa_genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro_causa_causa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registro_causa_id = table.Column<int>(type: "integer", nullable: false),
                    causa_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_registro_causa_causa", x => x.id);
                    table.ForeignKey(
                        name: "fk_registro_causa_causa_causa_causa_id",
                        column: x => x.causa_id,
                        principalTable: "causa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_registro_causa_causa_registro_causa_registro_causa_id",
                        column: x => x.registro_causa_id,
                        principalTable: "registro_causa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 28, 0, 18, 15, 637, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.InsertData(
                table: "causa",
                columns: new[] { "id", "activo", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Diversidad sexual" },
                    { 2, true, "Energías limpias" },
                    { 3, true, "Infancias" },
                    { 4, true, "Ingreso vital" },
                    { 5, true, "Justicia climática (emergencia climática)" },
                    { 6, true, "Juventudes" },
                    { 7, true, "Legalización" },
                    { 8, true, "Mujeres" },
                    { 9, true, "Paz" }
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_registro_causa_entidad_federativa_id",
                table: "registro_causa",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_causa_escolaridad_id",
                table: "registro_causa",
                column: "escolaridad_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_causa_genero_id",
                table: "registro_causa",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_causa_causa_causa_id",
                table: "registro_causa_causa",
                column: "causa_id");

            migrationBuilder.CreateIndex(
                name: "ix_registro_causa_causa_registro_causa_id",
                table: "registro_causa_causa",
                column: "registro_causa_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro_causa_causa");

            migrationBuilder.DropTable(
                name: "registro_causa");

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "causa",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7489), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7495), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7496), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7498), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7499), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7501), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7502), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7503), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7504), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7506), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7507), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7508), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7509), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7511), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7512), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7514), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7515), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7517), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7518), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7519), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7520), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7521), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7522), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7523), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7524), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7549), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7550), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7552), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7781), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(6200), new DateTime(2023, 4, 27, 19, 57, 41, 425, DateTimeKind.Utc).AddTicks(6204) });
        }
    }
}
