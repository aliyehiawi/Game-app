﻿// <auto-generated />
using GameApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220918180022_initialschema")]
    partial class initialschema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GameApp.Data.Game", b =>
                {
                    b.Property<int>("idGame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idGame"), 1L, 1);

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number1")
                        .HasColumnType("int");

                    b.Property<int>("number2")
                        .HasColumnType("int");

                    b.Property<int>("wonAmount")
                        .HasColumnType("int");

                    b.HasKey("idGame");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
