﻿// <auto-generated />
using System;
using KombiyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KombiyApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201228223303_İnit")]
    partial class İnit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KombniyApp.Core.Models.GalleryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GalleryImages");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.ImageTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GalleryImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GalleryImageId");

                    b.ToTable("ImageTags");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.MailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderUserId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("mailModels");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.PasswordCodeModel", b =>
                {
                    b.Property<int>("PaswordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<DateTime>("GeneratedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaswordId");

                    b.HasIndex("UserId");

                    b.ToTable("Passwords");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.RegisterViewModel", b =>
                {
                    b.Property<int>("registerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordTekrar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Phone")
                        .HasColumnType("smallint");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("registerId");

                    b.ToTable("registerViewModels");
                });

            modelBuilder.Entity("KombniyApp.Core.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StlingAndEnvironmentId")
                        .HasColumnType("int");

                    b.Property<int>("WardrobeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("StlingAndEnvironmentId");

                    b.HasIndex("WardrobeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KombniyApp.Core.StlingAndEnvironment", b =>
                {
                    b.Property<int>("StlingAndEnvironmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("StlingAndEnvironmentId");

                    b.ToTable("StlingAndEnviroments");
                });

            modelBuilder.Entity("KombniyApp.Core.StylingManage", b =>
                {
                    b.Property<int>("StylingManageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StylingGetUserId")
                        .HasColumnType("int");

                    b.Property<int>("StylingGiveUserId")
                        .HasColumnType("int");

                    b.HasKey("StylingManageId");

                    b.ToTable("stylingManagers");
                });

            modelBuilder.Entity("KombniyApp.Core.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Repassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WardrobeId")
                        .HasColumnType("int");

                    b.Property<string>("photoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("WardrobeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KombniyApp.Core.Wardrobe", b =>
                {
                    b.Property<int>("WardrobeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WardrobeId");

                    b.HasIndex("ProductId1");

                    b.HasIndex("UserId");

                    b.ToTable("Wardrobes");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.ImageTag", b =>
                {
                    b.HasOne("KombniyApp.Core.Models.GalleryImage", null)
                        .WithMany("Tags")
                        .HasForeignKey("GalleryImageId");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.MailModel", b =>
                {
                    b.HasOne("KombniyApp.Core.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KombniyApp.Core.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderUserId");
                });

            modelBuilder.Entity("KombniyApp.Core.Models.PasswordCodeModel", b =>
                {
                    b.HasOne("KombniyApp.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KombniyApp.Core.Product", b =>
                {
                    b.HasOne("KombniyApp.Core.StlingAndEnvironment", "StlingAndEnvironment")
                        .WithMany("Products")
                        .HasForeignKey("StlingAndEnvironmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KombniyApp.Core.Wardrobe", null)
                        .WithMany("Products")
                        .HasForeignKey("WardrobeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KombniyApp.Core.User", b =>
                {
                    b.HasOne("KombniyApp.Core.Wardrobe", "Wardrobe")
                        .WithMany()
                        .HasForeignKey("WardrobeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KombniyApp.Core.Wardrobe", b =>
                {
                    b.HasOne("KombniyApp.Core.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("KombniyApp.Core.User", null)
                        .WithMany("Wardrobes")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
