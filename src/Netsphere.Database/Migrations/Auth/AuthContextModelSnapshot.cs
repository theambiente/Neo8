﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netsphere.Database;

namespace Netsphere.Database.Migrations.Auth
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Netsphere.Database.Auth.AccountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nickname")
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .HasMaxLength(40);

                    b.Property<string>("Salt")
                        .HasMaxLength(40);

                    b.Property<byte>("SecurityLevel");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Nickname")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Netsphere.Database.Auth.BanEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<long>("Date");

                    b.Property<long?>("Duration");

                    b.Property<string>("Reason");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("bans");
                });

            modelBuilder.Entity("Netsphere.Database.Auth.LoginHistoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<long>("Date");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("login_history");
                });

            modelBuilder.Entity("Netsphere.Database.Auth.NicknameHistoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<long?>("ExpireDate");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("nickname_history");
                });

            modelBuilder.Entity("Netsphere.Database.Auth.BanEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Auth.AccountEntity", "Account")
                        .WithMany("Bans")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Auth.LoginHistoryEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Auth.AccountEntity", "Account")
                        .WithMany("LoginHistory")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Netsphere.Database.Auth.NicknameHistoryEntity", b =>
                {
                    b.HasOne("Netsphere.Database.Auth.AccountEntity", "Account")
                        .WithMany("NicknameHistory")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
