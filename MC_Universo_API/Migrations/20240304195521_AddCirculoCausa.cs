using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddCirculoCausa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "circulo_causa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circulo_id = table.Column<int>(type: "integer", nullable: false),
                    causa_id = table.Column<int>(type: "integer", nullable: false, comment: "Causa de voces del futuro"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    usuario_creacion_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_modificacion_id = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_circulo_causa", x => x.id);
                    table.ForeignKey(
                        name: "fk_circulo_causa_circulo_circulo_id",
                        column: x => x.circulo_id,
                        principalTable: "circulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4705), "7h0lje8m" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4722), "kup0demh" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4726), "e03tmycq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4729), "6eogkdde" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4732), "o4zvclsz" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4736), "n32ekp4b" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4739), "h9j212p7" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3201), "xt1cxds7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3238), "cmbmpqdu" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3242), "osizk327" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3245), "f92yulde" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3272), "txhgmk8t" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4899), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2294), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2296), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2298), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2307), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2313), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2314), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2316), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2318), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2325), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2329), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2331), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2332), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2334), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2337), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2343), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2354), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2361), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2368), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2371), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2374), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2377), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2379), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2389), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2392), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2395), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2397), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2401), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2403), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2405), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2406), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2408), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2409), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2411), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2413), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2417), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2425), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2431), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2434), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2435), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2438), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2441), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2443), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2448), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2452), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2459), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2472), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2473), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2475), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2476), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2478), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2481), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2483), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2486), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2487), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2489), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1657), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1663), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1667), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3341), "qla8j3bp" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3349), "mi3dpmpf" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3353), "trgwfbr2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3356), "s39x1i2i" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3360), "ja4v6stp" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4959), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5023), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5024), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5188), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5255), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5261), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5262), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5264), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(286), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(292), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(298), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(300), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(318), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(324), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(326), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(328), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(329), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(331), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(332), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(333), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(334), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(339), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(340), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(341), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(343), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 4, 19, 55, 18, 63, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 55, 18, 62, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 3, 4, 19, 55, 18, 62, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.CreateIndex(
                name: "ix_circulo_causa_circulo_id",
                table: "circulo_causa",
                column: "circulo_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "circulo_causa");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7564), "1w1fwfte" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7581), "7tfvqt60" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7630), "znz9b36i" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7634), "77r8tbyv" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7638), "obko52e1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7642), "9acr5w8d" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7645), "6g2ocqfu" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6072), "qsoqfix7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6105), "atdvj9b1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6115), "36y1raw9" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6119), "tiuh9w69" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6150), "ywenncyf" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7828), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5106), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5115), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5117), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5120), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5121), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5123), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5125), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5128), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5130), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5132), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5133), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5134), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5136), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5137), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5139), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5140), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5142), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5144), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5149), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5151), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5152), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5154), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5155), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5156), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5158), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5159), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5161), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5162), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5168), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5169), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5171), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5173), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5175), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5178), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5180), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5184), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5186), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5188), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5200), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5204), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5206), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5207), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5209), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5210), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5212), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5214), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5215), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5216), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5218), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5219), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5221), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5222), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5224), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5227), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5231), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5240), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5243), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5247), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5249), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5250), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5252), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5254), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5257), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5259), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5262), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5263), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5264), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5266), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5267), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5270), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5272), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5273), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5275), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5276), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5281), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5282), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5284), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5285), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5286), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5288), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5293), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5299), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5300), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5302), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6215), "iau3j215" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6223), "b6xjgsm3" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6227), "iryu6oi2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6231), "1a0xdp92" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6234), "2ubo3pia" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7948), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8181), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8306), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8317), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8243), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3129), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3132), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3135), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3152), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3156), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3159), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3245), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3642), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 3, 2, 5, 47, 46, 860, DateTimeKind.Utc).AddTicks(1144) });
        }
    }
}
