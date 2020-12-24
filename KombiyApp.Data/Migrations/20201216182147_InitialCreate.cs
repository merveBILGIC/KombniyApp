using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KombiyApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registerViewModels",
                columns: table => new
                {
                    registerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SurName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<short>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PasswordTekrar = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registerViewModels", x => x.registerId);
                });

            migrationBuilder.CreateTable(
                name: "StlingAndEnviroments",
                columns: table => new
                {
                    StlingAndEnvironmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StlingAndEnviroments", x => x.StlingAndEnvironmentId);
                });

            migrationBuilder.CreateTable(
                name: "stylingManagers",
                columns: table => new
                {
                    StylingManageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StylingGiveUserId = table.Column<int>(nullable: false),
                    StylingGetUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stylingManagers", x => x.StylingManageId);
                });

            migrationBuilder.CreateTable(
                name: "Wardrobes",
                columns: table => new
                {
                    WardrobeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ProductId1 = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wardrobes", x => x.WardrobeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSrc = table.Column<string>(nullable: true),
                    WardrobeId = table.Column<int>(nullable: false),
                    StlingAndEnvironmentId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    photoPath = table.Column<string>(nullable: true),
                    About = table.Column<string>(maxLength: 1000, nullable: true),
                    WardrobeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Wardrobes_WardrobeId",
                        column: x => x.WardrobeId,
                        principalTable: "Wardrobes",
                        principalColumn: "WardrobeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mailModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(maxLength: 150, nullable: true),
                    SenderUserId = table.Column<int>(nullable: true),
                    ReceiverId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(maxLength: 2000, nullable: true),
                    IsRead = table.Column<bool>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mailModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mailModels_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mailModels_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    PaswordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 6, nullable: true),
                    GeneratedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.PaswordId);
                    table.ForeignKey(
                        name: "FK_Passwords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mailModels_ReceiverId",
                table: "mailModels",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_mailModels_SenderUserId",
                table: "mailModels",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Passwords_UserId",
                table: "Passwords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StlingAndEnvironmentId",
                table: "Products",
                column: "StlingAndEnvironmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WardrobeId",
                table: "Products",
                column: "WardrobeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WardrobeId",
                table: "Users",
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
                name: "FK_Wardrobes_Users_UserId",
                table: "Wardrobes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wardrobes_Products_ProductId1",
                table: "Wardrobes",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wardrobes_Users_UserId",
                table: "Wardrobes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StlingAndEnviroments_StlingAndEnvironmentId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Wardrobes_WardrobeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "mailModels");

            migrationBuilder.DropTable(
                name: "Passwords");

            migrationBuilder.DropTable(
                name: "registerViewModels");

            migrationBuilder.DropTable(
                name: "stylingManagers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StlingAndEnviroments");

            migrationBuilder.DropTable(
                name: "Wardrobes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
