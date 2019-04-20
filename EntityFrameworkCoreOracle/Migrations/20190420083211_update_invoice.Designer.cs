﻿// <auto-generated />
using System;
using EntityFrameworkCoreOracle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCoreOracle.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20190420083211_update_invoice")]
    partial class update_invoice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("NETCORE")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("DemoCore.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnName("CUSTOMERID");

                    b.Property<string>("Address")
                        .HasColumnName("ADDRESS");

                    b.Property<string>("FirstName")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("LastName")
                        .HasColumnName("LASTNAME");

                    b.HasKey("CustomerId");

                    b.ToTable("CUSTOMER");
                });

            modelBuilder.Entity("DemoCore.Entity.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("CustomerId")
                        .HasColumnName("CUSTOMERID");

                    b.Property<DateTime>("Date")
                        .HasColumnName("DATE");

                    b.Property<string>("Test")
                        .HasColumnName("TEST");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("INVOICE");
                });

            modelBuilder.Entity("DemoCore.Entity.Invoice", b =>
                {
                    b.HasOne("DemoCore.Entity.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
