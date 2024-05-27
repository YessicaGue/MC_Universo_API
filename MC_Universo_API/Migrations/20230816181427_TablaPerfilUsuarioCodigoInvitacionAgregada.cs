using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilUsuarioCodigoInvitacionAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_expiracion",
                table: "avance_etapas_candidato",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "perfil_usuario_codigo_invitacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_usuario_id = table.Column<int>(type: "integer", nullable: false),
                    codigo_invitacion_id = table.Column<int>(type: "integer", nullable: false, comment: "Esta columna es una llave foranea que viene de la DB de dashboard"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_usuario_codigo_invitacion", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_usuario_codigo_invitacion_perfil_usuario_perfil_usua",
                        column: x => x.perfil_usuario_id,
                        principalTable: "perfil_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_perfil_usuario_codigo_invitacion_perfil_usuario_id",
                table: "perfil_usuario_codigo_invitacion",
                column: "perfil_usuario_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfil_usuario_codigo_invitacion");

            migrationBuilder.DropColumn(
                name: "fecha_expiracion",
                table: "avance_etapas_candidato");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9459), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9473), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9475), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9476), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9478), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9481), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9484), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9487), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9492), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9493), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9508), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9509), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9511), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9516), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9576), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9578), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9579), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9582), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9583), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9584), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9585), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9587), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9588), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9593), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9598), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9602), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9609), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9612), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9617), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9619), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9621), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9626), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9635), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9638), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7916), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7917), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7918), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7919), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7921), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7923), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7924), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7927), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7928), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7932), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7935), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7936), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7938), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7942), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7943), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7944), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7945), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7948), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8236), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 12, 1, 40, 12, 813, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(6239), new DateTime(2023, 8, 12, 1, 40, 12, 812, DateTimeKind.Utc).AddTicks(6244) });
        }
    }
}
