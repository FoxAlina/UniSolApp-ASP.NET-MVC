using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class LinkEntitiesRelationsDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeaders_DimensionHeaders_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroups_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_LinkItemId_LinkItemUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_ListHeaders_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Modules_LinkModuleId_LinkModuleUserId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "LinkModuleIdx",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "LinkListHeaderIdx",
                table: "ListHeaders");

            migrationBuilder.DropIndex(
                name: "LinkItemIdx",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups");

            migrationBuilder.DropIndex(
                name: "LinkItemGroupIdx",
                table: "ItemGroups");

            migrationBuilder.DropIndex(
                name: "LinkDimHeaderIdx",
                table: "DimensionHeaders");

            migrationBuilder.DropColumn(
                name: "LinkModuleId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LinkModuleUserId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LinkListHeaderId",
                table: "ListHeaders");

            migrationBuilder.DropColumn(
                name: "LinkListHeaderUserId",
                table: "ListHeaders");

            migrationBuilder.DropColumn(
                name: "LinkItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LinkItemUserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LinkItemGroupId",
                table: "ItemGroups");

            migrationBuilder.DropColumn(
                name: "LinkItemGroupUserId",
                table: "ItemGroups");

            migrationBuilder.DropColumn(
                name: "LinkHeaderId",
                table: "DimensionHeaders");

            migrationBuilder.DropColumn(
                name: "LinkHeaderUserId",
                table: "DimensionHeaders");

            migrationBuilder.AddColumn<int>(
                name: "DomainType",
                table: "DimensionGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DomainType",
                table: "DimensionGroups");

            migrationBuilder.AddColumn<Guid>(
                name: "LinkModuleId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkModuleUserId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkListHeaderId",
                table: "ListHeaders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkListHeaderUserId",
                table: "ListHeaders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkItemId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkItemUserId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkItemGroupId",
                table: "ItemGroups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkItemGroupUserId",
                table: "ItemGroups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkHeaderId",
                table: "DimensionHeaders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LinkHeaderUserId",
                table: "DimensionHeaders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "LinkModuleIdx",
                table: "Modules",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "LinkListHeaderIdx",
                table: "ListHeaders",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "LinkItemIdx",
                table: "Items",
                columns: new[] { "LinkItemId", "LinkItemUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ItemGroupId", "ModuleId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "LinkItemGroupIdx",
                table: "ItemGroups",
                column: "LinkItemGroupId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "LinkDimHeaderIdx",
                table: "DimensionHeaders",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeaders_DimensionHeaders_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeaders",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroups_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_LinkItemId_LinkItemUserId",
                table: "Items",
                columns: new[] { "LinkItemId", "LinkItemUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_ListHeaders_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeaders",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Modules_LinkModuleId_LinkModuleUserId",
                table: "Modules",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
