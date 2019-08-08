﻿// <auto-generated />
using System;
using Class52.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Class52.Migrations
{
    [DbContext(typeof(BootCampDbContext))]
    [Migration("20190806004752_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Class52.Models.Coworker", b =>
                {
                    b.Property<int>("CoworkerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.HasKey("CoworkerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Coworker");
                });

            modelBuilder.Entity("Class52.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NameEmployeeNameId");

                    b.Property<string>("Nickname");

                    b.HasKey("EmployeeId");

                    b.HasIndex("NameEmployeeNameId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Class52.Models.EmployeeName", b =>
                {
                    b.Property<int>("EmployeeNameId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeNameId");

                    b.ToTable("EmployeeName");
                });

            modelBuilder.Entity("Class52.Models.Coworker", b =>
                {
                    b.HasOne("Class52.Models.Employee", "Employee")
                        .WithMany("Coworkers")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Class52.Models.Employee", b =>
                {
                    b.HasOne("Class52.Models.EmployeeName", "Name")
                        .WithMany()
                        .HasForeignKey("NameEmployeeNameId");
                });
#pragma warning restore 612, 618
        }
    }
}