﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220124004621_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AutorName")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("Autor_Name");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("Book_Name");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Status")
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("Status");

                    b.Property<string>("Synopsis")
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Synopsis");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id")
                        .HasName("pk_BookId");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
