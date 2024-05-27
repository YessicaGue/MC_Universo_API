using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilUsuarioPerfilGrupalAgregadaColumnasPerfilTablasPublicacionesAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "publicacion_perfil_grupal",
                type: "integer",
                nullable: true,
                comment: "Esta columna es opcional y registra al usuario dashboard administrador de este perfil grupal que realiza la publicacion",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "perfil_usuario_id",
                table: "publicacion_perfil_grupal",
                type: "integer",
                nullable: true,
                comment: "Esta columna es opcional y registra al perfil ajeno a dashboard administrador de este perfil grupal que realiza la publicacion");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "publicacion",
                type: "integer",
                nullable: true,
                comment: "Para el tipo de publicaciones legacy que utilizaron esta columna para identificar al autor",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "perfil_id",
                table: "publicacion",
                type: "integer",
                nullable: true,
                comment: "Para el tipo de publicaciones que utilizaran esta nueva columna para identificar al autor");

            migrationBuilder.CreateTable(
                name: "perfil_usuario_perfil_grupal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_usuario_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_grupal_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_usuario_perfil_grupal", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_usuario_perfil_grupal_perfil_grupal_perfil_grupal_id",
                        column: x => x.perfil_grupal_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_usuario_perfil_grupal_perfil_usuario_perfil_usuario_",
                        column: x => x.perfil_usuario_id,
                        principalTable: "perfil_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3017), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3023), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3024), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3026), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3027), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3028), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3031), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3032), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3034), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3035), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3036), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3038), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3039), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3042), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3043), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3044), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3047), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3049), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3050), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3051), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3052), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3054), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3055), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3056), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3057), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3059), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3062), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3063), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3064), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3065), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3068), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3069), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3072), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3103), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3105), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3107), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3110), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3111), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3112), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3113), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3114), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3115), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3116), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3118), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3119), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3120), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3121), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3122), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3124), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3125), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3126), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3128), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3129), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3134), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3137), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3140), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3143), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3147), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3151), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3153), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3154), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3158), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3163), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3164), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3166), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3167), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3168), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3169), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3171), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3172), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3176), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1782), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1787), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1788), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1789), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1792), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1793), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1795), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1796), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1798), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1807), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1809), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1811), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1812), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1813), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1814), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1815), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1816), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1818), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1819), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1820), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1822), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1823), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1825), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1826), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1865), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(381), new DateTime(2023, 8, 4, 0, 39, 42, 5, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_grupal_perfil_usuario_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_usuario_id");

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_id",
                table: "publicacion",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_perfil_grupal_perfil_grupal_id",
                table: "perfil_usuario_perfil_grupal",
                column: "perfil_grupal_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_perfil_grupal_perfil_usuario_id",
                table: "perfil_usuario_perfil_grupal",
                column: "perfil_usuario_id");

            migrationBuilder.AddForeignKey(
                name: "fk_publicacion_perfil_perfil_id",
                table: "publicacion",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_usuario_perfil_usuario_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_usuario_id",
                principalTable: "perfil_usuario",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_publicacion_perfil_perfil_id",
                table: "publicacion");

            migrationBuilder.DropForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_usuario_perfil_usuario_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropTable(
                name: "perfil_usuario_perfil_grupal");

            migrationBuilder.DropIndex(
                name: "ix_publicacion_perfil_grupal_perfil_usuario_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropIndex(
                name: "ix_publicacion_perfil_id",
                table: "publicacion");

            migrationBuilder.DropColumn(
                name: "perfil_usuario_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "perfil_id",
                table: "publicacion");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "publicacion_perfil_grupal",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Esta columna es opcional y registra al usuario dashboard administrador de este perfil grupal que realiza la publicacion");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "publicacion",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Para el tipo de publicaciones legacy que utilizaron esta columna para identificar al autor");

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

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1896));

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

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(1956));

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
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2021), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2028), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2029), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2032), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2034), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2036), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2037), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2038), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2040), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2041), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2042), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2043), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2045), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2047), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2048), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2050), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2052), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2054), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2055), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2057), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2058), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2060), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2061), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2062), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2063), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2065), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2067), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2070), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2071), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2074), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2077), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2079), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2080), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2118), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2121), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2124), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2125), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2129), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2132), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2134), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2143), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2153), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2156), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2162), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2173), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2185) });

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

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 31, 22, 49, 56, 784, DateTimeKind.Utc).AddTicks(2426));

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
        }
    }
}
