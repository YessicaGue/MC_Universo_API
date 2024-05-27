using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaFotoPortadaAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto_portada",
                table: "perfil_grupal",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8771), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8775), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8776), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8778), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8779), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8781), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8783), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8784), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8786), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8787), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8788), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8790), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8792), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8794), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8795), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8798), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8799), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8800), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8802), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8803), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8804), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8806), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8807), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8808), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8811), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8812), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8814), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8816), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8818), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8819), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8822), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8823), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8825), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8827), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8828), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8829), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8831), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8832), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8833), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8835), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8836), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8837), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8838), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8841), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8842), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8843), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8845), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8846), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8847), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8849), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8850), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8851), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8852), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8854), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8855), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8856), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8922), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8923), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8925), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8926), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8927), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8928), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8931), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8932), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8934), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8935), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8937), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8938), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8939), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8942), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8944), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8946), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8949), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8951), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8953), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8954), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8955), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8957), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8961), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8962), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8963), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8967), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8969), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8971), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8972), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8974), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8975), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6847), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6856), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6857), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6861), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6862), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6867), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6868), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6885), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6886), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6888), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6889), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6892), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6896), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6902), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6906), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6908), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6909), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "foto_portada" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8492), null });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "foto_portada" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8501), null });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "foto_portada" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8508), null });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "foto_portada" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8514), null });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "foto_portada" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8522), null });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6985), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(4541), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(4546) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto_portada",
                table: "perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5886), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5888), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5892), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5901), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5906), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5910), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5912), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5915), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5916), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5917), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5918), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5920), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5921), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5925), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5929), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5933), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5941), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5945), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5948), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5952), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5957), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5989), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5990), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5992), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5998), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5999), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6004), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6005), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6006), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6008), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6009), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6010), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6011), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6014), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6016), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6019), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6025), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6026), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6027), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4589), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4595), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4601), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4602), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4603), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4606), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4607), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4608), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4610), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4612), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4613), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4614), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4615), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4616), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4617), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4618), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4619), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4620), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4621), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4622), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4623), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4624), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4625), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4627), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4632), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4673), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4876), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 8, 16, 18, 14, 27, 393, DateTimeKind.Utc).AddTicks(3342) });
        }
    }
}
