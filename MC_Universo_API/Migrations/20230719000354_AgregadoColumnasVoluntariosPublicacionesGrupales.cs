using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoColumnasVoluntariosPublicacionesGrupales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "correo_electronico",
                table: "voluntario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "voluntario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "url_movimiento_social",
                table: "publicacion_perfil_grupal",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6011), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6023), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6026), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6031), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6035), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6037), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6039), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6041), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6044), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6047), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6048), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6049), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6050), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6052), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6053), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6056), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6061), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6108), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6343), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(4308), new DateTime(2023, 7, 19, 0, 3, 54, 211, DateTimeKind.Utc).AddTicks(4312) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correo_electronico",
                table: "voluntario");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "voluntario");

            migrationBuilder.DropColumn(
                name: "url_movimiento_social",
                table: "publicacion_perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4090), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4096), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4097), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4099), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4100), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4102), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4104), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4105), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4106), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4108), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4110), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4111), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4123), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4127), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4128), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4132), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4182), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4183), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4186), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4188), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4189), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4191), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4262), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4670), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 7, 7, 1, 4, 23, 192, DateTimeKind.Utc).AddTicks(2011) });
        }
    }
}
