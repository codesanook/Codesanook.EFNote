﻿// <auto-generated />
using System;
using Codesanook.EFNote.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Codesanook.EFNote.Migrations
{
    [DbContext(typeof(NoteDbContext))]
    partial class NoteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Codesanook.EFNote.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_utc");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<int>("NotebookId")
                        .HasColumnType("int")
                        .HasColumnName("notebook_id");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_end");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_start");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_utc");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int")
                        .HasColumnName("view_count");

                    b.HasKey("Id")
                        .HasName("pk_note");

                    b.HasIndex("NotebookId")
                        .HasDatabaseName("ix_note_notebook_id");

                    b.ToTable("note", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                        {
                            ttb
                                .HasPeriodStart("PeriodStart")
                                .HasColumnName("period_start");
                            ttb
                                .HasPeriodEnd("PeriodEnd")
                                .HasColumnName("period_end");
                        }
                    ));
                });

            modelBuilder.Entity("Codesanook.EFNote.Models.Notebook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("name");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_end");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_start");

                    b.HasKey("Id")
                        .HasName("pk_notebook");

                    b.ToTable("notebook", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                        {
                            ttb
                                .HasPeriodStart("PeriodStart")
                                .HasColumnName("period_start");
                            ttb
                                .HasPeriodEnd("PeriodEnd")
                                .HasColumnName("period_end");
                        }
                    ));
                });

            modelBuilder.Entity("Codesanook.EFNote.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("name");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_end");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_start");

                    b.HasKey("Id")
                        .HasName("pk_tag");

                    b.ToTable("tag", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                        {
                            ttb
                                .HasPeriodStart("PeriodStart")
                                .HasColumnName("period_start");
                            ttb
                                .HasPeriodEnd("PeriodEnd")
                                .HasColumnName("period_end");
                        }
                    ));
                });

            modelBuilder.Entity("NoteTag", b =>
                {
                    b.Property<int>("NotesId")
                        .HasColumnType("int")
                        .HasColumnName("notes_id");

                    b.Property<int>("TagsId")
                        .HasColumnType("int")
                        .HasColumnName("tags_id");

                    b.Property<DateTime>("PeriodEnd")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_end");

                    b.Property<DateTime>("PeriodStart")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("period_start");

                    b.HasKey("NotesId", "TagsId")
                        .HasName("pk_note_tag");

                    b.HasIndex("TagsId")
                        .HasDatabaseName("ix_note_tag_tags_id");

                    b.ToTable("note_tag", (string)null);

                    b.ToTable(tb => tb.IsTemporal(ttb =>
                        {
                            ttb
                                .HasPeriodStart("PeriodStart")
                                .HasColumnName("period_start");
                            ttb
                                .HasPeriodEnd("PeriodEnd")
                                .HasColumnName("period_end");
                        }
                    ));
                });

            modelBuilder.Entity("Codesanook.EFNote.Models.Note", b =>
                {
                    b.HasOne("Codesanook.EFNote.Models.Notebook", "Notebook")
                        .WithMany("Notes")
                        .HasForeignKey("NotebookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_note_notebook_notebook_id");

                    b.Navigation("Notebook");
                });

            modelBuilder.Entity("NoteTag", b =>
                {
                    b.HasOne("Codesanook.EFNote.Models.Note", null)
                        .WithMany()
                        .HasForeignKey("NotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_note_tag_notes_notes_id");

                    b.HasOne("Codesanook.EFNote.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_note_tag_tags_tags_id");
                });

            modelBuilder.Entity("Codesanook.EFNote.Models.Notebook", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
