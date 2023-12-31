﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatchManager.Model;

namespace PatchManager.Migrations
{
    [DbContext(typeof(PatchDbContext))]
    [Migration("20210613225601_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PatchManager.Model.Entity.ManagedProgramEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("managed_program");
                });

            modelBuilder.Entity("PatchManager.Model.Entity.PatchEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromVersionId");

                    b.Property<int>("ManagedProgramId");

                    b.Property<int>("ToVersionId");

                    b.HasKey("Id");

                    b.HasIndex("FromVersionId");

                    b.HasIndex("ManagedProgramId");

                    b.HasIndex("ToVersionId");

                    b.ToTable("patch");
                });

            modelBuilder.Entity("PatchManager.Model.Entity.ProgramVersionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Major");

                    b.Property<int>("ManagedProgramId");

                    b.Property<int>("Minor");

                    b.Property<int>("Patch");

                    b.HasKey("Id");

                    b.HasIndex("ManagedProgramId");

                    b.ToTable("program_version");
                });

            modelBuilder.Entity("PatchManager.Model.Entity.PatchEntity", b =>
                {
                    b.HasOne("PatchManager.Model.Entity.ProgramVersionEntity", "FromVersion")
                        .WithMany()
                        .HasForeignKey("FromVersionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PatchManager.Model.Entity.ManagedProgramEntity", "ManagedProgram")
                        .WithMany("Patches")
                        .HasForeignKey("ManagedProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PatchManager.Model.Entity.ProgramVersionEntity", "ToVersion")
                        .WithMany()
                        .HasForeignKey("ToVersionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PatchManager.Model.Entity.ProgramVersionEntity", b =>
                {
                    b.HasOne("PatchManager.Model.Entity.ManagedProgramEntity", "ManagedProgram")
                        .WithMany("ProgramVersions")
                        .HasForeignKey("ManagedProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
