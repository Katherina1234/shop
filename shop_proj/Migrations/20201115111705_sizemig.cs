using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class sizemig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Kinds");

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Size_Kinds_KindId",
                        column: x => x.KindId,
                        principalTable: "Kinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Size_KindId",
                table: "Size",
                column: "KindId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Kinds",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
