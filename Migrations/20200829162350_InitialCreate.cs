using Microsoft.EntityFrameworkCore.Migrations;

namespace EAD2WeatherApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: false),
                    CurrentCondition = table.Column<string>(nullable: false),
                    MaxTemperature = table.Column<double>(nullable: false),
                    MinTemperature = table.Column<double>(nullable: false),
                    WindDirection = table.Column<string>(nullable: false),
                    WindSpeed = table.Column<int>(nullable: false),
                    Outlook = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
