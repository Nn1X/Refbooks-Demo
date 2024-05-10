using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class ChangeKsgCalculationSalaryShareType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "salary_share",
                table: "ksg_calculation",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "salary_share",
                table: "ksg_calculation",
                type: "text",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);
        }
    }
}
