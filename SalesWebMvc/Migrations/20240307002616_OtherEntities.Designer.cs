﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc.Data;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20240307002616_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("MyProperty");

                    b.Property<int?>("SellerID");

                    b.HasKey("Id");

                    b.HasIndex("SellerID");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("DapartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("DapartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerID");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Department", "Dapartment")
                        .WithMany("Sellers")
                        .HasForeignKey("DapartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
