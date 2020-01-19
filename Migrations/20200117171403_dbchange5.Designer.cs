﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using terminus_webapp.Data;

namespace terminus_webapp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200117171403_dbchange5")]
    partial class dbchange5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("terminus.shared.models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("terminus.shared.models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("companyId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("terminus.shared.models.CheckDetails", b =>
                {
                    b.Property<Guid>("checkDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("bankName")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("branch")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime>("checkDate")
                        .HasColumnType("datetime2");

                    b.HasKey("checkDetailId");

                    b.ToTable("CheckDetails");
                });

            modelBuilder.Entity("terminus.shared.models.Company", b =>
                {
                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("companyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("terminus.shared.models.Expense", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("cashOrCheck")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<Guid?>("checkDetailscheckDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("reference")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("accountId");

                    b.HasIndex("checkDetailscheckDetailId");

                    b.HasIndex("companyId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("terminus.shared.models.GLAccount", b =>
                {
                    b.Property<Guid>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("accountCode")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("accountDesc")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<decimal>("balance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("cashAccount")
                        .HasColumnType("bit");

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("expense")
                        .HasColumnType("bit");

                    b.Property<bool>("outputVatAccount")
                        .HasColumnType("bit");

                    b.Property<bool>("revenue")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("accountId");

                    b.HasIndex("companyId");

                    b.ToTable("GLAccounts");
                });

            modelBuilder.Entity("terminus.shared.models.JournalEntryDtl", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<Guid?>("JournalEntryHdrid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(14,4)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("lineNumber")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("JournalEntryHdrid");

                    b.HasIndex("accountId");

                    b.ToTable("JournalEntriesDtl");
                });

            modelBuilder.Entity("terminus.shared.models.JournalEntryHdr", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.ToTable("JournalEntriesHdr");
                });

            modelBuilder.Entity("terminus.shared.models.Owner", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("contactNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("emailAddress")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("terminus.shared.models.Property", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("terminus.shared.models.PropertyDirectory", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("propertyid")
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("tenantid")
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.HasIndex("propertyid");

                    b.HasIndex("tenantid");

                    b.ToTable("PropertyDirectory");
                });

            modelBuilder.Entity("terminus.shared.models.Revenue", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid?>("cashAccountaccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cashOrCheck")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<Guid?>("checkDetailscheckDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("dueDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("journalEntryid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("propertyDirectoryid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("receiptNo")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("reference")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<decimal>("taxAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("accountId");

                    b.HasIndex("cashAccountaccountId");

                    b.HasIndex("checkDetailscheckDetailId");

                    b.HasIndex("companyId");

                    b.HasIndex("journalEntryid");

                    b.HasIndex("propertyDirectoryid");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("terminus.shared.models.Tenant", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("companyId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("contactNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("emailAddress")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("terminus.shared.models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("terminus.shared.models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("terminus.shared.models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("terminus.shared.models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("terminus.shared.models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("terminus.shared.models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("terminus.shared.models.AppUser", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.Expense", b =>
                {
                    b.HasOne("terminus.shared.models.GLAccount", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("terminus.shared.models.CheckDetails", "checkDetails")
                        .WithMany()
                        .HasForeignKey("checkDetailscheckDetailId");

                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.GLAccount", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.JournalEntryDtl", b =>
                {
                    b.HasOne("terminus.shared.models.JournalEntryHdr", null)
                        .WithMany("JournalDetails")
                        .HasForeignKey("JournalEntryHdrid");

                    b.HasOne("terminus.shared.models.GLAccount", "account")
                        .WithMany()
                        .HasForeignKey("accountId");
                });

            modelBuilder.Entity("terminus.shared.models.JournalEntryHdr", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.Owner", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.Property", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });

            modelBuilder.Entity("terminus.shared.models.PropertyDirectory", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");

                    b.HasOne("terminus.shared.models.Property", "property")
                        .WithMany()
                        .HasForeignKey("propertyid");

                    b.HasOne("terminus.shared.models.Tenant", "tenant")
                        .WithMany()
                        .HasForeignKey("tenantid");
                });

            modelBuilder.Entity("terminus.shared.models.Revenue", b =>
                {
                    b.HasOne("terminus.shared.models.GLAccount", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("terminus.shared.models.GLAccount", "cashAccount")
                        .WithMany()
                        .HasForeignKey("cashAccountaccountId");

                    b.HasOne("terminus.shared.models.CheckDetails", "checkDetails")
                        .WithMany()
                        .HasForeignKey("checkDetailscheckDetailId");

                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");

                    b.HasOne("terminus.shared.models.JournalEntryHdr", "journalEntry")
                        .WithMany()
                        .HasForeignKey("journalEntryid");

                    b.HasOne("terminus.shared.models.PropertyDirectory", "propertyDirectory")
                        .WithMany()
                        .HasForeignKey("propertyDirectoryid");
                });

            modelBuilder.Entity("terminus.shared.models.Tenant", b =>
                {
                    b.HasOne("terminus.shared.models.Company", "company")
                        .WithMany()
                        .HasForeignKey("companyId");
                });
#pragma warning restore 612, 618
        }
    }
}
