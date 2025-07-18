using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversalSolutionApplication.Migrations
{
    public partial class DimLineRelationToDimCombinationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLines_DimensionHeaders_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimHeaderUserId",
                table: "DimensionLines");

            migrationBuilder.DropIndex(
                name: "ItemIdx1",
                table: "DimensionLines");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimensionHeaderId",
                table: "UserTransactions",
                newName: "DimensionLineDimensionCombinationId");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimHeaderUserId",
                table: "UserTransactions",
                newName: "DimensionLineDimCombinationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionLineDimensionCombinationId_DimensionLineLineNum_DimensionLineDimCombinationUserId");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities",
                newName: "DimensionLineDimCombinationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities",
                newName: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimCombinationUserId");

            migrationBuilder.RenameColumn(
                name: "DimHeaderUserId",
                table: "DimensionLines",
                newName: "DimCombinationUserId");

            migrationBuilder.RenameColumn(
                name: "DimensionHeaderId",
                table: "DimensionLines",
                newName: "DimensionCombinationId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimCombinationUserId",
                table: "DimensionLines",
                columns: new[] { "LotId", "DimCombinationUserId" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx1",
                table: "DimensionLines",
                columns: new[] { "ItemId", "ItemUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId", "LineNum", "DimensionCombinationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLines_DimensionCombinations_DimensionCombinationId_DimCombinationUserId",
                table: "DimensionLines",
                columns: new[] { "DimensionCombinationId", "DimCombinationUserId" },
                principalTable: "DimensionCombinations",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimCombinationUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "DimensionLineLotId", "DimensionLineDimCombinationUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "LotId", "DimCombinationUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionCombinationId_DimensionLineLineNum_DimensionLineDimCombinationUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionLineDimensionCombinationId", "DimensionLineLineNum", "DimensionLineDimCombinationUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "DimensionCombinationId", "LineNum", "DimCombinationUserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DimensionLines_DimensionCombinations_DimensionCombinationId_DimCombinationUserId",
                table: "DimensionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimCombinationUserId",
                table: "LinkedFormattingEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionCombinationId_DimensionLineLineNum_DimensionLineDimCombinationUserId",
                table: "UserTransactions");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimCombinationUserId",
                table: "DimensionLines");

            migrationBuilder.DropIndex(
                name: "ItemIdx1",
                table: "DimensionLines");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimensionCombinationId",
                table: "UserTransactions",
                newName: "DimensionLineDimensionHeaderId");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimCombinationUserId",
                table: "UserTransactions",
                newName: "DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTransactions_DimensionLineDimensionCombinationId_DimensionLineLineNum_DimensionLineDimCombinationUserId",
                table: "UserTransactions",
                newName: "IX_UserTransactions_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameColumn(
                name: "DimensionLineDimCombinationUserId",
                table: "LinkedFormattingEntities",
                newName: "DimensionLineDimHeaderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimCombinationUserId",
                table: "LinkedFormattingEntities",
                newName: "IX_LinkedFormattingEntities_DimensionLineLotId_DimensionLineDimHeaderUserId");

            migrationBuilder.RenameColumn(
                name: "DimCombinationUserId",
                table: "DimensionLines",
                newName: "DimHeaderUserId");

            migrationBuilder.RenameColumn(
                name: "DimensionCombinationId",
                table: "DimensionLines",
                newName: "DimensionHeaderId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DimensionLines_LotId_DimHeaderUserId",
                table: "DimensionLines",
                columns: new[] { "LotId", "DimHeaderUserId" });

            migrationBuilder.CreateIndex(
                name: "ItemIdx1",
                table: "DimensionLines",
                columns: new[] { "ItemId", "ItemUserId" })
                .Annotation("SqlServer:Include", new[] { "LotId", "LineNum", "DimensionHeaderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DimensionLines_DimensionHeaders_DimensionHeaderId_DimHeaderUserId",
                table: "DimensionLines",
                columns: new[] { "DimensionHeaderId", "DimHeaderUserId" },
                principalTable: "DimensionHeaders",
                principalColumns: new[] { "Id", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LinkedFormattingEntities_DimensionLines_DimensionLineLotId_DimensionLineDimHeaderUserId",
                table: "LinkedFormattingEntities",
                columns: new[] { "DimensionLineLotId", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "LotId", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactions_DimensionLines_DimensionLineDimensionHeaderId_DimensionLineLineNum_DimensionLineDimHeaderUserId",
                table: "UserTransactions",
                columns: new[] { "DimensionLineDimensionHeaderId", "DimensionLineLineNum", "DimensionLineDimHeaderUserId" },
                principalTable: "DimensionLines",
                principalColumns: new[] { "DimensionHeaderId", "LineNum", "DimHeaderUserId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
