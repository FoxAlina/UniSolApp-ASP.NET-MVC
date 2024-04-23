using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Follower",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FollowerRefId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Follower_User_FollowerRefId",
                        column: x => x.FollowerRefId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Follower_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkItemGroupUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroup", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_ItemGroup_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                        columns: x => new { x.LinkItemGroupId, x.LinkItemGroupUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemGroup_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimensionCombination",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemUserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DimHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DimHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionCombination", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_DimensionCombination_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimensionLine",
                columns: table => new
                {
                    LineNum = table.Column<float>(type: "real", nullable: false),
                    DimensionHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LotId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Integer = table.Column<int>(type: "int", nullable: true),
                    Double = table.Column<double>(type: "float", nullable: true),
                    Bool = table.Column<bool>(type: "bit", nullable: true),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DimHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionLine", x => new { x.DimensionHeaderId, x.LineNum, x.UserId });
                    table.UniqueConstraint("AK_DimensionLine_LotId", x => x.LotId);
                    table.ForeignKey(
                        name: "FK_DimensionLine_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListHeader",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleUserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ModuleRefUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupRefUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimHeaderRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimHeaderRefUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkListHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkListHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimensionHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimensionHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListHeader", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_ListHeader_ItemGroup_ItemGroupId_ItemGroupUserId",
                        columns: x => new { x.ItemGroupId, x.ItemGroupUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_ItemGroup_ItemGroupRefId_ItemGroupRefUserId",
                        columns: x => new { x.ItemGroupRefId, x.ItemGroupRefUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_ListHeader_LinkListHeaderId_LinkListHeaderUserId",
                        columns: x => new { x.LinkListHeaderId, x.LinkListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimensionHeader",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TableType = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    LinkHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ListHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ListHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionHeader", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_DimensionHeader_DimensionHeader_LinkHeaderId_LinkHeaderUserId",
                        columns: x => new { x.LinkHeaderId, x.LinkHeaderUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionHeader_ListHeader_ListHeaderId_ListHeaderUserId",
                        columns: x => new { x.ListHeaderId, x.ListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionHeader_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    General = table.Column<bool>(type: "bit", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ModuleRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ModuleRefUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkModuleId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkModuleUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_Module_DimensionHeader_DimHeaderId_DimHeaderUserId",
                        columns: x => new { x.DimHeaderId, x.DimHeaderUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_ItemGroup_ItemGroupId_ItemGroupUserId",
                        columns: x => new { x.ItemGroupId, x.ItemGroupUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_Module_LinkModuleId_LinkModuleUserId",
                        columns: x => new { x.LinkModuleId, x.LinkModuleUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_Module_ModuleRefId_ModuleRefUserId",
                        columns: x => new { x.ModuleRefId, x.ModuleRefUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkItemId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LinkItemUserId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemGroupUserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ModuleUserId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_Item_Item_LinkItemId_LinkItemUserId",
                        columns: x => new { x.LinkItemId, x.LinkItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_ItemGroup_ItemGroupId_ItemGroupUserId",
                        columns: x => new { x.ItemGroupId, x.ItemGroupUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Module_ModuleId_ModuleUserId",
                        columns: x => new { x.ModuleId, x.ModuleUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListLine",
                columns: table => new
                {
                    LineNum = table.Column<float>(type: "real", nullable: false),
                    ListHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LotId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListHeaderUserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ItemUserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLine", x => new { x.ListHeaderId, x.LineNum, x.UserId });
                    table.UniqueConstraint("AK_ListLine_LotId", x => x.LotId);
                    table.ForeignKey(
                        name: "FK_ListLine_Item_ItemId_ItemUserId",
                        columns: x => new { x.ItemId, x.ItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListLine_ListHeader_ListHeaderId_ListHeaderUserId",
                        columns: x => new { x.ListHeaderId, x.ListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListLine_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransType = table.Column<int>(type: "int", nullable: false),
                    RefType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ListId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTransaction_Item_ItemId_UserId",
                        columns: x => new { x.ItemId, x.UserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_ListHeader_ListId_UserId",
                        columns: x => new { x.ListId, x.UserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_Module_ModuleId_UserId",
                        columns: x => new { x.ModuleId, x.UserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombination",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_ItemId_ItemUserId",
                table: "DimensionCombination",
                columns: new[] { "ItemId", "ItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_UserId",
                table: "DimensionCombination",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_UserId",
                table: "DimensionHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionLine_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionLine_ItemId_ItemUserId",
                table: "DimensionLine",
                columns: new[] { "ItemId", "ItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionLine_UserId",
                table: "DimensionLine",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_FollowerRefId",
                table: "Follower",
                column: "FollowerRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_UserId",
                table: "Follower",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemGroupId_ItemGroupUserId",
                table: "Item",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_LinkItemId_LinkItemUserId",
                table: "Item",
                columns: new[] { "LinkItemId", "LinkItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ModuleId_ModuleUserId",
                table: "Item",
                columns: new[] { "ModuleId", "ModuleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_UserId",
                table: "Item",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroup",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_UserId",
                table: "ItemGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_DimensionHeaderId_DimensionHeaderUserId",
                table: "ListHeader",
                columns: new[] { "DimensionHeaderId", "DimensionHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_DimHeaderRefId_DimHeaderRefUserId",
                table: "ListHeader",
                columns: new[] { "DimHeaderRefId", "DimHeaderRefUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ItemGroupId_ItemGroupUserId",
                table: "ListHeader",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ItemGroupRefId_ItemGroupRefUserId",
                table: "ListHeader",
                columns: new[] { "ItemGroupRefId", "ItemGroupRefUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeader",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ModuleId_ModuleUserId",
                table: "ListHeader",
                columns: new[] { "ModuleId", "ModuleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ModuleRefId_ModuleRefUserId",
                table: "ListHeader",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_UserId",
                table: "ListHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListLine_ItemId_ItemUserId",
                table: "ListLine",
                columns: new[] { "ItemId", "ItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListLine_ListHeaderId_ListHeaderUserId",
                table: "ListLine",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_ListLine_UserId",
                table: "ListLine",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_DimHeaderId_DimHeaderUserId",
                table: "Module",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Module_ItemGroupId_ItemGroupUserId",
                table: "Module",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Module_LinkModuleId_LinkModuleUserId",
                table: "Module",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Module_ModuleRefId_ModuleRefUserId",
                table: "Module",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Module_UserId",
                table: "Module",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_ItemId_UserId",
                table: "UserTransaction",
                columns: new[] { "ItemId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_ListId_UserId",
                table: "UserTransaction",
                columns: new[] { "ListId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_ModuleId_UserId",
                table: "UserTransaction",
                columns: new[] { "ModuleId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_UserId",
                table: "UserTransaction",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombination_DimensionHeader_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombination",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombination_Item_ItemId_ItemUserId",
                table: "DimensionCombination",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLine_DimensionHeader_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLine_Item_ItemId_ItemUserId",
                table: "DimensionLine",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_DimensionHeader_DimensionHeaderId_DimensionHeaderUserId",
                table: "ListHeader",
                columns: new[] { "DimensionHeaderId", "DimensionHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_DimensionHeader_DimHeaderRefId_DimHeaderRefUserId",
                table: "ListHeader",
                columns: new[] { "DimHeaderRefId", "DimHeaderRefUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_Module_ModuleId_ModuleUserId",
                table: "ListHeader",
                columns: new[] { "ModuleId", "ModuleUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_Module_ModuleRefId_ModuleRefUserId",
                table: "ListHeader",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_DimensionHeader_DimensionHeaderId_DimensionHeaderUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_DimensionHeader_DimHeaderRefId_DimHeaderRefUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_DimensionHeader_DimHeaderId_DimHeaderUserId",
                table: "Module");

            migrationBuilder.DropTable(
                name: "DimensionCombination");

            migrationBuilder.DropTable(
                name: "DimensionLine");

            migrationBuilder.DropTable(
                name: "Follower");

            migrationBuilder.DropTable(
                name: "ListLine");

            migrationBuilder.DropTable(
                name: "UserTransaction");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "DimensionHeader");

            migrationBuilder.DropTable(
                name: "ListHeader");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "ItemGroup");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
