using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Add_O_Refbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "o001",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    continuation_name = table.Column<string>(type: "text", nullable: true),
                    alpha2code = table.Column<string>(type: "text", nullable: true),
                    alpha3code = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    last_edit_number = table.Column<string>(type: "text", nullable: true),
                    last_edit_type = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_o001", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "o002",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    territory_code = table.Column<string>(type: "text", nullable: true),
                    area_city_code = table.Column<string>(type: "text", nullable: true),
                    village_council_code = table.Column<string>(type: "text", nullable: true),
                    village_code = table.Column<string>(type: "text", nullable: true),
                    section_code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    additional_data = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    last_edit_number = table.Column<string>(type: "text", nullable: true),
                    last_edit_type = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_o002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "o003",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    section_code = table.Column<string>(type: "text", nullable: true),
                    position_code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    additional_data = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    last_edit_number = table.Column<string>(type: "text", nullable: true),
                    last_edit_type = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_o003", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "o004",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    collection_algorithm = table.Column<string>(type: "text", nullable: true),
                    last_edit_number = table.Column<string>(type: "text", nullable: true),
                    last_edit_type = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_o004", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "o005",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    last_edit_number = table.Column<string>(type: "text", nullable: true),
                    last_edit_type = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_o005", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_o001_id",
                table: "o001",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_o002_id",
                table: "o002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_o003_id",
                table: "o003",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_o004_id",
                table: "o004",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_o005_id",
                table: "o005",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "o001");

            migrationBuilder.DropTable(
                name: "o002");

            migrationBuilder.DropTable(
                name: "o003");

            migrationBuilder.DropTable(
                name: "o004");

            migrationBuilder.DropTable(
                name: "o005");
        }
    }
}
