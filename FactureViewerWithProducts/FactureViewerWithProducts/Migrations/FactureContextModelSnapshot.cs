﻿// <auto-generated />
using System;
using FactureViewerWithProducts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FactureViewerWithProducts.Migrations
{
    [DbContext(typeof(FactureContext))]
    partial class FactureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("FactureViewerWithProducts.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StatusID");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("FactureViewerWithProducts.Models.FactureProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FactureId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FactureId");

                    b.HasIndex("ProductId");

                    b.ToTable("FactureProducts");
                });

            modelBuilder.Entity("FactureViewerWithProducts.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Tax")
                        .HasColumnType("REAL");

                    b.Property<string>("WareName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FactureViewerWithProducts.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("FactureViewerWithProducts.Models.Facture", b =>
                {
                    b.HasOne("FactureViewerWithProducts.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FactureViewerWithProducts.Models.FactureProducts", b =>
                {
                    b.HasOne("FactureViewerWithProducts.Models.Facture", "Facture")
                        .WithMany("FactureProducts")
                        .HasForeignKey("FactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FactureViewerWithProducts.Models.Product", "Product")
                        .WithMany("FactureProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
