using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Celestio.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserDescription",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BriefId",
                table: "Media",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Briefs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyDescription", "CompanyName", "ContactEmail", "Created", "ProfilePicMediaId", "Type" },
                values: new object[,]
                {
                    { 1, "Celestio Content description woo", "Celestio", "celestio.dev@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, "Agencija 404 za kreatore", "Agency 404", "contact@404.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "BriefId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "LastName", "PasswordHash", "PasswordSalt", "UserDescription" },
                values: new object[] { 1, "Ivančević (č, ć, dž, đ, š, ž)", new byte[] { 2, 202, 149, 236, 59, 10, 177, 248, 231, 153, 2, 81, 226, 125, 241, 9, 103, 37, 43, 105, 21, 142, 1, 190, 244, 77, 114, 104, 247, 52, 180, 98, 167, 141, 8, 75, 23, 68, 240, 82, 147, 113, 192, 126, 140, 64, 201, 88, 165, 126, 141, 233, 1, 178, 149, 56, 25, 143, 97, 179, 198, 155, 140, 191 }, new byte[] { 6, 86, 100, 247, 245, 0, 206, 217, 101, 56, 160, 255, 170, 84, 175, 110, 68, 82, 108, 79, 133, 156, 136, 217, 97, 94, 104, 154, 140, 44, 176, 158, 35, 67, 34, 169, 43, 169, 127, 220, 65, 50, 166, 90, 238, 250, 97, 230, 41, 138, 181, 96, 79, 215, 218, 17, 20, 19, 155, 119, 75, 246, 27, 115, 84, 51, 89, 233, 231, 185, 47, 218, 66, 68, 88, 153, 197, 243, 201, 36, 127, 176, 225, 208, 163, 87, 180, 128, 147, 53, 145, 252, 246, 85, 71, 249, 155, 150, 122, 224, 117, 78, 3, 154, 144, 203, 9, 182, 151, 35, 209, 154, 28, 130, 114, 116, 37, 94, 205, 30, 32, 209, 29, 133, 18, 177, 177, 40 }, "Ja sam teo bla bla" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Created", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "ProfilePicMediaId", "RoleId", "UserDescription" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "leonarda@404.com", "Leonarda", "Lovrić", new byte[] { 57, 11, 176, 82, 193, 74, 240, 166, 60, 154, 17, 80, 11, 69, 62, 103, 192, 196, 217, 133, 243, 200, 139, 12, 113, 107, 4, 114, 53, 69, 83, 30, 147, 142, 221, 51, 239, 196, 82, 175, 245, 7, 152, 25, 214, 155, 49, 97, 185, 253, 192, 130, 92, 11, 122, 120, 20, 188, 53, 79, 7, 113, 182, 105 }, new byte[] { 131, 213, 127, 241, 168, 233, 129, 164, 0, 88, 207, 247, 46, 81, 131, 217, 212, 185, 163, 41, 180, 159, 150, 214, 221, 207, 162, 73, 1, 162, 126, 248, 157, 214, 125, 93, 242, 164, 128, 164, 51, 10, 4, 73, 62, 15, 181, 65, 162, 55, 34, 82, 77, 188, 109, 76, 172, 210, 157, 236, 29, 113, 75, 106, 196, 42, 162, 172, 232, 203, 246, 208, 151, 140, 241, 40, 167, 78, 209, 157, 100, 52, 36, 60, 249, 64, 30, 54, 210, 109, 88, 131, 145, 148, 67, 130, 46, 53, 231, 159, 239, 21, 130, 20, 138, 127, 95, 85, 132, 53, 130, 69, 73, 159, 155, 21, 46, 170, 175, 87, 190, 66, 243, 156, 157, 29, 136, 31 }, 1, 2, "Ja sam leonarda bla bla" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_BriefId",
                table: "Media",
                column: "BriefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Briefs_BriefId",
                table: "Media",
                column: "BriefId",
                principalTable: "Briefs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Briefs_BriefId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CompanyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Media_BriefId",
                table: "Media");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserDescription",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BriefId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Briefs");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ivancevic", new byte[] { 42, 188, 186, 70, 123, 48, 174, 178, 160, 70, 80, 48, 56, 210, 75, 169, 76, 31, 25, 182, 178, 79, 43, 89, 75, 144, 55, 129, 54, 211, 174, 185, 212, 217, 58, 16, 97, 3, 34, 103, 149, 98, 70, 237, 205, 239, 175, 241, 161, 64, 27, 92, 21, 179, 72, 254, 113, 254, 34, 106, 224, 231, 133, 157 }, new byte[] { 207, 182, 61, 231, 116, 203, 161, 217, 151, 117, 120, 174, 225, 181, 46, 186, 83, 193, 177, 213, 255, 202, 197, 184, 247, 96, 4, 141, 28, 56, 3, 213, 161, 185, 226, 42, 152, 171, 185, 89, 239, 141, 158, 171, 180, 194, 151, 128, 222, 29, 124, 7, 144, 72, 70, 125, 119, 27, 158, 105, 42, 14, 125, 8, 222, 129, 168, 188, 74, 236, 72, 50, 122, 28, 246, 198, 89, 7, 102, 205, 50, 237, 152, 74, 6, 151, 153, 231, 12, 92, 242, 187, 244, 77, 170, 251, 251, 43, 247, 15, 196, 17, 173, 127, 40, 52, 144, 146, 151, 115, 197, 53, 17, 43, 223, 8, 110, 72, 50, 191, 154, 251, 86, 31, 118, 251, 247, 200 } });
        }
    }
}
