﻿// <auto-generated />
using System;
using MedicineControls.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicineControls.Migrations
{
    [DbContext(typeof(MedicineDbContext))]
    partial class MedicineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicineControls.Models.HoursOfUse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UseTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.ToTable("HoursOfUses");
                });

            modelBuilder.Entity("MedicineControls.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsExist")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PiecesInBox")
                        .HasColumnType("int");

                    b.Property<int>("RemainingPieces")
                        .HasColumnType("int");

                    b.Property<int>("UsageId")
                        .HasColumnType("int");

                    b.Property<int>("UsedPieces")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsageId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MedicineControls.Models.Usage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsRegularUse")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsing")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UseQuitDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("UseStartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Usages");
                });

            modelBuilder.Entity("MedicineControls.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MedicineControls.Models.HoursOfUse", b =>
                {
                    b.HasOne("MedicineControls.Models.Medicine", "Medicine")
                        .WithMany("HoursOfUse")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("MedicineControls.Models.Medicine", b =>
                {
                    b.HasOne("MedicineControls.Models.Usage", "Usage")
                        .WithOne("Medicine")
                        .HasForeignKey("MedicineControls.Models.Medicine", "UsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicineControls.Models.User", "User")
                        .WithMany("Medicines")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicineControls.Models.Medicine", b =>
                {
                    b.Navigation("HoursOfUse");
                });

            modelBuilder.Entity("MedicineControls.Models.Usage", b =>
                {
                    b.Navigation("Medicine")
                        .IsRequired();
                });

            modelBuilder.Entity("MedicineControls.Models.User", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
