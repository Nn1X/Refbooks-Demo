using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Add_R_Refbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "r001",
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
                    table.PrimaryKey("PK_r001", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r002",
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
                    table.PrimaryKey("PK_r002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r003",
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
                    table.PrimaryKey("PK_r003", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r004",
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
                    table.PrimaryKey("PK_r004", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r005",
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
                    table.PrimaryKey("PK_r005", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r006",
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
                    table.PrimaryKey("PK_r006", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r007",
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
                    table.PrimaryKey("PK_r007", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r008",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<decimal>(type: "numeric", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_r008", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r009",
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
                    table.PrimaryKey("PK_r009", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r010",
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
                    table.PrimaryKey("PK_r010", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r011",
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
                    table.PrimaryKey("PK_r011", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r012",
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
                    table.PrimaryKey("PK_r012", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r013",
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
                    table.PrimaryKey("PK_r013", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "r014",
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
                    table.PrimaryKey("PK_r014", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_r001_id",
                table: "r001",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r002_id",
                table: "r002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r003_id",
                table: "r003",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r004_id",
                table: "r004",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r005_id",
                table: "r005",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r006_id",
                table: "r006",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r007_id",
                table: "r007",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r008_id",
                table: "r008",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r009_id",
                table: "r009",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r010_id",
                table: "r010",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r011_id",
                table: "r011",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r012_id",
                table: "r012",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r013_id",
                table: "r013",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_r014_id",
                table: "r014",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "r001");

            migrationBuilder.DropTable(
                name: "r002");

            migrationBuilder.DropTable(
                name: "r003");

            migrationBuilder.DropTable(
                name: "r004");

            migrationBuilder.DropTable(
                name: "r005");

            migrationBuilder.DropTable(
                name: "r006");

            migrationBuilder.DropTable(
                name: "r007");

            migrationBuilder.DropTable(
                name: "r008");

            migrationBuilder.DropTable(
                name: "r009");

            migrationBuilder.DropTable(
                name: "r010");

            migrationBuilder.DropTable(
                name: "r011");

            migrationBuilder.DropTable(
                name: "r012");

            migrationBuilder.DropTable(
                name: "r013");

            migrationBuilder.DropTable(
                name: "r014");
        }
    }
}
