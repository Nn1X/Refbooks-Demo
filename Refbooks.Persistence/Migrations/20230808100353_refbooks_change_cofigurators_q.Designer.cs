﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Refbooks.Persistence;

#nullable disable

namespace Refbooks.Persistence.Migrations
{
    [DbContext(typeof(RefbooksDbContext))]
    [Migration("20230808100353_refbooks_change_cofigurators_q")]
    partial class refbooks_change_cofigurators_q
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F005", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f005", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F006", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f006", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F007", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f007", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F008", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f008", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F009", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f009", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F010", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<int?>("FederalDistrictCode")
                        .HasColumnType("integer")
                        .HasColumnName("federal_district_code");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Okato")
                        .HasColumnType("text")
                        .HasColumnName("okato");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f010", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F011", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("DocumentNumberMask")
                        .HasColumnType("text")
                        .HasColumnName("document_number_mask");

                    b.Property<string>("DocumentSerialMask")
                        .HasColumnType("text")
                        .HasColumnName("document_serial_mask");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f011", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F014", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<int?>("CodeReserveField")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("PenaltyCoefficient")
                        .HasColumnType("numeric");

                    b.Property<string>("PgFormCode")
                        .HasColumnType("text");

                    b.Property<string>("RefusalReason")
                        .HasColumnType("text");

                    b.Property<decimal?>("SanctionCoefficient")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("F014");
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F015", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f015", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F032", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<DateTime?>("ExclussionDate")
                        .HasColumnType("date")
                        .HasColumnName("exclussion_date");

                    b.Property<int?>("ExclussionReasonCode")
                        .HasColumnType("integer")
                        .HasColumnName("exclussion_reason_code");

                    b.Property<DateTime?>("InclussionDate")
                        .HasColumnType("date")
                        .HasColumnName("inclussion_date");

                    b.Property<string>("Oktmo")
                        .HasColumnType("text")
                        .HasColumnName("oktmo");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("text")
                        .HasColumnName("registration_number");

                    b.Property<string>("SubjectName")
                        .HasColumnType("text")
                        .HasColumnName("subject_name");

                    b.Property<string>("Uid")
                        .HasColumnType("text")
                        .HasColumnName("uid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f032", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.FRefbooks.F042", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CasesEkmpNumber")
                        .HasColumnType("integer")
                        .HasColumnName("cases_ekmp_number");

                    b.Property<string>("Code")
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<int?>("ConductedEkmpNumber")
                        .HasColumnType("integer")
                        .HasColumnName("conducted_ekmp_number");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<DateTime?>("ExclussionDate")
                        .HasColumnType("date")
                        .HasColumnName("exclussion_date");

                    b.Property<int?>("ExclussionReasonCode")
                        .HasColumnType("integer")
                        .HasColumnName("exclussion_reason_code");

                    b.Property<DateTime?>("InclussionDate")
                        .HasColumnType("date")
                        .HasColumnName("inclussion_date");

                    b.Property<int?>("MoEkmpNumber")
                        .HasColumnType("integer")
                        .HasColumnName("mo_ekmp_number");

                    b.Property<string>("Oktmo")
                        .HasColumnType("text")
                        .HasColumnName("oktmo");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("text")
                        .HasColumnName("registration_number");

                    b.Property<string>("SubjectName")
                        .HasColumnType("text")
                        .HasColumnName("subject_name");

                    b.Property<string>("Uid")
                        .HasColumnType("text")
                        .HasColumnName("uid");

                    b.Property<int?>("UnreasonableEkmpNumber")
                        .HasColumnType("integer")
                        .HasColumnName("unreasonable_ekmp_number");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("f042", (string)null);
                });

            modelBuilder.Entity("Refbooks.Domain.NRefbooks.N001", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Code")
                        .HasColumnType("integer")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateBegin")
                        .HasColumnType("date")
                        .HasColumnName("date_begin");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("date_end");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("n001", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
