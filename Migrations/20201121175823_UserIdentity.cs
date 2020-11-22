using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStore.Migrations
{
    public partial class UserIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    OrderRegistrationDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsThumbnail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Basketball" },
                    { 2, "Football" },
                    { 3, "LifeStyle" },
                    { 4, "baseball" },
                    { 5, "Running" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "CategoryName", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 11, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 11", 441m, "product 11" },
                    { 75, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 75", 2425m, "product 75" },
                    { 71, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 71", 2301m, "product 71" },
                    { 69, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 69", 2239m, "product 69" },
                    { 65, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 65", 2115m, "product 65" },
                    { 54, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 54", 1774m, "product 54" },
                    { 46, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 46", 1526m, "product 46" },
                    { 43, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 43", 1433m, "product 43" },
                    { 41, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 41", 1371m, "product 41" },
                    { 31, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 31", 1061m, "product 31" },
                    { 24, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 24", 844m, "product 24" },
                    { 19, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 19", 689m, "product 19" },
                    { 12, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 12", 472m, "product 12" },
                    { 9, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 9", 379m, "product 9" },
                    { 98, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 98", 3138m, "product 98" },
                    { 93, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 93", 2983m, "product 93" },
                    { 91, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 91", 2921m, "product 91" },
                    { 85, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 85", 2735m, "product 85" },
                    { 81, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 81", 2611m, "product 81" },
                    { 77, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 77", 2487m, "product 77" },
                    { 72, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 72", 2332m, "product 72" },
                    { 62, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 62", 2022m, "product 62" },
                    { 86, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 86", 2766m, "product 86" },
                    { 60, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 60", 1960m, "product 60" },
                    { 87, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 87", 2797m, "product 87" },
                    { 99, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 99", 3169m, "product 99" },
                    { 84, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 84", 2704m, "product 84" },
                    { 82, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 82", 2642m, "product 82" },
                    { 78, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 78", 2518m, "product 78" },
                    { 76, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 76", 2456m, "product 76" },
                    { 70, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 70", 2270m, "product 70" },
                    { 63, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 63", 2053m, "product 63" },
                    { 58, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 58", 1898m, "product 58" },
                    { 57, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 57", 1867m, "product 57" },
                    { 52, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 52", 1712m, "product 52" },
                    { 51, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 51", 1681m, "product 51" },
                    { 47, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 47", 1557m, "product 47" },
                    { 42, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 42", 1402m, "product 42" },
                    { 39, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 39", 1309m, "product 39" },
                    { 29, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 29", 999m, "product 29" },
                    { 28, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 28", 968m, "product 28" },
                    { 25, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 25", 875m, "product 25" },
                    { 21, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 21", 751m, "product 21" },
                    { 16, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 16", 596m, "product 16" },
                    { 14, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 14", 534m, "product 14" },
                    { 8, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 8", 348m, "product 8" },
                    { 5, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 5", 255m, "product 5" },
                    { 90, 4, "baseball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 90", 2890m, "product 90" },
                    { 59, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 59", 1929m, "product 59" },
                    { 56, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 56", 1836m, "product 56" },
                    { 49, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 49", 1619m, "product 49" },
                    { 34, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 34", 1154m, "product 34" },
                    { 26, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 26", 906m, "product 26" },
                    { 23, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 23", 813m, "product 23" },
                    { 20, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 20", 720m, "product 20" },
                    { 15, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 15", 565m, "product 15" },
                    { 2, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 2", 162m, "product 2" },
                    { 96, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 96", 3076m, "product 96" },
                    { 95, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 95", 3045m, "product 95" },
                    { 92, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 92", 2952m, "product 92" },
                    { 80, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 80", 2580m, "product 80" },
                    { 67, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 67", 2177m, "product 67" },
                    { 66, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 66", 2146m, "product 66" },
                    { 55, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 55", 1805m, "product 55" },
                    { 50, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 50", 1650m, "product 50" },
                    { 38, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 38", 1278m, "product 38" },
                    { 37, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 37", 1247m, "product 37" },
                    { 35, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 35", 1185m, "product 35" },
                    { 32, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 32", 1092m, "product 32" },
                    { 27, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 27", 937m, "product 27" },
                    { 22, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 22", 782m, "product 22" },
                    { 18, 1, "Basketball", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 18", 658m, "product 18" },
                    { 44, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 44", 1464m, "product 44" },
                    { 45, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 45", 1495m, "product 45" },
                    { 48, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 48", 1588m, "product 48" },
                    { 53, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 53", 1743m, "product 53" },
                    { 40, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 40", 1340m, "product 40" },
                    { 36, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 36", 1216m, "product 36" },
                    { 33, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 33", 1123m, "product 33" },
                    { 30, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 30", 1030m, "product 30" },
                    { 17, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 17", 627m, "product 17" },
                    { 13, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 13", 503m, "product 13" },
                    { 10, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 10", 410m, "product 10" },
                    { 7, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 7", 317m, "product 7" },
                    { 6, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 6", 286m, "product 6" },
                    { 4, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 4", 224m, "product 4" },
                    { 88, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 88", 2828m, "product 88" },
                    { 3, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 3", 193m, "product 3" },
                    { 100, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 100", 3200m, "product 100" },
                    { 94, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 94", 3014m, "product 94" },
                    { 89, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 89", 2859m, "product 89" },
                    { 83, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 83", 2673m, "product 83" },
                    { 79, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 79", 2549m, "product 79" },
                    { 74, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 74", 2394m, "product 74" },
                    { 73, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 73", 2363m, "product 73" },
                    { 68, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 68", 2208m, "product 68" },
                    { 64, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 64", 2084m, "product 64" },
                    { 61, 2, "Football", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 61", 1991m, "product 61" },
                    { 1, 3, "LifeStyle", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 1", 131m, "product 1" },
                    { 97, 5, "Running", "Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. 97", 3107m, "product 97" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImageId", "ImageUrl", "IsThumbnail", "ProductID" },
                values: new object[,]
                {
                    { 77, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 11 },
                    { 207, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 46 },
                    { 161, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 46 },
                    { 99, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 46 },
                    { 286, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 43 },
                    { 40, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 43 },
                    { 301, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 41 },
                    { 291, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 41 },
                    { 278, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 41 },
                    { 252, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 41 },
                    { 400, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 31 },
                    { 262, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 31 },
                    { 233, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 31 },
                    { 75, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 31 },
                    { 70, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 31 },
                    { 308, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 24 },
                    { 205, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 193, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 121, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 108, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 107, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 106, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 270, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 46 },
                    { 86, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 24 },
                    { 280, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 46 },
                    { 42, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 54 },
                    { 145, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 86 },
                    { 332, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 75 },
                    { 29, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 75 },
                    { 243, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 71 },
                    { 212, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 71 },
                    { 185, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 71 },
                    { 51, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 71 },
                    { 321, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 69 },
                    { 241, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 69 },
                    { 189, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 69 },
                    { 141, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 69 },
                    { 320, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 65 },
                    { 288, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 65 },
                    { 238, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 65 },
                    { 218, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 65 },
                    { 124, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 65 },
                    { 327, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 54 },
                    { 298, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 54 },
                    { 296, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 54 },
                    { 290, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 54 },
                    { 282, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 54 },
                    { 365, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 46 },
                    { 347, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 86 },
                    { 92, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 19 },
                    { 384, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 12 },
                    { 387, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 77 },
                    { 311, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 77 },
                    { 196, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 77 },
                    { 170, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 77 },
                    { 34, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 77 },
                    { 317, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 72 },
                    { 7, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 62 },
                    { 299, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 60 },
                    { 136, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 60 },
                    { 115, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 60 },
                    { 85, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 60 },
                    { 31, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 60 },
                    { 137, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 59 },
                    { 1, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 59 },
                    { 364, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 56 },
                    { 394, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 49 },
                    { 370, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 49 },
                    { 319, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 49 },
                    { 304, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 49 },
                    { 294, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 49 },
                    { 259, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 49 },
                    { 333, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 81 },
                    { 15, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 19 },
                    { 119, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 85 },
                    { 57, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 91 },
                    { 176, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 12 },
                    { 127, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 12 },
                    { 66, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 12 },
                    { 396, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 9 },
                    { 366, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 201, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 197, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 9 },
                    { 155, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 146, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 96, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 41, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 9 },
                    { 165, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 98 },
                    { 340, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 93 },
                    { 244, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 93 },
                    { 224, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 93 },
                    { 133, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 93 },
                    { 118, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 93 },
                    { 79, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 93 },
                    { 266, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 91 },
                    { 194, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 91 },
                    { 154, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 91 },
                    { 32, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 91 },
                    { 361, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 86 },
                    { 12, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 87 },
                    { 22, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 87 },
                    { 82, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 70 },
                    { 10, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 70 },
                    { 344, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 63 },
                    { 343, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 63 },
                    { 341, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 63 },
                    { 274, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 63 },
                    { 4, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 63 },
                    { 325, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 58 },
                    { 281, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 58 },
                    { 339, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 57 },
                    { 302, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 57 },
                    { 211, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 57 },
                    { 71, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 57 },
                    { 18, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 57 },
                    { 315, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 52 },
                    { 134, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 52 },
                    { 24, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 52 },
                    { 191, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 51 },
                    { 178, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 51 },
                    { 113, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 51 },
                    { 54, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 51 },
                    { 182, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 70 },
                    { 386, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 47 },
                    { 219, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 70 },
                    { 27, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 76 },
                    { 292, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 97 },
                    { 204, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 97 },
                    { 111, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 97 },
                    { 250, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 88 },
                    { 237, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 88 },
                    { 216, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 88 },
                    { 84, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 88 },
                    { 215, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 84 },
                    { 202, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 84 },
                    { 140, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 84 },
                    { 28, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 84 },
                    { 352, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 310, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 232, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 223, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 125, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 38, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 82 },
                    { 330, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 78 },
                    { 171, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 78 },
                    { 295, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 76 },
                    { 268, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 76 },
                    { 390, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 70 },
                    { 349, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 47 },
                    { 305, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 47 },
                    { 209, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 47 },
                    { 62, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 14 },
                    { 21, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 14 },
                    { 399, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 398, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 8 },
                    { 380, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 8 },
                    { 362, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 309, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 248, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 187, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 68, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 8 },
                    { 314, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 5 },
                    { 169, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 5 },
                    { 33, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 5 },
                    { 381, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 99 },
                    { 316, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 99 },
                    { 168, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 99 },
                    { 138, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 99 },
                    { 91, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 99 },
                    { 8, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 99 },
                    { 129, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 90 },
                    { 323, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 87 },
                    { 350, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 14 },
                    { 36, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 16 },
                    { 337, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 16 },
                    { 44, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 21 },
                    { 104, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 47 },
                    { 397, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 42 },
                    { 279, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 42 },
                    { 275, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 42 },
                    { 249, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 42 },
                    { 173, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 42 },
                    { 90, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 42 },
                    { 43, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 42 },
                    { 37, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 42 },
                    { 19, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 39 },
                    { 401, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 40 },
                    { 128, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 29 },
                    { 181, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 28 },
                    { 52, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 28 },
                    { 363, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 25 },
                    { 360, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 25 },
                    { 359, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 25 },
                    { 356, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 25 },
                    { 338, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 25 },
                    { 334, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 25 },
                    { 76, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 25 },
                    { 130, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 21 },
                    { 393, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 28 },
                    { 326, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 97 },
                    { 391, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 40 },
                    { 180, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 40 },
                    { 157, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 96 },
                    { 94, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 96 },
                    { 63, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 96 },
                    { 389, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 95 },
                    { 200, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 95 },
                    { 177, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 95 },
                    { 166, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 95 },
                    { 114, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 95 },
                    { 97, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 95 },
                    { 377, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 92 },
                    { 221, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 92 },
                    { 150, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 92 },
                    { 105, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 92 },
                    { 102, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 92 },
                    { 14, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 92 },
                    { 318, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 80 },
                    { 276, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 80 },
                    { 78, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 80 },
                    { 72, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 80 },
                    { 253, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 67 },
                    { 98, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 67 },
                    { 214, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 96 },
                    { 49, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 66 },
                    { 369, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 96 },
                    { 175, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 2 },
                    { 158, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 34 },
                    { 65, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 34 },
                    { 265, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 26 },
                    { 123, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 26 },
                    { 110, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 26 },
                    { 13, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 26 },
                    { 287, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 23 },
                    { 220, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 23 },
                    { 132, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 23 },
                    { 81, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 23 },
                    { 273, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 20 },
                    { 225, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 20 },
                    { 190, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 20 },
                    { 116, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 20 },
                    { 73, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 20 },
                    { 47, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 20 },
                    { 242, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 15 },
                    { 46, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 15 },
                    { 9, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 15 },
                    { 235, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 2 },
                    { 186, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 2 },
                    { 26, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 2 },
                    { 184, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 34 },
                    { 23, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 66 },
                    { 371, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 55 },
                    { 156, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 35 },
                    { 39, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 35 },
                    { 240, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 32 },
                    { 239, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 32 },
                    { 167, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 32 },
                    { 100, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 32 },
                    { 80, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 32 },
                    { 45, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 32 },
                    { 246, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 27 },
                    { 229, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 27 },
                    { 152, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 27 },
                    { 147, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 27 },
                    { 50, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 27 },
                    { 331, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 22 },
                    { 192, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 22 },
                    { 162, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 22 },
                    { 260, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 18 },
                    { 60, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 18 },
                    { 59, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 18 },
                    { 284, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 11 },
                    { 112, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 11 },
                    { 179, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 35 },
                    { 382, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 55 },
                    { 103, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 37 },
                    { 172, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 37 },
                    { 355, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 55 },
                    { 313, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 55 },
                    { 293, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 55 },
                    { 117, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 55 },
                    { 69, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 55 },
                    { 378, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 50 },
                    { 358, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 50 },
                    { 297, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 50 },
                    { 210, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 50 },
                    { 151, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 50 },
                    { 372, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 38 },
                    { 257, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 38 },
                    { 195, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 38 },
                    { 131, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 38 },
                    { 120, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 38 },
                    { 88, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 38 },
                    { 48, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 38 },
                    { 25, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 38 },
                    { 367, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 37 },
                    { 228, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 37 },
                    { 203, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 37 },
                    { 135, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 37 },
                    { 324, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 34 },
                    { 2, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 44 },
                    { 199, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 44 },
                    { 143, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 10 },
                    { 395, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 7 },
                    { 388, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 7 },
                    { 348, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 7 },
                    { 256, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 7 },
                    { 174, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 7 },
                    { 122, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 7 },
                    { 101, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 7 },
                    { 258, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 6 },
                    { 247, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 6 },
                    { 142, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 6 },
                    { 322, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 4 },
                    { 236, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 4 },
                    { 5, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 4 },
                    { 375, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 3 },
                    { 336, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 3 },
                    { 353, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 1 },
                    { 346, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 1 },
                    { 264, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 160, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 95, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 164, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 10 },
                    { 56, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 231, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 10 },
                    { 303, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 10 },
                    { 376, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 36 },
                    { 285, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 36 },
                    { 230, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 36 },
                    { 53, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 36 },
                    { 11, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 36 },
                    { 351, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 33 },
                    { 277, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 33 },
                    { 89, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 33 },
                    { 67, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 30 },
                    { 64, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 30 },
                    { 17, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 30 },
                    { 3, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 30 },
                    { 385, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 17 },
                    { 328, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 17 },
                    { 163, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 17 },
                    { 93, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 17 },
                    { 307, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 13 },
                    { 283, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 13 },
                    { 269, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 13 },
                    { 227, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 13 },
                    { 74, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 13 },
                    { 271, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 10 },
                    { 16, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 6, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 1 },
                    { 87, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 94 },
                    { 267, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 64 },
                    { 226, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 64 },
                    { 392, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 61 },
                    { 153, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 61 },
                    { 58, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 61 },
                    { 20, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 61 },
                    { 383, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 53 },
                    { 289, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 53 },
                    { 208, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 53 },
                    { 159, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 53 },
                    { 251, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 48 },
                    { 183, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 48 },
                    { 254, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 45 },
                    { 213, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 45 },
                    { 198, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 45 },
                    { 188, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 45 },
                    { 148, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 45 },
                    { 30, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 45 },
                    { 345, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 44 },
                    { 335, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 44 },
                    { 312, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 44 },
                    { 354, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 64 },
                    { 368, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 64 },
                    { 306, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 68 },
                    { 126, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 73 },
                    { 83, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 94 },
                    { 374, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 89 },
                    { 245, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 89 },
                    { 149, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 89 },
                    { 357, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 342, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 217, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 144, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 139, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 109, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 222, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 40 },
                    { 61, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 35, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 373, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 74 },
                    { 263, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 74 },
                    { 261, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 74 },
                    { 206, " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg", true, 74 },
                    { 379, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ", true, 73 },
                    { 300, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 73 },
                    { 272, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 73 },
                    { 255, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 73 },
                    { 234, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 73 },
                    { 55, "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ", true, 83 },
                    { 329, "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg ", true, 97 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId1",
                table: "ShoppingCarts",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
