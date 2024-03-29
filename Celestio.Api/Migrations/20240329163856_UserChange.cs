using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Celestio.Api.Migrations
{
    /// <inheritdoc />
    public partial class UserChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Media_ProfilePicMediaId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserDescription",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ProfilePicMediaId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 11, 214, 102, 157, 173, 184, 236, 215, 227, 128, 128, 88, 1, 92, 134, 210, 76, 58, 221, 73, 69, 76, 197, 204, 230, 114, 235, 195, 33, 142, 139, 92, 5, 254, 242, 3, 64, 244, 245, 60, 92, 123, 121, 130, 199, 233, 172, 98, 178, 86, 155, 161, 117, 160, 110, 255, 207, 215, 83, 129, 77, 114, 45, 220 }, new byte[] { 83, 226, 187, 63, 47, 245, 119, 69, 89, 137, 120, 126, 52, 175, 69, 250, 159, 253, 76, 195, 54, 56, 219, 206, 89, 8, 15, 41, 121, 248, 111, 5, 51, 148, 40, 207, 9, 196, 172, 225, 35, 4, 22, 223, 10, 185, 69, 71, 17, 206, 175, 78, 254, 165, 244, 77, 204, 255, 43, 86, 45, 132, 89, 157, 224, 167, 215, 105, 53, 225, 202, 212, 36, 81, 185, 176, 176, 174, 101, 143, 187, 232, 130, 68, 62, 217, 30, 150, 232, 249, 40, 201, 12, 165, 223, 121, 151, 68, 128, 189, 234, 82, 225, 186, 227, 155, 166, 91, 229, 56, 220, 213, 207, 254, 74, 54, 134, 126, 45, 164, 153, 129, 141, 143, 97, 71, 244, 239 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 68, 63, 174, 59, 254, 110, 126, 90, 37, 130, 175, 208, 231, 81, 88, 150, 80, 23, 253, 69, 117, 77, 238, 91, 213, 136, 161, 198, 44, 86, 145, 223, 4, 76, 95, 209, 182, 55, 65, 254, 146, 194, 162, 136, 84, 220, 177, 121, 219, 126, 139, 182, 187, 129, 195, 236, 237, 69, 192, 44, 13, 121, 239, 57 }, new byte[] { 252, 132, 84, 115, 232, 148, 3, 147, 153, 188, 126, 254, 153, 105, 252, 99, 63, 190, 5, 172, 29, 55, 84, 49, 167, 62, 179, 238, 96, 123, 98, 5, 178, 3, 78, 138, 237, 86, 69, 239, 48, 128, 19, 154, 232, 244, 60, 92, 239, 156, 178, 181, 173, 169, 113, 222, 57, 152, 116, 192, 20, 31, 234, 183, 128, 84, 238, 73, 217, 156, 174, 149, 93, 22, 153, 178, 141, 81, 200, 8, 109, 8, 8, 122, 132, 216, 199, 75, 179, 125, 204, 161, 91, 237, 107, 138, 53, 111, 244, 84, 104, 153, 104, 41, 29, 18, 152, 202, 220, 130, 9, 253, 254, 82, 72, 247, 210, 19, 160, 135, 172, 189, 142, 155, 203, 85, 100, 73 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Media_ProfilePicMediaId",
                table: "Users",
                column: "ProfilePicMediaId",
                principalTable: "Media",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Media_ProfilePicMediaId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserDescription",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfilePicMediaId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 2, 202, 149, 236, 59, 10, 177, 248, 231, 153, 2, 81, 226, 125, 241, 9, 103, 37, 43, 105, 21, 142, 1, 190, 244, 77, 114, 104, 247, 52, 180, 98, 167, 141, 8, 75, 23, 68, 240, 82, 147, 113, 192, 126, 140, 64, 201, 88, 165, 126, 141, 233, 1, 178, 149, 56, 25, 143, 97, 179, 198, 155, 140, 191 }, new byte[] { 6, 86, 100, 247, 245, 0, 206, 217, 101, 56, 160, 255, 170, 84, 175, 110, 68, 82, 108, 79, 133, 156, 136, 217, 97, 94, 104, 154, 140, 44, 176, 158, 35, 67, 34, 169, 43, 169, 127, 220, 65, 50, 166, 90, 238, 250, 97, 230, 41, 138, 181, 96, 79, 215, 218, 17, 20, 19, 155, 119, 75, 246, 27, 115, 84, 51, 89, 233, 231, 185, 47, 218, 66, 68, 88, 153, 197, 243, 201, 36, 127, 176, 225, 208, 163, 87, 180, 128, 147, 53, 145, 252, 246, 85, 71, 249, 155, 150, 122, 224, 117, 78, 3, 154, 144, 203, 9, 182, 151, 35, 209, 154, 28, 130, 114, 116, 37, 94, 205, 30, 32, 209, 29, 133, 18, 177, 177, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 57, 11, 176, 82, 193, 74, 240, 166, 60, 154, 17, 80, 11, 69, 62, 103, 192, 196, 217, 133, 243, 200, 139, 12, 113, 107, 4, 114, 53, 69, 83, 30, 147, 142, 221, 51, 239, 196, 82, 175, 245, 7, 152, 25, 214, 155, 49, 97, 185, 253, 192, 130, 92, 11, 122, 120, 20, 188, 53, 79, 7, 113, 182, 105 }, new byte[] { 131, 213, 127, 241, 168, 233, 129, 164, 0, 88, 207, 247, 46, 81, 131, 217, 212, 185, 163, 41, 180, 159, 150, 214, 221, 207, 162, 73, 1, 162, 126, 248, 157, 214, 125, 93, 242, 164, 128, 164, 51, 10, 4, 73, 62, 15, 181, 65, 162, 55, 34, 82, 77, 188, 109, 76, 172, 210, 157, 236, 29, 113, 75, 106, 196, 42, 162, 172, 232, 203, 246, 208, 151, 140, 241, 40, 167, 78, 209, 157, 100, 52, 36, 60, 249, 64, 30, 54, 210, 109, 88, 131, 145, 148, 67, 130, 46, 53, 231, 159, 239, 21, 130, 20, 138, 127, 95, 85, 132, 53, 130, 69, 73, 159, 155, 21, 46, 170, 175, 87, 190, 66, 243, 156, 157, 29, 136, 31 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Media_ProfilePicMediaId",
                table: "Users",
                column: "ProfilePicMediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
