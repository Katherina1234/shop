using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_proj.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Komentars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TovarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentars_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentars_Tovars_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KomentarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answers_Komentars_KomentarId",
                        column: x => x.KomentarId,
                        principalTable: "Komentars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_KomentarId",
                table: "Answers",
                column: "KomentarId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentars_TovarId",
                table: "Komentars",
                column: "TovarId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentars_UserId",
                table: "Komentars",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Komentars");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");
        }
    }
}
