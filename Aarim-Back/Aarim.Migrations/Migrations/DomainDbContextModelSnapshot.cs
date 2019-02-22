﻿// <auto-generated />
using System;
using Aarim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aarim_Data.Migrations
{
    [DbContext(typeof(DomainDbContext))]
    partial class DomainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Aarim.Models.CreditCard", b =>
                {
                    b.Property<string>("Number")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CardBrand");

                    b.Property<string>("CardholderName");

                    b.Property<Guid>("CreditCardId");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("HasPassword");

                    b.Property<string>("Password");

                    b.Property<int>("Type");

                    b.HasKey("Number");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("Aarim.Models.Transacation", b =>
                {
                    b.Property<Guid>("TransacationId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("Number");

                    b.Property<string>("Type");

                    b.HasKey("TransacationId");

                    b.HasIndex("Number");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Aarim.Models.Transacation", b =>
                {
                    b.HasOne("Aarim.Models.CreditCard", "Card")
                        .WithMany()
                        .HasForeignKey("Number");
                });
#pragma warning restore 612, 618
        }
    }
}
