﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoryOfTarniaWebApp.Data;

#nullable disable

namespace StoryOfTarniaWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241217111927_Character_Feats")]
    partial class Character_Feats
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Ability", b =>
                {
                    b.Property<int>("AbilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbilityID"));

                    b.Property<string>("AbilityDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AbilityModifier")
                        .HasColumnType("int");

                    b.Property<string>("AbilityName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("AbilityScore")
                        .HasColumnType("int");

                    b.HasKey("AbilityID");

                    b.ToTable("Abilities");

                    b.HasData(
                        new
                        {
                            AbilityID = 1,
                            AbilityDesc = "Strength measures a character's physical power, including their ability to lift, push, pull, and perform feats of raw might. It's crucial for characters who rely on melee combat and physical prowess.",
                            AbilityModifier = -1,
                            AbilityName = "Strength",
                            AbilityScore = 8
                        },
                        new
                        {
                            AbilityID = 2,
                            AbilityDesc = "Dexterity represents agility, reflexes, and balance. It's critical for characters who rely on speed and precision, such as rogues and rangers.",
                            AbilityModifier = -1,
                            AbilityName = "Dexterity",
                            AbilityScore = 8
                        },
                        new
                        {
                            AbilityID = 3,
                            AbilityDesc = "Constitution measures endurance and health. It determines how well a character resists physical stress, illness, and how much punishment they can take.",
                            AbilityModifier = -1,
                            AbilityName = "Constitution",
                            AbilityScore = 8
                        },
                        new
                        {
                            AbilityID = 4,
                            AbilityDesc = "Intelligence reflects mental acuity, analytical ability, and memory. It’s vital for spellcasters like wizards and for understanding complex problems.",
                            AbilityModifier = -1,
                            AbilityName = "Intelligence",
                            AbilityScore = 8
                        },
                        new
                        {
                            AbilityID = 5,
                            AbilityDesc = "Wisdom reflects perception, intuition, and awareness of the world. It's crucial for clerics, druids, and other characters who rely on insight.",
                            AbilityModifier = -1,
                            AbilityName = "Wisdom",
                            AbilityScore = 8
                        },
                        new
                        {
                            AbilityID = 6,
                            AbilityDesc = "Charisma measures force of personality, persuasiveness, and leadership. It's essential for characters like bards, sorcerers, and warlocks.",
                            AbilityModifier = -1,
                            AbilityName = "Charisma",
                            AbilityScore = 8
                        });
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnType("int");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Feat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prerequisite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Feat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "+3 on Initiative",
                            Name = "Alert",
                            Tier = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "+1 on attack rolls",
                            Name = "Attack Bonus",
                            Tier = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "+10 HP",
                            Name = "Toughness",
                            Tier = 0
                        },
                        new
                        {
                            Id = 4,
                            Description = "+2 on attack rolls",
                            Name = "Improved Attack Bonus",
                            Prerequisite = "Attack Bonus",
                            Tier = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "+5 on spells cast for every class point spent",
                            Name = "Empower Spell",
                            Tier = 1
                        });
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("DamageType")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Power");
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Feat", b =>
                {
                    b.HasOne("StoryOfTarniaWebApp.Models.Character", null)
                        .WithMany("Feats")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Power", b =>
                {
                    b.HasOne("StoryOfTarniaWebApp.Models.Character", null)
                        .WithMany("Powers")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("StoryOfTarniaWebApp.Models.Character", b =>
                {
                    b.Navigation("Feats");

                    b.Navigation("Powers");
                });
#pragma warning restore 612, 618
        }
    }
}
