using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class SaraHobby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 4, "Creating in my art journal allows me to express myself", "Art Journal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbys",
                keyColumn: "HobbyId",
                keyValue: 4);
        }
    }
}
