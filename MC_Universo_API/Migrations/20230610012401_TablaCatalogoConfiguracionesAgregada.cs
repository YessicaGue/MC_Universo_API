using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaCatalogoConfiguracionesAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_configuraciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    valor = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_configuraciones", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.InsertData(
                table: "catalogo_configuraciones",
                columns: new[] { "id", "fecha_creacion", "nombre", "valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3779), "client_id", "10" },
                    { 2, new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3785), "client_secret", "Ji28k8iPYrUqDTGCiIQCjZAZL4NZGAaez8W6C2PL" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2848), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2856), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2858), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2859), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2860), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2864), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2866), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2867), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2869), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2870), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2873), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2877), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2878), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2880), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2881), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2882), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2884), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2885), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2887), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2888), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2889), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2890), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2891), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2893), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2894), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2895), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2896), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2898), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3014), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(1146), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(1150) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalogo_configuraciones");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1685), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1692), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1699), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1710), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1711), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1716), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1718), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1721), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1723), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1724), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1757), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(251), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(255) });
        }
    }
}
