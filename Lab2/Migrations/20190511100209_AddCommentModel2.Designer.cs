﻿// <auto-generated />
using System;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab2.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20190511100209_AddCommentModel2")]
    partial class AddCommentModel2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab2.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Important");

                    b.Property<int?>("MovieId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Lab2.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<int>("DurationInMinutes");

                    b.Property<string>("Genre");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.Property<string>("Watched");

                    b.Property<int>("YearOfRelease");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Lab2.Models.Comment", b =>
                {
                    b.HasOne("Lab2.Models.Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
