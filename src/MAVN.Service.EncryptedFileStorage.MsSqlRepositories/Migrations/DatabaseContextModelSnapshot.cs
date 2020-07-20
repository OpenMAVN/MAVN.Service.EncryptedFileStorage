﻿// <auto-generated />
using System;
using MAVN.Service.EncryptedFileStorage.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.EncryptedFileStorage.MsSqlRepositories.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("encrypted_files_storage")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.EncryptedFileStorage.Domain.Models.EncryptedFile", b =>
                {
                    b.Property<Guid>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BlobName")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime?>("FileDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("IsUploadCompleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<long?>("Length")
                        .HasColumnType("bigint");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("character varying(63)")
                        .HasMaxLength(63);

                    b.HasKey("FileId");

                    b.HasIndex("Origin", "FileName")
                        .IsUnique();

                    b.ToTable("encrypted_files");
                });
#pragma warning restore 612, 618
        }
    }
}
