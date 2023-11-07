using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomosAlkemy.Migrations
{
    public partial class MigracionVer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 1, "42305828", "mathiasdavid@live.ca", "Mathias", false, "Perez", "1234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 2, "4231145", "jorgeperez@live.ca", "Jorge", false, "Perez", "3332" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 2);
        }
    }
}
