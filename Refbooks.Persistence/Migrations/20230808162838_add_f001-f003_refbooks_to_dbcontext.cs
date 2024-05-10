using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class add_f001f003_refbooks_to_dbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "f001",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    okato = table.Column<string>(type: "text", nullable: true),
                    ogrn = table.Column<string>(type: "text", nullable: true),
                    full_name = table.Column<string>(type: "text", nullable: true),
                    short_name = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    director_last_name = table.Column<string>(type: "text", nullable: true),
                    director_first_name = table.Column<string>(type: "text", nullable: true),
                    director_patronymic = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    fax = table.Column<string>(type: "text", nullable: true),
                    hotline_phone_number = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    branches_number = table.Column<string>(type: "text", nullable: true),
                    official_website = table.Column<string>(type: "text", nullable: true),
                    bic = table.Column<string>(type: "text", nullable: true),
                    inn = table.Column<string>(type: "text", nullable: true),
                    kpp = table.Column<string>(type: "text", nullable: true),
                    kbk = table.Column<string>(type: "text", nullable: true),
                    oktmo = table.Column<string>(type: "text", nullable: true),
                    name_mtr_recipient = table.Column<string>(type: "text", nullable: true),
                    bank_name_mtr_recipient = table.Column<string>(type: "text", nullable: true),
                    rs_mtr_recipient = table.Column<string>(type: "text", nullable: true),
                    name_mtr_sender = table.Column<string>(type: "text", nullable: true),
                    bank_name_mtr_sender = table.Column<string>(type: "text", nullable: true),
                    rs_mtr_sender = table.Column<string>(type: "text", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_f001", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "f002",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    ogrn = table.Column<string>(type: "text", nullable: true),
                    kpp = table.Column<string>(type: "text", nullable: true),
                    full_name = table.Column<string>(type: "text", nullable: true),
                    short_name = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    director_last_name = table.Column<string>(type: "text", nullable: true),
                    director_first_name = table.Column<string>(type: "text", nullable: true),
                    director_patronymic = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    fax = table.Column<string>(type: "text", nullable: true),
                    hotline_phone_number = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    license_number = table.Column<string>(type: "text", nullable: true),
                    issue_date_license = table.Column<DateTime>(type: "date", nullable: true),
                    end_date_license = table.Column<DateTime>(type: "date", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_f002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "f003",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    okato = table.Column<string>(type: "text", nullable: true),
                    full_name = table.Column<string>(type: "text", nullable: true),
                    short_name = table.Column<string>(type: "text", nullable: true),
                    inn = table.Column<string>(type: "text", nullable: true),
                    ogrn = table.Column<string>(type: "text", nullable: true),
                    kpp = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    okopf_code = table.Column<string>(type: "text", nullable: true),
                    departmental_affiliation_code = table.Column<string>(type: "text", nullable: true),
                    subordination_sign = table.Column<string>(type: "text", nullable: true),
                    director_last_name = table.Column<string>(type: "text", nullable: true),
                    director_first_name = table.Column<string>(type: "text", nullable: true),
                    director_patronymic = table.Column<string>(type: "text", nullable: true),
                    first_phone_number = table.Column<string>(type: "text", nullable: true),
                    second_phone_number = table.Column<string>(type: "text", nullable: true),
                    first_fax = table.Column<string>(type: "text", nullable: true),
                    second_fax = table.Column<string>(type: "text", nullable: true),
                    first_email = table.Column<string>(type: "text", nullable: true),
                    second_email = table.Column<string>(type: "text", nullable: true),
                    official_website = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_edit = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_f003", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_f001_id",
                table: "f001",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f002_id",
                table: "f002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f003_id",
                table: "f003",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "f001");

            migrationBuilder.DropTable(
                name: "f002");

            migrationBuilder.DropTable(
                name: "f003");
        }
    }
}
