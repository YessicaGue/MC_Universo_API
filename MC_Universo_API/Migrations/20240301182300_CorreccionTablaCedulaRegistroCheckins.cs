using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionTablaCedulaRegistroCheckins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins");

            migrationBuilder.DropIndex(
                name: "ix_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins");

            migrationBuilder.DropColumn(
                name: "catalogo_check_ins_cedula_circulo_id",
                table: "cedula_registro_check_ins");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4769), "xbdz0e6c" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4793), "szfrojvr" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4799), "zm8jqy5t" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4803), "s9jhgowq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4807), "euq7vnhb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4811), "a4uepfd2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4814), "ad7mzpgi" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2962), "d5ngohsu" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3001), "umfwrr43" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3005), "hozc57u3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3009), "30q8tctm" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3031), "z29c9bqm" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5057), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5069), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1772), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1774), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1784), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1786), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1799), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1803), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1805), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1806), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1813), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1814), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1817), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1819), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1821), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1822), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1824), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1827), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1837), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1839), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1840), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1844), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1846), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1847), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1849), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1852), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1856), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1858), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1859), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1863), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1864), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1867), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1869), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1872), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1873), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1875), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1877), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1882), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1883), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1885), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1887), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1888), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1891), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1893), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1898), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1900), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1901), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1903), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1914), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1917), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1943), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1946), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1948), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1952), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1957), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1966), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1968), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1971), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1973), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1977), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1979), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1982), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1984), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1989), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2000), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1017), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3118), "veqk27zx" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3133), "myjpslct" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3138), "vbxf16el" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3142), "zy7ajjke" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3146), "1vsynaqg" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5143), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5225), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5232), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5233), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5306), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5314), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5639), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5648), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5649), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5651), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5652), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5654), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5656), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5657), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5544), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5556), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5557), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5558), new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9311), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9334), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9337), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9339), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9342), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9348), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9351), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9477), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 18, 22, 55, 939, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(7092), new DateTime(2024, 3, 1, 18, 22, 55, 938, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.CreateIndex(
                name: "ix_cedula_registro_check_ins_check_in_id",
                table: "cedula_registro_check_ins",
                column: "check_in_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins",
                column: "check_in_id",
                principalTable: "catalogo_check_ins_cedula_circulo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins");

            migrationBuilder.DropIndex(
                name: "ix_cedula_registro_check_ins_check_in_id",
                table: "cedula_registro_check_ins");

            migrationBuilder.AddColumn<int>(
                name: "catalogo_check_ins_cedula_circulo_id",
                table: "cedula_registro_check_ins",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5362), "xr1ik4o2" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5394), "dgulghvl" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5398), "y7ccvww8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5401), "xkwj0pnu" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5404), "n15mja41" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5407), "sb7bdi1a" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5410), "qy2p2ir1" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "catalogo_check_ins_cedula_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2802), "g1y358c8" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2863), "i2hatazg" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2867), "fdxklun3" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2871), "1bem3h7q" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2937), "bz8ymhu3" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5739), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5741), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_circulo",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8579), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8582), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8584), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8589), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8592), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8595), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8597), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8599), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8602), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8603), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8605), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8606), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8607), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8609), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8611), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8613), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8615), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8616), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8636), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8638), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8640), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8642), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8644), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8648), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8651), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8653), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8655), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8657), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8659), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8661), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8663), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8664), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8666), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8669), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8672), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8675), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8676), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8678), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8684), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8691), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8692), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8694), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8697), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8699), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8700), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8701), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8703), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8705), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8711), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8714), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8718), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8722), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8725), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8727), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8728), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8732), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8733), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8739), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8755), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8756), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8758), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8761), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8763), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8764), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8766), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8767), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8769), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8771), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8772), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8773), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8776), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8778), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8779), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8794), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7028), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3109), "hkammwqh" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3129), "79u8c2bf" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3134), "zdii5f8x" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3138), "92ujsd5t" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3141), "ldsvv01i" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5867), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6023), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6024), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6125), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6735), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6739), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6740), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6741), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6742), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6571), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6591), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6592), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6593), new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4782), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4785), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4789), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4794), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4795), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4796), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4798), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4801), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4804), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4805), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4807), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4809), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4933), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2024, 3, 1, 6, 29, 56, 346, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 3, 1, 6, 29, 56, 345, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.CreateIndex(
                name: "ix_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins",
                column: "catalogo_check_ins_cedula_circulo_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cedula_registro_check_ins_catalogo_check_ins_cedula_circulo",
                table: "cedula_registro_check_ins",
                column: "catalogo_check_ins_cedula_circulo_id",
                principalTable: "catalogo_check_ins_cedula_circulo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
