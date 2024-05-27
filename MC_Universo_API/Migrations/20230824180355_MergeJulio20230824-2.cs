using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio202308242 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_persona_perfil_chc_perfil_perfil_id",
                table: "persona_perfil_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_persona_perfil_chc_persona_persona_id",
                table: "persona_perfil_chc");

            migrationBuilder.DropPrimaryKey(
                name: "pk_persona_perfil_chc",
                table: "persona_perfil_chc");

            migrationBuilder.RenameTable(
                name: "persona_perfil_chc",
                newName: "perfil_persona_chc");

            migrationBuilder.RenameIndex(
                name: "ix_persona_perfil_chc_persona_id",
                table: "perfil_persona_chc",
                newName: "ix_perfil_persona_chc_persona_id");

            migrationBuilder.RenameIndex(
                name: "ix_persona_perfil_chc_perfil_id",
                table: "perfil_persona_chc",
                newName: "ix_perfil_persona_chc_perfil_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_perfil_persona_chc",
                table: "perfil_persona_chc",
                column: "id");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6298), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6305), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6306), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6307), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6308), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6310), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6311), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6312), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6313), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6315), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6316), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6317), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6319), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6320), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6321), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6322), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6323), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6325), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6326), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6327), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6328), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6330), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6331), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6332), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6333), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6334), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6335), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6367), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6368), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6370), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6371), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6372), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6374), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6380), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6381), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6382), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6383), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6384), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6385), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6386), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6387), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6389), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6390), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6391), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6392), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6393), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6394), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6395), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6396), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6399), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6400), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6401), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6402), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6403), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6404), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6405), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6407), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6408), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6409), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6411), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6412), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6413), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6414), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6415), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6416), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6417), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6419), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6420), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6421), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6422), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6423), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6424), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6425), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6426), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6429), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6430), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6432), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6433), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6434), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6435), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6436), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6438), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6439), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6441), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6442), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6443), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6444), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6445), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6446), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6448), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6449), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6450), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6451), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6452), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6453), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6454), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6455), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6457), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6458), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4952), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4958), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4959), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4960), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4962), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4964), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4965), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4966), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4967), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4969), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4971), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4977), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4978), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4979), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4980), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4983), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4984), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4986), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4987), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4988), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4989), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4991), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4993), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4994), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4995), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4996), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4997), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4998), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4999), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5000), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5077), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5356), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(3532), new DateTime(2023, 8, 24, 18, 3, 55, 17, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.AddForeignKey(
                name: "fk_perfil_persona_chc_perfil_perfil_id",
                table: "perfil_persona_chc",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_perfil_persona_chc_persona_persona_id",
                table: "perfil_persona_chc",
                column: "persona_id",
                principalTable: "persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_perfil_persona_chc_perfil_perfil_id",
                table: "perfil_persona_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_perfil_persona_chc_persona_persona_id",
                table: "perfil_persona_chc");

            migrationBuilder.DropPrimaryKey(
                name: "pk_perfil_persona_chc",
                table: "perfil_persona_chc");

            migrationBuilder.RenameTable(
                name: "perfil_persona_chc",
                newName: "persona_perfil_chc");

            migrationBuilder.RenameIndex(
                name: "ix_perfil_persona_chc_persona_id",
                table: "persona_perfil_chc",
                newName: "ix_persona_perfil_chc_persona_id");

            migrationBuilder.RenameIndex(
                name: "ix_perfil_persona_chc_perfil_id",
                table: "persona_perfil_chc",
                newName: "ix_persona_perfil_chc_perfil_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_persona_perfil_chc",
                table: "persona_perfil_chc",
                column: "id");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7168), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7171), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7174), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7176), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7177), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7179), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7181), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7182), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7183), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7187), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7188), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7189), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7190), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7192), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7193), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7195), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7196), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7197), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7199), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7202), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7203), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7204), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7205), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7207), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7208), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7209), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7210), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7211), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7212), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7213), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7215), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7218), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7221), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7222), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7223), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7249), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7251), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7252), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7253), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7254), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7255), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7256), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7257), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7259), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7261), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7262), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7263), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7264), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7265), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7267), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7268), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7270), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7272), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7274), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7276), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7277), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7278), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7279), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7281), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7284), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7285), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7286), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7287), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7288), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7290), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7291), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7292), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7295), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7296), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7297), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7298), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7299), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7301), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7302), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7304), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7305), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7307), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7308), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7309), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7312), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6013), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6014), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6019), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6023), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6025), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6027), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6031), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6032), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6034), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6035), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6037), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6038), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6039), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6041), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6043), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6044), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6294), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(4690), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.AddForeignKey(
                name: "fk_persona_perfil_chc_perfil_perfil_id",
                table: "persona_perfil_chc",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_persona_perfil_chc_persona_persona_id",
                table: "persona_perfil_chc",
                column: "persona_id",
                principalTable: "persona",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
