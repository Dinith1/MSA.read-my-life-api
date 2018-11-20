﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadMyLife.Models;

namespace ReadMyLife.Migrations
{
    [DbContext(typeof(ReadMyLifeContext))]
    partial class ReadMyLifeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ReadMyLife.Models.StoryItem", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorID");

                    b.Property<string>("AuthorName");

                    b.Property<string>("Contents");

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<int>("NumRatings");

                    b.Property<string>("Rating");

                    b.Property<string>("Tag");

                    b.Property<string>("Title");

                    b.HasKey("StoryID");

                    b.ToTable("StoryItem");
                });
#pragma warning restore 612, 618
        }
    }
}