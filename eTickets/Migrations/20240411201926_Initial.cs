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
                name: "DimensionHeader",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TableType = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DimensionHeader_User_UserId",
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroup_User_UserId",
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
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    General = table.Column<bool>(type: "bit", nullable: false),
                    ModuleRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DimHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_DimensionHeader_DimHeaderId",
                        column: x => x.DimHeaderId,
                        principalTable: "DimensionHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Module_Module_ModuleRefId",
                        column: x => x.ModuleRefId,
                        principalTable: "Module",
                        principalColumn: "Id",
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
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemGroupId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
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
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ModuleRefId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListHeader_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListHeader_Module_ModuleRefId",
                        column: x => x.ModuleRefId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListHeader_User_UserId",
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
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DimHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionCombination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DimensionCombination_DimensionHeader_DimHeaderId",
                        column: x => x.DimHeaderId,
                        principalTable: "DimensionHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionCombination_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DimensionLine",
                columns: table => new
                {
                    LineNum = table.Column<float>(type: "real(20)", precision: 20, scale: 2, nullable: false),
                    DimensionHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LotId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Integer = table.Column<int>(type: "int", nullable: true),
                    Double = table.Column<double>(type: "float(15)", precision: 15, scale: 2, nullable: true),
                    Bool = table.Column<bool>(type: "bit", nullable: true),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionLine", x => new { x.DimensionHeaderId, x.LineNum });
                    table.UniqueConstraint("AK_DimensionLine_LotId", x => x.LotId);
                    table.ForeignKey(
                        name: "FK_DimensionLine_DimensionHeader_DimensionHeaderId",
                        column: x => x.DimensionHeaderId,
                        principalTable: "DimensionHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListLine",
                columns: table => new
                {
                    LineNum = table.Column<float>(type: "real(20)", precision: 20, scale: 2, nullable: false),
                    ListHeaderId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LotId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLine", x => new { x.ListHeaderId, x.LineNum });
                    table.UniqueConstraint("AK_ListLine_LotId", x => x.LotId);
                    table.ForeignKey(
                        name: "FK_ListLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListLine_ListHeader_ListHeaderId",
                        column: x => x.ListHeaderId,
                        principalTable: "ListHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransType = table.Column<int>(type: "int", nullable: false),
                    RefType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTransaction_Item_UserId",
                        column: x => x.UserId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_ListHeader_UserId",
                        column: x => x.UserId,
                        principalTable: "ListHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_Module_UserId",
                        column: x => x.UserId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_DimHeaderId",
                table: "DimensionCombination",
                column: "DimHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionCombination_ItemId",
                table: "DimensionCombination",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionHeader_UserId",
                table: "DimensionHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionLine_ItemId",
                table: "DimensionLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemGroupId",
                table: "Item",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ModuleId",
                table: "Item",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UserId",
                table: "Item",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_UserId",
                table: "ItemGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ModuleId",
                table: "ListHeader",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_ModuleRefId",
                table: "ListHeader",
                column: "ModuleRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ListHeader_UserId",
                table: "ListHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ListLine_ItemId",
                table: "ListLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_DimHeaderId",
                table: "Module",
                column: "DimHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_ItemGroupId",
                table: "Module",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_ModuleRefId",
                table: "Module",
                column: "ModuleRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Module_UserId",
                table: "Module",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_UserId",
                table: "UserTransaction",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DimensionCombination");

            migrationBuilder.DropTable(
                name: "DimensionLine");

            migrationBuilder.DropTable(
                name: "ListLine");

            migrationBuilder.DropTable(
                name: "UserTransaction");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ListHeader");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "DimensionHeader");

            migrationBuilder.DropTable(
                name: "ItemGroup");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
