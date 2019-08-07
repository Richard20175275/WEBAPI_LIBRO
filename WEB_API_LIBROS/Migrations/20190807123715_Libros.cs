using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_API_LIBROS.Migrations
{
    public partial class Libros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Autores_AutorId1",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_AutorId1",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "AutorId1",
                table: "Libros");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Libros",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Libros",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorId",
                table: "Libros",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Autores_AutorId",
                table: "Libros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Autores_AutorId",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_AutorId",
                table: "Libros");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Libros",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "AutorId",
                table: "Libros",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Libros",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutorId1",
                table: "Libros",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorId1",
                table: "Libros",
                column: "AutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Autores_AutorId1",
                table: "Libros",
                column: "AutorId1",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
