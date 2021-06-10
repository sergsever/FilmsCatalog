﻿// <auto-generated />
using System;
using FilmsCatalog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmsCatalog.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20210609060309_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FilmsCatalog.Data.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Джон Уэйн"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Клин Иствуд"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Чарльз Бронсон"
                        });
                });

            modelBuilder.Entity("FilmsCatalog.Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "вестерн",
                            Release = new DateTime(1930, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Большой след"
                        },
                        new
                        {
                            Id = 2,
                            Description = "детектив",
                            Release = new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Грязный Гарри"
                        },
                        new
                        {
                            Id = 3,
                            Description = "вестерн",
                            Release = new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Дилижанс"
                        },
                        new
                        {
                            Id = 4,
                            Description = "военный",
                            Release = new DateTime(1962, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Самый длинный день"
                        },
                        new
                        {
                            Id = 5,
                            Description = "детектив",
                            Release = new DateTime(1944, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "В седле"
                        },
                        new
                        {
                            Id = 6,
                            Description = "вестерн",
                            Release = new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "За пригрошню долларов"
                        },
                        new
                        {
                            Id = 7,
                            Description = "вестерн",
                            Release = new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Хороший, плохой, злой"
                        },
                        new
                        {
                            Id = 8,
                            Description = "военный",
                            Release = new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Куда не долетают орлы"
                        },
                        new
                        {
                            Id = 9,
                            Description = "военный",
                            Release = new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Большой побег"
                        },
                        new
                        {
                            Id = 10,
                            Description = "вестерн",
                            Release = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Белый бизон"
                        });
                });

            modelBuilder.Entity("FilmsCatalog.Data.Entities.Actor", b =>
                {
                    b.HasOne("FilmsCatalog.Data.Entities.Movie", null)
                        .WithMany("FilmActors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("FilmsCatalog.Data.Entities.Movie", b =>
                {
                    b.Navigation("FilmActors");
                });
#pragma warning restore 612, 618
        }
    }
}
