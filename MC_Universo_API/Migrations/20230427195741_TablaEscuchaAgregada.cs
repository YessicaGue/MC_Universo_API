using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaEscuchaAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "escucha",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    respuesta = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_escucha", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "escucha");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2737), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2738), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2745), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2747), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2749), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2751), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2752), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2753), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2755), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2756), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2758), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2759), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2760), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2761), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2762), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2763), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2764), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2765), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2766), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2767), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2768), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2769), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2801), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3022), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(1145) });
        }
    }
}
