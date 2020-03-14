﻿// <auto-generated />
using System;
using BattleTanks.DB.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BattleTanks.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200308173534_DeleteUselessFields")]
    partial class DeleteUselessFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BattleTanks.DB.Entities.Bullet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PhotoId");

                    b.Property<float>("Speed");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Bullets");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Friend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Deleted");

                    b.Property<Guid?>("ForWhoId");

                    b.Property<Guid?>("WhoId");

                    b.HasKey("Id");

                    b.HasIndex("ForWhoId");

                    b.HasIndex("WhoId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Finished");

                    b.Property<Guid?>("MapId");

                    b.Property<DateTime>("Started");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Map", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Coordinates");

                    b.Property<Guid?>("WallIconId");

                    b.HasKey("Id");

                    b.HasIndex("WallIconId");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Img");

                    b.Property<byte[]>("Thumb");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Tank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BulletId");

                    b.Property<Guid?>("IconId");

                    b.Property<float>("Speed");

                    b.HasKey("Id");

                    b.HasIndex("BulletId");

                    b.HasIndex("IconId");

                    b.ToTable("Tanks");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<byte>("Gender");

                    b.Property<bool>("IsBlocked");

                    b.Property<string>("Nickname");

                    b.Property<string>("PasswordHash");

                    b.Property<Guid?>("PhotoId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Login");

                    b.Property<DateTime>("Logout");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Coordinates");

                    b.Property<bool>("Died");

                    b.Property<Guid?>("GameId");

                    b.Property<Guid?>("TankId");

                    b.Property<Guid?>("TankerId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TankId");

                    b.HasIndex("TankerId");

                    b.ToTable("UserGames");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserTankAccess", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("TankId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TankId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTankAccesses");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Bullet", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Friend", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.User", "ForWho")
                        .WithMany()
                        .HasForeignKey("ForWhoId");

                    b.HasOne("BattleTanks.DB.Entities.User", "Who")
                        .WithMany()
                        .HasForeignKey("WhoId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Game", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Map", "Map")
                        .WithMany()
                        .HasForeignKey("MapId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Map", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Photo", "WallIcon")
                        .WithMany()
                        .HasForeignKey("WallIconId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.Tank", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Bullet", "Bullet")
                        .WithMany()
                        .HasForeignKey("BulletId");

                    b.HasOne("BattleTanks.DB.Entities.Photo", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.User", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.HasOne("BattleTanks.DB.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserActivity", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserGame", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("BattleTanks.DB.Entities.Tank", "Tank")
                        .WithMany()
                        .HasForeignKey("TankId");

                    b.HasOne("BattleTanks.DB.Entities.User", "Tanker")
                        .WithMany()
                        .HasForeignKey("TankerId");
                });

            modelBuilder.Entity("BattleTanks.DB.Entities.UserTankAccess", b =>
                {
                    b.HasOne("BattleTanks.DB.Entities.Tank", "Tank")
                        .WithMany()
                        .HasForeignKey("TankId");

                    b.HasOne("BattleTanks.DB.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
