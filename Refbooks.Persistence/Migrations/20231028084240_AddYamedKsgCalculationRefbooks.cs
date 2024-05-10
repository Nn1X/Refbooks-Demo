using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class AddYamedKsgCalculationRefbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "calculation_mo_coefficient",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mo_code = table.Column<string>(type: "text", nullable: true),
                    hospital_level_coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    outpatient_care_coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    specificity_emc_coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calculation_mo_coefficient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "first_stage_adult_medical_examination_by_service_count_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group_id = table.Column<decimal>(type: "numeric", nullable: true),
                    regional_feature = table.Column<decimal>(type: "numeric", nullable: true),
                    gender = table.Column<decimal>(type: "numeric", nullable: true),
                    age = table.Column<string>(type: "text", nullable: true),
                    service_count_by_standard = table.Column<decimal>(type: "numeric", nullable: true),
                    acceptable_service_count = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_first_stage_adult_medical_examination_by_service_count_calc~", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "first_stage_adult_medical_examination_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    age_group = table.Column<string>(type: "text", nullable: true),
                    regional_feature = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    age = table.Column<string>(type: "text", nullable: true),
                    service_code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_first_stage_adult_medical_examination_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "first_stage_adult_professional_examination_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    age_group = table.Column<string>(type: "text", nullable: true),
                    regional_feature = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    age = table.Column<string>(type: "text", nullable: true),
                    service_code = table.Column<string>(type: "text", nullable: true),
                    service_name = table.Column<string>(type: "text", nullable: true),
                    obligation_service_sign = table.Column<int>(type: "integer", nullable: true),
                    specialization = table.Column<int>(type: "integer", nullable: true),
                    profile = table.Column<int>(type: "integer", nullable: true),
                    child_sign = table.Column<int>(type: "integer", nullable: false),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_first_stage_adult_professional_examination_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hematology_tariff",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    service_code = table.Column<string>(type: "text", nullable: true),
                    tariff = table.Column<decimal>(type: "numeric", nullable: true),
                    assistance_terms = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hematology_tariff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "high_tech_medical_care_tariff",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group_id = table.Column<int>(type: "integer", nullable: true),
                    tariff = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_high_tech_medical_care_tariff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ksg_base_rate",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    assistance_terms = table.Column<int>(type: "integer", nullable: true),
                    rate = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ksg_base_rate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ksg_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    assistance_terms = table.Column<int>(type: "integer", nullable: true),
                    ksg_number = table.Column<string>(type: "text", nullable: true),
                    ksg_name = table.Column<string>(type: "text", nullable: true),
                    cost_iintensity_coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    ksg_type = table.Column<string>(type: "text", nullable: true),
                    management_coefficient_sign = table.Column<string>(type: "text", nullable: true),
                    optimal_duration_treatment_sign = table.Column<string>(type: "text", nullable: true),
                    salary_share = table.Column<string>(type: "text", nullable: true),
                    diagnosis_sing = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ksg_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ksg_grouper",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    main_diagnosis = table.Column<string>(type: "text", nullable: true),
                    concomitant_diagnosis = table.Column<string>(type: "text", nullable: true),
                    complication_diagnosis = table.Column<string>(type: "text", nullable: true),
                    service_code = table.Column<string>(type: "text", nullable: true),
                    age_group = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    treatment_duration = table.Column<int>(type: "integer", nullable: true),
                    ksg_number = table.Column<string>(type: "text", nullable: true),
                    s_type = table.Column<int>(type: "integer", nullable: true),
                    additional_criteria = table.Column<string>(type: "text", nullable: true),
                    fractions_range = table.Column<string>(type: "text", nullable: true),
                    number = table.Column<string>(type: "text", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ksg_grouper", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "management_ksg_coefficient",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ksg_number = table.Column<string>(type: "text", nullable: true),
                    coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_management_ksg_coefficient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mkb10",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    @class = table.Column<int>(name: "class", type: "integer", nullable: true),
                    section = table.Column<int>(type: "integer", nullable: true),
                    payability_sign = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mkb10", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mobile_teams_medical_examination_coefficient",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    regional_feature = table.Column<string>(type: "text", nullable: true),
                    team_type = table.Column<int>(type: "integer", nullable: true),
                    coefficient = table.Column<decimal>(type: "numeric", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mobile_teams_medical_examination_coefficient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "outpatient_tariff_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tariff1 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff2 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff3 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff4 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff5 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff6 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff7 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff8 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff9 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff10 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff11 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff12 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff13 = table.Column<decimal>(type: "numeric", nullable: true),
                    tariff14 = table.Column<decimal>(type: "numeric", nullable: true),
                    profile = table.Column<int>(type: "integer", nullable: true),
                    regional_feature = table.Column<int>(type: "integer", nullable: true),
                    assistance_terms = table.Column<int>(type: "integer", nullable: true),
                    payment_method = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outpatient_tariff_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regional_laboratory_studies_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true),
                    service_number = table.Column<string>(type: "text", nullable: true),
                    service_code_v001 = table.Column<string>(type: "text", nullable: true),
                    service_name_v001 = table.Column<string>(type: "text", nullable: true),
                    service_code_lis = table.Column<string>(type: "text", nullable: true),
                    service_name_lis = table.Column<string>(type: "text", nullable: true),
                    service_code_regional = table.Column<string>(type: "text", nullable: true),
                    service_name_regional = table.Column<string>(type: "text", nullable: true),
                    tariff = table.Column<decimal>(type: "numeric", nullable: true),
                    assistance_type = table.Column<int>(type: "integer", nullable: true),
                    assistance_profile = table.Column<int>(type: "integer", nullable: true),
                    assistance_specialization = table.Column<int>(type: "integer", nullable: true),
                    assistance_form = table.Column<int>(type: "integer", nullable: true),
                    assistance_issue = table.Column<int>(type: "integer", nullable: true),
                    visit_purpose = table.Column<string>(type: "text", nullable: true),
                    assistance_result = table.Column<int>(type: "integer", nullable: true),
                    payment_method_code = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regional_laboratory_studies_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regional_service_tariff",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    service_code = table.Column<string>(type: "text", nullable: true),
                    tariff = table.Column<decimal>(type: "numeric", nullable: true),
                    assistance_terms = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regional_service_tariff", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "uet_dentistry_calculation",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    service_code = table.Column<string>(type: "text", nullable: true),
                    service_name = table.Column<string>(type: "text", nullable: true),
                    adult_uet_count = table.Column<decimal>(type: "numeric", nullable: true),
                    child_uet_count = table.Column<decimal>(type: "numeric", nullable: true),
                    multiple = table.Column<int>(type: "integer", nullable: true),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true),
                    date_end = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uet_dentistry_calculation", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_calculation_mo_coefficient_id",
                table: "calculation_mo_coefficient",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_first_stage_adult_medical_examination_by_service_count_calc~",
                table: "first_stage_adult_medical_examination_by_service_count_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_first_stage_adult_medical_examination_calculation_id",
                table: "first_stage_adult_medical_examination_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_first_stage_adult_professional_examination_calculation_id",
                table: "first_stage_adult_professional_examination_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hematology_tariff_id",
                table: "hematology_tariff",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_high_tech_medical_care_tariff_id",
                table: "high_tech_medical_care_tariff",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ksg_base_rate_id",
                table: "ksg_base_rate",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ksg_calculation_id",
                table: "ksg_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ksg_grouper_id",
                table: "ksg_grouper",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_management_ksg_coefficient_id",
                table: "management_ksg_coefficient",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mkb10_id",
                table: "mkb10",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mobile_teams_medical_examination_coefficient_id",
                table: "mobile_teams_medical_examination_coefficient",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_outpatient_tariff_calculation_id",
                table: "outpatient_tariff_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_regional_laboratory_studies_calculation_id",
                table: "regional_laboratory_studies_calculation",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_regional_service_tariff_id",
                table: "regional_service_tariff",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_uet_dentistry_calculation_id",
                table: "uet_dentistry_calculation",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calculation_mo_coefficient");

            migrationBuilder.DropTable(
                name: "first_stage_adult_medical_examination_by_service_count_calculation");

            migrationBuilder.DropTable(
                name: "first_stage_adult_medical_examination_calculation");

            migrationBuilder.DropTable(
                name: "first_stage_adult_professional_examination_calculation");

            migrationBuilder.DropTable(
                name: "hematology_tariff");

            migrationBuilder.DropTable(
                name: "high_tech_medical_care_tariff");

            migrationBuilder.DropTable(
                name: "ksg_base_rate");

            migrationBuilder.DropTable(
                name: "ksg_calculation");

            migrationBuilder.DropTable(
                name: "ksg_grouper");

            migrationBuilder.DropTable(
                name: "management_ksg_coefficient");

            migrationBuilder.DropTable(
                name: "mkb10");

            migrationBuilder.DropTable(
                name: "mobile_teams_medical_examination_coefficient");

            migrationBuilder.DropTable(
                name: "outpatient_tariff_calculation");

            migrationBuilder.DropTable(
                name: "regional_laboratory_studies_calculation");

            migrationBuilder.DropTable(
                name: "regional_service_tariff");

            migrationBuilder.DropTable(
                name: "uet_dentistry_calculation");
        }
    }
}
