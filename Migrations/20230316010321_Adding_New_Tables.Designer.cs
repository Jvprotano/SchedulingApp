﻿// <auto-generated />
using System;
using AppAgendamentos.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppAgendamentos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230316010321_Adding_New_Tables")]
    partial class Adding_New_Tables
    {
/// <inheritdoc />
protected override void BuildTargetModel(ModelBuilder modelBuilder)
{
#pragma warning disable 612, 618
    modelBuilder
.HasAnnotation("ProductVersion", "7.0.3")
.HasAnnotation("Relational:MaxIdentifierLength", 128);

    SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

    modelBuilder.Entity("AppAgendamentos.Models.Category", b =>
{
    b.Property<int>("Id")
.ValueGeneratedOnAdd()
.HasColumnType("int")
.HasColumnName("id");

    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

    b.Property<string>("Name")
.HasColumnType("nvarchar(max)")
.HasColumnName("name");

    b.Property<DateTime>("RegisterDate")
.HasColumnType("datetime2")
.HasColumnName("register_date");

    b.Property<int>("Status")
.HasColumnType("int")
.HasColumnName("status");

    b.Property<DateTime>("UpdateDate")
.HasColumnType("datetime2")
.HasColumnName("update_date");

    b.HasKey("Id");

    b.ToTable("categories");
});

    modelBuilder.Entity("AppAgendamentos.Models.Company", b =>
{
    b.Property<int>("Id")
.ValueGeneratedOnAdd()
.HasColumnType("int")
.HasColumnName("id");

    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

    b.Property<string>("CNPJ")
.HasColumnType("nvarchar(max)")
.HasColumnName("c_n_p_j");

    b.Property<string>("Description")
.IsRequired()
.HasColumnType("nvarchar(max)")
.HasColumnName("description");

    b.Property<string>("Name")
.IsRequired()
.HasColumnType("nvarchar(max)")
.HasColumnName("name");

    b.Property<DateTime>("RegisterDate")
.HasColumnType("datetime2")
.HasColumnName("register_date");

    b.Property<int>("Status")
.HasColumnType("int")
.HasColumnName("status");

    b.Property<DateTime>("UpdateDate")
.HasColumnType("datetime2")
.HasColumnName("update_date");

    b.HasKey("Id");

    b.ToTable("companies");
});

    modelBuilder.Entity("AppAgendamentos.Models.CompanyOwners", b =>
{
    b.Property<int>("Id")
.ValueGeneratedOnAdd()
.HasColumnType("int")
.HasColumnName("id");

    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

    b.Property<int>("CompanyId")
.HasColumnType("int")
.HasColumnName("company_id");

    b.Property<DateTime>("RegisterDate")
.HasColumnType("datetime2")
.HasColumnName("register_date");

    b.Property<int>("Status")
.HasColumnType("int")
.HasColumnName("status");

    b.Property<DateTime>("UpdateDate")
.HasColumnType("datetime2")
.HasColumnName("update_date");

    b.Property<int>("UserId")
.HasColumnType("int")
.HasColumnName("user_id");

    b.HasKey("Id");

    b.HasIndex("CompanyId");

    b.HasIndex("UserId");

    b.ToTable("company_owners");
});

    modelBuilder.Entity("AppAgendamentos.Models.ServicesOffered", b =>
{
    b.Property<int>("Id")
.ValueGeneratedOnAdd()
.HasColumnType("int")
.HasColumnName("id");

    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

    b.Property<int>("CompanyId")
.HasColumnType("int")
.HasColumnName("company_id");

    b.Property<string>("Name")
.IsRequired()
.HasColumnType("nvarchar(max)")
.HasColumnName("name");

    b.Property<float>("Price")
.HasColumnType("real")
.HasColumnName("price");

    b.Property<DateTime>("RegisterDate")
.HasColumnType("datetime2")
.HasColumnName("register_date");

    b.Property<int>("Status")
.HasColumnType("int")
.HasColumnName("status");

    b.Property<DateTime>("UpdateDate")
.HasColumnType("datetime2")
.HasColumnName("update_date");

    b.HasKey("Id");

    b.ToTable("services_offered");
});

    modelBuilder.Entity("AppAgendamentos.Models.User", b =>
{
    b.Property<int>("Id")
.ValueGeneratedOnAdd()
.HasColumnType("int")
.HasColumnName("id");

    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

    b.Property<DateTime>("BirthDate")
.HasColumnType("datetime2")
.HasColumnName("birth_date");

    b.Property<string>("Name")
.IsRequired()
.HasColumnType("nvarchar(max)")
.HasColumnName("name");

    b.Property<DateTime>("RegisterDate")
.HasColumnType("datetime2")
.HasColumnName("register_date");

    b.Property<int>("Status")
.HasColumnType("int")
.HasColumnName("status");

    b.Property<DateTime>("UpdateDate")
.HasColumnType("datetime2")
.HasColumnName("update_date");

    b.HasKey("Id");

    b.ToTable("users");
});

    modelBuilder.Entity("AppAgendamentos.Models.CompanyOwners", b =>
{
    b.HasOne("AppAgendamentos.Models.Company", "Company")
.WithMany()
.HasForeignKey("CompanyId")
.OnDelete(DeleteBehavior.Cascade)
.IsRequired();

    b.HasOne("AppAgendamentos.Models.User", "User")
.WithMany("Companies")
.HasForeignKey("UserId")
.OnDelete(DeleteBehavior.Cascade)
.IsRequired();

    b.Navigation("Company");

    b.Navigation("User");
});

    modelBuilder.Entity("AppAgendamentos.Models.User", b =>
{
    b.Navigation("Companies");
});
#pragma warning restore 612, 618
}
    }
}
