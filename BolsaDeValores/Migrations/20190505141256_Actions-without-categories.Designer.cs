﻿// <auto-generated />
using System;
using BolsaDeValores.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BolsaDeValores.Migrations
{
    [DbContext(typeof(BolsaDeValoresContext))]
    [Migration("20190505141256_Actions-without-categories")]
    partial class Actionswithoutcategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BolsaDeValores.Models.Actions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdOwner");

                    b.Property<int>("Name");

                    b.Property<int?>("OwnerId");

                    b.Property<int>("PriceQuant");

                    b.Property<int>("QuantMinSell");

                    b.Property<int>("Quantity");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("BolsaDeValores.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BolsaDeValores.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BolsaDeValores.Models.Actions", b =>
                {
                    b.HasOne("BolsaDeValores.Models.Clients", "Owner")
                        .WithMany("Actions")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}