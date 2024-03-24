using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Celestio.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "SocialMediae",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "SocialMediae",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 188, 186, 70, 123, 48, 174, 178, 160, 70, 80, 48, 56, 210, 75, 169, 76, 31, 25, 182, 178, 79, 43, 89, 75, 144, 55, 129, 54, 211, 174, 185, 212, 217, 58, 16, 97, 3, 34, 103, 149, 98, 70, 237, 205, 239, 175, 241, 161, 64, 27, 92, 21, 179, 72, 254, 113, 254, 34, 106, 224, 231, 133, 157 }, new byte[] { 207, 182, 61, 231, 116, 203, 161, 217, 151, 117, 120, 174, 225, 181, 46, 186, 83, 193, 177, 213, 255, 202, 197, 184, 247, 96, 4, 141, 28, 56, 3, 213, 161, 185, 226, 42, 152, 171, 185, 89, 239, 141, 158, 171, 180, 194, 151, 128, 222, 29, 124, 7, 144, 72, 70, 125, 119, 27, 158, 105, 42, 14, 125, 8, 222, 129, 168, 188, 74, 236, 72, 50, 122, 28, 246, 198, 89, 7, 102, 205, 50, 237, 152, 74, 6, 151, 153, 231, 12, 92, 242, 187, 244, 77, 170, 251, 251, 43, 247, 15, 196, 17, 173, 127, 40, 52, 144, 146, 151, 115, 197, 53, 17, 43, 223, 8, 110, 72, 50, 191, 154, 251, 86, 31, 118, 251, 247, 200 } });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediae_BrandId",
                table: "SocialMediae",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediae_CompanyId",
                table: "SocialMediae",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMediae_Brands_BrandId",
                table: "SocialMediae",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMediae_Companies_CompanyId",
                table: "SocialMediae",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMediae_Brands_BrandId",
                table: "SocialMediae");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMediae_Companies_CompanyId",
                table: "SocialMediae");

            migrationBuilder.DropIndex(
                name: "IX_SocialMediae_BrandId",
                table: "SocialMediae");

            migrationBuilder.DropIndex(
                name: "IX_SocialMediae_CompanyId",
                table: "SocialMediae");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "SocialMediae");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "SocialMediae");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 90, 151, 205, 107, 71, 36, 123, 96, 51, 145, 239, 41, 130, 221, 139, 15, 74, 147, 243, 0, 92, 78, 136, 242, 23, 124, 136, 95, 213, 173, 22, 124, 237, 19, 176, 154, 16, 56, 213, 225, 131, 235, 14, 145, 141, 58, 193, 171, 73, 23, 23, 168, 144, 223, 95, 100, 136, 201, 131, 149, 231, 89, 84 }, new byte[] { 210, 29, 17, 125, 137, 129, 240, 147, 60, 115, 157, 144, 98, 11, 240, 23, 172, 98, 131, 180, 155, 85, 223, 229, 112, 189, 201, 207, 93, 162, 203, 126, 70, 153, 227, 80, 58, 182, 5, 38, 168, 176, 245, 205, 77, 172, 38, 29, 191, 168, 66, 106, 139, 172, 205, 118, 165, 180, 145, 159, 13, 169, 193, 157, 49, 13, 151, 255, 131, 232, 244, 3, 92, 52, 116, 162, 48, 10, 78, 164, 38, 211, 96, 81, 66, 36, 199, 20, 104, 81, 221, 12, 106, 62, 41, 175, 94, 113, 137, 5, 168, 159, 136, 138, 247, 206, 19, 129, 146, 212, 7, 119, 169, 74, 26, 97, 23, 192, 8, 226, 30, 216, 192, 247, 244, 204, 136, 239 } });
        }
    }
}
