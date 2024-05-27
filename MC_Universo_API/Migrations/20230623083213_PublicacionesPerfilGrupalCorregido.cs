using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class PublicacionesPerfilGrupalCorregido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropIndex(
                name: "ix_publicacion_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.RenameColumn(
                name: "perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                newName: "usuario_id");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3901), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3903), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3907), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3908), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3909), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3910), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3914), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3915), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3917), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3918), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3919), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3920), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3922), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3924), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3926), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3927), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3928), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3929), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3931), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3932), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3933), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3934), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3936), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3937), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3938), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3939), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3941), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3942), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3996), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4236), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 6, 23, 8, 32, 13, 297, DateTimeKind.Utc).AddTicks(2142) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "publicacion_perfil_grupal",
                newName: "perfil_grupal_id");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4558), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4564), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4566), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4569), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4621), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4627), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4632), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4639), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4641), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4642), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4643), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4645), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4648), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4687), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4917), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 6, 23, 7, 50, 41, 800, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_grupal_id");

            migrationBuilder.AddForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_grupal_id",
                principalTable: "perfil_grupal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
