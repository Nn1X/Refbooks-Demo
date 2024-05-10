using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChageNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_v037",
                table: "v037");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v036",
                table: "v036");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v033",
                table: "v033");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v032",
                table: "v032");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v031",
                table: "v031");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v030",
                table: "v030");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v029",
                table: "v029");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v028",
                table: "v028");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v027",
                table: "v027");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v026",
                table: "v026");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v025",
                table: "v025");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v024",
                table: "v024");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v023",
                table: "v023");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v022",
                table: "v022");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v021",
                table: "v021");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v020",
                table: "v020");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v019",
                table: "v019");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v018",
                table: "v018");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v017",
                table: "v017");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v016",
                table: "v016");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v015",
                table: "v015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v014",
                table: "v014");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v013",
                table: "v013");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v012",
                table: "v012");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v010",
                table: "v010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v009",
                table: "v009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v008",
                table: "v008");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v006",
                table: "v006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v005",
                table: "v005");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v003",
                table: "v003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_v002",
                table: "v002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_uet_dentistry_calculation",
                table: "uet_dentistry_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_regional_laboratory_studies_calculation",
                table: "regional_laboratory_studies_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r014",
                table: "r014");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r013",
                table: "r013");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r012",
                table: "r012");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r011",
                table: "r011");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r010",
                table: "r010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r009",
                table: "r009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r008",
                table: "r008");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r007",
                table: "r007");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r006",
                table: "r006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r005",
                table: "r005");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r004",
                table: "r004");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r003",
                table: "r003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r002",
                table: "r002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_r001",
                table: "r001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q023",
                table: "q023");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q022",
                table: "q022");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q021",
                table: "q021");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q020",
                table: "q020");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q019",
                table: "q019");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q018",
                table: "q018");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q017",
                table: "q017");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q016",
                table: "q016");

            migrationBuilder.DropPrimaryKey(
                name: "PK_q015",
                table: "q015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_outpatient_tariff_calculation",
                table: "outpatient_tariff_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_o005",
                table: "o005");

            migrationBuilder.DropPrimaryKey(
                name: "PK_o004",
                table: "o004");

            migrationBuilder.DropPrimaryKey(
                name: "PK_o003",
                table: "o003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_o002",
                table: "o002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_o001",
                table: "o001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n021",
                table: "n021");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n020",
                table: "n020");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n019",
                table: "n019");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n018",
                table: "n018");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n017",
                table: "n017");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n016",
                table: "n016");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n015",
                table: "n015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n014",
                table: "n014");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n013",
                table: "n013");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n012",
                table: "n012");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n011",
                table: "n011");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n010",
                table: "n010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n009",
                table: "n009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n008",
                table: "n008");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n007",
                table: "n007");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n006",
                table: "n006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n005",
                table: "n005");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n004",
                table: "n004");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n003",
                table: "n003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n002",
                table: "n002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_n001",
                table: "n001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mkb10",
                table: "mkb10");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ksg_grouper",
                table: "ksg_grouper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ksg_calculation",
                table: "ksg_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_k004",
                table: "k004");

            migrationBuilder.DropPrimaryKey(
                name: "PK_k003",
                table: "k003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_k002",
                table: "k002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_first_stage_adult_professional_examination_calculation",
                table: "first_stage_adult_professional_examination_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_first_stage_adult_medical_examination_calculation",
                table: "first_stage_adult_medical_examination_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_first_stage_adult_medical_examination_by_service_count_calc~",
                table: "first_stage_adult_medical_examination_by_service_count_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f042",
                table: "f042");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f032",
                table: "f032");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f015",
                table: "f015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f014",
                table: "f014");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f011",
                table: "f011");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f010",
                table: "f010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f009",
                table: "f009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f008",
                table: "f008");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f007",
                table: "f007");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f006",
                table: "f006");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f005",
                table: "f005");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f003",
                table: "f003");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f002",
                table: "f002");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f001",
                table: "f001");

            migrationBuilder.DropPrimaryKey(
                name: "PK_service_template",
                table: "service_template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_regional_service_tariff",
                table: "regional_service_tariff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mobile_teams_medical_examination_coefficient",
                table: "mobile_teams_medical_examination_coefficient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_management_ksg_coefficient",
                table: "management_ksg_coefficient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ksg_base_rate",
                table: "ksg_base_rate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_high_tech_medical_care_tariff",
                table: "high_tech_medical_care_tariff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hematology_tariff",
                table: "hematology_tariff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_calculation_mo_coefficient",
                table: "calculation_mo_coefficient");

            migrationBuilder.RenameTable(
                name: "service_template",
                newName: "service_templates");

            migrationBuilder.RenameTable(
                name: "regional_service_tariff",
                newName: "regional_service_tariffs");

            migrationBuilder.RenameTable(
                name: "mobile_teams_medical_examination_coefficient",
                newName: "mobile_teams_medical_examination_coefficients");

            migrationBuilder.RenameTable(
                name: "management_ksg_coefficient",
                newName: "management_ksg_coefficients");

            migrationBuilder.RenameTable(
                name: "ksg_base_rate",
                newName: "ksg_base_rates");

            migrationBuilder.RenameTable(
                name: "high_tech_medical_care_tariff",
                newName: "high_tech_medical_care_tariffs");

            migrationBuilder.RenameTable(
                name: "hematology_tariff",
                newName: "hematology_tariffs");

            migrationBuilder.RenameTable(
                name: "calculation_mo_coefficient",
                newName: "calculation_mo_coefficients");

            migrationBuilder.RenameIndex(
                name: "IX_v037_id",
                table: "v037",
                newName: "ix_v037_id");

            migrationBuilder.RenameIndex(
                name: "IX_v036_id",
                table: "v036",
                newName: "ix_v036_id");

            migrationBuilder.RenameIndex(
                name: "IX_v033_id",
                table: "v033",
                newName: "ix_v033_id");

            migrationBuilder.RenameIndex(
                name: "IX_v032_id",
                table: "v032",
                newName: "ix_v032_id");

            migrationBuilder.RenameIndex(
                name: "IX_v031_id",
                table: "v031",
                newName: "ix_v031_id");

            migrationBuilder.RenameIndex(
                name: "IX_v030_id",
                table: "v030",
                newName: "ix_v030_id");

            migrationBuilder.RenameIndex(
                name: "IX_v029_id",
                table: "v029",
                newName: "ix_v029_id");

            migrationBuilder.RenameIndex(
                name: "IX_v028_id",
                table: "v028",
                newName: "ix_v028_id");

            migrationBuilder.RenameIndex(
                name: "IX_v027_id",
                table: "v027",
                newName: "ix_v027_id");

            migrationBuilder.RenameIndex(
                name: "IX_v026_id",
                table: "v026",
                newName: "ix_v026_id");

            migrationBuilder.RenameIndex(
                name: "IX_v025_id",
                table: "v025",
                newName: "ix_v025_id");

            migrationBuilder.RenameIndex(
                name: "IX_v024_id",
                table: "v024",
                newName: "ix_v024_id");

            migrationBuilder.RenameIndex(
                name: "IX_v023_id",
                table: "v023",
                newName: "ix_v023_id");

            migrationBuilder.RenameIndex(
                name: "IX_v022_id",
                table: "v022",
                newName: "ix_v022_id");

            migrationBuilder.RenameIndex(
                name: "IX_v021_id",
                table: "v021",
                newName: "ix_v021_id");

            migrationBuilder.RenameIndex(
                name: "IX_v020_id",
                table: "v020",
                newName: "ix_v020_id");

            migrationBuilder.RenameIndex(
                name: "IX_v019_id",
                table: "v019",
                newName: "ix_v019_id");

            migrationBuilder.RenameIndex(
                name: "IX_v018_id",
                table: "v018",
                newName: "ix_v018_id");

            migrationBuilder.RenameIndex(
                name: "IX_v017_id",
                table: "v017",
                newName: "ix_v017_id");

            migrationBuilder.RenameIndex(
                name: "IX_v016_id",
                table: "v016",
                newName: "ix_v016_id");

            migrationBuilder.RenameIndex(
                name: "IX_v015_id",
                table: "v015",
                newName: "ix_v015_id");

            migrationBuilder.RenameIndex(
                name: "IX_v014_id",
                table: "v014",
                newName: "ix_v014_id");

            migrationBuilder.RenameIndex(
                name: "IX_v013_id",
                table: "v013",
                newName: "ix_v013_id");

            migrationBuilder.RenameIndex(
                name: "IX_v012_id",
                table: "v012",
                newName: "ix_v012_id");

            migrationBuilder.RenameIndex(
                name: "IX_v010_id",
                table: "v010",
                newName: "ix_v010_id");

            migrationBuilder.RenameIndex(
                name: "IX_v009_id",
                table: "v009",
                newName: "ix_v009_id");

            migrationBuilder.RenameIndex(
                name: "IX_v008_id",
                table: "v008",
                newName: "ix_v008_id");

            migrationBuilder.RenameIndex(
                name: "IX_v006_id",
                table: "v006",
                newName: "ix_v006_id");

            migrationBuilder.RenameIndex(
                name: "IX_v005_id",
                table: "v005",
                newName: "ix_v005_id");

            migrationBuilder.RenameIndex(
                name: "IX_v003_id",
                table: "v003",
                newName: "ix_v003_id");

            migrationBuilder.RenameIndex(
                name: "IX_v002_id",
                table: "v002",
                newName: "ix_v002_id");

            migrationBuilder.RenameIndex(
                name: "IX_uet_dentistry_calculation_id",
                table: "uet_dentistry_calculation",
                newName: "ix_uet_dentistry_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_regional_laboratory_studies_calculation_id",
                table: "regional_laboratory_studies_calculation",
                newName: "ix_regional_laboratory_studies_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_r014_id",
                table: "r014",
                newName: "ix_r014_id");

            migrationBuilder.RenameIndex(
                name: "IX_r013_id",
                table: "r013",
                newName: "ix_r013_id");

            migrationBuilder.RenameIndex(
                name: "IX_r012_id",
                table: "r012",
                newName: "ix_r012_id");

            migrationBuilder.RenameIndex(
                name: "IX_r011_id",
                table: "r011",
                newName: "ix_r011_id");

            migrationBuilder.RenameIndex(
                name: "IX_r010_id",
                table: "r010",
                newName: "ix_r010_id");

            migrationBuilder.RenameIndex(
                name: "IX_r009_id",
                table: "r009",
                newName: "ix_r009_id");

            migrationBuilder.RenameIndex(
                name: "IX_r008_id",
                table: "r008",
                newName: "ix_r008_id");

            migrationBuilder.RenameIndex(
                name: "IX_r007_id",
                table: "r007",
                newName: "ix_r007_id");

            migrationBuilder.RenameIndex(
                name: "IX_r006_id",
                table: "r006",
                newName: "ix_r006_id");

            migrationBuilder.RenameIndex(
                name: "IX_r005_id",
                table: "r005",
                newName: "ix_r005_id");

            migrationBuilder.RenameIndex(
                name: "IX_r004_id",
                table: "r004",
                newName: "ix_r004_id");

            migrationBuilder.RenameIndex(
                name: "IX_r003_id",
                table: "r003",
                newName: "ix_r003_id");

            migrationBuilder.RenameIndex(
                name: "IX_r002_id",
                table: "r002",
                newName: "ix_r002_id");

            migrationBuilder.RenameIndex(
                name: "IX_r001_id",
                table: "r001",
                newName: "ix_r001_id");

            migrationBuilder.RenameIndex(
                name: "IX_q023_id",
                table: "q023",
                newName: "ix_q023_id");

            migrationBuilder.RenameIndex(
                name: "IX_q022_id",
                table: "q022",
                newName: "ix_q022_id");

            migrationBuilder.RenameIndex(
                name: "IX_q021_id",
                table: "q021",
                newName: "ix_q021_id");

            migrationBuilder.RenameIndex(
                name: "IX_q020_id",
                table: "q020",
                newName: "ix_q020_id");

            migrationBuilder.RenameIndex(
                name: "IX_q019_id",
                table: "q019",
                newName: "ix_q019_id");

            migrationBuilder.RenameIndex(
                name: "IX_q018_id",
                table: "q018",
                newName: "ix_q018_id");

            migrationBuilder.RenameIndex(
                name: "IX_q017_id",
                table: "q017",
                newName: "ix_q017_id");

            migrationBuilder.RenameIndex(
                name: "IX_q016_id",
                table: "q016",
                newName: "ix_q016_id");

            migrationBuilder.RenameIndex(
                name: "IX_q015_id",
                table: "q015",
                newName: "ix_q015_id");

            migrationBuilder.RenameIndex(
                name: "IX_outpatient_tariff_calculation_id",
                table: "outpatient_tariff_calculation",
                newName: "ix_outpatient_tariff_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_o005_id",
                table: "o005",
                newName: "ix_o005_id");

            migrationBuilder.RenameIndex(
                name: "IX_o004_id",
                table: "o004",
                newName: "ix_o004_id");

            migrationBuilder.RenameIndex(
                name: "IX_o003_id",
                table: "o003",
                newName: "ix_o003_id");

            migrationBuilder.RenameIndex(
                name: "IX_o002_id",
                table: "o002",
                newName: "ix_o002_id");

            migrationBuilder.RenameIndex(
                name: "IX_o001_id",
                table: "o001",
                newName: "ix_o001_id");

            migrationBuilder.RenameIndex(
                name: "IX_n021_id",
                table: "n021",
                newName: "ix_n021_id");

            migrationBuilder.RenameIndex(
                name: "IX_n020_id",
                table: "n020",
                newName: "ix_n020_id");

            migrationBuilder.RenameIndex(
                name: "IX_n019_id",
                table: "n019",
                newName: "ix_n019_id");

            migrationBuilder.RenameIndex(
                name: "IX_n018_id",
                table: "n018",
                newName: "ix_n018_id");

            migrationBuilder.RenameIndex(
                name: "IX_n017_id",
                table: "n017",
                newName: "ix_n017_id");

            migrationBuilder.RenameIndex(
                name: "IX_n016_id",
                table: "n016",
                newName: "ix_n016_id");

            migrationBuilder.RenameIndex(
                name: "IX_n015_id",
                table: "n015",
                newName: "ix_n015_id");

            migrationBuilder.RenameIndex(
                name: "IX_n014_id",
                table: "n014",
                newName: "ix_n014_id");

            migrationBuilder.RenameIndex(
                name: "IX_n013_id",
                table: "n013",
                newName: "ix_n013_id");

            migrationBuilder.RenameIndex(
                name: "IX_n012_id",
                table: "n012",
                newName: "ix_n012_id");

            migrationBuilder.RenameIndex(
                name: "IX_n011_id",
                table: "n011",
                newName: "ix_n011_id");

            migrationBuilder.RenameIndex(
                name: "IX_n010_id",
                table: "n010",
                newName: "ix_n010_id");

            migrationBuilder.RenameIndex(
                name: "IX_n009_id",
                table: "n009",
                newName: "ix_n009_id");

            migrationBuilder.RenameIndex(
                name: "IX_n008_id",
                table: "n008",
                newName: "ix_n008_id");

            migrationBuilder.RenameIndex(
                name: "IX_n007_id",
                table: "n007",
                newName: "ix_n007_id");

            migrationBuilder.RenameIndex(
                name: "IX_n006_id",
                table: "n006",
                newName: "ix_n006_id");

            migrationBuilder.RenameIndex(
                name: "IX_n005_id",
                table: "n005",
                newName: "ix_n005_id");

            migrationBuilder.RenameIndex(
                name: "IX_n004_id",
                table: "n004",
                newName: "ix_n004_id");

            migrationBuilder.RenameIndex(
                name: "IX_n003_id",
                table: "n003",
                newName: "ix_n003_id");

            migrationBuilder.RenameIndex(
                name: "IX_n002_id",
                table: "n002",
                newName: "ix_n002_id");

            migrationBuilder.RenameIndex(
                name: "IX_n001_id",
                table: "n001",
                newName: "ix_n001_id");

            migrationBuilder.RenameIndex(
                name: "IX_mkb10_id",
                table: "mkb10",
                newName: "ix_mkb10_id");

            migrationBuilder.RenameIndex(
                name: "IX_ksg_grouper_id",
                table: "ksg_grouper",
                newName: "ix_ksg_grouper_id");

            migrationBuilder.RenameIndex(
                name: "IX_ksg_calculation_id",
                table: "ksg_calculation",
                newName: "ix_ksg_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_k004_id",
                table: "k004",
                newName: "ix_k004_id");

            migrationBuilder.RenameIndex(
                name: "IX_k003_id",
                table: "k003",
                newName: "ix_k003_id");

            migrationBuilder.RenameIndex(
                name: "IX_k002_id",
                table: "k002",
                newName: "ix_k002_id");

            migrationBuilder.RenameIndex(
                name: "IX_first_stage_adult_professional_examination_calculation_id",
                table: "first_stage_adult_professional_examination_calculation",
                newName: "ix_first_stage_adult_professional_examination_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_first_stage_adult_medical_examination_calculation_id",
                table: "first_stage_adult_medical_examination_calculation",
                newName: "ix_first_stage_adult_medical_examination_calculation_id");

            migrationBuilder.RenameIndex(
                name: "IX_first_stage_adult_medical_examination_by_service_count_calc~",
                table: "first_stage_adult_medical_examination_by_service_count_calculation",
                newName: "ix_first_stage_adult_medical_examination_by_service_count_calc");

            migrationBuilder.RenameIndex(
                name: "IX_f042_id",
                table: "f042",
                newName: "ix_f042_id");

            migrationBuilder.RenameIndex(
                name: "IX_f032_id",
                table: "f032",
                newName: "ix_f032_id");

            migrationBuilder.RenameIndex(
                name: "IX_f015_id",
                table: "f015",
                newName: "ix_f015_id");

            migrationBuilder.RenameIndex(
                name: "IX_f014_id",
                table: "f014",
                newName: "ix_f014_id");

            migrationBuilder.RenameIndex(
                name: "IX_f011_id",
                table: "f011",
                newName: "ix_f011_id");

            migrationBuilder.RenameIndex(
                name: "IX_f010_id",
                table: "f010",
                newName: "ix_f010_id");

            migrationBuilder.RenameIndex(
                name: "IX_f009_id",
                table: "f009",
                newName: "ix_f009_id");

            migrationBuilder.RenameIndex(
                name: "IX_f008_id",
                table: "f008",
                newName: "ix_f008_id");

            migrationBuilder.RenameIndex(
                name: "IX_f007_id",
                table: "f007",
                newName: "ix_f007_id");

            migrationBuilder.RenameIndex(
                name: "IX_f006_id",
                table: "f006",
                newName: "ix_f006_id");

            migrationBuilder.RenameIndex(
                name: "IX_f005_id",
                table: "f005",
                newName: "ix_f005_id");

            migrationBuilder.RenameIndex(
                name: "IX_f003_id",
                table: "f003",
                newName: "ix_f003_id");

            migrationBuilder.RenameIndex(
                name: "IX_f002_id",
                table: "f002",
                newName: "ix_f002_id");

            migrationBuilder.RenameIndex(
                name: "IX_f001_id",
                table: "f001",
                newName: "ix_f001_id");

            migrationBuilder.RenameIndex(
                name: "IX_service_template_id",
                table: "service_templates",
                newName: "ix_service_templates_id");

            migrationBuilder.RenameIndex(
                name: "IX_regional_service_tariff_id",
                table: "regional_service_tariffs",
                newName: "ix_regional_service_tariffs_id");

            migrationBuilder.RenameIndex(
                name: "IX_mobile_teams_medical_examination_coefficient_id",
                table: "mobile_teams_medical_examination_coefficients",
                newName: "ix_mobile_teams_medical_examination_coefficients_id");

            migrationBuilder.RenameIndex(
                name: "IX_management_ksg_coefficient_id",
                table: "management_ksg_coefficients",
                newName: "ix_management_ksg_coefficients_id");

            migrationBuilder.RenameIndex(
                name: "IX_ksg_base_rate_id",
                table: "ksg_base_rates",
                newName: "ix_ksg_base_rates_id");

            migrationBuilder.RenameIndex(
                name: "IX_high_tech_medical_care_tariff_id",
                table: "high_tech_medical_care_tariffs",
                newName: "ix_high_tech_medical_care_tariffs_id");

            migrationBuilder.RenameIndex(
                name: "IX_hematology_tariff_id",
                table: "hematology_tariffs",
                newName: "ix_hematology_tariffs_id");

            migrationBuilder.RenameIndex(
                name: "IX_calculation_mo_coefficient_id",
                table: "calculation_mo_coefficients",
                newName: "ix_calculation_mo_coefficients_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v037",
                table: "v037",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v036",
                table: "v036",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v033",
                table: "v033",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v032",
                table: "v032",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v031",
                table: "v031",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v030",
                table: "v030",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v029",
                table: "v029",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v028",
                table: "v028",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v027",
                table: "v027",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v026",
                table: "v026",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v025",
                table: "v025",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v024",
                table: "v024",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v023",
                table: "v023",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v022",
                table: "v022",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v021",
                table: "v021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v020",
                table: "v020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v019",
                table: "v019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v018",
                table: "v018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v017",
                table: "v017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v016",
                table: "v016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v015",
                table: "v015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v014",
                table: "v014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v013",
                table: "v013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v012",
                table: "v012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v010",
                table: "v010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v009",
                table: "v009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v008",
                table: "v008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v006",
                table: "v006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v005",
                table: "v005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v003",
                table: "v003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_v002",
                table: "v002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_uet_dentistry_calculation",
                table: "uet_dentistry_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_regional_laboratory_studies_calculation",
                table: "regional_laboratory_studies_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r014",
                table: "r014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r013",
                table: "r013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r012",
                table: "r012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r011",
                table: "r011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r010",
                table: "r010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r009",
                table: "r009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r008",
                table: "r008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r007",
                table: "r007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r006",
                table: "r006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r005",
                table: "r005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r004",
                table: "r004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r003",
                table: "r003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r002",
                table: "r002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_r001",
                table: "r001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q023",
                table: "q023",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q022",
                table: "q022",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q021",
                table: "q021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q020",
                table: "q020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q019",
                table: "q019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q018",
                table: "q018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q017",
                table: "q017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q016",
                table: "q016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_q015",
                table: "q015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_outpatient_tariff_calculation",
                table: "outpatient_tariff_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_o005",
                table: "o005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_o004",
                table: "o004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_o003",
                table: "o003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_o002",
                table: "o002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_o001",
                table: "o001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n021",
                table: "n021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n020",
                table: "n020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n019",
                table: "n019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n018",
                table: "n018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n017",
                table: "n017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n016",
                table: "n016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n015",
                table: "n015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n014",
                table: "n014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n013",
                table: "n013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n012",
                table: "n012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n011",
                table: "n011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n010",
                table: "n010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n009",
                table: "n009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n008",
                table: "n008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n007",
                table: "n007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n006",
                table: "n006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n005",
                table: "n005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n004",
                table: "n004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n003",
                table: "n003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n002",
                table: "n002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_n001",
                table: "n001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_mkb10",
                table: "mkb10",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ksg_grouper",
                table: "ksg_grouper",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ksg_calculation",
                table: "ksg_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_k004",
                table: "k004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_k003",
                table: "k003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_k002",
                table: "k002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_first_stage_adult_professional_examination_calculation",
                table: "first_stage_adult_professional_examination_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_first_stage_adult_medical_examination_calculation",
                table: "first_stage_adult_medical_examination_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_first_stage_adult_medical_examination_by_service_count_calc",
                table: "first_stage_adult_medical_examination_by_service_count_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f042",
                table: "f042",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f032",
                table: "f032",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f015",
                table: "f015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f014",
                table: "f014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f011",
                table: "f011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f010",
                table: "f010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f009",
                table: "f009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f008",
                table: "f008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f007",
                table: "f007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f006",
                table: "f006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f005",
                table: "f005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f003",
                table: "f003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f002",
                table: "f002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_f001",
                table: "f001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_templates",
                table: "service_templates",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_regional_service_tariffs",
                table: "regional_service_tariffs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_mobile_teams_medical_examination_coefficients",
                table: "mobile_teams_medical_examination_coefficients",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_management_ksg_coefficients",
                table: "management_ksg_coefficients",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ksg_base_rates",
                table: "ksg_base_rates",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_high_tech_medical_care_tariffs",
                table: "high_tech_medical_care_tariffs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_hematology_tariffs",
                table: "hematology_tariffs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_calculation_mo_coefficients",
                table: "calculation_mo_coefficients",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_v037",
                table: "v037");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v036",
                table: "v036");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v033",
                table: "v033");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v032",
                table: "v032");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v031",
                table: "v031");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v030",
                table: "v030");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v029",
                table: "v029");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v028",
                table: "v028");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v027",
                table: "v027");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v026",
                table: "v026");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v025",
                table: "v025");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v024",
                table: "v024");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v023",
                table: "v023");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v022",
                table: "v022");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v021",
                table: "v021");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v020",
                table: "v020");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v019",
                table: "v019");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v018",
                table: "v018");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v017",
                table: "v017");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v016",
                table: "v016");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v015",
                table: "v015");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v014",
                table: "v014");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v013",
                table: "v013");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v012",
                table: "v012");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v010",
                table: "v010");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v009",
                table: "v009");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v008",
                table: "v008");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v006",
                table: "v006");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v005",
                table: "v005");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v003",
                table: "v003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_v002",
                table: "v002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_uet_dentistry_calculation",
                table: "uet_dentistry_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_regional_laboratory_studies_calculation",
                table: "regional_laboratory_studies_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r014",
                table: "r014");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r013",
                table: "r013");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r012",
                table: "r012");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r011",
                table: "r011");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r010",
                table: "r010");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r009",
                table: "r009");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r008",
                table: "r008");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r007",
                table: "r007");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r006",
                table: "r006");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r005",
                table: "r005");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r004",
                table: "r004");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r003",
                table: "r003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r002",
                table: "r002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_r001",
                table: "r001");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q023",
                table: "q023");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q022",
                table: "q022");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q021",
                table: "q021");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q020",
                table: "q020");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q019",
                table: "q019");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q018",
                table: "q018");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q017",
                table: "q017");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q016",
                table: "q016");

            migrationBuilder.DropPrimaryKey(
                name: "pk_q015",
                table: "q015");

            migrationBuilder.DropPrimaryKey(
                name: "pk_outpatient_tariff_calculation",
                table: "outpatient_tariff_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_o005",
                table: "o005");

            migrationBuilder.DropPrimaryKey(
                name: "pk_o004",
                table: "o004");

            migrationBuilder.DropPrimaryKey(
                name: "pk_o003",
                table: "o003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_o002",
                table: "o002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_o001",
                table: "o001");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n021",
                table: "n021");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n020",
                table: "n020");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n019",
                table: "n019");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n018",
                table: "n018");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n017",
                table: "n017");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n016",
                table: "n016");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n015",
                table: "n015");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n014",
                table: "n014");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n013",
                table: "n013");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n012",
                table: "n012");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n011",
                table: "n011");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n010",
                table: "n010");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n009",
                table: "n009");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n008",
                table: "n008");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n007",
                table: "n007");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n006",
                table: "n006");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n005",
                table: "n005");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n004",
                table: "n004");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n003",
                table: "n003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n002",
                table: "n002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_n001",
                table: "n001");

            migrationBuilder.DropPrimaryKey(
                name: "pk_mkb10",
                table: "mkb10");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ksg_grouper",
                table: "ksg_grouper");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ksg_calculation",
                table: "ksg_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_k004",
                table: "k004");

            migrationBuilder.DropPrimaryKey(
                name: "pk_k003",
                table: "k003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_k002",
                table: "k002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_first_stage_adult_professional_examination_calculation",
                table: "first_stage_adult_professional_examination_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_first_stage_adult_medical_examination_calculation",
                table: "first_stage_adult_medical_examination_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_first_stage_adult_medical_examination_by_service_count_calc",
                table: "first_stage_adult_medical_examination_by_service_count_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f042",
                table: "f042");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f032",
                table: "f032");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f015",
                table: "f015");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f014",
                table: "f014");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f011",
                table: "f011");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f010",
                table: "f010");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f009",
                table: "f009");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f008",
                table: "f008");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f007",
                table: "f007");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f006",
                table: "f006");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f005",
                table: "f005");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f003",
                table: "f003");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f002",
                table: "f002");

            migrationBuilder.DropPrimaryKey(
                name: "pk_f001",
                table: "f001");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_templates",
                table: "service_templates");

            migrationBuilder.DropPrimaryKey(
                name: "pk_regional_service_tariffs",
                table: "regional_service_tariffs");

            migrationBuilder.DropPrimaryKey(
                name: "pk_mobile_teams_medical_examination_coefficients",
                table: "mobile_teams_medical_examination_coefficients");

            migrationBuilder.DropPrimaryKey(
                name: "pk_management_ksg_coefficients",
                table: "management_ksg_coefficients");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ksg_base_rates",
                table: "ksg_base_rates");

            migrationBuilder.DropPrimaryKey(
                name: "pk_high_tech_medical_care_tariffs",
                table: "high_tech_medical_care_tariffs");

            migrationBuilder.DropPrimaryKey(
                name: "pk_hematology_tariffs",
                table: "hematology_tariffs");

            migrationBuilder.DropPrimaryKey(
                name: "pk_calculation_mo_coefficients",
                table: "calculation_mo_coefficients");

            migrationBuilder.RenameTable(
                name: "service_templates",
                newName: "service_template");

            migrationBuilder.RenameTable(
                name: "regional_service_tariffs",
                newName: "regional_service_tariff");

            migrationBuilder.RenameTable(
                name: "mobile_teams_medical_examination_coefficients",
                newName: "mobile_teams_medical_examination_coefficient");

            migrationBuilder.RenameTable(
                name: "management_ksg_coefficients",
                newName: "management_ksg_coefficient");

            migrationBuilder.RenameTable(
                name: "ksg_base_rates",
                newName: "ksg_base_rate");

            migrationBuilder.RenameTable(
                name: "high_tech_medical_care_tariffs",
                newName: "high_tech_medical_care_tariff");

            migrationBuilder.RenameTable(
                name: "hematology_tariffs",
                newName: "hematology_tariff");

            migrationBuilder.RenameTable(
                name: "calculation_mo_coefficients",
                newName: "calculation_mo_coefficient");

            migrationBuilder.RenameIndex(
                name: "ix_v037_id",
                table: "v037",
                newName: "IX_v037_id");

            migrationBuilder.RenameIndex(
                name: "ix_v036_id",
                table: "v036",
                newName: "IX_v036_id");

            migrationBuilder.RenameIndex(
                name: "ix_v033_id",
                table: "v033",
                newName: "IX_v033_id");

            migrationBuilder.RenameIndex(
                name: "ix_v032_id",
                table: "v032",
                newName: "IX_v032_id");

            migrationBuilder.RenameIndex(
                name: "ix_v031_id",
                table: "v031",
                newName: "IX_v031_id");

            migrationBuilder.RenameIndex(
                name: "ix_v030_id",
                table: "v030",
                newName: "IX_v030_id");

            migrationBuilder.RenameIndex(
                name: "ix_v029_id",
                table: "v029",
                newName: "IX_v029_id");

            migrationBuilder.RenameIndex(
                name: "ix_v028_id",
                table: "v028",
                newName: "IX_v028_id");

            migrationBuilder.RenameIndex(
                name: "ix_v027_id",
                table: "v027",
                newName: "IX_v027_id");

            migrationBuilder.RenameIndex(
                name: "ix_v026_id",
                table: "v026",
                newName: "IX_v026_id");

            migrationBuilder.RenameIndex(
                name: "ix_v025_id",
                table: "v025",
                newName: "IX_v025_id");

            migrationBuilder.RenameIndex(
                name: "ix_v024_id",
                table: "v024",
                newName: "IX_v024_id");

            migrationBuilder.RenameIndex(
                name: "ix_v023_id",
                table: "v023",
                newName: "IX_v023_id");

            migrationBuilder.RenameIndex(
                name: "ix_v022_id",
                table: "v022",
                newName: "IX_v022_id");

            migrationBuilder.RenameIndex(
                name: "ix_v021_id",
                table: "v021",
                newName: "IX_v021_id");

            migrationBuilder.RenameIndex(
                name: "ix_v020_id",
                table: "v020",
                newName: "IX_v020_id");

            migrationBuilder.RenameIndex(
                name: "ix_v019_id",
                table: "v019",
                newName: "IX_v019_id");

            migrationBuilder.RenameIndex(
                name: "ix_v018_id",
                table: "v018",
                newName: "IX_v018_id");

            migrationBuilder.RenameIndex(
                name: "ix_v017_id",
                table: "v017",
                newName: "IX_v017_id");

            migrationBuilder.RenameIndex(
                name: "ix_v016_id",
                table: "v016",
                newName: "IX_v016_id");

            migrationBuilder.RenameIndex(
                name: "ix_v015_id",
                table: "v015",
                newName: "IX_v015_id");

            migrationBuilder.RenameIndex(
                name: "ix_v014_id",
                table: "v014",
                newName: "IX_v014_id");

            migrationBuilder.RenameIndex(
                name: "ix_v013_id",
                table: "v013",
                newName: "IX_v013_id");

            migrationBuilder.RenameIndex(
                name: "ix_v012_id",
                table: "v012",
                newName: "IX_v012_id");

            migrationBuilder.RenameIndex(
                name: "ix_v010_id",
                table: "v010",
                newName: "IX_v010_id");

            migrationBuilder.RenameIndex(
                name: "ix_v009_id",
                table: "v009",
                newName: "IX_v009_id");

            migrationBuilder.RenameIndex(
                name: "ix_v008_id",
                table: "v008",
                newName: "IX_v008_id");

            migrationBuilder.RenameIndex(
                name: "ix_v006_id",
                table: "v006",
                newName: "IX_v006_id");

            migrationBuilder.RenameIndex(
                name: "ix_v005_id",
                table: "v005",
                newName: "IX_v005_id");

            migrationBuilder.RenameIndex(
                name: "ix_v003_id",
                table: "v003",
                newName: "IX_v003_id");

            migrationBuilder.RenameIndex(
                name: "ix_v002_id",
                table: "v002",
                newName: "IX_v002_id");

            migrationBuilder.RenameIndex(
                name: "ix_uet_dentistry_calculation_id",
                table: "uet_dentistry_calculation",
                newName: "IX_uet_dentistry_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_regional_laboratory_studies_calculation_id",
                table: "regional_laboratory_studies_calculation",
                newName: "IX_regional_laboratory_studies_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_r014_id",
                table: "r014",
                newName: "IX_r014_id");

            migrationBuilder.RenameIndex(
                name: "ix_r013_id",
                table: "r013",
                newName: "IX_r013_id");

            migrationBuilder.RenameIndex(
                name: "ix_r012_id",
                table: "r012",
                newName: "IX_r012_id");

            migrationBuilder.RenameIndex(
                name: "ix_r011_id",
                table: "r011",
                newName: "IX_r011_id");

            migrationBuilder.RenameIndex(
                name: "ix_r010_id",
                table: "r010",
                newName: "IX_r010_id");

            migrationBuilder.RenameIndex(
                name: "ix_r009_id",
                table: "r009",
                newName: "IX_r009_id");

            migrationBuilder.RenameIndex(
                name: "ix_r008_id",
                table: "r008",
                newName: "IX_r008_id");

            migrationBuilder.RenameIndex(
                name: "ix_r007_id",
                table: "r007",
                newName: "IX_r007_id");

            migrationBuilder.RenameIndex(
                name: "ix_r006_id",
                table: "r006",
                newName: "IX_r006_id");

            migrationBuilder.RenameIndex(
                name: "ix_r005_id",
                table: "r005",
                newName: "IX_r005_id");

            migrationBuilder.RenameIndex(
                name: "ix_r004_id",
                table: "r004",
                newName: "IX_r004_id");

            migrationBuilder.RenameIndex(
                name: "ix_r003_id",
                table: "r003",
                newName: "IX_r003_id");

            migrationBuilder.RenameIndex(
                name: "ix_r002_id",
                table: "r002",
                newName: "IX_r002_id");

            migrationBuilder.RenameIndex(
                name: "ix_r001_id",
                table: "r001",
                newName: "IX_r001_id");

            migrationBuilder.RenameIndex(
                name: "ix_q023_id",
                table: "q023",
                newName: "IX_q023_id");

            migrationBuilder.RenameIndex(
                name: "ix_q022_id",
                table: "q022",
                newName: "IX_q022_id");

            migrationBuilder.RenameIndex(
                name: "ix_q021_id",
                table: "q021",
                newName: "IX_q021_id");

            migrationBuilder.RenameIndex(
                name: "ix_q020_id",
                table: "q020",
                newName: "IX_q020_id");

            migrationBuilder.RenameIndex(
                name: "ix_q019_id",
                table: "q019",
                newName: "IX_q019_id");

            migrationBuilder.RenameIndex(
                name: "ix_q018_id",
                table: "q018",
                newName: "IX_q018_id");

            migrationBuilder.RenameIndex(
                name: "ix_q017_id",
                table: "q017",
                newName: "IX_q017_id");

            migrationBuilder.RenameIndex(
                name: "ix_q016_id",
                table: "q016",
                newName: "IX_q016_id");

            migrationBuilder.RenameIndex(
                name: "ix_q015_id",
                table: "q015",
                newName: "IX_q015_id");

            migrationBuilder.RenameIndex(
                name: "ix_outpatient_tariff_calculation_id",
                table: "outpatient_tariff_calculation",
                newName: "IX_outpatient_tariff_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_o005_id",
                table: "o005",
                newName: "IX_o005_id");

            migrationBuilder.RenameIndex(
                name: "ix_o004_id",
                table: "o004",
                newName: "IX_o004_id");

            migrationBuilder.RenameIndex(
                name: "ix_o003_id",
                table: "o003",
                newName: "IX_o003_id");

            migrationBuilder.RenameIndex(
                name: "ix_o002_id",
                table: "o002",
                newName: "IX_o002_id");

            migrationBuilder.RenameIndex(
                name: "ix_o001_id",
                table: "o001",
                newName: "IX_o001_id");

            migrationBuilder.RenameIndex(
                name: "ix_n021_id",
                table: "n021",
                newName: "IX_n021_id");

            migrationBuilder.RenameIndex(
                name: "ix_n020_id",
                table: "n020",
                newName: "IX_n020_id");

            migrationBuilder.RenameIndex(
                name: "ix_n019_id",
                table: "n019",
                newName: "IX_n019_id");

            migrationBuilder.RenameIndex(
                name: "ix_n018_id",
                table: "n018",
                newName: "IX_n018_id");

            migrationBuilder.RenameIndex(
                name: "ix_n017_id",
                table: "n017",
                newName: "IX_n017_id");

            migrationBuilder.RenameIndex(
                name: "ix_n016_id",
                table: "n016",
                newName: "IX_n016_id");

            migrationBuilder.RenameIndex(
                name: "ix_n015_id",
                table: "n015",
                newName: "IX_n015_id");

            migrationBuilder.RenameIndex(
                name: "ix_n014_id",
                table: "n014",
                newName: "IX_n014_id");

            migrationBuilder.RenameIndex(
                name: "ix_n013_id",
                table: "n013",
                newName: "IX_n013_id");

            migrationBuilder.RenameIndex(
                name: "ix_n012_id",
                table: "n012",
                newName: "IX_n012_id");

            migrationBuilder.RenameIndex(
                name: "ix_n011_id",
                table: "n011",
                newName: "IX_n011_id");

            migrationBuilder.RenameIndex(
                name: "ix_n010_id",
                table: "n010",
                newName: "IX_n010_id");

            migrationBuilder.RenameIndex(
                name: "ix_n009_id",
                table: "n009",
                newName: "IX_n009_id");

            migrationBuilder.RenameIndex(
                name: "ix_n008_id",
                table: "n008",
                newName: "IX_n008_id");

            migrationBuilder.RenameIndex(
                name: "ix_n007_id",
                table: "n007",
                newName: "IX_n007_id");

            migrationBuilder.RenameIndex(
                name: "ix_n006_id",
                table: "n006",
                newName: "IX_n006_id");

            migrationBuilder.RenameIndex(
                name: "ix_n005_id",
                table: "n005",
                newName: "IX_n005_id");

            migrationBuilder.RenameIndex(
                name: "ix_n004_id",
                table: "n004",
                newName: "IX_n004_id");

            migrationBuilder.RenameIndex(
                name: "ix_n003_id",
                table: "n003",
                newName: "IX_n003_id");

            migrationBuilder.RenameIndex(
                name: "ix_n002_id",
                table: "n002",
                newName: "IX_n002_id");

            migrationBuilder.RenameIndex(
                name: "ix_n001_id",
                table: "n001",
                newName: "IX_n001_id");

            migrationBuilder.RenameIndex(
                name: "ix_mkb10_id",
                table: "mkb10",
                newName: "IX_mkb10_id");

            migrationBuilder.RenameIndex(
                name: "ix_ksg_grouper_id",
                table: "ksg_grouper",
                newName: "IX_ksg_grouper_id");

            migrationBuilder.RenameIndex(
                name: "ix_ksg_calculation_id",
                table: "ksg_calculation",
                newName: "IX_ksg_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_k004_id",
                table: "k004",
                newName: "IX_k004_id");

            migrationBuilder.RenameIndex(
                name: "ix_k003_id",
                table: "k003",
                newName: "IX_k003_id");

            migrationBuilder.RenameIndex(
                name: "ix_k002_id",
                table: "k002",
                newName: "IX_k002_id");

            migrationBuilder.RenameIndex(
                name: "ix_first_stage_adult_professional_examination_calculation_id",
                table: "first_stage_adult_professional_examination_calculation",
                newName: "IX_first_stage_adult_professional_examination_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_first_stage_adult_medical_examination_calculation_id",
                table: "first_stage_adult_medical_examination_calculation",
                newName: "IX_first_stage_adult_medical_examination_calculation_id");

            migrationBuilder.RenameIndex(
                name: "ix_first_stage_adult_medical_examination_by_service_count_calc",
                table: "first_stage_adult_medical_examination_by_service_count_calculation",
                newName: "IX_first_stage_adult_medical_examination_by_service_count_calc~");

            migrationBuilder.RenameIndex(
                name: "ix_f042_id",
                table: "f042",
                newName: "IX_f042_id");

            migrationBuilder.RenameIndex(
                name: "ix_f032_id",
                table: "f032",
                newName: "IX_f032_id");

            migrationBuilder.RenameIndex(
                name: "ix_f015_id",
                table: "f015",
                newName: "IX_f015_id");

            migrationBuilder.RenameIndex(
                name: "ix_f014_id",
                table: "f014",
                newName: "IX_f014_id");

            migrationBuilder.RenameIndex(
                name: "ix_f011_id",
                table: "f011",
                newName: "IX_f011_id");

            migrationBuilder.RenameIndex(
                name: "ix_f010_id",
                table: "f010",
                newName: "IX_f010_id");

            migrationBuilder.RenameIndex(
                name: "ix_f009_id",
                table: "f009",
                newName: "IX_f009_id");

            migrationBuilder.RenameIndex(
                name: "ix_f008_id",
                table: "f008",
                newName: "IX_f008_id");

            migrationBuilder.RenameIndex(
                name: "ix_f007_id",
                table: "f007",
                newName: "IX_f007_id");

            migrationBuilder.RenameIndex(
                name: "ix_f006_id",
                table: "f006",
                newName: "IX_f006_id");

            migrationBuilder.RenameIndex(
                name: "ix_f005_id",
                table: "f005",
                newName: "IX_f005_id");

            migrationBuilder.RenameIndex(
                name: "ix_f003_id",
                table: "f003",
                newName: "IX_f003_id");

            migrationBuilder.RenameIndex(
                name: "ix_f002_id",
                table: "f002",
                newName: "IX_f002_id");

            migrationBuilder.RenameIndex(
                name: "ix_f001_id",
                table: "f001",
                newName: "IX_f001_id");

            migrationBuilder.RenameIndex(
                name: "ix_service_templates_id",
                table: "service_template",
                newName: "IX_service_template_id");

            migrationBuilder.RenameIndex(
                name: "ix_regional_service_tariffs_id",
                table: "regional_service_tariff",
                newName: "IX_regional_service_tariff_id");

            migrationBuilder.RenameIndex(
                name: "ix_mobile_teams_medical_examination_coefficients_id",
                table: "mobile_teams_medical_examination_coefficient",
                newName: "IX_mobile_teams_medical_examination_coefficient_id");

            migrationBuilder.RenameIndex(
                name: "ix_management_ksg_coefficients_id",
                table: "management_ksg_coefficient",
                newName: "IX_management_ksg_coefficient_id");

            migrationBuilder.RenameIndex(
                name: "ix_ksg_base_rates_id",
                table: "ksg_base_rate",
                newName: "IX_ksg_base_rate_id");

            migrationBuilder.RenameIndex(
                name: "ix_high_tech_medical_care_tariffs_id",
                table: "high_tech_medical_care_tariff",
                newName: "IX_high_tech_medical_care_tariff_id");

            migrationBuilder.RenameIndex(
                name: "ix_hematology_tariffs_id",
                table: "hematology_tariff",
                newName: "IX_hematology_tariff_id");

            migrationBuilder.RenameIndex(
                name: "ix_calculation_mo_coefficients_id",
                table: "calculation_mo_coefficient",
                newName: "IX_calculation_mo_coefficient_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v037",
                table: "v037",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v036",
                table: "v036",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v033",
                table: "v033",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v032",
                table: "v032",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v031",
                table: "v031",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v030",
                table: "v030",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v029",
                table: "v029",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v028",
                table: "v028",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v027",
                table: "v027",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v026",
                table: "v026",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v025",
                table: "v025",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v024",
                table: "v024",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v023",
                table: "v023",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v022",
                table: "v022",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v021",
                table: "v021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v020",
                table: "v020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v019",
                table: "v019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v018",
                table: "v018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v017",
                table: "v017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v016",
                table: "v016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v015",
                table: "v015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v014",
                table: "v014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v013",
                table: "v013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v012",
                table: "v012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v010",
                table: "v010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v009",
                table: "v009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v008",
                table: "v008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v006",
                table: "v006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v005",
                table: "v005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v003",
                table: "v003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_v002",
                table: "v002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_uet_dentistry_calculation",
                table: "uet_dentistry_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_regional_laboratory_studies_calculation",
                table: "regional_laboratory_studies_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r014",
                table: "r014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r013",
                table: "r013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r012",
                table: "r012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r011",
                table: "r011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r010",
                table: "r010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r009",
                table: "r009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r008",
                table: "r008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r007",
                table: "r007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r006",
                table: "r006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r005",
                table: "r005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r004",
                table: "r004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r003",
                table: "r003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r002",
                table: "r002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_r001",
                table: "r001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q023",
                table: "q023",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q022",
                table: "q022",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q021",
                table: "q021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q020",
                table: "q020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q019",
                table: "q019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q018",
                table: "q018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q017",
                table: "q017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q016",
                table: "q016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_q015",
                table: "q015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_outpatient_tariff_calculation",
                table: "outpatient_tariff_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_o005",
                table: "o005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_o004",
                table: "o004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_o003",
                table: "o003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_o002",
                table: "o002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_o001",
                table: "o001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n021",
                table: "n021",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n020",
                table: "n020",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n019",
                table: "n019",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n018",
                table: "n018",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n017",
                table: "n017",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n016",
                table: "n016",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n015",
                table: "n015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n014",
                table: "n014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n013",
                table: "n013",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n012",
                table: "n012",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n011",
                table: "n011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n010",
                table: "n010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n009",
                table: "n009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n008",
                table: "n008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n007",
                table: "n007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n006",
                table: "n006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n005",
                table: "n005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n004",
                table: "n004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n003",
                table: "n003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n002",
                table: "n002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_n001",
                table: "n001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mkb10",
                table: "mkb10",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ksg_grouper",
                table: "ksg_grouper",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ksg_calculation",
                table: "ksg_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_k004",
                table: "k004",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_k003",
                table: "k003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_k002",
                table: "k002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_first_stage_adult_professional_examination_calculation",
                table: "first_stage_adult_professional_examination_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_first_stage_adult_medical_examination_calculation",
                table: "first_stage_adult_medical_examination_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_first_stage_adult_medical_examination_by_service_count_calc~",
                table: "first_stage_adult_medical_examination_by_service_count_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f042",
                table: "f042",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f032",
                table: "f032",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f015",
                table: "f015",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f014",
                table: "f014",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f011",
                table: "f011",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f010",
                table: "f010",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f009",
                table: "f009",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f008",
                table: "f008",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f007",
                table: "f007",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f006",
                table: "f006",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f005",
                table: "f005",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f003",
                table: "f003",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f002",
                table: "f002",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_f001",
                table: "f001",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_service_template",
                table: "service_template",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_regional_service_tariff",
                table: "regional_service_tariff",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mobile_teams_medical_examination_coefficient",
                table: "mobile_teams_medical_examination_coefficient",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_management_ksg_coefficient",
                table: "management_ksg_coefficient",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ksg_base_rate",
                table: "ksg_base_rate",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_high_tech_medical_care_tariff",
                table: "high_tech_medical_care_tariff",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hematology_tariff",
                table: "hematology_tariff",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_calculation_mo_coefficient",
                table: "calculation_mo_coefficient",
                column: "id");
        }
    }
}
