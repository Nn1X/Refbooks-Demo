using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class Add_V_Refbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "v002",
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
                    table.PrimaryKey("PK_v002", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v003",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    element_code = table.Column<int>(type: "integer", nullable: true),
                    admissibility_sign = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v003", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v005",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v005", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v006",
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
                    table.PrimaryKey("PK_v006", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v008",
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
                    table.PrimaryKey("PK_v008", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v009",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    v006code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v009", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v010",
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
                    table.PrimaryKey("PK_v010", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v012",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    v006code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v012", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v013",
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
                    table.PrimaryKey("PK_v013", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v014",
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
                    table.PrimaryKey("PK_v014", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v015",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    speciality_code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    hierarchy = table.Column<int>(type: "integer", nullable: true),
                    okso = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v015", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v016",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    values_set = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v016", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v017",
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
                    table.PrimaryKey("PK_v017", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v018",
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
                    table.PrimaryKey("PK_v018", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v019",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    mkb_diagnosis = table.Column<string>(type: "text", nullable: true),
                    type_code = table.Column<string>(type: "text", nullable: true),
                    group_number = table.Column<int>(type: "integer", nullable: true),
                    patient_model = table.Column<string>(type: "text", nullable: true),
                    patient_model_id = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v019", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v020",
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
                    table.PrimaryKey("PK_v020", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v021",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    speciality_name = table.Column<string>(type: "text", nullable: true),
                    position_name = table.Column<string>(type: "text", nullable: true),
                    position_code = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v021", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v022",
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
                    table.PrimaryKey("PK_v022", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v023",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    number = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    coefficient = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v023", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v024",
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
                    table.PrimaryKey("PK_v024", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v025",
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
                    table.PrimaryKey("PK_v025", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v026",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    number = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    coefficient = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v026", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v027",
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
                    table.PrimaryKey("PK_v027", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v028",
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
                    table.PrimaryKey("PK_v028", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v029",
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
                    table.PrimaryKey("PK_v029", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v030",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    scheme = table.Column<string>(type: "text", nullable: true),
                    severity_code = table.Column<int>(type: "integer", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v030", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v031",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    group = table.Column<string>(type: "text", nullable: true),
                    mnn_sign = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v031", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v032",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    scheme = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v032", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v033",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    medecation_code = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v033", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v036",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    mandatory_parametr = table.Column<int>(type: "integer", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v036", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "v037",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    mandatory_parametr = table.Column<int>(type: "integer", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_v037", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_v002_id",
                table: "v002",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v003_id",
                table: "v003",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v005_id",
                table: "v005",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v006_id",
                table: "v006",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v008_id",
                table: "v008",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v009_id",
                table: "v009",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v010_id",
                table: "v010",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v012_id",
                table: "v012",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v013_id",
                table: "v013",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v014_id",
                table: "v014",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v015_id",
                table: "v015",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v016_id",
                table: "v016",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v017_id",
                table: "v017",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v018_id",
                table: "v018",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v019_id",
                table: "v019",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v020_id",
                table: "v020",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v021_id",
                table: "v021",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v022_id",
                table: "v022",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v023_id",
                table: "v023",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v024_id",
                table: "v024",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v025_id",
                table: "v025",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v026_id",
                table: "v026",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v027_id",
                table: "v027",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v028_id",
                table: "v028",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v029_id",
                table: "v029",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v030_id",
                table: "v030",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v031_id",
                table: "v031",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v032_id",
                table: "v032",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v033_id",
                table: "v033",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v036_id",
                table: "v036",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_v037_id",
                table: "v037",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "v002");

            migrationBuilder.DropTable(
                name: "v003");

            migrationBuilder.DropTable(
                name: "v005");

            migrationBuilder.DropTable(
                name: "v006");

            migrationBuilder.DropTable(
                name: "v008");

            migrationBuilder.DropTable(
                name: "v009");

            migrationBuilder.DropTable(
                name: "v010");

            migrationBuilder.DropTable(
                name: "v012");

            migrationBuilder.DropTable(
                name: "v013");

            migrationBuilder.DropTable(
                name: "v014");

            migrationBuilder.DropTable(
                name: "v015");

            migrationBuilder.DropTable(
                name: "v016");

            migrationBuilder.DropTable(
                name: "v017");

            migrationBuilder.DropTable(
                name: "v018");

            migrationBuilder.DropTable(
                name: "v019");

            migrationBuilder.DropTable(
                name: "v020");

            migrationBuilder.DropTable(
                name: "v021");

            migrationBuilder.DropTable(
                name: "v022");

            migrationBuilder.DropTable(
                name: "v023");

            migrationBuilder.DropTable(
                name: "v024");

            migrationBuilder.DropTable(
                name: "v025");

            migrationBuilder.DropTable(
                name: "v026");

            migrationBuilder.DropTable(
                name: "v027");

            migrationBuilder.DropTable(
                name: "v028");

            migrationBuilder.DropTable(
                name: "v029");

            migrationBuilder.DropTable(
                name: "v030");

            migrationBuilder.DropTable(
                name: "v031");

            migrationBuilder.DropTable(
                name: "v032");

            migrationBuilder.DropTable(
                name: "v033");

            migrationBuilder.DropTable(
                name: "v036");

            migrationBuilder.DropTable(
                name: "v037");
        }
    }
}
