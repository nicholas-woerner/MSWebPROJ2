﻿// <auto-generated />
using System;
using MSWebPROJ2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MSWebPROJ2.Migrations
{
    [DbContext(typeof(ProfileContext))]
    partial class ProfileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MSWebPROJ2.Models.User", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "Kylan",
                            LastName = "Larson"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Nicholas",
                            LastName = "Woerner"
                        },
                        new
                        {
                            ID = 3,
                            FirstName = "Michael",
                            LastName = "Myers"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
