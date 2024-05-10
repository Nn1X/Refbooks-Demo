using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class add_n001_chage_columnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "F007",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "F007",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "F007",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "F007",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "F007",
                newName: "date_begin");

            migrationBuilder.RenameIndex(
                name: "IX_F007_Id",
                table: "F007",
                newName: "IX_F007_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "F006",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "F006",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "F006",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "F006",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "F006",
                newName: "date_begin");

            migrationBuilder.RenameIndex(
                name: "IX_F006_Id",
                table: "F006",
                newName: "IX_F006_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "F005",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "F005",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "F005",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "F005",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "F005",
                newName: "date_begin");

            migrationBuilder.RenameIndex(
                name: "IX_F005_Id",
                table: "F005",
                newName: "IX_F005_id");

            migrationBuilder.CreateTable(
                name: "N001",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N001", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_N001_id",
                table: "N001",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "N001");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F007",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F007",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F007",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F007",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F007",
                newName: "DateBegin");

            migrationBuilder.RenameIndex(
                name: "IX_F007_id",
                table: "F007",
                newName: "IX_F007_Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F006",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F006",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F006",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F006",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F006",
                newName: "DateBegin");

            migrationBuilder.RenameIndex(
                name: "IX_F006_id",
                table: "F006",
                newName: "IX_F006_Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F005",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F005",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F005",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F005",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F005",
                newName: "DateBegin");

            migrationBuilder.RenameIndex(
                name: "IX_F005_id",
                table: "F005",
                newName: "IX_F005_Id");
        }
    }
}
