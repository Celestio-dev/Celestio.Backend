using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Celestio.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BriefId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    WatermarkMediaId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicMediaId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Briefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BriefTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Briefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Briefs_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BriefId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Briefs_BriefId",
                        column: x => x.BriefId,
                        principalTable: "Briefs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicMediaId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Role_ProfilePicMediaId",
                        column: x => x.ProfilePicMediaId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProfilePicMediaId = table.Column<int>(type: "int", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Role_ProfilePicMediaId",
                        column: x => x.ProfilePicMediaId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocId = table.Column<int>(type: "int", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaName = table.Column<int>(type: "int", nullable: false),
                    SocialMediaUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 3, 31, 15, 8, 43, 364, DateTimeKind.Utc).AddTicks(8660)),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SocialMedia_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SocialMedia_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "BriefId", "Created", "MediaType", "MediaUrl" },
                values: new object[] { 1, null, new DateTime(2024, 3, 31, 17, 8, 43, 364, DateTimeKind.Local).AddTicks(9310), "aaa", "lasbd url media" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SuperAdmin" },
                    { 2, "AgencyAdmin" },
                    { 3, "Creator" },
                    { 4, "User" },
                    { 5, "BrandAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyDescription", "CompanyName", "ContactEmail", "Created", "ProfilePicMediaId", "Type" },
                values: new object[,]
                {
                    { 1, "Celestio Content description woo", "Celestio", "celestio.dev@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, "Agencija 404 za kreatore", "Agency 404", "contact@404.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Created", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "ProfilePicMediaId", "RoleId", "UserDescription" },
                values: new object[,]
                {
                    { 1, 1, null, "teo@teo.com", "Teo", "Ivančević (č, ć, dž, đ, š, ž)", new byte[] { 153, 102, 69, 8, 21, 201, 169, 109, 9, 126, 187, 43, 54, 82, 159, 106, 62, 94, 133, 138, 199, 84, 26, 4, 99, 118, 0, 39, 63, 37, 191, 80, 91, 210, 97, 254, 196, 136, 191, 7, 153, 232, 52, 162, 26, 213, 126, 69, 22, 39, 233, 40, 93, 234, 233, 94, 17, 101, 140, 45, 22, 103, 145, 71 }, new byte[] { 50, 119, 47, 17, 227, 52, 25, 147, 129, 27, 215, 178, 254, 99, 77, 168, 214, 195, 146, 238, 101, 33, 42, 57, 218, 28, 171, 143, 28, 127, 37, 179, 114, 181, 135, 69, 63, 135, 89, 188, 105, 34, 85, 15, 188, 187, 72, 137, 84, 252, 147, 237, 163, 233, 89, 115, 242, 26, 22, 246, 179, 23, 163, 125, 188, 26, 178, 49, 224, 18, 148, 109, 57, 166, 30, 156, 105, 180, 227, 248, 185, 254, 99, 118, 62, 54, 86, 236, 242, 5, 97, 92, 29, 18, 73, 191, 21, 95, 218, 75, 21, 54, 137, 229, 78, 246, 86, 130, 85, 35, 210, 221, 120, 177, 36, 35, 201, 125, 152, 173, 7, 199, 126, 158, 220, 147, 87, 22 }, 1, 1, "Ja sam teo bla bla" },
                    { 2, 2, null, "leonarda@404.com", "Leonarda", "Lovrić", new byte[] { 122, 103, 21, 224, 82, 147, 198, 7, 7, 236, 25, 168, 109, 59, 194, 160, 107, 203, 126, 241, 52, 123, 110, 121, 232, 248, 171, 159, 98, 161, 141, 212, 178, 59, 123, 235, 9, 238, 248, 82, 148, 33, 219, 73, 208, 92, 185, 84, 181, 46, 118, 73, 17, 251, 61, 8, 112, 182, 149, 248, 67, 32, 231, 213 }, new byte[] { 10, 210, 89, 106, 253, 27, 163, 15, 237, 102, 239, 28, 29, 178, 138, 32, 106, 23, 222, 167, 47, 64, 18, 94, 49, 111, 159, 203, 36, 56, 230, 124, 53, 226, 20, 166, 254, 235, 59, 251, 231, 21, 13, 63, 93, 92, 4, 170, 240, 12, 241, 81, 41, 140, 227, 35, 127, 244, 93, 57, 228, 245, 126, 138, 149, 151, 115, 169, 9, 130, 122, 218, 20, 73, 221, 233, 108, 116, 8, 78, 166, 47, 106, 105, 164, 183, 129, 74, 84, 196, 194, 218, 165, 65, 27, 246, 242, 188, 80, 186, 101, 166, 12, 49, 74, 73, 28, 1, 255, 86, 209, 29, 249, 14, 248, 250, 207, 72, 55, 247, 217, 128, 134, 51, 55, 184, 106, 246 }, 1, 2, "Ja sam leonarda bla bla" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brand_CompanyId",
                table: "Brand",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_ProfilePicMediaId",
                table: "Brand",
                column: "ProfilePicMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Briefs_BrandId",
                table: "Briefs",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProfilePicMediaId",
                table: "Companies",
                column: "ProfilePicMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_BriefId",
                table: "Role",
                column: "BriefId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_BrandId",
                table: "SocialMedia",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_CompanyId",
                table: "SocialMedia",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_UserId",
                table: "SocialMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfilePicMediaId",
                table: "Users",
                column: "ProfilePicMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Companies_CompanyId",
                table: "Brand",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Role_ProfilePicMediaId",
                table: "Brand",
                column: "ProfilePicMediaId",
                principalTable: "Role",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Companies_CompanyId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Role_ProfilePicMediaId",
                table: "Brand");

            migrationBuilder.DropTable(
                name: "CompanyBrands");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "UserCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Briefs");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
