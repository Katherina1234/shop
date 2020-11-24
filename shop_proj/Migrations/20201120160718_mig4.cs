using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korzuna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korzuna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korzuna_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korzynaitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    KorzynaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korzynaitems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korzynaitems_Korzuna_KorzynaId",
                        column: x => x.KorzynaId,
                        principalTable: "Korzuna",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korzynaitems_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korzuna_UserId1",
                table: "Korzuna",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Korzynaitems_KorzynaId",
                table: "Korzynaitems",
                column: "KorzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_Korzynaitems_SizeId",
                table: "Korzynaitems",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korzynaitems");

            migrationBuilder.DropTable(
                name: "Korzuna");
        }
    }
}
