using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class sizemig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Size_Kinds_KindId",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameIndex(
                name: "IX_Size_KindId",
                table: "Sizes",
                newName: "IX_Sizes_KindId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Kinds_KindId",
                table: "Sizes",
                column: "KindId",
                principalTable: "Kinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Kinds_KindId",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_KindId",
                table: "Size",
                newName: "IX_Size_KindId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Size_Kinds_KindId",
                table: "Size",
                column: "KindId",
                principalTable: "Kinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
