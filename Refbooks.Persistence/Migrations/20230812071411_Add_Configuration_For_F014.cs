using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Add_Configuration_For_F014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_F014",
                table: "F014");

            migrationBuilder.RenameTable(
                name: "F014",
                newName: "f014");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f014",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "f014",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f014",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f014",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SanctionCoefficient",
                table: "f014",
                newName: "sanction_coefficient");

            migrationBuilder.RenameColumn(
                name: "RefusalReason",
                table: "f014",
                newName: "refusal_reason");

            migrationBuilder.RenameColumn(
                name: "PgFormCode",
                table: "f014",
                newName: "pg_form_code");

            migrationBuilder.RenameColumn(
                name: "PenaltyCoefficient",
                table: "f014",
                newName: "penalty_coefficient");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f014",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f014",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "CodeReserveField",
                table: "f014",
                newName: "code_reserve_field");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f014",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f014",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_f014",
                table: "f014",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_f014_id",
                table: "f014",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_f014",
                table: "f014");

            migrationBuilder.DropIndex(
                name: "IX_f014_id",
                table: "f014");

            migrationBuilder.RenameTable(
                name: "f014",
                newName: "F014");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F014",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "F014",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F014",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F014",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "sanction_coefficient",
                table: "F014",
                newName: "SanctionCoefficient");

            migrationBuilder.RenameColumn(
                name: "refusal_reason",
                table: "F014",
                newName: "RefusalReason");

            migrationBuilder.RenameColumn(
                name: "pg_form_code",
                table: "F014",
                newName: "PgFormCode");

            migrationBuilder.RenameColumn(
                name: "penalty_coefficient",
                table: "F014",
                newName: "PenaltyCoefficient");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F014",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F014",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "code_reserve_field",
                table: "F014",
                newName: "CodeReserveField");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F014",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F014",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_F014",
                table: "F014",
                column: "Id");
        }
    }
}
