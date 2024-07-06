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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                name: "DimensionGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionGroup", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_DimensionGroup_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Follower",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserRefId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerRefId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Follower_User_FollowerRefId",
                        column: x => x.FollowerRefId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Follower_User_UserRefId",
                        column: x => x.UserRefId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkItemGroupUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "ListFormattingEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListFormattingEntity", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_ListFormattingEntity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextFormattingEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFormattingEntity", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_TextFormattingEntity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimensionHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TableType = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    DimGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimGroupUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionHeader", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_DimensionHeader_DimensionGroup_DimGroupId_DimGroupUserId",
                        columns: x => new { x.DimGroupId, x.DimGroupUserId },
                        principalTable: "DimensionGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionHeader_DimensionHeader_LinkHeaderId_LinkHeaderUserId",
                        columns: x => new { x.LinkHeaderId, x.LinkHeaderUserId },
                        principalTable: "DimensionHeader",
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    General = table.Column<bool>(type: "bit", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ModuleRefId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModuleRefUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkModuleUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilterLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilterLinkUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilterLinkName = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => new { x.Id, x.UserId });
                    table.CheckConstraint("ItemGroupToModule", "FilterLinkName = \"ItemGroup\"");
                    table.CheckConstraint("DimensionHeaderToModule", "FilterLinkName = \"DimensionHeader\"");
                    table.ForeignKey(
                        name: "DimensionHeaderToModule",
                        columns: x => new { x.FilterLinkId, x.FilterLinkUserId },
                        principalTable: "DimensionHeader",
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
                    table.ForeignKey(
                        name: "ItemGroupToModule",
                        columns: x => new { x.FilterLinkId, x.FilterLinkUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkItemUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemGroupUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModuleUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
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
                name: "ListHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DomainType = table.Column<int>(type: "int", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilterRefId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilterRefUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilterRefName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkListHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkListHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListHeader", x => new { x.Id, x.UserId });
                    table.CheckConstraint("ModuleToListHeader", "FilterRefName = \"Module\"");
                    table.CheckConstraint("ItemGroupToListHeader", "FilterRefName = \"ItemGroup\"");
                    table.CheckConstraint("DimensionHeaderToListHeader", "FilterRefName = \"DimensionHeader\"");
                    table.ForeignKey(
                        name: "DimensionHeaderToListHeader",
                        columns: x => new { x.FilterRefId, x.FilterRefUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_ListHeader_LinkListHeaderId_LinkListHeaderUserId",
                        columns: x => new { x.LinkListHeaderId, x.LinkListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_Module_ModuleId_ModuleUserId",
                        columns: x => new { x.ModuleId, x.ModuleUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ItemGroupToListHeader",
                        columns: x => new { x.FilterRefId, x.FilterRefUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ModuleToListHeader",
                        columns: x => new { x.FilterRefId, x.FilterRefUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DimensionCombination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DimHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DimHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionCombination", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_DimensionCombination_DimensionHeader_DimHeaderId_DimHeaderUserId",
                        columns: x => new { x.DimHeaderId, x.DimHeaderUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionCombination_Item_ItemId_ItemUserId",
                        columns: x => new { x.ItemId, x.ItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
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
                    LineNum = table.Column<float>(type: "real(20)", precision: 20, scale: 2, nullable: false),
                    DimensionHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DimHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Integer = table.Column<int>(type: "int", nullable: true),
                    Double = table.Column<double>(type: "float(15)", precision: 15, scale: 2, nullable: true),
                    Bool = table.Column<bool>(type: "bit", nullable: true),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionLine", x => new { x.DimensionHeaderId, x.LineNum, x.DimHeaderUserId });
                    table.UniqueConstraint("AK_DimensionLine_LotId", x => x.LotId);
                    table.UniqueConstraint("AK_DimensionLine_LotId_DimHeaderUserId", x => new { x.LotId, x.DimHeaderUserId });
                    table.ForeignKey(
                        name: "FK_DimensionLine_DimensionHeader_DimensionHeaderId_DimHeaderUserId",
                        columns: x => new { x.DimensionHeaderId, x.DimHeaderUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionLine_Item_ItemId_ItemUserId",
                        columns: x => new { x.ItemId, x.ItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListLine",
                columns: table => new
                {
                    LineNum = table.Column<float>(type: "real(20)", precision: 20, scale: 2, nullable: false),
                    ListHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLine", x => new { x.ListHeaderId, x.LineNum, x.ListHeaderUserId });
                    table.UniqueConstraint("AK_ListLine_LotId", x => x.LotId);
                    table.ForeignKey(
                        name: "FK_ListLine_Item_ItemId_ItemUserId",
                        columns: x => new { x.ItemId, x.ItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListLine_ListHeader_ListHeaderId_ListHeaderUserId",
                        columns: x => new { x.ListHeaderId, x.ListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurrogateId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransType = table.Column<int>(type: "int", nullable: false),
                    RefType = table.Column<int>(type: "int", nullable: false),
                    TransLinkUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransLinkName = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransaction", x => x.Id);
                    table.CheckConstraint("ModuleToUserTransaction", "TransLinkName = \"Module\"");
                    table.CheckConstraint("ListToUserTransaction", "TransLinkName = \"ListHeader\"");
                    table.CheckConstraint("ItemToUserTransaction", "TransLinkName = \"Item\"");
                    table.ForeignKey(
                        name: "FK_UserTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ItemToUserTransaction",
                        columns: x => new { x.TransLinkId, x.TransLinkUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ListToUserTransaction",
                        columns: x => new { x.TransLinkId, x.TransLinkUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ModuleToUserTransaction",
                        columns: x => new { x.TransLinkId, x.TransLinkUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinkedFormattingEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormattingType = table.Column<int>(type: "int", nullable: false),
                    FilterLinkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModuleUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionHeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionLineUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemGroupUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DimensionGroupUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TextFormattingEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TextFormattingEntityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListFormattingEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListFormattingEntityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkedFormattingEntity", x => new { x.Id, x.UserId });
                    table.CheckConstraint("ListFormatting", "FormattingType = \"List\"");
                    table.CheckConstraint("TextFormatting", "FormattingType = \"Text\"");
                    table.CheckConstraint("FormattingModule", "FilterLinkName = \"Module\"");
                    table.CheckConstraint("FormattingListHeader", "FilterLinkName = \"ListHeader\"");
                    table.CheckConstraint("FormattingDimensionHeader", "FilterLinkName = \"DimensionHeader\"");
                    table.CheckConstraint("FormattingDimensionLine", "FilterLinkName = \"DimensionLine\"");
                    table.CheckConstraint("FormattingItem", "FilterLinkName = \"Item\"");
                    table.CheckConstraint("FormattingItemGroup", "FilterLinkName = \"ItemGroup\"");
                    table.CheckConstraint("FormattingDimensionGroup", "FilterLinkName = \"DimensionGroup\"");
                    table.ForeignKey(
                        name: "FK_LinkedFormattingEntity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FormattingDimensionGroup",
                        columns: x => new { x.DimensionGroupId, x.DimensionGroupUserId },
                        principalTable: "DimensionGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingDimensionHeader",
                        columns: x => new { x.DimensionHeaderId, x.DimensionHeaderUserId },
                        principalTable: "DimensionHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingDimensionLine",
                        columns: x => new { x.DimensionLineId, x.DimensionLineUserId },
                        principalTable: "DimensionLine",
                        principalColumns: new[] { "LotId", "DimHeaderUserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingItem",
                        columns: x => new { x.ItemId, x.ItemUserId },
                        principalTable: "Item",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingItemGroup",
                        columns: x => new { x.ItemGroupId, x.ItemGroupUserId },
                        principalTable: "ItemGroup",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingListHeader",
                        columns: x => new { x.ListHeaderId, x.ListHeaderUserId },
                        principalTable: "ListHeader",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FormattingModule",
                        columns: x => new { x.ModuleId, x.ModuleUserId },
                        principalTable: "Module",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ListFormatting",
                        columns: x => new { x.ListFormattingEntityId, x.ListFormattingEntityUserId },
                        principalTable: "ListFormattingEntity",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "TextFormatting",
                        columns: x => new { x.TextFormattingEntityId, x.TextFormattingEntityUserId },
                        principalTable: "TextFormattingEntity",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "DimCombIdx",
                table: "DimensionCombination",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DimHeaderIdx",
                table: "DimensionCombination",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx",
                table: "DimensionCombination",
                columns: new[] { "ItemId", "ItemUserId" })
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_UserId",
                table: "DimensionCombination",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionGroup_UserId",
                table: "DimensionGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "DimHeaderIdx1",
                table: "DimensionHeader",
                columns: new[] { "Id", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_DimGroupId_DimGroupUserId",
                table: "DimensionHeader",
                columns: new[] { "DimGroupId", "DimGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "LinkDimHeaderIdx",
                table: "DimensionHeader",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "ListIdx",
                table: "DimensionHeader",
                column: "ListHeaderId")
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "UserIdx",
                table: "DimensionHeader",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "DimHeaderIdx2",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx1",
                table: "DimensionLine",
                columns: new[] { "ItemId", "ItemUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId", "LineNum", "DimensionHeaderId" });

            migrationBuilder.CreateIndex(
                name: "LineNumIdx",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "LotId" });

            migrationBuilder.CreateIndex(
                name: "FollowerIdx",
                table: "Follower",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FollowerRefIdx",
                table: "Follower",
                column: "FollowerRefId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "UserRefIdx",
                table: "Follower",
                column: "UserRefId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "ItemGroupIdx",
                table: "Item",
                column: "ItemGroupId")
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId", "Name" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx2",
                table: "Item",
                columns: new[] { "Id", "UserId" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "ItemGroupId", "ModuleId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemGroupId_ItemGroupUserId",
                table: "Item",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ModuleId_ModuleUserId",
                table: "Item",
                columns: new[] { "ModuleId", "ModuleUserId" });

            migrationBuilder.CreateIndex(
                name: "LinkItemIdx",
                table: "Item",
                columns: new[] { "LinkItemId", "LinkItemUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ItemGroupId", "ModuleId", "Name" });

            migrationBuilder.CreateIndex(
                name: "ModuleIdx",
                table: "Item",
                column: "ModuleId")
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ItemGroupId", "Name" });

            migrationBuilder.CreateIndex(
                name: "UserIdx1",
                table: "Item",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id", "ItemGroupId", "ModuleId", "Name" });

            migrationBuilder.CreateIndex(
                name: "ItemGroupIdx1",
                table: "ItemGroup",
                columns: new[] { "Id", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroup",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "LinkItemGroupIdx",
                table: "ItemGroup",
                column: "LinkItemGroupId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "UserIdx2",
                table: "ItemGroup",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_DimensionGroupId_DimensionGroupUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "DimensionGroupId", "DimensionGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_DimensionHeaderId_DimensionHeaderUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "DimensionHeaderId", "DimensionHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_DimensionLineId_DimensionLineUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "DimensionLineId", "DimensionLineUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_ItemGroupId_ItemGroupUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_ItemId_ItemUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "ItemId", "ItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "ListFormattingEntityId", "ListFormattingEntityUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_ListHeaderId_ListHeaderUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_ModuleId_ModuleUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "ModuleId", "ModuleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TextFormattingEntityId", "TextFormattingEntityUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkedFormattingEntity_UserId",
                table: "LinkedFormattingEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListFormattingEntity_UserId",
                table: "ListFormattingEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "DimHeaderRefIdx",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "ItemGroupRefIdx",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "LinkListHeaderIdx",
                table: "ListHeader",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "ListHeaderIdx",
                table: "ListHeader",
                columns: new[] { "Id", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ModuleIdx1",
                table: "ListHeader",
                columns: new[] { "ModuleId", "ModuleUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "ModuleRefIdx",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "UserIdx3",
                table: "ListHeader",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id", "ModuleId" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx3",
                table: "ListLine",
                columns: new[] { "ItemId", "ItemUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId", "LineNum", "ListHeaderId" });

            migrationBuilder.CreateIndex(
                name: "LineNumIdx1",
                table: "ListLine",
                columns: new[] { "ListHeaderId", "LineNum", "ListHeaderUserId" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "LotId" });

            migrationBuilder.CreateIndex(
                name: "ListHeaderIdx1",
                table: "ListLine",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId" });

            migrationBuilder.CreateIndex(
                name: "FilterLinkIdx",
                table: "Module",
                columns: new[] { "FilterLinkId", "FilterLinkUserId", "FilterLinkName" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "LinkModuleIdx",
                table: "Module",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "ModuleIdx2",
                table: "Module",
                columns: new[] { "Id", "UserId" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name" });

            migrationBuilder.CreateIndex(
                name: "ModuleRefIdx1",
                table: "Module",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" })
                .Annotation("SqlServer:Include", new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "UserIdx4",
                table: "Module",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_TextFormattingEntity_UserId",
                table: "TextFormattingEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "NickNameIdx",
                table: "User",
                column: "NickName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserIdx5",
                table: "User",
                column: "Id",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "NickName", "Name", "Surname", "Email" });

            migrationBuilder.CreateIndex(
                name: "TransIdx",
                table: "UserTransaction",
                columns: new[] { "Id", "UserId" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "TransType" });

            migrationBuilder.CreateIndex(
                name: "TransLinkIdx",
                table: "UserTransaction",
                columns: new[] { "TransLinkId", "TransLinkUserId", "TransLinkName" })
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.CreateIndex(
                name: "UserIdx6",
                table: "UserTransaction",
                column: "UserId")
                .Annotation("SqlServer:Include", new[] { "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeader_ListHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "DimensionHeaderToListHeader",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "DimensionHeaderToModule",
                table: "Module");

            migrationBuilder.DropTable(
                name: "DimensionCombination");

            migrationBuilder.DropTable(
                name: "Follower");

            migrationBuilder.DropTable(
                name: "LinkedFormattingEntity");

            migrationBuilder.DropTable(
                name: "ListLine");

            migrationBuilder.DropTable(
                name: "UserTransaction");

            migrationBuilder.DropTable(
                name: "DimensionLine");

            migrationBuilder.DropTable(
                name: "ListFormattingEntity");

            migrationBuilder.DropTable(
                name: "TextFormattingEntity");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "DimensionHeader");

            migrationBuilder.DropTable(
                name: "DimensionGroup");

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
