using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasSecretariaOrganizacionAccionPoliticaAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_estado_validacion_archivo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_estado_validacion_archivo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_rol_comision",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_rol_comision", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_tipo_archivo_sesion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_tipo_archivo_sesion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_tipo_comision",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_tipo_comision", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_tipo_sesion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_tipo_sesion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "comision",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo_comision_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_vigencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Fecha de vigencia de comision"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_comision", x => x.id);
                    table.ForeignKey(
                        name: "fk_comision_catalogo_tipo_comision_tipo_comision_id",
                        column: x => x.tipo_comision_id,
                        principalTable: "catalogo_tipo_comision",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comision_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Debido a que cada estado solo puede tener un tipo de comision, se establece constraint unique");

            migrationBuilder.CreateTable(
                name: "sesion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo_sesion_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_id = table.Column<int>(type: "integer", nullable: false, comment: "Id del usuario dashboard que registra la sesion"),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    comentarios = table.Column<string>(type: "text", nullable: true),
                    fecha_sesion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Fecha en la que se registra la sesion"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sesion", x => x.id);
                    table.ForeignKey(
                        name: "fk_sesion_catalogo_tipo_sesion_tipo_sesion_id",
                        column: x => x.tipo_sesion_id,
                        principalTable: "catalogo_tipo_sesion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sesion_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comision_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    comision_id = table.Column<int>(type: "integer", nullable: false),
                    rol_comision_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_id = table.Column<int>(type: "integer", nullable: false, comment: "Id del usuario dashboard relacionado a la comision"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_comision_usuario", x => x.id);
                    table.ForeignKey(
                        name: "fk_comision_usuario_catalogo_rol_comision_rol_comision_id",
                        column: x => x.rol_comision_id,
                        principalTable: "catalogo_rol_comision",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comision_usuario_comision_comision_id",
                        column: x => x.comision_id,
                        principalTable: "comision",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sesion_archivo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sesion_id = table.Column<int>(type: "integer", nullable: false),
                    archivo_id = table.Column<int>(type: "integer", nullable: false),
                    estado_validacion_archivo_id = table.Column<int>(type: "integer", nullable: false),
                    usuario_validacion_archivo_id = table.Column<int>(type: "integer", nullable: false, comment: "Id del usuario dashboard que cambia el estado de validacion del archivo"),
                    usuario_carga_id = table.Column<int>(type: "integer", nullable: false, comment: "Id del usuario dashboard que carga el archivo"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sesion_archivo", x => x.id);
                    table.ForeignKey(
                        name: "fk_sesion_archivo_archivo_archivo_id",
                        column: x => x.archivo_id,
                        principalTable: "archivo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sesion_archivo_catalogo_estado_validacion_archivo_estado_va",
                        column: x => x.estado_validacion_archivo_id,
                        principalTable: "catalogo_estado_validacion_archivo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sesion_archivo_sesion_sesion_id",
                        column: x => x.sesion_id,
                        principalTable: "sesion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.InsertData(
                table: "catalogo_estado_validacion_archivo",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9183), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9183), "En proceso" },
                    { 2, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9190), "Comentado" },
                    { 3, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9191), "Aceptado" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7972), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7975), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7985), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7986), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7991), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7992), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7996), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8002), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8003), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8011), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8013), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8019), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8027), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8028), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8032), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8034), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8035), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8036), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8038), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8039), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8041), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8044), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8045), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8046), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8048), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8049), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8052), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8053), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8054), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8055), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8062), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8068), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8121), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8123), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8124), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8125), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8126), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8129), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8130), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8131), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8134), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8137), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8138), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8139), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8142), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8144), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8146), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8151), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8155), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8157), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8162), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8170), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8173), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8174), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8175), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8176), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8178), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.InsertData(
                table: "catalogo_rol_comision",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[] { 1, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9218), "Coordinador" });

            migrationBuilder.InsertData(
                table: "catalogo_tipo_archivo_sesion",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9250), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9250), "Foto/Imagen" },
                    { 2, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9260), "Acta" },
                    { 3, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9261), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9261), "Lista" }
                });

            migrationBuilder.InsertData(
                table: "catalogo_tipo_comision",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9347), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9347), "Electa" },
                    { 2, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9351), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9351), "Provisional" }
                });

            migrationBuilder.InsertData(
                table: "catalogo_tipo_sesion",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9382), "Consejo estatal" },
                    { 2, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9386), "Comisión operativa estatal" },
                    { 3, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9387), "Junta de coordinación" },
                    { 4, true, new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9388), "Coordinadora" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6887), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6896), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6901), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6917), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6918), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6919), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6921), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6922), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6923), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6924), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6927), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6928), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6931), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6933), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6935), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6936), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6937), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6975), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7186), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.CreateIndex(
                name: "ix_comision_entidad_federativa_id",
                table: "comision",
                column: "entidad_federativa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_comision_tipo_comision_id",
                table: "comision",
                column: "tipo_comision_id");

            migrationBuilder.CreateIndex(
                name: "ix_comision_usuario_comision_id",
                table: "comision_usuario",
                column: "comision_id");

            migrationBuilder.CreateIndex(
                name: "ix_comision_usuario_rol_comision_id",
                table: "comision_usuario",
                column: "rol_comision_id");

            migrationBuilder.CreateIndex(
                name: "ix_sesion_entidad_federativa_id",
                table: "sesion",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_sesion_tipo_sesion_id",
                table: "sesion",
                column: "tipo_sesion_id");

            migrationBuilder.CreateIndex(
                name: "ix_sesion_archivo_archivo_id",
                table: "sesion_archivo",
                column: "archivo_id");

            migrationBuilder.CreateIndex(
                name: "ix_sesion_archivo_estado_validacion_archivo_id",
                table: "sesion_archivo",
                column: "estado_validacion_archivo_id");

            migrationBuilder.CreateIndex(
                name: "ix_sesion_archivo_sesion_id",
                table: "sesion_archivo",
                column: "sesion_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalogo_tipo_archivo_sesion");

            migrationBuilder.DropTable(
                name: "comision_usuario");

            migrationBuilder.DropTable(
                name: "sesion_archivo");

            migrationBuilder.DropTable(
                name: "catalogo_rol_comision");

            migrationBuilder.DropTable(
                name: "comision");

            migrationBuilder.DropTable(
                name: "catalogo_estado_validacion_archivo");

            migrationBuilder.DropTable(
                name: "sesion");

            migrationBuilder.DropTable(
                name: "catalogo_tipo_comision");

            migrationBuilder.DropTable(
                name: "catalogo_tipo_sesion");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1566), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1570), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1575), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1581), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1587), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1596), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1598), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1611), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1612), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1615), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1617), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1619), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1621), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1623), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1625), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1627), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1637), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1639), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1641), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1643), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1644), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1654), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1655), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1656), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1658), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1659), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1660), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1662), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1663), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1665), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1666), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1668), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1685), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1688), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1690), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1692), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1697), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1710), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1712), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1715), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1718), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1723), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1726), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1728), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1730), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1731), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1734), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1735), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(4), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(5), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(7), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(9), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(12), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(22), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(30), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(33), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(35), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(105), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(337), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(8571), new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(8580) });
        }
    }
}
