﻿// <auto-generated />
using System;
using FTPSearch.API.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FTPSearch.API.Infrastructure.Data.Migrations
{
    [DbContext(typeof(FTPSearchDbContext))]
    partial class FTPSearchDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FTPSearch.API.Domain.Entities.Base.TempFiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FileMetaType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.HasKey("Id");

                    b.HasIndex("Path")
                        .HasDatabaseName("IX_TempFiles_Path");

                    b.HasIndex("Name", "Path", "SiteId")
                        .IsUnique()
                        .HasDatabaseName("IX_TempFiles_Name_Path");

                    b.ToTable("TempFiles", (string)null);
                });

            modelBuilder.Entity("FTPSearch.API.Domain.Entities.FileEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FileMetaType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_FileEntity_Name_GIN")
                        .HasAnnotation("Npgsql:TsVectorConfig", "english");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Name"), "GIN");

                    b.HasIndex("Path")
                        .HasDatabaseName("IX_FileEntity_Path");

                    b.HasIndex("Name", "Path", "SiteId")
                        .IsUnique()
                        .HasDatabaseName("IX_FileEntity_Name_Path");

                    b.ToTable("Files", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
