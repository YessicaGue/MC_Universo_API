using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeDevMainCore8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2046), "kutqo7vw" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2058), "s79xwcg0" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2061), "jyi8x2d9" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2063), "if5c93gp" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2065), "e711q04i" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2068), "zzvs6pfj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2069), "eiux2eir" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(690), "xyd7wqul" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(722), "8dqzcbg6" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(725), "k7b3z8oc" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(727), "s9gorqqn" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(746), "msi5c9qj" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9882), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9884), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9885), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9887), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9889), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9891), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9893), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9894), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9897), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9899), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9901), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9904), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9905), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9907), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9908), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9909), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9912), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9913), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9914), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9954), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9955), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9957), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9958), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9959), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9961), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9962), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9964), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9965), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9967), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9968), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9969), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9972), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9973), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9974), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9976), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9977), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9978), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9981), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9982), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9983), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9985), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9986), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9987), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9988), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9991), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9992), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9994), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9995), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9998), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9999), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(3), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(4), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(7), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(16), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(33), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(69), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(70), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(72), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(73), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(75), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(78), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(79), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(80), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(82), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(84), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(85), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(87), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(88), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(89), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(91), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(92), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(95), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(96), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(97), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(794), "vu5icjyl" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(803), "zysrrt8q" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(805), "f06gluud" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(808), "2ayrko1k" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(810), "v6jdocak" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2331), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2334), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2377), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2382), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2476), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2483), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2485), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2421), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2430), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2431), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2432), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8318), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8325), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8326), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8329), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8334), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8347), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8361), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8363), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8365), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8366), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8430), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8731), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(6942), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(6945) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5262), "q6pufdir" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5278), "m5nbg3eq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5281), "quj9q684" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5284), "81ykmvbt" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5287), "d6yy90xx" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5290), "tavr8mtc" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5293), "ugejeyul" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4184), "v4of9f7r" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4215), "4ncc4yo1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4219), "oyv5ewn2" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4221), "9l5py4cz" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4233), "oajylfe2" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5419), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5423), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3531), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3542), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3543), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3545), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3547), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3548), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3550), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3551), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3553), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3554), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3556), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3557), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3559), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3568), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3569), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3570), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3572), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3574), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3577), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3581), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3582), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3583), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3584), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3585), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3587), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3588), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3590), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3591), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3592), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3594), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3596), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3597), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3598), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3600), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3601), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3602), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3603), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3605), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3606), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3607), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3609), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3610), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3611), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3613), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3614), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3615), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3617), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3618), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3619), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3622), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3623), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3624), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3626), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3627), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3630), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3631), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3632), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3634), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3635), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3636), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3638), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3639), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3641), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3642), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3643), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3646), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3647), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3649), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3651), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3653), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3654), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3662), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3664), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3665), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3666), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3668), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3669), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3671), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3672), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3673), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3674), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3676), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3678), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3679), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3681), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3682), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3683), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3685), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3686), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3688), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3689), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3690), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3691), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3694), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3695), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3696), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3698), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3699), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3700), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3702), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3703), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3704), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3706), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3707), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3708), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3710), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3711), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3712), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4278), "ba7odtol" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4287), "0aomrh0w" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4290), "nwff5r4s" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4293), "j4vqy42z" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4296), "y3qy6pyd" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5471), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5499), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5504), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5505), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5538), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5609), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5610), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5611), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5612), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5613), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5615), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5568), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5571), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5572), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5573), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1884), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1888), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1890), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1891), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1896), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1897), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1907), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1909), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1911), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1912), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1916), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1917), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1919), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1928), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1930), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1931), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1932), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1933), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1934), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1935), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1936), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1938), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1979), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2516), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 11, 23, 21, 10, 36, 575, DateTimeKind.Utc).AddTicks(448) });
        }
    }
}
