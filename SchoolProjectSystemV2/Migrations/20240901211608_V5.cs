using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectSystemV2.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Emaill",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalID",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "students",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Emaill",
                table: "students");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "students");
        }
    }
}
