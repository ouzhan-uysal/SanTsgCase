﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211207001849_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("Reservation_CustomerCustomer_ID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Type")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("ID");

                    b.HasIndex("Reservation_CustomerCustomer_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Arrival")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Departure")
                        .HasColumnType("int");

                    b.Property<int?>("LocationCode")
                        .HasColumnType("int");

                    b.Property<int>("PricePerAdult")
                        .HasColumnType("int");

                    b.Property<int>("PricePerChild")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationCode");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("LocationCode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PricePerAdult")
                        .HasColumnType("int");

                    b.Property<int>("PricePerChild")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationCode");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Location", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Code");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Begin_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation_Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_ID"), 1L, 1);

                    b.Property<int?>("ReservationID")
                        .HasColumnType("int");

                    b.HasKey("Customer_ID");

                    b.HasIndex("ReservationID");

                    b.ToTable("Reservation_Customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation_Service", b =>
                {
                    b.Property<int>("Service_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Service_ID"), 1L, 1);

                    b.Property<int?>("ReservationID")
                        .HasColumnType("int");

                    b.HasKey("Service_ID");

                    b.HasIndex("ReservationID");

                    b.ToTable("Reservation_Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Repassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Reservation_Customer", "Reservation_Customer")
                        .WithMany()
                        .HasForeignKey("Reservation_CustomerCustomer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation_Customer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Flight", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationCode");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hotel", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationCode");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation", b =>
                {
                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation_Customer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Reservation", "Reservation")
                        .WithMany("Reservation_Customers")
                        .HasForeignKey("ReservationID");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation_Service", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Reservation", "Reservation")
                        .WithMany("Reservation_Services")
                        .HasForeignKey("ReservationID");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservation", b =>
                {
                    b.Navigation("Reservation_Customers");

                    b.Navigation("Reservation_Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}