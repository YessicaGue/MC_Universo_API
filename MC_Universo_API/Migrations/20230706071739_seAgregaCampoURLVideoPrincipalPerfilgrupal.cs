using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class seAgregaCampoURLVideoPrincipalPerfilgrupal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url_video_principal",
                table: "perfil_grupal",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3744), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3761), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3764), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3767), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3773), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3775), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3777), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3784), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3786), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3809), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3812), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3814), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3824), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3828), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3831), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3833), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3855), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "url_video_principal" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5686), "https://www.youtube.com/embed/Cd_S6YQtBqk" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "url_video_principal" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5710), "https://www.youtube.com/embed/Cd_S6YQtBqk" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "url_video_principal" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5778), "https://www.youtube.com/embed/Cd_S6YQtBqk" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "url_video_principal" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5787), "https://www.youtube.com/embed/Cd_S6YQtBqk" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "url_video_principal" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(5794), "https://www.youtube.com/embed/Cd_S6YQtBqk" });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3936), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(1288), new DateTime(2023, 7, 6, 7, 17, 37, 887, DateTimeKind.Utc).AddTicks(1293) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url_video_principal",
                table: "perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1513), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1521), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1523), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1525), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1526), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1529), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1532), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1533), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1536), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1537), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1539), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1548), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1552), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1791), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(265), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(269) });
        }
    }
}
