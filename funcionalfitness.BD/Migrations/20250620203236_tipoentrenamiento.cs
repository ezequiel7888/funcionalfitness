using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace funcionalfitness.BD.Migrations
{
    /// <inheritdoc />
    public partial class tipoentrenamiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoEntrenamientoid",
                table: "ZonasCorporales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zonacorporalid",
                table: "TiposEntrenamiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ZonasCorporales_TipoEntrenamientoid",
                table: "ZonasCorporales",
                column: "TipoEntrenamientoid");

            migrationBuilder.AddForeignKey(
                name: "FK_ZonasCorporales_TiposEntrenamiento_TipoEntrenamientoid",
                table: "ZonasCorporales",
                column: "TipoEntrenamientoid",
                principalTable: "TiposEntrenamiento",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZonasCorporales_TiposEntrenamiento_TipoEntrenamientoid",
                table: "ZonasCorporales");

            migrationBuilder.DropIndex(
                name: "IX_ZonasCorporales_TipoEntrenamientoid",
                table: "ZonasCorporales");

            migrationBuilder.DropColumn(
                name: "TipoEntrenamientoid",
                table: "ZonasCorporales");

            migrationBuilder.DropColumn(
                name: "zonacorporalid",
                table: "TiposEntrenamiento");
        }
    }
}
