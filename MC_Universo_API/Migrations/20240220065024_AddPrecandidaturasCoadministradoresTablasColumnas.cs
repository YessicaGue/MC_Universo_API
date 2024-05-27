using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddPrecandidaturasCoadministradoresTablasColumnas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "guid_invitacion_coadministracion",
                table: "perfil_precandidatura",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liga_invitacion_coadministracion",
                table: "perfil_precandidatura",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "precandidatura_coadministrador",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_precandidatura_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_precandidatura_coadministrador", x => x.id);
                    table.ForeignKey(
                        name: "fk_precandidatura_coadministrador_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_precandidatura_coadministrador_perfil_precandidatura_perfil",
                        column: x => x.perfil_precandidatura_id,
                        principalTable: "perfil_precandidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3350), "p8y5w6yc" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3362), "h57s5kn1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3366), "x2ni22fr" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3369), "m995rccj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3372), "bk6p1c8y" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3375), "7byt9bif" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3378), "wdi1mcq6" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2241), "z8z2c7jo" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2264), "v2by7obn" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2268), "mvkxavns" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2271), "2ypofdyo" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2293), "e359hzxh" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3505), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3511), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1543), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1554), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1556), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1557), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1560), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1561), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1563), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1564), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1566), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1567), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1569), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1573), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1574), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1575), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1576), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1578), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1579), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1582), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1583), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1584), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1592), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1595), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1599), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1605), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1607), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1610), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1615), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1617), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1618), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1625), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1628), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1631), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1635), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1636), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1640), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1642), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1643), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1645), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1646), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1647), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1649), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1650), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1651), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1654), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1656), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1659), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1661), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1662), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1671), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1672), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1674), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1678), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1679), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1680), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1699), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1707), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2333), "a7qfx5g3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2342), "ahdg39z3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2345), "79rqjx25" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2348), "uj411ppz" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2351), "cg5x7e4z" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3542), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3585), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3589), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3590), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3627), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3838), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3842), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3843), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3844), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3796), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(223), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(224), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(228), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(231), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(249), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(263), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(265), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(270), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(271), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(274), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(275), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(278), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(282), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 20, 6, 50, 19, 312, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 50, 19, 311, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 2, 20, 6, 50, 19, 311, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.CreateIndex(
                name: "ix_precandidatura_coadministrador_perfil_id",
                table: "precandidatura_coadministrador",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_precandidatura_coadministrador_perfil_precandidatura_id",
                table: "precandidatura_coadministrador",
                column: "perfil_precandidatura_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precandidatura_coadministrador");

            migrationBuilder.DropColumn(
                name: "guid_invitacion_coadministracion",
                table: "perfil_precandidatura");

            migrationBuilder.DropColumn(
                name: "liga_invitacion_coadministracion",
                table: "perfil_precandidatura");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1705), "ltdte0hy" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1733), "6d5t8fo2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1736), "1v0qdzce" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1740), "f2kslz5l" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1756), "udqvwps0" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1760), "7mvtjymm" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1763), "zhj8lylv" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9937), "8fjugkbc" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9984), "v05q19bw" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9987), "vrlqlcd3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9991), "37jrrf8h" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(36), "san4t7q7" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2024), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8852), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8857), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8858), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8863), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8869), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8873), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8875), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8876), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8913), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8930), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8932), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8935), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8948), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8952), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8953), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8955), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8958), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8967), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8969), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8972), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8986), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8991), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8992), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8996), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8997), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9000), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9002), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9004), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9005), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9011), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9014), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9033), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9035), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9038), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9041), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9044), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9047), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9054), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8062), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8064), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8065), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8066), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8068), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(122), "lyckoges" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(143), "6c9kp83s" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(147), "4ixceatl" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(151), "fr22ctsm" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(155), "61j41q87" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2102), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2196), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2291), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2759), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2760), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2761), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2767), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2769), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2672), new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5883), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5923), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5937), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6502), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 875, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 2, 16, 10, 30, 20, 874, DateTimeKind.Utc).AddTicks(3218) });
        }
    }
}
