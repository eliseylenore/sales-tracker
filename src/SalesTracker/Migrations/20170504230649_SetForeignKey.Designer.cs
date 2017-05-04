using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SalesTracker.Models;

namespace SalesTracker.Migrations
{
    [DbContext(typeof(SalesTrackerContext))]
    [Migration("20170504230649_SetForeignKey")]
    partial class SetForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesTracker.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<decimal>("Price");

                    b.Property<string>("Year");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("SalesTracker.Models.CarSale", b =>
                {
                    b.Property<int>("CarSaleId");

                    b.Property<int>("CarId");

                    b.Property<string>("Comment");

                    b.Property<decimal>("SellingPrice");

                    b.HasKey("CarSaleId");

                    b.HasIndex("CarSaleId")
                        .IsUnique();

                    b.ToTable("CarSales");
                });

            modelBuilder.Entity("SalesTracker.Models.CarSale", b =>
                {
                    b.HasOne("SalesTracker.Models.Car", "Car")
                        .WithOne("CarSale")
                        .HasForeignKey("SalesTracker.Models.CarSale", "CarSaleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
