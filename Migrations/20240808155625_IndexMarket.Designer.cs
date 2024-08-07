﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace stocktracker.Migrations
{
    [DbContext(typeof(StockTrackerDbContext))]
    [Migration("20240808155625_IndexMarket")]
    partial class IndexMarket
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IndexMarket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<decimal>("ChangeBy")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MaxDailyChangePercentMax")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MaxDailyChangePercentMin")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("StartPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TradeHoursPerDay")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Indexes");
                });
#pragma warning restore 612, 618
        }
    }
}
