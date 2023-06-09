﻿// <auto-generated />
using System;
using CMDB_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMDB_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("CMDB")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Actors", b =>
                {
                    b.Property<int>("Actors_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Actors_Id"));

                    b.Property<string>("Actors_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime>("Date_of_Birdth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Profile_Pic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Actors_Id");

                    b.HasIndex("Actors_Name")
                        .IsUnique();

                    b.ToTable("Actors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Directors", b =>
                {
                    b.Property<int>("Directors_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Directors_Id"));

                    b.Property<int>("Directors_Name")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Directors_Id");

                    b.ToTable("Directors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Genres", b =>
                {
                    b.Property<int>("Genre_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Genre_Id"));

                    b.Property<string>("Genre_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Genre_Id");

                    b.HasIndex("Genre_Name");

                    b.ToTable("Genres", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.MediaType", b =>
                {
                    b.Property<int>("Media_TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Media_TypeId"));

                    b.Property<string>("Media_Type_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Media_TypeId");

                    b.HasIndex("Media_Type_Name")
                        .IsUnique();

                    b.ToTable("MediaType", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie", b =>
                {
                    b.Property<int>("Movie_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Movie_Id"));

                    b.Property<double>("Average_Rating")
                        .HasColumnType("float");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("OverView")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Poster_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Runtime")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Movie_Id");

                    b.HasIndex("MediaTypeId")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Movie", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Actors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Actors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Movies_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Actors_Id");

                    b.HasIndex("Movies_Id");

                    b.ToTable("Movie_Actors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Directors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Directors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Movies_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Directors_Id");

                    b.HasIndex("Movies_Id");

                    b.ToTable("Movie_Directors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Genres_Id")
                        .HasColumnType("int");

                    b.Property<int>("Movie_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Genres_Id");

                    b.HasIndex("Movie_Id");

                    b.ToTable("Movie_Genres", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series", b =>
                {
                    b.Property<int>("Series_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Series_Id"));

                    b.Property<double>("Average_Rating")
                        .HasColumnType("float");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("OverView")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Poster_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Series_Id");

                    b.HasIndex("MediaTypeId")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Series", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Actors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Actors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Series_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Actors_Id");

                    b.HasIndex("Series_Id");

                    b.ToTable("Series_Actors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Directors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Directors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Series_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Directors_Id");

                    b.HasIndex("Series_Id");

                    b.ToTable("Series_Directors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Genres_Id")
                        .HasColumnType("int");

                    b.Property<int>("Series_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Genres_Id");

                    b.HasIndex("Series_Id");

                    b.ToTable("Series_Genres", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Actors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Actors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tvshow_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Actors_Id");

                    b.HasIndex("Tvshow_Id");

                    b.ToTable("TvShow_Actors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Directors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Directors_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tvshow_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Directors_Id");

                    b.HasIndex("Tvshow_Id");

                    b.ToTable("TvShow_Directors", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Genres_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tvshow_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Genres_Id");

                    b.HasIndex("Tvshow_Id");

                    b.ToTable("TvShow_Genres", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShows", b =>
                {
                    b.Property<int>("Tvshow_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tvshow_Id"));

                    b.Property<double>("Average_Rating")
                        .HasColumnType("float");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("OverView")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Poster_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Tvshow_Id");

                    b.HasIndex("MediaTypeId")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("TvShows", "CMDB");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.MediaType", "MediaType")
                        .WithOne("Movie")
                        .HasForeignKey("CMDB_BackEnd.Domain.Data.Movie", "MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Actors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Actors", "Actors")
                        .WithMany("Movie_Actors")
                        .HasForeignKey("Actors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Movie", "Movies")
                        .WithMany("Movie_Actors")
                        .HasForeignKey("Movies_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Directors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Directors", "Directors")
                        .WithMany("Movie_Directors")
                        .HasForeignKey("Directors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Movie", "Movies")
                        .WithMany("Movie_Directors")
                        .HasForeignKey("Movies_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directors");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie_Genres", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Genres", "Genres")
                        .WithMany("Movie_Genres")
                        .HasForeignKey("Genres_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Movie", "Movie")
                        .WithMany("Movie_Genres")
                        .HasForeignKey("Movie_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.MediaType", "MediaType")
                        .WithOne("Series")
                        .HasForeignKey("CMDB_BackEnd.Domain.Data.Series", "MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Actors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Actors", "Actors")
                        .WithMany("Series_Actors")
                        .HasForeignKey("Actors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Series", "Series")
                        .WithMany("Series_Actors")
                        .HasForeignKey("Series_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Directors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Directors", "Directors")
                        .WithMany("Series_Directors")
                        .HasForeignKey("Directors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Series", "Series")
                        .WithMany("Series_Directors")
                        .HasForeignKey("Series_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directors");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series_Genres", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Genres", "Genres")
                        .WithMany("Series_Genres")
                        .HasForeignKey("Genres_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.Series", "Series")
                        .WithMany("Series_Genres")
                        .HasForeignKey("Series_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Actors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Actors", "Actors")
                        .WithMany("TvShow_Actors")
                        .HasForeignKey("Actors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.TvShows", "TvShows")
                        .WithMany("TvShow_Actors")
                        .HasForeignKey("Tvshow_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("TvShows");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Directors", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Directors", "Directors")
                        .WithMany("TvShow_Directors")
                        .HasForeignKey("Directors_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.TvShows", "TvShows")
                        .WithMany("TvShow_Directors")
                        .HasForeignKey("Tvshow_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directors");

                    b.Navigation("TvShows");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShow_Genres", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.Genres", "Genres")
                        .WithMany("TvShow_Genres")
                        .HasForeignKey("Genres_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMDB_BackEnd.Domain.Data.TvShows", "TvShows")
                        .WithMany("TvShow_Genres")
                        .HasForeignKey("Tvshow_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("TvShows");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShows", b =>
                {
                    b.HasOne("CMDB_BackEnd.Domain.Data.MediaType", "MediaType")
                        .WithOne("TvShows")
                        .HasForeignKey("CMDB_BackEnd.Domain.Data.TvShows", "MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Actors", b =>
                {
                    b.Navigation("Movie_Actors");

                    b.Navigation("Series_Actors");

                    b.Navigation("TvShow_Actors");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Directors", b =>
                {
                    b.Navigation("Movie_Directors");

                    b.Navigation("Series_Directors");

                    b.Navigation("TvShow_Directors");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Genres", b =>
                {
                    b.Navigation("Movie_Genres");

                    b.Navigation("Series_Genres");

                    b.Navigation("TvShow_Genres");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.MediaType", b =>
                {
                    b.Navigation("Movie")
                        .IsRequired();

                    b.Navigation("Series")
                        .IsRequired();

                    b.Navigation("TvShows")
                        .IsRequired();
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Movie", b =>
                {
                    b.Navigation("Movie_Actors");

                    b.Navigation("Movie_Directors");

                    b.Navigation("Movie_Genres");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.Series", b =>
                {
                    b.Navigation("Series_Actors");

                    b.Navigation("Series_Directors");

                    b.Navigation("Series_Genres");
                });

            modelBuilder.Entity("CMDB_BackEnd.Domain.Data.TvShows", b =>
                {
                    b.Navigation("TvShow_Actors");

                    b.Navigation("TvShow_Directors");

                    b.Navigation("TvShow_Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
