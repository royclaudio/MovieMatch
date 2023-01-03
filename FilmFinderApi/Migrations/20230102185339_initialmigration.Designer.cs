﻿// <auto-generated />
using System;
using FilmFinderApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmFinderApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230102185339_initialmigration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("MovieCatalogModelUserModel", b =>
                {
                    b.Property<int>("MovieCatalogsMovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieCatalogsMovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieCatalogModelUserModel");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.MovieCatalogModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AO")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Action")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actors")
                        .HasColumnType("TEXT");

                    b.Property<int>("Adventure")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Animation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Awards")
                        .HasColumnType("TEXT");

                    b.Property<int>("Biography")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Box_office")
                        .HasColumnType("TEXT");

                    b.Property<int>("Comedy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("Crime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<int>("Documentary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Drama")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eighties")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Family")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fantasy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<int>("History")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Horror")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<int>("M_PG")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Metascore")
                        .HasColumnType("TEXT");

                    b.Property<int>("Music")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Musical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mystery")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NC_17")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NOT_RATED")
                        .HasColumnType("INTEGER");

                    b.Property<int>("N_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("News")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nineties")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PASSED")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PG")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PG_13")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<int>("R")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rated")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rated_G")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RealityTV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Released")
                        .HasColumnType("TEXT");

                    b.Property<string>("Response")
                        .HasColumnType("TEXT");

                    b.Property<int>("Romance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Runtime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sci_Fi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Short")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sport")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TV_14")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TV_G")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TV_MA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TV_PG")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Thriller")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Twenty_tens")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Two_Thousand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("UNRATED")
                        .HasColumnType("INTEGER");

                    b.Property<int>("War")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Western")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Writer")
                        .HasColumnType("TEXT");

                    b.Property<int>("X")
                        .HasColumnType("INTEGER");

                    b.Property<string>("image_file")
                        .HasColumnType("TEXT");

                    b.Property<string>("imdbID")
                        .HasColumnType("TEXT");

                    b.Property<string>("imdbRating")
                        .HasColumnType("TEXT");

                    b.Property<string>("imdbVotes")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("MovieCatalog");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserAverageFeaturesModel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Action")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adventure")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Animation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Biography")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comedy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Crime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Documentary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Drama")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Family")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fantasy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("History")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Horror")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Music")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Musical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mystery")
                        .HasColumnType("INTEGER");

                    b.Property<int>("News")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reality_TV")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Romance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sci_Fi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Short")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sport")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Thriller")
                        .HasColumnType("INTEGER");

                    b.Property<int>("War")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Western")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("UserAverageFeatures");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserFeaturesModel", b =>
                {
                    b.Property<int>("FeaturesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Action")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adventure")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Animation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Biography")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comedy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Crime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Documentary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Drama")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Family")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fantasy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("History")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Horror")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieCatalogMovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Music")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Musical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mystery")
                        .HasColumnType("INTEGER");

                    b.Property<int>("News")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reality_TV")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Romance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sci_Fi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Short")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sport")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Thriller")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("War")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Western")
                        .HasColumnType("INTEGER");

                    b.HasKey("FeaturesId");

                    b.HasIndex("MovieCatalogMovieId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFeatures");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserRatingsModel", b =>
                {
                    b.Property<int>("RatingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MovieCatalogMovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingsId");

                    b.HasIndex("MovieCatalogMovieId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRatings");
                });

            modelBuilder.Entity("MovieCatalogModelUserModel", b =>
                {
                    b.HasOne("MovieMauiAPI.Models.MovieCatalogModel", null)
                        .WithMany()
                        .HasForeignKey("MovieCatalogsMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieMauiAPI.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserAverageFeaturesModel", b =>
                {
                    b.HasOne("MovieMauiAPI.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserFeaturesModel", b =>
                {
                    b.HasOne("MovieMauiAPI.Models.MovieCatalogModel", "MovieCatalog")
                        .WithMany()
                        .HasForeignKey("MovieCatalogMovieId");

                    b.HasOne("MovieMauiAPI.Models.UserModel", "User")
                        .WithMany("UserInteractions")
                        .HasForeignKey("UserId");

                    b.Navigation("MovieCatalog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserRatingsModel", b =>
                {
                    b.HasOne("MovieMauiAPI.Models.MovieCatalogModel", "MovieCatalog")
                        .WithMany()
                        .HasForeignKey("MovieCatalogMovieId");

                    b.HasOne("MovieMauiAPI.Models.UserModel", "User")
                        .WithMany("UserRatings")
                        .HasForeignKey("UserId");

                    b.Navigation("MovieCatalog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieMauiAPI.Models.UserModel", b =>
                {
                    b.Navigation("UserInteractions");

                    b.Navigation("UserRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
