using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230925 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cargo_postulacion",
                table: "candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargos_desempeniados_dentro_mc",
                table: "candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "comentarios",
                table: "candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion_segunda_ronda",
                table: "candidatos_chc",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_ingreso_mc",
                table: "candidatos_chc",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "puesto_eleccion_popular_anteriores",
                table: "candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "domicilio_oir_recibir_notificaciones_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    candidato_id = table.Column<int>(type: "integer", nullable: false),
                    direccion_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_domicilio_oir_recibir_notificaciones_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_domicilio_oir_recibir_notificaciones_chc_candidatos_chc_can",
                        column: x => x.candidato_id,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_domicilio_oir_recibir_notificaciones_chc_direccion_direccio",
                        column: x => x.direccion_id,
                        principalTable: "direccion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4083), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4126), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4128), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4132), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4135), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4136), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4141), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4142), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4143), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4145), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4146), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4147), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4149), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4150), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4152), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4153), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4156), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4157), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4158), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4160), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4161), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4163), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4165), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4166), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4168), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4169), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4171), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4172), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4173), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4181), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4183), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4187), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4188), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4189), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4192), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4194), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4196), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4197), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4198), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4199), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4202), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4204), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4206), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4207), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4209), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4258), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4261), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4263), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4264), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4265), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4268), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4269), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4271), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4272), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4273), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4276), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4277), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4278), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4280), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4281), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4282), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4284), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4286), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4288), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4289), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4290), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4291), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4293), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4294), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4295), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4299), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4301), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4302), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4303), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4305), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4306), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4309), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4315), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4317), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4318), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4326), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2681), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2691), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2692), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2694), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2695), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2722), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2724), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2725), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2726), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2727), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2729), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2737), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2738), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2740), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2744), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2745), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2746), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2749), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2751), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2752), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2753), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2755), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2756), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(1325), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.CreateIndex(
                name: "ix_domicilio_oir_recibir_notificaciones_chc_candidato_id",
                table: "domicilio_oir_recibir_notificaciones_chc",
                column: "candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_domicilio_oir_recibir_notificaciones_chc_direccion_id",
                table: "domicilio_oir_recibir_notificaciones_chc",
                column: "direccion_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "domicilio_oir_recibir_notificaciones_chc");

            migrationBuilder.DropColumn(
                name: "cargo_postulacion",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "cargos_desempeniados_dentro_mc",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "comentarios",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion_segunda_ronda",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "fecha_ingreso_mc",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "puesto_eleccion_popular_anteriores",
                table: "candidatos_chc");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3315), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3322), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3324), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3326), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3327), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3329), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3331), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3332), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3334), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3335), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3339), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3341), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3342), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3344), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3348), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3349), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3352), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3353), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3357), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3358), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3362), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3363), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3364), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3366), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3369), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3372), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3373), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3375), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3377), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3411), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3412), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3413), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3415), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3417), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3418), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3421), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3422), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3424), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3425), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3426), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3427), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3429), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3432), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3434), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3435), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3438), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3441), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3442), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3444), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3445), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3448), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3449), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3450), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3452), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3453), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3454), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3457), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3458), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3460), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3462), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3463), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3465), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3466), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3467), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3468), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3470), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3471), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3472), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3473), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3475), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3476), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3477), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3479), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3480), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3481), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3483), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3484), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3486), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3488), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3489), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3490), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3491), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3493), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3495), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3497), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3498), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3499), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3502), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3505), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3563), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2158), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2162), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2173), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2228), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2438), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 9, 20, 0, 32, 12, 22, DateTimeKind.Utc).AddTicks(803) });
        }
    }
}
