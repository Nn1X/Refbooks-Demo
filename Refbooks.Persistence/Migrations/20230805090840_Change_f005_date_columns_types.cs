using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Change_f005_date_columns_types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F007",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F007",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F006",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F006",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateEnd",
                table: "F005",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateBegin",
                table: "F005",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(3) without time zone",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F007",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F007",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F006",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F006",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F005",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F005",
                type: "timestamp(3) without time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);
        }
    }
}
