﻿// <auto-generated />
using System;
using DakarRally.Net_dusanj.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DakarRally.Net_dusanj.Migrations
{
    [DbContext(typeof(DakarRallyDBContext))]
    [Migration("20210429060734_AddVehicleType")]
    partial class AddVehicleType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Race", b =>
                {
                    b.Property<int>("RaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RaceStatus")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("RaceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MalfunctionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RaceId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.HasIndex("RaceId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Car", b =>
                {
                    b.HasBaseType("DakarRally.Net_dusanj.Domain.Entity.Vehicle");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Motorcycle", b =>
                {
                    b.HasBaseType("DakarRally.Net_dusanj.Domain.Entity.Vehicle");

                    b.Property<int>("MotorcycleType")
                        .HasColumnType("int");

                    b.ToTable("Motorcycles");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Truck", b =>
                {
                    b.HasBaseType("DakarRally.Net_dusanj.Domain.Entity.Vehicle");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Vehicle", b =>
                {
                    b.HasOne("DakarRally.Net_dusanj.Domain.Entity.Race", null)
                        .WithMany("Vehicle")
                        .HasForeignKey("RaceId");
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Car", b =>
                {
                    b.HasOne("DakarRally.Net_dusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.Net_dusanj.Domain.Entity.Car", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Motorcycle", b =>
                {
                    b.HasOne("DakarRally.Net_dusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.Net_dusanj.Domain.Entity.Motorcycle", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Truck", b =>
                {
                    b.HasOne("DakarRally.Net_dusanj.Domain.Entity.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("DakarRally.Net_dusanj.Domain.Entity.Truck", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DakarRally.Net_dusanj.Domain.Entity.Race", b =>
                {
                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
