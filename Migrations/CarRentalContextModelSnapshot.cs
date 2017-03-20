using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CarRental.api.db;
using ;

namespace CarRental1._1.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    partial class CarRentalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Car", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarNumber");

                    b.Property<int>("Engine");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<int>("Type");

                    b.Property<string>("YearOfBuild");

                    b.HasKey("id");

                    b.ToTable("Cars");
                });
        }
    }
}
