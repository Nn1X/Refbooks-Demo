using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class AddQRefbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "q015",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    element_id = table.Column<string>(type: "text", nullable: true),
                    registry_type = table.Column<string>(type: "text", nullable: true),
                    nsi_code = table.Column<string>(type: "text", nullable: true),
                    nsi_element = table.Column<string>(type: "text", nullable: true),
                    condition = table.Column<string>(type: "text", nullable: true),
                    values_set = table.Column<string>(type: "text", nullable: true),
                    max_length = table.Column<int>(type: "integer", nullable: true),
                    min_length = table.Column<int>(type: "integer", nullable: true),
                    mask = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q015", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q016",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    element_id = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    registry_type = table.Column<string>(type: "text", nullable: true),
                    nsi_code = table.Column<string>(type: "text", nullable: true),
                    nsi_element = table.Column<string>(type: "text", nullable: true),
                    condition = table.Column<string>(type: "text", nullable: true),
                    values_set = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q016", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q017",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q017", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q018",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    element_id = table.Column<string>(type: "text", nullable: true),
                    registry_type = table.Column<string>(type: "text", nullable: true),
                    element_type = table.Column<string>(type: "text", nullable: true),
                    element_format = table.Column<string>(type: "text", nullable: true),
                    max_length = table.Column<string>(type: "text", nullable: true),
                    element_name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q018", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q019",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q019", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q020",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q020", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q021",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q021", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q022",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    element_id = table.Column<string>(type: "text", nullable: true),
                    tfoms_element_id = table.Column<string>(type: "text", nullable: true),
                    registry_type = table.Column<string>(type: "text", nullable: true),
                    nsi_code = table.Column<string>(type: "text", nullable: true),
                    nsi_element = table.Column<string>(type: "text", nullable: true),
                    condition = table.Column<string>(type: "text", nullable: true),
                    values_set = table.Column<string>(type: "text", nullable: true),
                    max_length = table.Column<int>(type: "integer", nullable: true),
                    min_length = table.Column<int>(type: "integer", nullable: true),
                    mask = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q022", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q023",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    element_id = table.Column<string>(type: "text", nullable: true),
                    tfoms_element_id = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    registry_type = table.Column<string>(type: "text", nullable: true),
                    nsi_code = table.Column<string>(type: "text", nullable: true),
                    nsi_element = table.Column<string>(type: "text", nullable: true),
                    condition = table.Column<string>(type: "text", nullable: true),
                    values_set = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q023", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_q015_id",
                table: "q015",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q016_id",
                table: "q016",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q017_id",
                table: "q017",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q018_id",
                table: "q018",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q019_id",
                table: "q019",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q020_id",
                table: "q020",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q021_id",
                table: "q021",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q022_id",
                table: "q022",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_q023_id",
                table: "q023",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "q015");

            migrationBuilder.DropTable(
                name: "q016");

            migrationBuilder.DropTable(
                name: "q017");

            migrationBuilder.DropTable(
                name: "q018");

            migrationBuilder.DropTable(
                name: "q019");

            migrationBuilder.DropTable(
                name: "q020");

            migrationBuilder.DropTable(
                name: "q021");

            migrationBuilder.DropTable(
                name: "q022");

            migrationBuilder.DropTable(
                name: "q023");
        }
    }
}
