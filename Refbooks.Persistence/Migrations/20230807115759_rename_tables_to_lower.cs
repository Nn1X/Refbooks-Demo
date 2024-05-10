using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class rename_tables_to_lower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_N001",
                table: "N001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F007",
                table: "F007");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F006",
                table: "F006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F005",
                table: "F005");

            migrationBuilder.RenameTable(
                name: "N001",
                newName: "n001");

            migrationBuilder.RenameTable(
                name: "F007",
                newName: "f007");

            migrationBuilder.RenameTable(
                name: "F006",
                newName: "f006");

            migrationBuilder.RenameTable(
                name: "F005",
                newName: "f005");

            migrationBuilder.RenameIndex(
                name: "IX_N001_id",
                table: "n001",
                newName: "IX_n001_id");

            migrationBuilder.RenameIndex(
                name: "IX_F007_id",
                table: "f007",
                newName: "IX_f007_id");

            migrationBuilder.RenameIndex(
                name: "IX_F006_id",
                table: "f006",
                newName: "IX_f006_id");

            migrationBuilder.RenameIndex(
                name: "IX_F005_id",
                table: "f005",
                newName: "IX_f005_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n001",
                table: "n001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f007",
                table: "f007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f006",
                table: "f006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f005",
                table: "f005",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_n001",
                table: "n001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f007",
                table: "f007");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f006",
                table: "f006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f005",
                table: "f005");

            migrationBuilder.RenameTable(
                name: "n001",
                newName: "N001");

            migrationBuilder.RenameTable(
                name: "f007",
                newName: "F007");

            migrationBuilder.RenameTable(
                name: "f006",
                newName: "F006");

            migrationBuilder.RenameTable(
                name: "f005",
                newName: "F005");

            migrationBuilder.RenameIndex(
                name: "IX_n001_id",
                table: "N001",
                newName: "IX_N001_id");

            migrationBuilder.RenameIndex(
                name: "IX_f007_id",
                table: "F007",
                newName: "IX_F007_id");

            migrationBuilder.RenameIndex(
                name: "IX_f006_id",
                table: "F006",
                newName: "IX_F006_id");

            migrationBuilder.RenameIndex(
                name: "IX_f005_id",
                table: "F005",
                newName: "IX_F005_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_N001",
                table: "N001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F007",
                table: "F007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F006",
                table: "F006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F005",
                table: "F005",
                column: "id");
        }
    }
}
