﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgCompendium.Models;

namespace RpgCompendium.Migrations
{
    [DbContext(typeof(RpgCompendiumContext))]
    [Migration("20201020225546_WeaponAndItemPropertyAndItemPropertyJoinFix2")]
    partial class WeaponAndItemPropertyAndItemPropertyJoinFix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RpgCompendium.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RpgCompendium.Models.Armor", b =>
                {
                    b.Property<int>("ArmorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArmorDescription");

                    b.Property<string>("ArmorName");

                    b.Property<string>("ArmorSlot");

                    b.HasKey("ArmorId");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("RpgCompendium.Models.Behavior", b =>
                {
                    b.Property<int>("BehaviorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BehaviorDescription");

                    b.Property<string>("BehaviorName");

                    b.HasKey("BehaviorId");

                    b.ToTable("Behaviors");
                });

            modelBuilder.Entity("RpgCompendium.Models.ItemProperty", b =>
                {
                    b.Property<int>("ItemPropertyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemPropertyDescription");

                    b.Property<string>("ItemPropertyFlags");

                    b.Property<string>("ItemPropertyName");

                    b.HasKey("ItemPropertyId");

                    b.ToTable("ItemProperties");
                });

            modelBuilder.Entity("RpgCompendium.Models.ItemPropertyJoin", b =>
                {
                    b.Property<int>("ItemPropertyJoinId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArmorId");

                    b.Property<int>("ItemPropertyId");

                    b.Property<int?>("WeaponId");

                    b.HasKey("ItemPropertyJoinId");

                    b.HasIndex("ArmorId");

                    b.HasIndex("ItemPropertyId");

                    b.HasIndex("WeaponId");

                    b.ToTable("ItemPropertyJoins");
                });

            modelBuilder.Entity("RpgCompendium.Models.MainType", b =>
                {
                    b.Property<int>("MainTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MainTypeDescription");

                    b.Property<string>("MainTypeName");

                    b.HasKey("MainTypeId");

                    b.ToTable("MainTypes");
                });

            modelBuilder.Entity("RpgCompendium.Models.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MonsterName");

                    b.Property<string>("UserId");

                    b.HasKey("MonsterId");

                    b.HasIndex("UserId");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterArmor", b =>
                {
                    b.Property<int>("MonsterArmorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArmorId");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterArmorId");

                    b.HasIndex("ArmorId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterArmors");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterBehavior", b =>
                {
                    b.Property<int>("MonsterBehaviorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviorId");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterBehaviorId");

                    b.HasIndex("BehaviorId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterBehaviors");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterMainType", b =>
                {
                    b.Property<int>("MonsterMainTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MainTypeId");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterMainTypeId");

                    b.HasIndex("MainTypeId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterMainTypes");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterWeapon", b =>
                {
                    b.Property<int>("MonsterWeaponId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MonsterId");

                    b.Property<int>("WeaponId");

                    b.Property<string>("WeaponSlot");

                    b.HasKey("MonsterWeaponId");

                    b.HasIndex("MonsterId");

                    b.HasIndex("WeaponId");

                    b.ToTable("MonsterWeapons");
                });

            modelBuilder.Entity("RpgCompendium.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("WeaponDescription");

                    b.Property<string>("WeaponName");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RpgCompendium.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RpgCompendium.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RpgCompendium.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.ItemPropertyJoin", b =>
                {
                    b.HasOne("RpgCompendium.Models.Armor", "Armor")
                        .WithMany("ItemProperties")
                        .HasForeignKey("ArmorId");

                    b.HasOne("RpgCompendium.Models.ItemProperty", "ItemProperty")
                        .WithMany("ItemPropertyJoins")
                        .HasForeignKey("ItemPropertyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Weapon", "Weapon")
                        .WithMany("ItemProperties")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("RpgCompendium.Models.Monster", b =>
                {
                    b.HasOne("RpgCompendium.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterArmor", b =>
                {
                    b.HasOne("RpgCompendium.Models.Armor", "Armor")
                        .WithMany("Monsters")
                        .HasForeignKey("ArmorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("Armors")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterBehavior", b =>
                {
                    b.HasOne("RpgCompendium.Models.Behavior", "Behavior")
                        .WithMany("Monsters")
                        .HasForeignKey("BehaviorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("Behaviors")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterMainType", b =>
                {
                    b.HasOne("RpgCompendium.Models.MainType", "MainType")
                        .WithMany("Monsters")
                        .HasForeignKey("MainTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("MainTypes")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterWeapon", b =>
                {
                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("Weapons")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Weapon", "Weapon")
                        .WithMany("Monsters")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
