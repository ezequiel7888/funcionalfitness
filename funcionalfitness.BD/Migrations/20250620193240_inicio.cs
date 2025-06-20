using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace funcionalfitness.BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edadminima = table.Column<int>(type: "int", nullable: false),
                    edadmaxima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposEntrenamiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEntrenamiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ZonasCorporales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasCorporales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechainicioplan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechafinplan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    codigoingreso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaid = table.Column<int>(type: "int", nullable: false),
                    tipoentrenamientoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clientes_Categorias_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_TiposEntrenamiento_tipoentrenamientoid",
                        column: x => x.tipoentrenamientoid,
                        principalTable: "TiposEntrenamiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientesClases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    claseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesClases", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientesClases_Clases_claseid",
                        column: x => x.claseid,
                        principalTable: "Clases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesClases_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaenvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    leido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_categoriaid",
                table: "Clientes",
                column: "categoriaid");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_tipoentrenamientoid",
                table: "Clientes",
                column: "tipoentrenamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesClases_claseid",
                table: "ClientesClases",
                column: "claseid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesClases_clienteid",
                table: "ClientesClases",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_clienteid",
                table: "Notificaciones",
                column: "clienteid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesClases");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "ZonasCorporales");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "TiposEntrenamiento");
        }
    }
}
