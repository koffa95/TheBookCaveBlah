﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TheBookCave.Data;

namespace TheBookCave.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180507182047_authorTable")]
    partial class authorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Author", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<bool>("alive");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("authorId");

                    b.Property<string>("genre");

                    b.Property<string>("language");

                    b.Property<string>("originalLanguage");

                    b.Property<int>("pages");

                    b.Property<int>("price");

                    b.Property<string>("publisher");

                    b.Property<int>("releaseYear");

                    b.Property<string>("title");

                    b.Property<string>("translator");

                    b.HasKey("id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}