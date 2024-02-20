using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MycoMatrix.Migrations
{
    public partial class AddJWT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 12);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Mushrooms",
                columns: new[] { "MushroomId", "CommonName", "Editor", "Genus", "GillType", "ImageURL", "Notes", "Species", "ToxicityLevel" },
                values: new object[,]
                {
                    { 1, "Black Trumpet", "Kim Robinson", "Craterellus", "Ridged", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "choice edible, grows under oak and beech trees", "cornucopioides", 0 },
                    { 2, "Golden Chanterelle", "Mickey Mouse", "Cantharellus", "Ridged", "https://d2ci82p1s8eczl.cloudfront.net/wp-content/uploads/20231219151006/castatemushroom-scaled.jpg", "choice edible, grows in conifer forests under Douglas Fir, spruce and hemlocks", "cibarius", 0 },
                    { 3, "Morel", "Kim Robinson", "Morchella", "None", "https://media.istockphoto.com/id/1059075136/photo/a-large-group-of-morels-by-a-stream.jpg?s=612x612&w=0&k=20&c=QU-hajnz7xC60AGuQhsJWOAx7MpVB4sWbMB0xEE3vVI=", "may cause some stomach upset in certain individuals, must cook thoroughly", "esculenta", 3 },
                    { 4, "Chicken of the woods", "Henry Oberholtzer", "Laetiporus", "Polypore", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Laetiporus_sulphureus_JPG01.jpg/1920px-Laetiporus_sulphureus_JPG01.jpg", "may cause some GI upset in some individuals, grows on dead or dying trees", "sulphureus", 3 },
                    { 5, "Black Trumpet", "Kim Robinson", "Craterellus", "Ridged", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "choice edible, grows under oak and beech trees", "cornucopioides", 0 },
                    { 6, "Deadly Galerina", "Paul Stamets", "Galerina", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", "contains amatoxins, has been confused with Psilocybe stuntzii", "marginata", 10 },
                    { 7, "Fly Agaric", "Henry Oberholtzer", "Amanita", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Amanita_muscaria_3_vliegenzwammen_op_rij.jpg/1920px-Amanita_muscaria_3_vliegenzwammen_op_rij.jpg", "won't kill you", "muscaria", 5 },
                    { 8, "toxic black mold", "Paul Stamets", "Stachybotrys", "None", "https://upload.wikimedia.org/wikipedia/commons/7/7c/2009-05-09_Stachybotrys_chartarum_%28Ehrenb.%29_S._Hughes_43158.jpg", "One of the worst fungi to encounter", "chartarum", 8 },
                    { 9, "Turkey Tail", "Kim Robinson", "Trametes", "Pores", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Trametes_versicolor_G4_%281%29.JPG/1280px-Trametes_versicolor_G4_%281%29.JPG", "edible, medicinal", "versicolor", 0 },
                    { 10, "Crystal Brain", "Henry Oberholtzer", "Myxarium", "None", "https://upload.wikimedia.org/wikipedia/commons/9/95/Crystal_Brain_Fungus_%28Exidia_nucleata%29_-_geograph.org.uk_-_1000447.jpg", "Unknown if edible or not", "nucleatum", 0 },
                    { 11, "Magic Mushrooms", "Paul Stamets", "Psilocybe", "Gills", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Cubensis_Xalapa.jpg/1280px-Cubensis_Xalapa.jpg", "The classic tripper's delight", "cubensis", 2 },
                    { 12, "Cordyceps", "Pedro Pascal", "Ophiocordyceps ", "None", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Ophiocordyceps_unilateralis.png/800px-Ophiocordyceps_unilateralis.png", "If you're an ant it's bad news, otherwise it's medicinal", "unilateralis", 2 }
                });
        }
    }
}
