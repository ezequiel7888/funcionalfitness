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
                name: "RegistroUsuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoingreso = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroUsuarios", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroUsuarios");
        }
    }
}
