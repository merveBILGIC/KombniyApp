using Microsoft.EntityFrameworkCore.Migrations;

namespace KombiyApp.Data.Migrations
{
    public partial class twoinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Wardrobes_WardrobeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StlingAndEnviroments_StlingAndEnvironmentId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Wardrobes_WardrobeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "StlingAndEnviroments");

            migrationBuilder.DropTable(
                name: "Wardrobes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Users_WardrobeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WardrobeId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WardrobeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StlingAndEnviroments",
                columns: table => new
                {
                    StlingAndEnvironmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StlingAndEnviroments", x => x.StlingAndEnvironmentId);
                });

            migrationBuilder.CreateTable(
                name: "Wardrobes",
                columns: table => new
                {
                    WardrobeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wardrobes", x => x.WardrobeId);
                    table.ForeignKey(
                        name: "FK_Wardrobes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StlingAndEnvironmentId = table.Column<int>(type: "int", nullable: false),
                    WardrobeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_StlingAndEnviroments_StlingAndEnvironmentId",
                        column: x => x.StlingAndEnvironmentId,
                        principalTable: "StlingAndEnviroments",
                        principalColumn: "StlingAndEnvironmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Wardrobes_WardrobeId",
                        column: x => x.WardrobeId,
                        principalTable: "Wardrobes",
                        principalColumn: "WardrobeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_WardrobeId",
                table: "Users",
                column: "WardrobeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StlingAndEnvironmentId",
                table: "Products",
                column: "StlingAndEnvironmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WardrobeId",
                table: "Products",
                column: "WardrobeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wardrobes_ProductId1",
                table: "Wardrobes",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wardrobes_UserId",
                table: "Wardrobes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Wardrobes_WardrobeId",
                table: "Users",
                column: "WardrobeId",
                principalTable: "Wardrobes",
                principalColumn: "WardrobeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wardrobes_Products_ProductId1",
                table: "Wardrobes",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
