using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDeControlUno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7983), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7992), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7994), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8003), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8018), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8027), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8029), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8081), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8336), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(6234), new DateTime(2023, 7, 4, 11, 15, 51, 690, DateTimeKind.Utc).AddTicks(6237) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1830), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1844), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1845), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1846), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1852), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1856), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1860), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1863), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1865), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1869), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1986), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 853, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 7, 4, 8, 41, 4, 853, DateTimeKind.Utc).AddTicks(9816) });
        }
    }
}
