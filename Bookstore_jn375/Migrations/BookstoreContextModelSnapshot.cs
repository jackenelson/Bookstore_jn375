﻿// <auto-generated />
using System;
using Bookstore_jn375.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookstore_jn375.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    partial class BookstoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Bookstore_jn375.Models.Books", b =>
                {
                    b.Property<long>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Bookstore_jn375.Models.CartLineItem", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("BooksBookId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineId");

                    b.HasIndex("BooksBookId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("CartLineItem");
                });

            modelBuilder.Entity("Bookstore_jn375.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Anonymous")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Bookstore_jn375.Models.CartLineItem", b =>
                {
                    b.HasOne("Bookstore_jn375.Models.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BooksBookId");

                    b.HasOne("Bookstore_jn375.Models.Purchase", null)
                        .WithMany("Lines")
                        .HasForeignKey("PurchaseId");
                });
#pragma warning restore 612, 618
        }
    }
}
