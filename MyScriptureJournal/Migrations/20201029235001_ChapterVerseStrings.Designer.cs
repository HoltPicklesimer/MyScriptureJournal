﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Migrations
{
    [DbContext(typeof(MyScriptureJournalContext))]
    [Migration("20201029235001_ChapterVerseStrings")]
    partial class ChapterVerseStrings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyScriptureJournal.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CanonId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CanonId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.Canon", b =>
                {
                    b.Property<int>("CanonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CanonId");

                    b.ToTable("Canon");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.JournalEntry", b =>
                {
                    b.Property<int>("JournalEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Chapter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Verse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JournalEntryId");

                    b.HasIndex("BookId");

                    b.ToTable("JournalEntry");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.Book", b =>
                {
                    b.HasOne("MyScriptureJournal.Models.Canon", "Canon")
                        .WithMany()
                        .HasForeignKey("CanonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyScriptureJournal.Models.JournalEntry", b =>
                {
                    b.HasOne("MyScriptureJournal.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
