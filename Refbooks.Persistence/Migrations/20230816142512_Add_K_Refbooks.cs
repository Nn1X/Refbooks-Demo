using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Add_K_Refbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "k002",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_o002 = table.Column<string>(type: "text", nullable: true),
                    code_v006 = table.Column<int>(type: "integer", nullable: true),
                    medical_care = table.Column<string>(type: "text", nullable: true),
                    medical_care_coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_k002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "k003",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_o002 = table.Column<string>(type: "text", nullable: true),
                    code_v006 = table.Column<int>(type: "integer", nullable: true),
                    base_rate = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_k003", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "k004",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_o002 = table.Column<string>(type: "text", nullable: true),
                    coeffiecient_number = table.Column<int>(type: "integer", nullable: true),
                    coeffiecient_number_reason = table.Column<int>(type: "integer", nullable: true),
                    coeffiecient_value = table.Column<decimal>(type: "numeric", nullable: true),
                    coefficient_applying_condition = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_k004", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_k002_id",
                table: "k002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_k003_id",
                table: "k003",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_k004_id",
                table: "k004",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "k002");

            migrationBuilder.DropTable(
                name: "k003");

            migrationBuilder.DropTable(
                name: "k004");
        }
    }
}
