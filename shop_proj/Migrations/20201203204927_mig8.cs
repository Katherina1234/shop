using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tovars_Categories_CategoryId",
                table: "Tovars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Tovars");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Tovars");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Tovars",
                newName: "ModellId");

            migrationBuilder.RenameIndex(
                name: "IX_Tovars_CategoryId",
                table: "Tovars",
                newName: "IX_Tovars_ModellId");

            migrationBuilder.AddColumn<int>(
                name: "SexId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Modells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modells_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sexs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SexId",
                table: "Categories",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Modells_CategoryId",
                table: "Modells",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sexs_SexId",
                table: "Categories",
                column: "SexId",
                principalTable: "Sexs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tovars_Modells_ModellId",
                table: "Tovars",
                column: "ModellId",
                principalTable: "Modells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sexs_SexId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Tovars_Modells_ModellId",
                table: "Tovars");

            migrationBuilder.DropTable(
                name: "Modells");

            migrationBuilder.DropTable(
                name: "Sexs");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SexId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SexId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ModellId",
                table: "Tovars",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tovars_ModellId",
                table: "Tovars",
                newName: "IX_Tovars_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Tovars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Tovars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tovars_Categories_CategoryId",
                table: "Tovars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
