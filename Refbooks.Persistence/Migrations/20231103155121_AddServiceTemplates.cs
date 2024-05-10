using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class AddServiceTemplates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "service_template",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    code = table.Column<string>(type: "text", nullable: true),
                    code_vme = table.Column<string>(type: "text", nullable: true),
                    count = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true),
                    profile = table.Column<int>(type: "integer", nullable: true),
                    child_sign = table.Column<int>(type: "integer", nullable: true),
                    specialization = table.Column<int>(type: "integer", nullable: true),
                    mandatory = table.Column<int>(type: "integer", nullable: true),
                    complexity_mandatory = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_template", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_service_template_id",
                table: "service_template",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "service_template");
        }
    }
}
