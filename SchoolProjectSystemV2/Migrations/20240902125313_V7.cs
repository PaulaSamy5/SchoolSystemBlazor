using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectSystemV2.Migrations
{
    /// <inheritdoc />
    public partial class V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_students_Emaill",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_NationalID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_PhoneNumber",
                table: "students");

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Emaill",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Emaill",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_students_Emaill",
                table: "students",
                column: "Emaill",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_NationalID",
                table: "students",
                column: "NationalID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_PhoneNumber",
                table: "students",
                column: "PhoneNumber",
                unique: true);
        }
    }
}
