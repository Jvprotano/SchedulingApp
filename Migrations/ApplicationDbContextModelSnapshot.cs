﻿// <auto-generated />
using System;
using AppAgendamentos.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppAgendamentos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
***REMOVED***protected override void BuildModel(ModelBuilder modelBuilder)
***REMOVED***{
#pragma warning disable 612, 618
***REMOVED***    modelBuilder
***REMOVED******REMOVED***.HasAnnotation("ProductVersion", "7.0.3")
***REMOVED******REMOVED***.HasAnnotation("Relational:MaxIdentifierLength", 128);

***REMOVED***    SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.Category", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<string>("Name")
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("name");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.ToTable("categories");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.Company", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<string>("CNPJ")
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("cnpj");

***REMOVED******REMOVED***    b.Property<string>("Description")
***REMOVED******REMOVED******REMOVED***.IsRequired()
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("description");

***REMOVED******REMOVED***    b.Property<string>("Image")
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("image");

***REMOVED******REMOVED***    b.Property<string>("Name")
***REMOVED******REMOVED******REMOVED***.IsRequired()
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("name");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.ToTable("companies");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.CompanyOpeningHours", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<TimeSpan>("ClosingHour")
***REMOVED******REMOVED******REMOVED***.HasColumnType("time")
***REMOVED******REMOVED******REMOVED***.HasColumnName("closing_hour");

***REMOVED******REMOVED***    b.Property<int>("CompanyId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("company_id");

***REMOVED******REMOVED***    b.Property<int>("DayOfWeek")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("day_of_week");

***REMOVED******REMOVED***    b.Property<TimeSpan>("OpeningHour")
***REMOVED******REMOVED******REMOVED***.HasColumnType("time")
***REMOVED******REMOVED******REMOVED***.HasColumnName("opening_hour");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.HasIndex("CompanyId");

***REMOVED******REMOVED***    b.ToTable("company_opening_hours");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.CompanyOwners", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<int>("CompanyId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("company_id");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.Property<int>("UserId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("user_id");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.HasIndex("CompanyId");

***REMOVED******REMOVED***    b.HasIndex("UserId");

***REMOVED******REMOVED***    b.ToTable("company_owners");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.Scheduling", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<int>("CompanyId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("company_id");

***REMOVED******REMOVED***    b.Property<int>("CustomerId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("customer_id");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<DateTime>("ScheduledDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("scheduled_date");

***REMOVED******REMOVED***    b.Property<int>("ServicesOfferedId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("services_offered_id");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.HasIndex("CompanyId");

***REMOVED******REMOVED***    b.HasIndex("CustomerId");

***REMOVED******REMOVED***    b.HasIndex("ServicesOfferedId");

***REMOVED******REMOVED***    b.ToTable("schedulings");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.ServicesOffered", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<int>("CompanyId")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("company_id");

***REMOVED******REMOVED***    b.Property<TimeSpan>("Duration")
***REMOVED******REMOVED******REMOVED***.HasColumnType("time")
***REMOVED******REMOVED******REMOVED***.HasColumnName("duration");

***REMOVED******REMOVED***    b.Property<string>("Name")
***REMOVED******REMOVED******REMOVED***.IsRequired()
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("name");

***REMOVED******REMOVED***    b.Property<float>("Price")
***REMOVED******REMOVED******REMOVED***.HasColumnType("real")
***REMOVED******REMOVED******REMOVED***.HasColumnName("price");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.HasIndex("CompanyId");

***REMOVED******REMOVED***    b.ToTable("services_offered");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.User", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Property<int>("Id")
***REMOVED******REMOVED******REMOVED***.ValueGeneratedOnAdd()
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("id");

***REMOVED******REMOVED***    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

***REMOVED******REMOVED***    b.Property<DateTime>("BirthDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("birth_date");

***REMOVED******REMOVED***    b.Property<string>("Name")
***REMOVED******REMOVED******REMOVED***.IsRequired()
***REMOVED******REMOVED******REMOVED***.HasColumnType("nvarchar(max)")
***REMOVED******REMOVED******REMOVED***.HasColumnName("name");

***REMOVED******REMOVED***    b.Property<DateTime>("RegisterDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("register_date");

***REMOVED******REMOVED***    b.Property<int>("Status")
***REMOVED******REMOVED******REMOVED***.HasColumnType("int")
***REMOVED******REMOVED******REMOVED***.HasColumnName("status");

***REMOVED******REMOVED***    b.Property<DateTime>("UpdateDate")
***REMOVED******REMOVED******REMOVED***.HasColumnType("datetime2")
***REMOVED******REMOVED******REMOVED***.HasColumnName("update_date");

***REMOVED******REMOVED***    b.HasKey("Id");

***REMOVED******REMOVED***    b.ToTable("users");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.CompanyOpeningHours", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.Company", "Company")
***REMOVED******REMOVED******REMOVED***.WithMany()
***REMOVED******REMOVED******REMOVED***.HasForeignKey("CompanyId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.Navigation("Company");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.CompanyOwners", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.Company", "Company")
***REMOVED******REMOVED******REMOVED***.WithMany()
***REMOVED******REMOVED******REMOVED***.HasForeignKey("CompanyId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.User", "User")
***REMOVED******REMOVED******REMOVED***.WithMany("Companies")
***REMOVED******REMOVED******REMOVED***.HasForeignKey("UserId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.Navigation("Company");

***REMOVED******REMOVED***    b.Navigation("User");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.Scheduling", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.Company", "Company")
***REMOVED******REMOVED******REMOVED***.WithMany()
***REMOVED******REMOVED******REMOVED***.HasForeignKey("CompanyId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.User", "Customer")
***REMOVED******REMOVED******REMOVED***.WithMany()
***REMOVED******REMOVED******REMOVED***.HasForeignKey("CustomerId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.ServicesOffered", "ServicesOffered")
***REMOVED******REMOVED******REMOVED***.WithMany()
***REMOVED******REMOVED******REMOVED***.HasForeignKey("ServicesOfferedId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.Navigation("Company");

***REMOVED******REMOVED***    b.Navigation("Customer");

***REMOVED******REMOVED***    b.Navigation("ServicesOffered");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.ServicesOffered", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.HasOne("AppAgendamentos.Models.Company", "Company")
***REMOVED******REMOVED******REMOVED***.WithMany("ServicesOffered")
***REMOVED******REMOVED******REMOVED***.HasForeignKey("CompanyId")
***REMOVED******REMOVED******REMOVED***.OnDelete(DeleteBehavior.Cascade)
***REMOVED******REMOVED******REMOVED***.IsRequired();

***REMOVED******REMOVED***    b.Navigation("Company");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.Company", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Navigation("ServicesOffered");
***REMOVED******REMOVED***});

***REMOVED***    modelBuilder.Entity("AppAgendamentos.Models.User", b =>
***REMOVED******REMOVED***{
***REMOVED******REMOVED***    b.Navigation("Companies");
***REMOVED******REMOVED***});
#pragma warning restore 612, 618
***REMOVED***}
    }
}
