using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaCatalogoTokensAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "token",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "catalogo_token_id",
                table: "token",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "catalogo_tokens",
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
                    table.PrimaryKey("pk_catalogo_tokens", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.InsertData(
                table: "catalogo_tokens",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[] { 1, true, new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3978), "Instagram" });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3124), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3137), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3139), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3140), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3143), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3151), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3153), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3154), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3158), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 6, 29, 0, 12, 34, 556, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.CreateIndex(
                name: "ix_token_catalogo_token_id",
                table: "token",
                column: "catalogo_token_id");

            migrationBuilder.AddForeignKey(
                name: "fk_token_catalogo_tokens_catalogo_token_id",
                table: "token",
                column: "catalogo_token_id",
                principalTable: "catalogo_tokens",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_token_catalogo_tokens_catalogo_token_id",
                table: "token");

            migrationBuilder.DropTable(
                name: "catalogo_tokens");

            migrationBuilder.DropIndex(
                name: "ix_token_catalogo_token_id",
                table: "token");

            migrationBuilder.DropColumn(
                name: "catalogo_token_id",
                table: "token");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "token",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7404), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7477), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(6090) });
        }
    }
}
