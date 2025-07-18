using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class AppDbContextEntitiesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombination_DimensionHeader_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombination_Item_ItemId_ItemUserId",
                table: "DimensionCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombination_User_UserId",
                table: "DimensionCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionGroup_User_UserId",
                table: "DimensionGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeader_DimensionGroup_DimGroupId_DimGroupUserId",
                table: "DimensionHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeader_DimensionHeader_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeader_ListHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeader_User_UserId",
                table: "DimensionHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLine_DimensionHeader_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLine_Item_ItemId_ItemUserId",
                table: "DimensionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_Follower_User_FollowerRefId",
                table: "Follower");

            migrationBuilder.DropForeignKey(
                name: "FK_Follower_User_UserRefId",
                table: "Follower");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_LinkItemId_LinkItemUserId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemGroup_ItemGroupId_ItemGroupUserId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Module_ModuleId_ModuleUserId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_User_UserId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroup_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroup_User_UserId",
                table: "ItemGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionGroup_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionHeader_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionLine_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_Item_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_ItemGroup_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_ListFormattingEntity_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_ListHeader_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_Module_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_TextFormattingEntity_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntity_User_UserId",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ListFormattingEntity_User_UserId",
                table: "ListFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_DimensionHeader_FilterRefId_FilterRefUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_ItemGroup_FilterRefId_FilterRefUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_ListHeader_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_Module_FilterRefId_FilterRefUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_Module_ModuleId_ModuleUserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeader_User_UserId",
                table: "ListHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_ListLine_Item_ItemId_ItemUserId",
                table: "ListLine");

            migrationBuilder.DropForeignKey(
                name: "FK_ListLine_ListHeader_ListHeaderId_ListHeaderUserId",
                table: "ListLine");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_DimensionHeader_FilterLinkId_FilterLinkUserId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_ItemGroup_FilterLinkId_FilterLinkUserId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_Module_LinkModuleId_LinkModuleUserId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_Module_ModuleRefId_ModuleRefUserId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_User_UserId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_TextFormattingEntity_User_UserId",
                table: "TextFormattingEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_DimensionCombination_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_DimensionGroup_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_DimensionHeader_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_DimensionLine_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_Follower_FollowerId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_Item_TransLinkId_TransLinkUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_ItemGroup_ItemGroupId_ItemGroupUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_LinkedFormattingEntity_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_ListFormattingEntity_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_ListHeader_TransLinkId_TransLinkUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_ListLine_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_Module_TransLinkId_TransLinkUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_TextFormattingEntity_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransaction_User_UserId",
                table: "UserTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTransaction",
                table: "UserTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextFormattingEntity",
                table: "TextFormattingEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ListLine_LotId",
                table: "ListLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListLine",
                table: "ListLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListHeader",
                table: "ListHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListFormattingEntity",
                table: "ListFormattingEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LinkedFormattingEntity",
                table: "LinkedFormattingEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemGroup",
                table: "ItemGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Follower",
                table: "Follower");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLine_LotId",
                table: "DimensionLine");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLine_LotId_DimHeaderUserId",
                table: "DimensionLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionLine",
                table: "DimensionLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionHeader",
                table: "DimensionHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionGroup",
                table: "DimensionGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionCombination",
                table: "DimensionCombination");

            migrationBuilder.RenameTable(
                name: "UserTransaction",
                newName: "UserTransactions");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TextFormattingEntity",
                newName: "TextFormattingEntities");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Modules");

            migrationBuilder.RenameTable(
                name: "ListLine",
                newName: "ListLines");

            migrationBuilder.RenameTable(
                name: "ListHeader",
                newName: "ListHeaders");

            migrationBuilder.RenameTable(
                name: "ListFormattingEntity",
                newName: "ListFormattingEntities");

            migrationBuilder.RenameTable(
                name: "LinkedFormattingEntity",
                newName: "LinkedFormattingEntities");

            migrationBuilder.RenameTable(
                name: "ItemGroup",
                newName: "ItemGroups");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Follower",
                newName: "Followers");

            migrationBuilder.RenameTable(
                name: "DimensionLine",
                newName: "DimensionLines");

            migrationBuilder.RenameTable(
                name: "DimensionHeader",
                newName: "DimensionHeaders");

            migrationBuilder.RenameTable(
                name: "DimensionGroup",
                newName: "DimensionGroups");

            migrationBuilder.RenameTable(
                name: "DimensionCombination",
                newName: "DimensionCombinations");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_TextFormattingEntityId_TextFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_ListFormattingEntityId_ListFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_LinkedFormattingEntityId_LinkedFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_ItemGroupId_ItemGroupUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_ItemGroupId_ItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_FollowerId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_FollowerId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionHeaderId_DimensionHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionGroupId_DimensionGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransaction_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionCombinationId_DimensionCombinationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TextFormattingEntity_UserId",
                table: "TextFormattingEntities",
                newName: "IX_TextFormattingEntities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ListFormattingEntity_UserId",
                table: "ListFormattingEntities",
                newName: "IX_ListFormattingEntities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntity_UserId",
                table: "LinkedFormattingEntities",
                newName: "IX_LinkedFormattingEntities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntity_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                newName: "IX_LinkedFormattingEntities_TransLinkId_TransLinkUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntity_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities",
                newName: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups",
                newName: "IX_ItemGroups_LinkItemGroupId_LinkItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ModuleId_ModuleUserId",
                table: "Items",
                newName: "IX_Items_ModuleId_ModuleUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ItemGroupId_ItemGroupUserId",
                table: "Items",
                newName: "IX_Items_ItemGroupId_ItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeaders",
                newName: "IX_DimensionHeaders_ListHeaderId_ListHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionHeader_DimGroupId_DimGroupUserId",
                table: "DimensionHeaders",
                newName: "IX_DimensionHeaders_DimGroupId_DimGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionGroup_UserId",
                table: "DimensionGroups",
                newName: "IX_DimensionGroups_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionCombination_UserId",
                table: "DimensionCombinations",
                newName: "IX_DimensionCombinations_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTransactions",
                table: "UserTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextFormattingEntities",
                table: "TextFormattingEntities",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ListLines_LotId",
                table: "ListLines",
                column: "LotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListLines",
                table: "ListLines",
                columns: new[] { "ListHeaderId", "LineNum", "ListHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListHeaders",
                table: "ListHeaders",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListFormattingEntities",
                table: "ListFormattingEntities",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LinkedFormattingEntities",
                table: "LinkedFormattingEntities",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemGroups",
                table: "ItemGroups",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLines_LotId",
                table: "DimensionLines",
                column: "LotId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimHeaderUserId",
                table: "DimensionLines",
                columns: new[] { "LotId", "DimHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionLines",
                table: "DimensionLines",
                columns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionHeaders",
                table: "DimensionHeaders",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionGroups",
                table: "DimensionGroups",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionCombinations",
                table: "DimensionCombinations",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombinations_DimensionHeaders_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombinations",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombinations_Items_ItemId_ItemUserId",
                table: "DimensionCombinations",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombinations_Users_UserId",
                table: "DimensionCombinations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionGroups_Users_UserId",
                table: "DimensionGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeaders_DimensionGroups_DimGroupId_DimGroupUserId",
                table: "DimensionHeaders",
                columns: new[] { "DimGroupId", "DimGroupUserId" },
                principalTable: "DimensionGroups",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeaders_DimensionHeaders_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeaders",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeaders_ListHeaders_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeaders",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeaders_Users_UserId",
                table: "DimensionHeaders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLines_DimensionHeaders_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLines",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLines_Items_ItemId_ItemUserId",
                table: "DimensionLines",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_FollowerRefId",
                table: "Followers",
                column: "FollowerRefId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_UserRefId",
                table: "Followers",
                column: "UserRefId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroups_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroups_Users_UserId",
                table: "ItemGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemGroups_ItemGroupId_ItemGroupUserId",
                table: "Items",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_LinkItemId_LinkItemUserId",
                table: "Items",
                columns: new[] { "LinkItemId", "LinkItemUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Modules_ModuleId_ModuleUserId",
                table: "Items",
                columns: new[] { "ModuleId", "ModuleUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionGroups_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "DimensionGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionHeaders_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "DimensionLineLotId", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "LotId", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_ItemGroups_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_Items_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_ListFormattingEntities_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListFormattingEntities",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_ListHeaders_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_Modules_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_TextFormattingEntities_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "TextFormattingEntities",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_Users_UserId",
                table: "LinkedFormattingEntities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListFormattingEntities_Users_UserId",
                table: "ListFormattingEntities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_DimensionHeaders_FilterRefId_FilterRefUserId",
                table: "ListHeaders",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_ItemGroups_FilterRefId_FilterRefUserId",
                table: "ListHeaders",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_ListHeaders_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeaders",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_Modules_FilterRefId_FilterRefUserId",
                table: "ListHeaders",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_Modules_ModuleId_ModuleUserId",
                table: "ListHeaders",
                columns: new[] { "ModuleId", "ModuleUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeaders_Users_UserId",
                table: "ListHeaders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListLines_Items_ItemId_ItemUserId",
                table: "ListLines",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListLines_ListHeaders_ListHeaderId_ListHeaderUserId",
                table: "ListLines",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DimensionHeaders_FilterLinkId_FilterLinkUserId",
                table: "Modules",
                columns: new[] { "FilterLinkId", "FilterLinkUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_ItemGroups_FilterLinkId_FilterLinkUserId",
                table: "Modules",
                columns: new[] { "FilterLinkId", "FilterLinkUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Modules_LinkModuleId_LinkModuleUserId",
                table: "Modules",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Modules_ModuleRefId_ModuleRefUserId",
                table: "Modules",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Users_UserId",
                table: "Modules",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TextFormattingEntities_Users_UserId",
                table: "TextFormattingEntities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionCombinations_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionCombinationId", "DimensionCombinationUserId" },
                principalTable: "DimensionCombinations",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionGroups_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionGroupId", "DimensionGroupUserId" },
                principalTable: "DimensionGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionHeaders_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionHeaderId", "DimensionHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionLineDimensionHeaderId", "DimensionLineLineNum", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_Followers_FollowerId",
                table: "UserTransactions",
                column: "FollowerId",
                principalTable: "Followers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_ItemGroups_ItemGroupId_ItemGroupUserId",
                table: "UserTransactions",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" },
                principalTable: "ItemGroups",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_Items_TransLinkId_TransLinkUserId",
                table: "UserTransactions",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Items",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_LinkedFormattingEntities_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransactions",
                columns: new[] { "LinkedFormattingEntityId", "LinkedFormattingEntityUserId" },
                principalTable: "LinkedFormattingEntities",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_ListFormattingEntities_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransactions",
                columns: new[] { "ListFormattingEntityId", "ListFormattingEntityUserId" },
                principalTable: "ListFormattingEntities",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_ListHeaders_TransLinkId_TransLinkUserId",
                table: "UserTransactions",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_ListLines_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransactions",
                columns: new[] { "ListLineListHeaderId", "ListLineLineNum", "ListLineListHeaderUserId" },
                principalTable: "ListLines",
                principalColumns: new[] { "ListHeaderId", "LineNum", "ListHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_Modules_TransLinkId_TransLinkUserId",
                table: "UserTransactions",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Modules",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_TextFormattingEntities_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransactions",
                columns: new[] { "TextFormattingEntityId", "TextFormattingEntityUserId" },
                principalTable: "TextFormattingEntities",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_Users_UserId",
                table: "UserTransactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombinations_DimensionHeaders_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombinations");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombinations_Items_ItemId_ItemUserId",
                table: "DimensionCombinations");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionCombinations_Users_UserId",
                table: "DimensionCombinations");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionGroups_Users_UserId",
                table: "DimensionGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeaders_DimensionGroups_DimGroupId_DimGroupUserId",
                table: "DimensionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeaders_DimensionHeaders_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeaders_ListHeaders_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionHeaders_Users_UserId",
                table: "DimensionHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLines_DimensionHeaders_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLines_Items_ItemId_ItemUserId",
                table: "DimensionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_FollowerRefId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_UserRefId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroups_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroups_Users_UserId",
                table: "ItemGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemGroups_ItemGroupId_ItemGroupUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_LinkItemId_LinkItemUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Modules_ModuleId_ModuleUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionGroups_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionHeaders_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_ItemGroups_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_Items_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_ListFormattingEntities_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_ListHeaders_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_Modules_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_TextFormattingEntities_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_Users_UserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_ListFormattingEntities_Users_UserId",
                table: "ListFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_DimensionHeaders_FilterRefId_FilterRefUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_ItemGroups_FilterRefId_FilterRefUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_ListHeaders_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_Modules_FilterRefId_FilterRefUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_Modules_ModuleId_ModuleUserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListHeaders_Users_UserId",
                table: "ListHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ListLines_Items_ItemId_ItemUserId",
                table: "ListLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ListLines_ListHeaders_ListHeaderId_ListHeaderUserId",
                table: "ListLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DimensionHeaders_FilterLinkId_FilterLinkUserId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_ItemGroups_FilterLinkId_FilterLinkUserId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Modules_LinkModuleId_LinkModuleUserId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Modules_ModuleRefId_ModuleRefUserId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Users_UserId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_TextFormattingEntities_Users_UserId",
                table: "TextFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionCombinations_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionGroups_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionHeaders_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_Followers_FollowerId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_ItemGroups_ItemGroupId_ItemGroupUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_Items_TransLinkId_TransLinkUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_LinkedFormattingEntities_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_ListFormattingEntities_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_ListHeaders_TransLinkId_TransLinkUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_ListLines_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_Modules_TransLinkId_TransLinkUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_TextFormattingEntities_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_Users_UserId",
                table: "UserTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTransactions",
                table: "UserTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextFormattingEntities",
                table: "TextFormattingEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ListLines_LotId",
                table: "ListLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListLines",
                table: "ListLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListHeaders",
                table: "ListHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListFormattingEntities",
                table: "ListFormattingEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LinkedFormattingEntities",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemGroups",
                table: "ItemGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLines_LotId",
                table: "DimensionLines");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimHeaderUserId",
                table: "DimensionLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionLines",
                table: "DimensionLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionHeaders",
                table: "DimensionHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionGroups",
                table: "DimensionGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DimensionCombinations",
                table: "DimensionCombinations");

            migrationBuilder.RenameTable(
                name: "UserTransactions",
                newName: "UserTransaction");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TextFormattingEntities",
                newName: "TextFormattingEntity");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Module");

            migrationBuilder.RenameTable(
                name: "ListLines",
                newName: "ListLine");

            migrationBuilder.RenameTable(
                name: "ListHeaders",
                newName: "ListHeader");

            migrationBuilder.RenameTable(
                name: "ListFormattingEntities",
                newName: "ListFormattingEntity");

            migrationBuilder.RenameTable(
                name: "LinkedFormattingEntities",
                newName: "LinkedFormattingEntity");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "ItemGroups",
                newName: "ItemGroup");

            migrationBuilder.RenameTable(
                name: "Followers",
                newName: "Follower");

            migrationBuilder.RenameTable(
                name: "DimensionLines",
                newName: "DimensionLine");

            migrationBuilder.RenameTable(
                name: "DimensionHeaders",
                newName: "DimensionHeader");

            migrationBuilder.RenameTable(
                name: "DimensionGroups",
                newName: "DimensionGroup");

            migrationBuilder.RenameTable(
                name: "DimensionCombinations",
                newName: "DimensionCombination");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_TextFormattingEntityId_TextFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_ListFormattingEntityId_ListFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_LinkedFormattingEntityId_LinkedFormattingEntityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_ItemGroupId_ItemGroupUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_ItemGroupId_ItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_FollowerId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_FollowerId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_DimensionHeaderId_DimensionHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_DimensionGroupId_DimensionGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransaction",
                newName: "IX_UserTransaction_DimensionCombinationId_DimensionCombinationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TextFormattingEntities_UserId",
                table: "TextFormattingEntity",
                newName: "IX_TextFormattingEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ListFormattingEntities_UserId",
                table: "ListFormattingEntity",
                newName: "IX_ListFormattingEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntities_UserId",
                table: "LinkedFormattingEntity",
                newName: "IX_LinkedFormattingEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntities_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                newName: "IX_LinkedFormattingEntity_TransLinkId_TransLinkUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntity",
                newName: "IX_LinkedFormattingEntity_DimensionLineLotId_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ModuleId_ModuleUserId",
                table: "Item",
                newName: "IX_Item_ModuleId_ModuleUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ItemGroupId_ItemGroupUserId",
                table: "Item",
                newName: "IX_Item_ItemGroupId_ItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemGroups_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroup",
                newName: "IX_ItemGroup_LinkItemGroupId_LinkItemGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionHeaders_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader",
                newName: "IX_DimensionHeader_ListHeaderId_ListHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionHeaders_DimGroupId_DimGroupUserId",
                table: "DimensionHeader",
                newName: "IX_DimensionHeader_DimGroupId_DimGroupUserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionGroups_UserId",
                table: "DimensionGroup",
                newName: "IX_DimensionGroup_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DimensionCombinations_UserId",
                table: "DimensionCombination",
                newName: "IX_DimensionCombination_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTransaction",
                table: "UserTransaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextFormattingEntity",
                table: "TextFormattingEntity",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ListLine_LotId",
                table: "ListLine",
                column: "LotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListLine",
                table: "ListLine",
                columns: new[] { "ListHeaderId", "LineNum", "ListHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListHeader",
                table: "ListHeader",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListFormattingEntity",
                table: "ListFormattingEntity",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LinkedFormattingEntity",
                table: "LinkedFormattingEntity",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemGroup",
                table: "ItemGroup",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Follower",
                table: "Follower",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLine_LotId",
                table: "DimensionLine",
                column: "LotId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLine_LotId_DimHeaderUserId",
                table: "DimensionLine",
                columns: new[] { "LotId", "DimHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionLine",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionHeader",
                table: "DimensionHeader",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionGroup",
                table: "DimensionGroup",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DimensionCombination",
                table: "DimensionCombination",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombination_DimensionHeader_DimHeaderId_DimHeaderUserId",
                table: "DimensionCombination",
                columns: new[] { "DimHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombination_Item_ItemId_ItemUserId",
                table: "DimensionCombination",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionCombination_User_UserId",
                table: "DimensionCombination",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionGroup_User_UserId",
                table: "DimensionGroup",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeader_DimensionGroup_DimGroupId_DimGroupUserId",
                table: "DimensionHeader",
                columns: new[] { "DimGroupId", "DimGroupUserId" },
                principalTable: "DimensionGroup",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeader_DimensionHeader_LinkHeaderId_LinkHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "LinkHeaderId", "LinkHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeader_ListHeader_ListHeaderId_ListHeaderUserId",
                table: "DimensionHeader",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionHeader_User_UserId",
                table: "DimensionHeader",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLine_DimensionHeader_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLine",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLine_Item_ItemId_ItemUserId",
                table: "DimensionLine",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Follower_User_FollowerRefId",
                table: "Follower",
                column: "FollowerRefId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Follower_User_UserRefId",
                table: "Follower",
                column: "UserRefId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_LinkItemId_LinkItemUserId",
                table: "Item",
                columns: new[] { "LinkItemId", "LinkItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemGroup_ItemGroupId_ItemGroupUserId",
                table: "Item",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Module_ModuleId_ModuleUserId",
                table: "Item",
                columns: new[] { "ModuleId", "ModuleUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_User_UserId",
                table: "Item",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroup_ItemGroup_LinkItemGroupId_LinkItemGroupUserId",
                table: "ItemGroup",
                columns: new[] { "LinkItemGroupId", "LinkItemGroupUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroup_User_UserId",
                table: "ItemGroup",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionGroup_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "DimensionGroup",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionHeader_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_DimensionLine_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "DimensionLineLotId", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLine",
                principalColumns: new[] { "LotId", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_Item_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_ItemGroup_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_ListFormattingEntity_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListFormattingEntity",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_ListHeader_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_Module_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_TextFormattingEntity_TransLinkId_TransLinkUserId",
                table: "LinkedFormattingEntity",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "TextFormattingEntity",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntity_User_UserId",
                table: "LinkedFormattingEntity",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListFormattingEntity_User_UserId",
                table: "ListFormattingEntity",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_DimensionHeader_FilterRefId_FilterRefUserId",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_ItemGroup_FilterRefId_FilterRefUserId",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_ListHeader_LinkListHeaderId_LinkListHeaderUserId",
                table: "ListHeader",
                columns: new[] { "LinkListHeaderId", "LinkListHeaderUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_Module_FilterRefId_FilterRefUserId",
                table: "ListHeader",
                columns: new[] { "FilterRefId", "FilterRefUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_Module_ModuleId_ModuleUserId",
                table: "ListHeader",
                columns: new[] { "ModuleId", "ModuleUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListHeader_User_UserId",
                table: "ListHeader",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListLine_Item_ItemId_ItemUserId",
                table: "ListLine",
                columns: new[] { "ItemId", "ItemUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ListLine_ListHeader_ListHeaderId_ListHeaderUserId",
                table: "ListLine",
                columns: new[] { "ListHeaderId", "ListHeaderUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Module_DimensionHeader_FilterLinkId_FilterLinkUserId",
                table: "Module",
                columns: new[] { "FilterLinkId", "FilterLinkUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Module_ItemGroup_FilterLinkId_FilterLinkUserId",
                table: "Module",
                columns: new[] { "FilterLinkId", "FilterLinkUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Module_LinkModuleId_LinkModuleUserId",
                table: "Module",
                columns: new[] { "LinkModuleId", "LinkModuleUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Module_ModuleRefId_ModuleRefUserId",
                table: "Module",
                columns: new[] { "ModuleRefId", "ModuleRefUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Module_User_UserId",
                table: "Module",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TextFormattingEntity_User_UserId",
                table: "TextFormattingEntity",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_DimensionCombination_DimensionCombinationId_DimensionCombinationUserId",
                table: "UserTransaction",
                columns: new[] { "DimensionCombinationId", "DimensionCombinationUserId" },
                principalTable: "DimensionCombination",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_DimensionGroup_DimensionGroupId_DimensionGroupUserId",
                table: "UserTransaction",
                columns: new[] { "DimensionGroupId", "DimensionGroupUserId" },
                principalTable: "DimensionGroup",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_DimensionHeader_DimensionHeaderId_DimensionHeaderUserId",
                table: "UserTransaction",
                columns: new[] { "DimensionHeaderId", "DimensionHeaderUserId" },
                principalTable: "DimensionHeader",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_DimensionLine_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransaction",
                columns: new[] { "DimensionLineDimensionHeaderId", "DimensionLineLineNum", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLine",
                principalColumns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_Follower_FollowerId",
                table: "UserTransaction",
                column: "FollowerId",
                principalTable: "Follower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_Item_TransLinkId_TransLinkUserId",
                table: "UserTransaction",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Item",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_ItemGroup_ItemGroupId_ItemGroupUserId",
                table: "UserTransaction",
                columns: new[] { "ItemGroupId", "ItemGroupUserId" },
                principalTable: "ItemGroup",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_LinkedFormattingEntity_LinkedFormattingEntityId_LinkedFormattingEntityUserId",
                table: "UserTransaction",
                columns: new[] { "LinkedFormattingEntityId", "LinkedFormattingEntityUserId" },
                principalTable: "LinkedFormattingEntity",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_ListFormattingEntity_ListFormattingEntityId_ListFormattingEntityUserId",
                table: "UserTransaction",
                columns: new[] { "ListFormattingEntityId", "ListFormattingEntityUserId" },
                principalTable: "ListFormattingEntity",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_ListHeader_TransLinkId_TransLinkUserId",
                table: "UserTransaction",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "ListHeader",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_ListLine_ListLineListHeaderId_ListLineLineNum_ListLineListHeaderUserId",
                table: "UserTransaction",
                columns: new[] { "ListLineListHeaderId", "ListLineLineNum", "ListLineListHeaderUserId" },
                principalTable: "ListLine",
                principalColumns: new[] { "ListHeaderId", "LineNum", "ListHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_Module_TransLinkId_TransLinkUserId",
                table: "UserTransaction",
                columns: new[] { "TransLinkId", "TransLinkUserId" },
                principalTable: "Module",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_TextFormattingEntity_TextFormattingEntityId_TextFormattingEntityUserId",
                table: "UserTransaction",
                columns: new[] { "TextFormattingEntityId", "TextFormattingEntityUserId" },
                principalTable: "TextFormattingEntity",
                principalColumns: new[] { "Id", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransaction_User_UserId",
                table: "UserTransaction",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
