using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20231026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alias",
                table: "perfil_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "perfil_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "catalogo_acciones_afirmativas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_acciones_afirmativas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "conteo_acciones_afirmativas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    accion_afirmativa_id = table.Column<int>(type: "integer", nullable: false),
                    representante_id = table.Column<int>(type: "integer", nullable: false),
                    requisito_minimo = table.Column<int>(type: "integer", nullable: false),
                    conteo_candidatos = table.Column<int>(type: "integer", nullable: false),
                    conteo_hombres = table.Column<int>(type: "integer", nullable: false),
                    conteo_mujeres = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_conteo_acciones_afirmativas", x => x.id);
                    table.ForeignKey(
                        name: "fk_conteo_acciones_afirmativas_catalogo_acciones_afirmativas_a",
                        column: x => x.accion_afirmativa_id,
                        principalTable: "catalogo_acciones_afirmativas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_conteo_acciones_afirmativas_catalogo_representante_represen",
                        column: x => x.representante_id,
                        principalTable: "catalogo_representante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.InsertData(
                table: "catalogo_acciones_afirmativas",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4924), " Personas Indígenas" },
                    { 2, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4929), " Personas Afromexicanas" },
                    { 3, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4929), " Personas con Discapacidad" },
                    { 4, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4930), " Personas Jóvenes" },
                    { 5, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4931), " Personas de la Diversidad Sexual" },
                    { 6, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4932), " Personas Migrantes y Residentes en el Extranjero" },
                    { 7, true, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4933), " Personas Adultas Mayores" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5057), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5061), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5062), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3298), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3306), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3308), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3309), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3311), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3313), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3316), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3319), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3321), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3322), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3323), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3324), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3326), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3327), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3329), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3330), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3332), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3333), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3334), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3336), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3341), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3342), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3345), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3349), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3351), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3352), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3355), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3357), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3361), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3363), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3364), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3367), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3372), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3375), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3377), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3379), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3381), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3389), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3390), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3394), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3398), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3401), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3402), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3403), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3406), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3407), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3410), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3413), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3414), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3415), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3419), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3424), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3427), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3428), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3431), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3432), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3435), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3436), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3441), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3443), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3444), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3446), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3448), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3450), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3451), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3452), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3453), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3455), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3457), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3460), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3463), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3464), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3465), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3467), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3468), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5102), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5138), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5141), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5172), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5177), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5237), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5240), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5199), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5208), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5210), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5211), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1512), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1521), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1523), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1524), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1528), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1533), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1557), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1562), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1571), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1573), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2023), new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 47, 53, 901, DateTimeKind.Utc).AddTicks(9824), new DateTime(2023, 10, 26, 6, 47, 53, 901, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.InsertData(
                table: "conteo_acciones_afirmativas",
                columns: new[] { "id", "accion_afirmativa_id", "activo", "conteo_candidatos", "conteo_hombres", "conteo_mujeres", "fecha_creacion", "representante_id", "requisito_minimo" },
                values: new object[,]
                {
                    { 1, 1, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4978), 1, 11 },
                    { 2, 2, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4980), 1, 1 },
                    { 3, 3, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4982), 1, 1 },
                    { 4, 5, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4983), 1, 2 },
                    { 5, 6, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4985), 1, 5 },
                    { 6, 1, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4986), 2, 18 },
                    { 7, 2, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4988), 2, 3 },
                    { 8, 3, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4989), 2, 6 },
                    { 9, 5, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4990), 2, 2 },
                    { 10, 6, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4992), 2, 0 },
                    { 11, 1, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4993), 3, 5 },
                    { 12, 2, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(4995), 3, 1 },
                    { 13, 3, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5001), 3, 1 },
                    { 14, 5, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5003), 3, 1 },
                    { 15, 6, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5004), 3, 0 },
                    { 16, 1, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5005), 4, 5 },
                    { 17, 2, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5006), 4, 1 },
                    { 18, 3, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5008), 4, 1 },
                    { 19, 5, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5010), 4, 1 },
                    { 20, 6, true, 0, 0, 0, new DateTime(2023, 10, 26, 6, 47, 53, 902, DateTimeKind.Utc).AddTicks(5011), 4, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_conteo_acciones_afirmativas_accion_afirmativa_id",
                table: "conteo_acciones_afirmativas",
                column: "accion_afirmativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_conteo_acciones_afirmativas_representante_id",
                table: "conteo_acciones_afirmativas",
                column: "representante_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conteo_acciones_afirmativas");

            migrationBuilder.DropTable(
                name: "catalogo_acciones_afirmativas");

            migrationBuilder.DropColumn(
                name: "alias",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "perfil_precandidatura");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5883), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4316), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4318), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4327), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4328), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4329), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4330), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4332), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4334), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4335), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4338), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4339), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4341), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4342), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4343), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4346), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4347), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4348), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4349), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4351), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4352), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4354), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4361), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4362), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4364), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4365), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4366), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4368), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4369), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4371), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4373), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4375), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4377), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4378), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4381), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4382), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4385), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4387), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4390), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4391), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4393), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4394), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4397), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4398), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4399), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4402), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4404), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4405), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4407), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4408), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4410), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4411), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4412), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4414), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4415), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4416), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4418), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4419), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4420), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4421), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4422), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4424), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4425), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4427), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4428), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4430), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4431), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4432), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4433), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4435), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4436), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4437), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4438), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4440), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4441), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4443), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4444), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4445), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4447), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4448), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4449), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4451), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4455), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4471), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4472), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4473), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4478), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4479), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4480), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4481), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4483), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4484), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4485), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4487), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6053), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6059), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3067), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3068), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3069), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3072), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3077), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3085), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3086), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3089), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3090), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3091), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3092), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3093), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3094), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3095), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3096), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3097), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3098), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3100), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3101), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3103), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3104), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3105), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 10, 23, 18, 57, 1, 774, DateTimeKind.Utc).AddTicks(1710) });
        }
    }
}
