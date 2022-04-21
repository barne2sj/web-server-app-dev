using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbys",
                columns: table => new
                {
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbys", x => x.HobbyId);
                });

            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 1, "Cooking for my family makes me happy", "Cooking" });

            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 2, "Swimming in water makes me feel relax", "Swimming" });

            migrationBuilder.InsertData(
                table: "Hobbys",
                columns: new[] { "HobbyId", "HobbyDescription", "HobbyName" },
                values: new object[] { 3, "Playing with my friends", "Video Games" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbys");
        }
    }
}
