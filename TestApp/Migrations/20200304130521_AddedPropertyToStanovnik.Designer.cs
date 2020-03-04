﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApp.Data;

namespace TestApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200304130521_AddedPropertyToStanovnik")]
    partial class AddedPropertyToStanovnik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApp.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojSkola")
                        .HasColumnType("int");

                    b.Property<int>("BrojStanovnika")
                        .HasColumnType("int");

                    b.Property<string>("Drzava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeGrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeGradonacelnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProracunGrada")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Grads");
                });

            modelBuilder.Entity("TestApp.Models.Stanovnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodenja")
                        .HasColumnType("Date");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("ImeStanovnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimeStanovnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UlicaStanovnika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Stanovniks");
                });

            modelBuilder.Entity("TestApp.Models.Stanovnik", b =>
                {
                    b.HasOne("TestApp.Models.Grad", "Grad")
                        .WithMany("Stanovnici")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}