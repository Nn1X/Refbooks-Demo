using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class add_n_refbooks_to_dbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "n002",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    scheme_code = table.Column<string>(type: "text", nullable: true),
                    medicament_id = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n003",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    t_code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n003", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n004",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    n_code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n004", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n005",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    m_code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n005", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n006",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    stage_code = table.Column<int>(type: "integer", nullable: true),
                    t_code = table.Column<int>(type: "integer", nullable: true),
                    n_code = table.Column<int>(type: "integer", nullable: true),
                    m_code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n006", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n007",
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
                    table.PrimaryKey("PK_n007", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n008",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    n007code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n008", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n009",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    n007code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n009", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n010",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    marker = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n010", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n011",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    n010code = table.Column<string>(type: "text", nullable: true),
                    result = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n011", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n012",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    n010code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n012", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n013",
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
                    table.PrimaryKey("PK_n013", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n014",
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
                    table.PrimaryKey("PK_n014", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n015",
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
                    table.PrimaryKey("PK_n015", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n016",
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
                    table.PrimaryKey("PK_n016", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n017",
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
                    table.PrimaryKey("PK_n017", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n018",
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
                    table.PrimaryKey("PK_n018", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n019",
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
                    table.PrimaryKey("PK_n019", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n020",
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
                    table.PrimaryKey("PK_n020", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "n021",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    scheme_code = table.Column<string>(type: "text", nullable: true),
                    medicament_id = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n021", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_n002_id",
                table: "n002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n003_id",
                table: "n003",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n004_id",
                table: "n004",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n005_id",
                table: "n005",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n006_id",
                table: "n006",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n007_id",
                table: "n007",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n008_id",
                table: "n008",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n009_id",
                table: "n009",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n010_id",
                table: "n010",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n011_id",
                table: "n011",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n012_id",
                table: "n012",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n013_id",
                table: "n013",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n014_id",
                table: "n014",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n015_id",
                table: "n015",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n016_id",
                table: "n016",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n017_id",
                table: "n017",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n018_id",
                table: "n018",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n019_id",
                table: "n019",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n020_id",
                table: "n020",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_n021_id",
                table: "n021",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "n002");

            migrationBuilder.DropTable(
                name: "n003");

            migrationBuilder.DropTable(
                name: "n004");

            migrationBuilder.DropTable(
                name: "n005");

            migrationBuilder.DropTable(
                name: "n006");

            migrationBuilder.DropTable(
                name: "n007");

            migrationBuilder.DropTable(
                name: "n008");

            migrationBuilder.DropTable(
                name: "n009");

            migrationBuilder.DropTable(
                name: "n010");

            migrationBuilder.DropTable(
                name: "n011");

            migrationBuilder.DropTable(
                name: "n012");

            migrationBuilder.DropTable(
                name: "n013");

            migrationBuilder.DropTable(
                name: "n014");

            migrationBuilder.DropTable(
                name: "n015");

            migrationBuilder.DropTable(
                name: "n016");

            migrationBuilder.DropTable(
                name: "n017");

            migrationBuilder.DropTable(
                name: "n018");

            migrationBuilder.DropTable(
                name: "n019");

            migrationBuilder.DropTable(
                name: "n020");

            migrationBuilder.DropTable(
                name: "n021");
        }
    }
}
