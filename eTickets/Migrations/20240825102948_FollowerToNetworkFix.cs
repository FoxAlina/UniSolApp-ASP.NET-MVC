using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class FollowerToNetworkFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "accessType",
                table: "Followers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accessType",
                table: "Followers");
        }
    }
}
