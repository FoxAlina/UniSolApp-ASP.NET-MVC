using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class SurrogateIdCleanning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "UserTransactions");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "TextFormattingEntities");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "ListLines");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "ListHeaders");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "ListFormattingEntities");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "ItemGroups");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "Followers");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "DimensionLines");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "DimensionHeaders");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "DimensionGroups");

            migrationBuilder.DropColumn(
                name: "SurrogateId",
                table: "DimensionCombinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "UserTransactions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "TextFormattingEntities",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "Modules",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "ListLines",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "ListHeaders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "ListFormattingEntities",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "Items",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "ItemGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "Followers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "DimensionLines",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "DimensionHeaders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "DimensionGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SurrogateId",
                table: "DimensionCombinations",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
