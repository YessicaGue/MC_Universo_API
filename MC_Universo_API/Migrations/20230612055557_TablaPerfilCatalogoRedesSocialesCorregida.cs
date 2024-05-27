using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPerfilCatalogoRedesSocialesCorregida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "perfil_catalogo_redes_sociales",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6782), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6787), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6791), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6795), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6796), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6801), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6802), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6844), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6848), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6849), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6850), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6851), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6853), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6854), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6856), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6917), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(5161), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(5172) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "perfil_catalogo_redes_sociales");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1080), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1086), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1088), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1099), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1101), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1132), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1135), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1136), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1139), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1142), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1184), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 6, 12, 2, 6, 23, 60, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 2, 6, 23, 59, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 6, 12, 2, 6, 23, 59, DateTimeKind.Utc).AddTicks(9572) });
        }
    }
}
