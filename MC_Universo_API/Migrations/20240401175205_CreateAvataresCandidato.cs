using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateAvataresCandidato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "avatares",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    url_imagen = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    actividades = table.Column<string>(type: "text", nullable: true),
                    extras = table.Column<string>(type: "text", nullable: true),
                    causas = table.Column<string>(type: "text", nullable: true),
                    causas_extra = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_eliminacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_avatares", x => x.id);
                    table.ForeignKey(
                        name: "fk_avatares_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7430), "qps53nl9" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7430), "yilomvmn" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7440), "3ul2xnak" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7440), "8fyhuwdf" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7440), "x3bqf7wm" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7440), "d4zodezb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7440), "4i1ht9u6" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6110), "8kocrlec" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6150), "1oupg7lj" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6150), "2m9hkzzk" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6160), "yuoz9wq6" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6170), "ecoeo8ev" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6190), "vsroo2wv" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6200), "1n05cibr" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6200), "em6boe5k" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6200), "e5afv00q" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6210), "jcqlla50" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7620), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7670), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4600), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4750), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(3360), new DateTime(2024, 4, 1, 17, 52, 3, 851, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.CreateIndex(
                name: "ix_avatares_perfil_id",
                table: "avatares",
                column: "perfil_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "avatares");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1740), "1scqcywm" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1750), "qo1ozhog" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1750), "m6ejz36m" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1750), "jg6vn1qj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1750), "wwr8184i" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1760), "rscnklg8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1760), "dtgpxjvg" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(570), "40h6tn4u" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(590), "6wxoa5mz" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(590), "a0filkpy" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(590), "fiuylbiq" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(590), "ngyodfen" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1860), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(180), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(620), "aywadm6o" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(630), "s56pllq8" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(640), "t0gotupk" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(640), "00adofkm" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(640), "1vyrmwsy" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1900), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1930), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "causa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9200), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 11, 19, 52, 41, 296, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(8100), new DateTime(2024, 3, 11, 19, 52, 41, 295, DateTimeKind.Utc).AddTicks(8100) });
        }
    }
}
