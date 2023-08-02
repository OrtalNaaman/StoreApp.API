﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.API.Data;

#nullable disable

namespace StoreApp.API.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                            ConcurrencyStamp = "998d6bce-6fb0-4476-a58e-5e210704d483",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            ConcurrencyStamp = "7a3ff70c-627e-470b-86cf-c5a722a869db",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                            ConcurrencyStamp = "b858d1d1-7f47-4557-99b7-2b685a9ab184",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "c32f66ed-c960-4cb7-a468-90662e1fb37a"
                        },
                        new
                        {
                            UserId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StoreApp.API.Data.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StoreItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreItemId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("StoreApp.API.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Sent")
                        .HasColumnType("bit");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreItemId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StoreApp.API.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AuthLevel")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            AuthLevel = 2,
                            ConcurrencyStamp = "a8ff9718-a852-460f-9632-8294757f08ee",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEG4+i4myotTZf8k6BiRxCxMJj5TY8gpoLadDN/dFIT6PT6rWJ3uJ4R/WpKBy2bJmFQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a4ba28f2-78f6-423e-8afc-301b8036e3cd",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            AccessFailedCount = 0,
                            AuthLevel = 1,
                            ConcurrencyStamp = "2180fc91-460a-4c32-b4c2-e1a0c7cf2a55",
                            Email = "netush@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "NETUSH@GMAIL.COM",
                            NormalizedUserName = "NETA",
                            PasswordHash = "AQAAAAEAACcQAAAAEOY5hC2Ya6s8BUQreiJsujjzyn9KgXX/hZxoHh/eoqbWi/Uyi7b5b652Dy52mqGZYA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "547cf5fd-2937-4f52-a928-f330bd205e14",
                            TwoFactorEnabled = false,
                            UserName = "Neta"
                        });
                });

            modelBuilder.Entity("StoreApp.API.Entities.StoreItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StoreItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            Image = "assets/Images/BabyBridesmaidWhiteDress.jpg",
                            Price = 70,
                            Title = "Baby Bridesmaid"
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            Image = "assets/Images/BabyDotsDressBlueAndWhite.jpg",
                            Price = 54,
                            Title = "Baby Dots Dress"
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            Image = "assets/Images/BabyDressBlackAndWhite.jpg",
                            Price = 57,
                            Title = "Black&White Baby Dress"
                        },
                        new
                        {
                            Id = 4,
                            Category = 1,
                            Image = "assets/Images/BabyFlowerGirlDressLightPink.jpg",
                            Price = 70,
                            Title = "Little Flower Baby Girl Dress"
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Image = "assets/Images/BabyJeansSet.jpg",
                            Price = 50,
                            Title = "Jeans Set"
                        },
                        new
                        {
                            Id = 6,
                            Category = 1,
                            Image = "assets/Images/BabyPinkOverall.jpg",
                            Price = 56,
                            Title = "Baby Overall"
                        },
                        new
                        {
                            Id = 7,
                            Category = 1,
                            Image = "assets/Images/BabyRedDress.jpg",
                            Price = 60,
                            Title = "Baby Red Dress"
                        },
                        new
                        {
                            Id = 8,
                            Category = 1,
                            Image = "assets/Images/BabyYelowFlowersDress.jpg",
                            Price = 63,
                            Title = "Baby Yelow Flowers Dress"
                        },
                        new
                        {
                            Id = 9,
                            Category = 2,
                            Image = "assets/Images/GirlBridesmaidWhiteDress.jpg",
                            Price = 85,
                            Title = "Girl Bridesmaid"
                        },
                        new
                        {
                            Id = 10,
                            Category = 2,
                            Image = "assets/Images/GirlsDressBrownAndWhite.jpg",
                            Price = 58,
                            Title = "Brown&White Dress"
                        },
                        new
                        {
                            Id = 11,
                            Category = 2,
                            Image = "assets/Images/GirlsDressTwoPieceBlackAndWhite.jpg",
                            Price = 60,
                            Title = "Two Piece Black&White"
                        },
                        new
                        {
                            Id = 12,
                            Category = 2,
                            Image = "assets/Images/GirlsDressTwoPieceWhiteAndFlowers.jpg",
                            Price = 53,
                            Title = "Two Piece White&Flowers"
                        },
                        new
                        {
                            Id = 13,
                            Category = 2,
                            Image = "assets/Images/GirlsTwoPieceWhiteAndPink.jpg",
                            Price = 50,
                            Title = "Two Piece White&Pink"
                        },
                        new
                        {
                            Id = 14,
                            Category = 2,
                            Image = "assets/Images/GirlsMultiColorDressWhitePinkBlue.jpg",
                            Price = 48,
                            Title = "Multi Color Dress"
                        },
                        new
                        {
                            Id = 15,
                            Category = 2,
                            Image = "assets/Images/GirlsPinkOverall.jpg",
                            Price = 52,
                            Title = "Overall"
                        },
                        new
                        {
                            Id = 16,
                            Category = 2,
                            Image = "assets/Images/GirlsSetJeansAndWhite.jpg",
                            Price = 50,
                            Title = "Girls Set Blue"
                        },
                        new
                        {
                            Id = 17,
                            Category = 2,
                            Image = "assets/Images/GirlsSetLightBlueAndWhite.jpg",
                            Price = 50,
                            Title = "Girls Set Light Blue"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StoreApp.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StoreApp.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApp.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StoreApp.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreApp.API.Data.Entities.CartItem", b =>
                {
                    b.HasOne("StoreApp.API.Entities.StoreItem", "StoreItem")
                        .WithMany()
                        .HasForeignKey("StoreItemId");

                    b.Navigation("StoreItem");
                });
#pragma warning restore 612, 618
        }
    }
}