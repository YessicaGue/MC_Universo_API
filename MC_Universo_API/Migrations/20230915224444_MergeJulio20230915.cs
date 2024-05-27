using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230915 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle_examenes_candidatos");

            migrationBuilder.DropTable(
                name: "examenes_candidatos");

            migrationBuilder.CreateTable(
                name: "candidatos_examenes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    examen_chc_id = table.Column<int>(type: "integer", nullable: false),
                    candidato_chc_id = table.Column<int>(type: "integer", nullable: false),
                    es_aprobado = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_ultimo_intento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidatos_examenes", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidatos_examenes_candidatos_chc_candidato_chc_id",
                        column: x => x.candidato_chc_id,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidatos_examenes_examenes_chc_examen_chc_id",
                        column: x => x.examen_chc_id,
                        principalTable: "examenes_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_candidatos_examenes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    examen_candidato_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta_examen_chc_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_detalle_candidatos_examenes", x => x.id);
                    table.ForeignKey(
                        name: "fk_detalle_candidatos_examenes_candidatos_examenes_examen_cand",
                        column: x => x.examen_candidato_id,
                        principalTable: "candidatos_examenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_detalle_candidatos_examenes_respuesta_examen_chc_respuesta_",
                        column: x => x.respuesta_examen_chc_id,
                        principalTable: "respuesta_examen_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5476), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5479), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5480), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5482), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5484), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5485), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5486), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5488), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5490), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5491), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5492), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5493), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5494), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5496), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5497), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5499), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5500), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5502), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5503), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5504), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5506), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5507), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5508), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5509), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5511), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5512), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5513), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5515), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5516), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5517), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5519), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5521), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5522), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5523), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5525), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5526), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5527), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5528), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5529), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5531), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5532), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5535), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5536), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5537), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5539), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5540), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5543), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5545), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5546), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5547), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5549), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5550), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5552), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5553), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5554), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5555), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5557), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5558), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5559), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5592), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5594), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5595), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5597), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5598), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5600), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5601), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5602), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5604), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5606), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5607), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5609), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5610), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5611), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5612), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5614), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5615), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5616), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5618), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5619), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5620), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5622), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5623), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5624), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5625), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5627), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5628), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5629), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5632), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5633), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5635), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5637), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5638), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5640), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5642), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5644), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5645), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5646), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5647), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5649), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5650), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5651), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5653), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5654), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5657), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5658), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5659), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5660), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3854), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3864), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3865), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3866), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3867), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3869), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3871), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3872), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3881), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3884), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3885), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3886), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3888), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3889), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3891), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3894), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3898), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3900), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3901), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3902), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3903), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3960), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4238), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(2316), new DateTime(2023, 9, 15, 22, 44, 42, 187, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_examenes_candidato_chc_id",
                table: "candidatos_examenes",
                column: "candidato_chc_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_examenes_examen_chc_id",
                table: "candidatos_examenes",
                column: "examen_chc_id");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_candidatos_examenes_examen_candidato_id",
                table: "detalle_candidatos_examenes",
                column: "examen_candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_candidatos_examenes_respuesta_examen_chc_id",
                table: "detalle_candidatos_examenes",
                column: "respuesta_examen_chc_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle_candidatos_examenes");

            migrationBuilder.DropTable(
                name: "candidatos_examenes");

            migrationBuilder.CreateTable(
                name: "examenes_candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    candidato_chc_id = table.Column<int>(type: "integer", nullable: false),
                    examen_chc_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    es_aprobado = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_ultimo_intento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_examenes_candidatos", x => x.id);
                    table.ForeignKey(
                        name: "fk_examenes_candidatos_candidatos_chc_candidato_chc_id",
                        column: x => x.candidato_chc_id,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_examenes_candidatos_examenes_chc_examen_chc_id",
                        column: x => x.examen_chc_id,
                        principalTable: "examenes_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_examenes_candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    examen_candidato_id = table.Column<int>(type: "integer", nullable: false),
                    respuesta_examen_chc_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_detalle_examenes_candidatos", x => x.id);
                    table.ForeignKey(
                        name: "fk_detalle_examenes_candidatos_examenes_candidatos_examen_cand",
                        column: x => x.examen_candidato_id,
                        principalTable: "examenes_candidatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_respuesta_",
                        column: x => x.respuesta_examen_chc_id,
                        principalTable: "respuesta_examen_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6601), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6609), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6612), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6622), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6624), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6635), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6637), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6638), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6641), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6642), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6643), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6645), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6646), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6647), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6652), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6653), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6656), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6657), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6661), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6662), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6664), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6665), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6666), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6668), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6669), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6672), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6675), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6678), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6679), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6681), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6682), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6685), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6686), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6687), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6688), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6691), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6692), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6742), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6743), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6744), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6746), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6747), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6748), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6750), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6751), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6754), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6755), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6756), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6758), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6763), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6764), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6766), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6767), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6769), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6773), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6781), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6792), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6795), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6797), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6801), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6802), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6803), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6805), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6806), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6807), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6809), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5438), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5439), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5440), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5441), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5443), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5444), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5445), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5446), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5447), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5449), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5454), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5455), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5456), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5457), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5460), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5461), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5462), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5463), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5464), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5466), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5467), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5468), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5469), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5470), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5471), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5472), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5516), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5724), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(4262), new DateTime(2023, 9, 14, 0, 35, 37, 843, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.CreateIndex(
                name: "ix_detalle_examenes_candidatos_examen_candidato_id",
                table: "detalle_examenes_candidatos",
                column: "examen_candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_examenes_candidatos_respuesta_examen_chc_id",
                table: "detalle_examenes_candidatos",
                column: "respuesta_examen_chc_id");

            migrationBuilder.CreateIndex(
                name: "ix_examenes_candidatos_candidato_chc_id",
                table: "examenes_candidatos",
                column: "candidato_chc_id");

            migrationBuilder.CreateIndex(
                name: "ix_examenes_candidatos_examen_chc_id",
                table: "examenes_candidatos",
                column: "examen_chc_id");
        }
    }
}
