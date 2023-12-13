﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netsphere.Database;

namespace Netsphere.Database.Migrations.Game
{
    [DbContext(typeof(GameContext))]
    [Migration("20190414105838_add_channels")]
    partial class add_channels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Netsphere.Database.Game.ChannelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Color");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("MaxLevel");

                    b.Property<int>("MinLevel");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("PlayerLimit");

                    b.HasKey("Id");

                    b.ToTable("channels");
                });

            modelBuilder.Entity("Netsphere.Database.Game.LevelRewardEntity", b =>
                {
                    b.Property<int>("Level");

                    b.Property<int>("Money");

                    b.Property<byte>("MoneyType");

                    b.HasKey("Level");

                    b.ToTable("level_rewards");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerCharacterEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AccessoryId");

                    b.Property<byte>("BasicFace");

                    b.Property<byte>("BasicHair");

                    b.Property<byte>("BasicPants");

                    b.Property<byte>("BasicShirt");

                    b.Property<long?>("FaceId");

                    b.Property<byte>("Gender");

                    b.Property<long?>("GlovesId");

                    b.Property<long?>("HairId");

                    b.Property<long?>("PantsId");

                    b.Property<int>("PlayerId");

                    b.Property<long?>("ShirtId");

                    b.Property<long?>("ShoesId");

                    b.Property<long?>("SkillId");

                    b.Property<byte>("Slot");

                    b.Property<long?>("Weapon1Id");

                    b.Property<long?>("Weapon2Id");

                    b.Property<long?>("Weapon3Id");

                    b.HasKey("Id");

                    b.HasIndex("AccessoryId");

                    b.HasIndex("FaceId");

                    b.HasIndex("GlovesId");

                    b.HasIndex("HairId");

                    b.HasIndex("PantsId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ShirtId");

                    b.HasIndex("ShoesId");

                    b.HasIndex("SkillId");

                    b.HasIndex("Weapon1Id");

                    b.HasIndex("Weapon2Id");

                    b.HasIndex("Weapon3Id");

                    b.ToTable("player_characters");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerDenyEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DenyPlayerId");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("DenyPlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("player_deny");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AP");

                    b.Property<int>("Coins1");

                    b.Property<int>("Coins2");

                    b.Property<byte>("CurrentCharacterSlot");

                    b.Property<int>("PEN");

                    b.Property<int>("TotalExperience");

                    b.Property<byte>("TutorialState");

                    b.HasKey("Id");

                    b.ToTable("players");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Color");

                    b.Property<int>("Count");

                    b.Property<int>("Durability");

                    b.Property<uint>("Effect");

                    b.Property<int>("PlayerId");

                    b.Property<long>("PurchaseDate");

                    b.Property<int>("ShopItemInfoId");

                    b.Property<int>("ShopPriceId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ShopItemInfoId");

                    b.HasIndex("ShopPriceId");

                    b.ToTable("player_items");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerMailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsMailDeleted");

                    b.Property<bool>("IsMailNew");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("PlayerId");

                    b.Property<int>("SenderPlayerId");

                    b.Property<long>("SentDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SenderPlayerId");

                    b.ToTable("player_mails");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerSettingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlayerId");

                    b.Property<string>("Setting")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("player_settings");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopEffectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("Effect");

                    b.Property<int>("EffectGroupId");

                    b.HasKey("Id");

                    b.HasIndex("EffectGroupId");

                    b.ToTable("shop_effects");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopEffectGroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("shop_effect_groups");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Colors");

                    b.Property<bool>("IsDestroyable");

                    b.Property<bool>("IsOneTimeUse");

                    b.Property<byte>("LevelLimit");

                    b.Property<byte>("RequiredGender");

                    b.Property<byte>("RequiredLevel");

                    b.Property<byte>("RequiredLicense");

                    b.Property<byte>("RequiredMasterLevel");

                    b.Property<byte>("UniqueColors");

                    b.HasKey("Id");

                    b.ToTable("shop_items");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopItemInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("DiscountPercentage");

                    b.Property<int>("EffectGroupId");

                    b.Property<byte>("IsEnabled");

                    b.Property<int>("PriceGroupId");

                    b.Property<long>("ShopItemId");

                    b.HasKey("Id");

                    b.HasIndex("EffectGroupId");

                    b.HasIndex("PriceGroupId");

                    b.HasIndex("ShopItemId");

                    b.ToTable("shop_iteminfos");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopPriceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Durability");

                    b.Property<bool>("IsEnabled");

                    b.Property<bool>("IsRefundable");

                    b.Property<int>("Period");

                    b.Property<byte>("PeriodType");

                    b.Property<int>("Price");

                    b.Property<int>("PriceGroupId");

                    b.HasKey("Id");

                    b.HasIndex("PriceGroupId");

                    b.ToTable("shop_prices");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopPriceGroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<byte>("PriceType");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("shop_price_groups");
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopVersionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("shop_version");
                });

            modelBuilder.Entity("Netsphere.Database.Game.StartItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Color");

                    b.Property<int>("Count");

                    b.Property<byte>("RequiredSecurityLevel");

                    b.Property<int>("ShopEffectId");

                    b.Property<int>("ShopItemInfoId");

                    b.Property<int>("ShopPriceId");

                    b.HasKey("Id");

                    b.HasIndex("ShopEffectId");

                    b.HasIndex("ShopItemInfoId");

                    b.HasIndex("ShopPriceId");

                    b.ToTable("start_items");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerCharacterEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Accessory")
                        .WithMany()
                        .HasForeignKey("AccessoryId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Face")
                        .WithMany()
                        .HasForeignKey("FaceId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Gloves")
                        .WithMany()
                        .HasForeignKey("GlovesId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Hair")
                        .WithMany()
                        .HasForeignKey("HairId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Pants")
                        .WithMany()
                        .HasForeignKey("PantsId");

                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "Player")
                        .WithMany("Characters")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Shirt")
                        .WithMany()
                        .HasForeignKey("ShirtId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Shoes")
                        .WithMany()
                        .HasForeignKey("ShoesId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Weapon1")
                        .WithMany()
                        .HasForeignKey("Weapon1Id");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Weapon2")
                        .WithMany()
                        .HasForeignKey("Weapon2Id");

                    b.HasOne("Netsphere.Database.Game.PlayerItemEntity", "Weapon3")
                        .WithMany()
                        .HasForeignKey("Weapon3Id");
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerDenyEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "DenyPlayer")
                        .WithMany()
                        .HasForeignKey("DenyPlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "Player")
                        .WithMany("Ignores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerItemEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "Player")
                        .WithMany("Items")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopItemInfoEntity", "ShopItemInfo")
                        .WithMany()
                        .HasForeignKey("ShopItemInfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopPriceEntity", "ShopPrice")
                        .WithMany()
                        .HasForeignKey("ShopPriceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerMailEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "Player")
                        .WithMany("Inbox")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "SenderPlayer")
                        .WithMany()
                        .HasForeignKey("SenderPlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.PlayerSettingEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.PlayerEntity", "Player")
                        .WithMany("Settings")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopEffectEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.ShopEffectGroupEntity", "EffectGroup")
                        .WithMany("ShopEffects")
                        .HasForeignKey("EffectGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopItemInfoEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.ShopEffectGroupEntity", "EffectGroup")
                        .WithMany()
                        .HasForeignKey("EffectGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopPriceGroupEntity", "PriceGroup")
                        .WithMany()
                        .HasForeignKey("PriceGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopItemEntity", "ShopItem")
                        .WithMany("ItemInfos")
                        .HasForeignKey("ShopItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.ShopPriceEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.ShopPriceGroupEntity", "PriceGroup")
                        .WithMany("ShopPrices")
                        .HasForeignKey("PriceGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Game.StartItemEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Game.ShopEffectEntity", "ShopEffect")
                        .WithMany()
                        .HasForeignKey("ShopEffectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopItemInfoEntity", "ShopItemInfo")
                        .WithMany()
                        .HasForeignKey("ShopItemInfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Netsphere.Database.Game.ShopPriceEntity", "ShopPrice")
                        .WithMany()
                        .HasForeignKey("ShopPriceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
