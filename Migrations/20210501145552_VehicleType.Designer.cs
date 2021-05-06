﻿// <auto-generated />
using System;
using DakarRally.NetDusanj.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DakarRally.NetDusanj.Migrations
{
    [DbContext(typeof(DakarRallyDBContext))]
    [Migration("20210501145552_VehicleType")]
    partial class VehicleType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Race", b =>
                {
                    b.Property<int>("RaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RaceStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("RaceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Distance")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MalfunctionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.Property<bool>("Winner")
                        .HasColumnType("bit");

                    b.HasKey("VehicleId");

                    b.HasIndex("RaceId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Car", b =>
                {
                    b.HasBaseType("DakarRally.NetDusanj.Domain.Entity.Vehicle");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Motorcycle", b =>
                {
                    b.HasBaseType("DakarRally.NetDusanj.Domain.Entity.Vehicle");

                    b.Property<int>("MotorcycleType")
                        .HasColumnType("int");

                    b.ToTable("Motorcycles");
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Truck", b =>
                {
                    b.HasBaseType("DakarRally.NetDusanj.Domain.Entity.Vehicle");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Vehicle", b =>
                {
                    b.HasOne("DakarRally.NetDusanj.Domain.Entity.Race", null)
                        .WithMany("Vehicle")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Car", b =>
                {
                    b.HasOne("DakarRally.NetDusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.NetDusanj.Domain.Entity.Car", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Motorcycle", b =>
                {
                    b.HasOne("DakarRally.NetDusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.NetDusanj.Domain.Entity.Motorcycle", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Truck", b =>
                {
                    b.HasOne("DakarRally.NetDusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.NetDusanj.Domain.Entity.Truck", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.NetDusanj.Domain.Entity.Race", b =>
                {
                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
