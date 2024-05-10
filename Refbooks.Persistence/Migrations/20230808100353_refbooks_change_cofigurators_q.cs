using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    public partial class refbooks_change_cofigurators_q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_F042",
                table: "F042");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F032",
                table: "F032");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F015",
                table: "F015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F011",
                table: "F011");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F010",
                table: "F010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F009",
                table: "F009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F008",
                table: "F008");

            migrationBuilder.RenameTable(
                name: "F042",
                newName: "f042");

            migrationBuilder.RenameTable(
                name: "F032",
                newName: "f032");

            migrationBuilder.RenameTable(
                name: "F015",
                newName: "f015");

            migrationBuilder.RenameTable(
                name: "F011",
                newName: "f011");

            migrationBuilder.RenameTable(
                name: "F010",
                newName: "f010");

            migrationBuilder.RenameTable(
                name: "F009",
                newName: "f009");

            migrationBuilder.RenameTable(
                name: "F008",
                newName: "f008");

            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "f042",
                newName: "uid");

            migrationBuilder.RenameColumn(
                name: "Oktmo",
                table: "f042",
                newName: "oktmo");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f042",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f042",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UnreasonableEkmpNumber",
                table: "f042",
                newName: "unreasonable_ekmp_number");

            migrationBuilder.RenameColumn(
                name: "SubjectName",
                table: "f042",
                newName: "subject_name");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "f042",
                newName: "registration_number");

            migrationBuilder.RenameColumn(
                name: "MoEkmpNumber",
                table: "f042",
                newName: "mo_ekmp_number");

            migrationBuilder.RenameColumn(
                name: "InclussionDate",
                table: "f042",
                newName: "inclussion_date");

            migrationBuilder.RenameColumn(
                name: "ExclussionReasonCode",
                table: "f042",
                newName: "exclussion_reason_code");

            migrationBuilder.RenameColumn(
                name: "ExclussionDate",
                table: "f042",
                newName: "exclussion_date");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f042",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f042",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "ConductedEkmpNumber",
                table: "f042",
                newName: "conducted_ekmp_number");

            migrationBuilder.RenameColumn(
                name: "CasesEkmpNumber",
                table: "f042",
                newName: "cases_ekmp_number");

            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "f032",
                newName: "uid");

            migrationBuilder.RenameColumn(
                name: "Oktmo",
                table: "f032",
                newName: "oktmo");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f032",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f032",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubjectName",
                table: "f032",
                newName: "subject_name");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "f032",
                newName: "registration_number");

            migrationBuilder.RenameColumn(
                name: "InclussionDate",
                table: "f032",
                newName: "inclussion_date");

            migrationBuilder.RenameColumn(
                name: "ExclussionReasonCode",
                table: "f032",
                newName: "exclussion_reason_code");

            migrationBuilder.RenameColumn(
                name: "ExclussionDate",
                table: "f032",
                newName: "exclussion_date");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f032",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f032",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f015",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f015",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f015",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f015",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f015",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f011",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f011",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f011",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DocumentSerialMask",
                table: "f011",
                newName: "document_serial_mask");

            migrationBuilder.RenameColumn(
                name: "DocumentNumberMask",
                table: "f011",
                newName: "document_number_mask");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f011",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f011",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "Okato",
                table: "f010",
                newName: "okato");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f010",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f010",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f010",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FederalDistrictCode",
                table: "f010",
                newName: "federal_district_code");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f010",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f010",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f009",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f009",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f009",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f009",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f009",
                newName: "date_begin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "f008",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "f008",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "f008",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "f008",
                newName: "date_end");

            migrationBuilder.RenameColumn(
                name: "DateBegin",
                table: "f008",
                newName: "date_begin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "inclussion_date",
                table: "f042",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "exclussion_date",
                table: "f042",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f042",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f042",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "inclussion_date",
                table: "f032",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "exclussion_date",
                table: "f032",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f032",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f032",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f015",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f015",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f011",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f011",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f010",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f010",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f009",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f009",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_end",
                table: "f008",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_begin",
                table: "f008",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_f042_id",
                table: "f042",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f032_id",
                table: "f032",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f015_id",
                table: "f015",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f011_id",
                table: "f011",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f010_id",
                table: "f010",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f009_id",
                table: "f009",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_f008_id",
                table: "f008",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_f042",
                table: "f042");

            migrationBuilder.DropIndex(
                name: "IX_f042_id",
                table: "f042");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f032",
                table: "f032");

            migrationBuilder.DropIndex(
                name: "IX_f032_id",
                table: "f032");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f015",
                table: "f015");

            migrationBuilder.DropIndex(
                name: "IX_f015_id",
                table: "f015");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f011",
                table: "f011");

            migrationBuilder.DropIndex(
                name: "IX_f011_id",
                table: "f011");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f010",
                table: "f010");

            migrationBuilder.DropIndex(
                name: "IX_f010_id",
                table: "f010");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f009",
                table: "f009");

            migrationBuilder.DropIndex(
                name: "IX_f009_id",
                table: "f009");

            migrationBuilder.DropPrimaryKey(
                name: "PK_f008",
                table: "f008");

            migrationBuilder.DropIndex(
                name: "IX_f008_id",
                table: "f008");

            migrationBuilder.RenameTable(
                name: "f042",
                newName: "F042");

            migrationBuilder.RenameTable(
                name: "f032",
                newName: "F032");

            migrationBuilder.RenameTable(
                name: "f015",
                newName: "F015");

            migrationBuilder.RenameTable(
                name: "f011",
                newName: "F011");

            migrationBuilder.RenameTable(
                name: "f010",
                newName: "F010");

            migrationBuilder.RenameTable(
                name: "f009",
                newName: "F009");

            migrationBuilder.RenameTable(
                name: "f008",
                newName: "F008");

            migrationBuilder.RenameColumn(
                name: "uid",
                table: "F042",
                newName: "Uid");

            migrationBuilder.RenameColumn(
                name: "oktmo",
                table: "F042",
                newName: "Oktmo");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F042",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F042",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "unreasonable_ekmp_number",
                table: "F042",
                newName: "UnreasonableEkmpNumber");

            migrationBuilder.RenameColumn(
                name: "subject_name",
                table: "F042",
                newName: "SubjectName");

            migrationBuilder.RenameColumn(
                name: "registration_number",
                table: "F042",
                newName: "RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "mo_ekmp_number",
                table: "F042",
                newName: "MoEkmpNumber");

            migrationBuilder.RenameColumn(
                name: "inclussion_date",
                table: "F042",
                newName: "InclussionDate");

            migrationBuilder.RenameColumn(
                name: "exclussion_reason_code",
                table: "F042",
                newName: "ExclussionReasonCode");

            migrationBuilder.RenameColumn(
                name: "exclussion_date",
                table: "F042",
                newName: "ExclussionDate");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F042",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F042",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "conducted_ekmp_number",
                table: "F042",
                newName: "ConductedEkmpNumber");

            migrationBuilder.RenameColumn(
                name: "cases_ekmp_number",
                table: "F042",
                newName: "CasesEkmpNumber");

            migrationBuilder.RenameColumn(
                name: "uid",
                table: "F032",
                newName: "Uid");

            migrationBuilder.RenameColumn(
                name: "oktmo",
                table: "F032",
                newName: "Oktmo");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F032",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F032",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subject_name",
                table: "F032",
                newName: "SubjectName");

            migrationBuilder.RenameColumn(
                name: "registration_number",
                table: "F032",
                newName: "RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "inclussion_date",
                table: "F032",
                newName: "InclussionDate");

            migrationBuilder.RenameColumn(
                name: "exclussion_reason_code",
                table: "F032",
                newName: "ExclussionReasonCode");

            migrationBuilder.RenameColumn(
                name: "exclussion_date",
                table: "F032",
                newName: "ExclussionDate");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F032",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F032",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F015",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F015",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F015",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F015",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F015",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F011",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F011",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F011",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "document_serial_mask",
                table: "F011",
                newName: "DocumentSerialMask");

            migrationBuilder.RenameColumn(
                name: "document_number_mask",
                table: "F011",
                newName: "DocumentNumberMask");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F011",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F011",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "okato",
                table: "F010",
                newName: "Okato");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F010",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F010",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F010",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "federal_district_code",
                table: "F010",
                newName: "FederalDistrictCode");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F010",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F010",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F009",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F009",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F009",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F009",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F009",
                newName: "DateBegin");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "F008",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "F008",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "F008",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "date_end",
                table: "F008",
                newName: "DateEnd");

            migrationBuilder.RenameColumn(
                name: "date_begin",
                table: "F008",
                newName: "DateBegin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InclussionDate",
                table: "F042",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExclussionDate",
                table: "F042",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F042",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F042",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InclussionDate",
                table: "F032",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExclussionDate",
                table: "F032",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F032",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F032",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F015",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F015",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F011",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F011",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F010",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F010",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F009",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F009",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "F008",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBegin",
                table: "F008",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_F042",
                table: "F042",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F032",
                table: "F032",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F015",
                table: "F015",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F011",
                table: "F011",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F010",
                table: "F010",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F009",
                table: "F009",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F008",
                table: "F008",
                column: "Id");
        }
    }
}
