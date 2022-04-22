using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class RemainingHobbies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 5, "Taking photos of random things such as buildings.", "Photography" });

            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 6, "Watching and analyzing movies while having meaningful discussions.", "Films" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "HobbyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "HobbyId",
                keyValue: 6);
        }
    }
}
