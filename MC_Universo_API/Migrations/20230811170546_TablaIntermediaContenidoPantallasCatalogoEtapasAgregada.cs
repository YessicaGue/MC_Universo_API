using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaIntermediaContenidoPantallasCatalogoEtapasAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_camino_",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropIndex(
                name: "ix_contenido_pantallas_etapas_chc_camino_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropIndex(
                name: "ix_contenido_pantallas_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropColumn(
                name: "camino_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropColumn(
                name: "etapa_id",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropColumn(
                name: "fecha_alta",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.RenameColumn(
                name: "fecha_ultimo_cambio",
                table: "contenido_pantallas_etapas_chc",
                newName: "fecha_creacion");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_actualizacion",
                table: "contenido_pantallas_etapas_chc",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "contenido_pantallas_etapas_chc_catalogo_etapas_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catalogo_etapas_chc_id = table.Column<int>(type: "integer", nullable: false),
                    contenido_pantallas_etapas_chc_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contenido_pantallas_etapas_chc_catalogo_etapas_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_catalogo",
                        column: x => x.catalogo_etapas_chc_id,
                        principalTable: "catalogo_etapas_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_contenid",
                        column: x => x.contenido_pantallas_etapas_chc_id,
                        principalTable: "contenido_pantallas_etapas_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(987), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(988), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(993), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(997), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1015), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1017), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1019), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1021), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1023), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1024), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1025), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1027), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1028), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1029), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1031), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1033), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1037), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1038), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1040), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1041), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1042), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1044), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1045), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1047), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1049), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1050), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1051), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1053), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1054), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1055), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1056), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1111), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1113), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1115), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1116), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1119), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1128), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1132), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1136), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1139), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1144), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1145), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1146), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1147), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1148), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1150), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1151), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1153), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1154), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1155), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1156), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1158), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1159), new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9356), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9359), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9362), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9363), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9365), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9366), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9371), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9372), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9379), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9381), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9386), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9392), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9393), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9684), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 11, 17, 5, 46, 8, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(7869), new DateTime(2023, 8, 11, 17, 5, 46, 7, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_catalogo_etapas_chc_catalogo",
                table: "contenido_pantallas_etapas_chc_catalogo_etapas_chc",
                column: "catalogo_etapas_chc_id");

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_catalogo_etapas_chc_contenid",
                table: "contenido_pantallas_etapas_chc_catalogo_etapas_chc",
                column: "contenido_pantallas_etapas_chc_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contenido_pantallas_etapas_chc_catalogo_etapas_chc");

            migrationBuilder.DropColumn(
                name: "fecha_actualizacion",
                table: "contenido_pantallas_etapas_chc");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "contenido_pantallas_etapas_chc",
                newName: "fecha_ultimo_cambio");

            migrationBuilder.AddColumn<int>(
                name: "camino_id",
                table: "contenido_pantallas_etapas_chc",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "etapa_id",
                table: "contenido_pantallas_etapas_chc",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_alta",
                table: "contenido_pantallas_etapas_chc",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9282), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9284), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9287), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9288), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9291), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9292), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9293), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9295), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9296), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9297), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9298), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9331), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9333), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9334), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9335), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9337), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9338), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9340), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9342), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9343), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9344), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9345), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9346), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9349), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9350), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9351), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9352), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9353), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9354), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9356), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9357), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9359), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9361), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9362), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9363), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9364), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9365), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9366), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9371), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9372), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9373), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9379), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9381), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9383), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9391), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9393), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9394), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9395), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9396), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9397), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9399), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9401), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9403), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9404), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9405), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9406), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9407), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9409), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9411), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9412), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9413), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9414), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9415), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9416), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9419), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9421), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9422), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9451), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9454), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9455), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9457), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9458), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9459), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9464), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9466), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8004), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8013), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8018), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8019), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8052), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8054), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8055), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8056), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8061), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8062), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8063), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8066), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 8, 10, 19, 43, 29, 354, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_camino_id",
                table: "contenido_pantallas_etapas_chc",
                column: "camino_id");

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc",
                column: "etapa_id");

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_camino_",
                table: "contenido_pantallas_etapas_chc",
                column: "camino_id",
                principalTable: "catalogo_caminos_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_etapa_id",
                table: "contenido_pantallas_etapas_chc",
                column: "etapa_id",
                principalTable: "catalogo_etapas_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
