﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OrderService.Infrastructure;

namespace OrderService.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.ContractAggregate.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("OrderCreationType");

                    b.Property<int>("Priority");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.ContractAggregate.ContractXrefTariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<int>("TariffId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("TariffId");

                    b.ToTable("ContractXrefTariff");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.DishAggregate.Dish", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhotoPath");

                    b.HasKey("Id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.LaneAggregate.Lane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DestinationRegionId");

                    b.Property<int>("LaneType");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("MatrixLaneType");

                    b.Property<int>("PricingType");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RateType");

                    b.Property<int>("SourceRegionId");

                    b.HasKey("Id");

                    b.HasIndex("DestinationRegionId");

                    b.HasIndex("SourceRegionId");

                    b.ToTable("Lanes");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.LaneAggregate.TariffXrefLane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LaneId");

                    b.Property<int>("TariffId");

                    b.HasKey("Id");

                    b.HasIndex("LaneId");

                    b.HasIndex("TariffId");

                    b.ToTable("TariffXrefLane");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.OrderAggregate.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CustomerId");

                    b.Property<string>("DateOfOrder");

                    b.Property<string>("Description");

                    b.Property<string>("NameOfCustomer");

                    b.Property<string>("OrderTime");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.OrderAggregate.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("DishId");

                    b.Property<long>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.RegionAggregate.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffAggregate.Conditional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("PackagingType");

                    b.Property<int>("TariffId");

                    b.HasKey("Id");

                    b.HasIndex("TariffId");

                    b.ToTable("Conditional");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffAggregate.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("DiscountValue");

                    b.Property<DateTime>("LastModified");

                    b.Property<decimal>("MaxValue");

                    b.Property<decimal>("MinValue");

                    b.Property<int>("Priority");

                    b.Property<int>("TariffId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("TariffId");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationType");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<decimal>("MinimumRate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PricingType");

                    b.Property<int>("UpchargeType");

                    b.Property<decimal>("UpchargeValue");

                    b.HasKey("Id");

                    b.ToTable("Tariffs");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffExtra.TariffExtra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessorialRateType");

                    b.Property<int>("ApplicationType");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("FuelRateType");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Rate");

                    b.Property<int>("TariffId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("TariffId");

                    b.ToTable("TariffExtras");
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.ContractAggregate.ContractXrefTariff", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.ContractAggregate.Contract", "Contract")
                        .WithMany("Tariffs")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", "Tariff")
                        .WithMany("Contracts")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.LaneAggregate.Lane", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.RegionAggregate.Region", "DestinationRegion")
                        .WithMany()
                        .HasForeignKey("DestinationRegionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderService.Domain.AggregatesModels.RegionAggregate.Region", "SourceRegion")
                        .WithMany()
                        .HasForeignKey("SourceRegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.LaneAggregate.TariffXrefLane", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.LaneAggregate.Lane", "Lane")
                        .WithMany("Tariffs")
                        .HasForeignKey("LaneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", "Tariff")
                        .WithMany("Lanes")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.DishAggregate.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OrderService.Domain.AggregatesModels.OrderAggregate.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffAggregate.Conditional", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", "Tariff")
                        .WithMany("Conditionals")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffAggregate.Discount", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", "Tariff")
                        .WithMany("Discounts")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Domain.AggregatesModels.TariffExtra.TariffExtra", b =>
                {
                    b.HasOne("OrderService.Domain.AggregatesModels.TariffAggregate.Tariff", "Tariff")
                        .WithMany("TariffExtras")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
