using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korzuna_AspNetUsers_UserId1",
                table: "Korzuna");

            migrationBuilder.DropIndex(
                name: "IX_Korzuna_UserId1",
                table: "Korzuna");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Korzuna");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Korzuna",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Korzuna_UserId",
                table: "Korzuna",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korzuna_AspNetUsers_UserId",
                table: "Korzuna",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korzuna_AspNetUsers_UserId",
                table: "Korzuna");

            migrationBuilder.DropIndex(
                name: "IX_Korzuna_UserId",
                table: "Korzuna");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Korzuna",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Korzuna",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korzuna_UserId1",
                table: "Korzuna",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Korzuna_AspNetUsers_UserId1",
                table: "Korzuna",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
