using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class refbooks_change_cofigurators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "F008",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F008", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F009",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F009", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F010",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Okato = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FederalDistrictCode = table.Column<int>(type: "integer", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F010", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F011",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DocumentSerialMask = table.Column<string>(type: "text", nullable: true),
                    DocumentNumberMask = table.Column<string>(type: "text", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F011", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F014",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    CodeReserveField = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RefusalReason = table.Column<string>(type: "text", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    SanctionCoefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    PenaltyCoefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    PgFormCode = table.Column<string>(type: "text", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F014", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F015",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F015", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F032",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Oktmo = table.Column<string>(type: "text", nullable: true),
                    SubjectName = table.Column<string>(type: "text", nullable: true),
                    ExclussionReasonCode = table.Column<int>(type: "integer", nullable: true),
                    InclussionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExclussionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F032", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F042",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Oktmo = table.Column<string>(type: "text", nullable: true),
                    SubjectName = table.Column<string>(type: "text", nullable: true),
                    ExclussionReasonCode = table.Column<int>(type: "integer", nullable: true),
                    InclussionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ExclussionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ConductedEkmpNumber = table.Column<int>(type: "integer", nullable: true),
                    CasesEkmpNumber = table.Column<int>(type: "integer", nullable: true),
                    MoEkmpNumber = table.Column<int>(type: "integer", nullable: true),
                    UnreasonableEkmpNumber = table.Column<int>(type: "integer", nullable: true),
                    DateBegin = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F042", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F008");

            migrationBuilder.DropTable(
                name: "F009");

            migrationBuilder.DropTable(
                name: "F010");

            migrationBuilder.DropTable(
                name: "F011");

            migrationBuilder.DropTable(
                name: "F014");

            migrationBuilder.DropTable(
                name: "F015");

            migrationBuilder.DropTable(
                name: "F032");

            migrationBuilder.DropTable(
                name: "F042");
        }
    }
}
