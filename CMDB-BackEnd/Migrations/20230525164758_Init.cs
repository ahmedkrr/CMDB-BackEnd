using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMDB_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CMDB");

            migrationBuilder.CreateTable(
                name: "Actors",
                schema: "CMDB",
                columns: table => new
                {
                    Actors_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actors_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date_of_Birdth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Profile_Pic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Actors_Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                schema: "CMDB",
                columns: table => new
                {
                    Directors_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Directors_Name = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Directors_Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                schema: "CMDB",
                columns: table => new
                {
                    Genre_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Genre_Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaType",
                schema: "CMDB",
                columns: table => new
                {
                    Media_TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Media_Type_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaType", x => x.Media_TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                schema: "CMDB",
                columns: table => new
                {
                    Movie_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OverView = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Runtime = table.Column<double>(type: "float", nullable: false),
                    Poster_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Average_Rating = table.Column<double>(type: "float", nullable: false),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Movie_Id);
                    table.ForeignKey(
                        name: "FK_Movie_MediaType_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalSchema: "CMDB",
                        principalTable: "MediaType",
                        principalColumn: "Media_TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                schema: "CMDB",
                columns: table => new
                {
                    Series_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OverView = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Poster_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Average_Rating = table.Column<double>(type: "float", nullable: false),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Series_Id);
                    table.ForeignKey(
                        name: "FK_Series_MediaType_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalSchema: "CMDB",
                        principalTable: "MediaType",
                        principalColumn: "Media_TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                schema: "CMDB",
                columns: table => new
                {
                    Tvshow_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OverView = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Poster_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Average_Rating = table.Column<double>(type: "float", nullable: false),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.Tvshow_Id);
                    table.ForeignKey(
                        name: "FK_TvShows_MediaType_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalSchema: "CMDB",
                        principalTable: "MediaType",
                        principalColumn: "Media_TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Actors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actors_Id = table.Column<int>(type: "int", nullable: false),
                    Movies_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Actors_Actors_Actors_Id",
                        column: x => x.Actors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Actors",
                        principalColumn: "Actors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Actors_Movie_Movies_Id",
                        column: x => x.Movies_Id,
                        principalSchema: "CMDB",
                        principalTable: "Movie",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Directors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Directors_Id = table.Column<int>(type: "int", nullable: false),
                    Movies_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Directors_Directors_Directors_Id",
                        column: x => x.Directors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Directors",
                        principalColumn: "Directors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Directors_Movie_Movies_Id",
                        column: x => x.Movies_Id,
                        principalSchema: "CMDB",
                        principalTable: "Movie",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Genres",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genres_Id = table.Column<int>(type: "int", nullable: false),
                    Movie_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Genres_Genres_Genres_Id",
                        column: x => x.Genres_Id,
                        principalSchema: "CMDB",
                        principalTable: "Genres",
                        principalColumn: "Genre_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Genres_Movie_Movie_Id",
                        column: x => x.Movie_Id,
                        principalSchema: "CMDB",
                        principalTable: "Movie",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series_Actors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actors_Id = table.Column<int>(type: "int", nullable: false),
                    Series_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Actors_Actors_Actors_Id",
                        column: x => x.Actors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Actors",
                        principalColumn: "Actors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Series_Actors_Series_Series_Id",
                        column: x => x.Series_Id,
                        principalSchema: "CMDB",
                        principalTable: "Series",
                        principalColumn: "Series_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series_Directors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Directors_Id = table.Column<int>(type: "int", nullable: false),
                    Series_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Directors_Directors_Directors_Id",
                        column: x => x.Directors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Directors",
                        principalColumn: "Directors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Series_Directors_Series_Series_Id",
                        column: x => x.Series_Id,
                        principalSchema: "CMDB",
                        principalTable: "Series",
                        principalColumn: "Series_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series_Genres",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genres_Id = table.Column<int>(type: "int", nullable: false),
                    Series_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Genres_Genres_Genres_Id",
                        column: x => x.Genres_Id,
                        principalSchema: "CMDB",
                        principalTable: "Genres",
                        principalColumn: "Genre_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Series_Genres_Series_Series_Id",
                        column: x => x.Series_Id,
                        principalSchema: "CMDB",
                        principalTable: "Series",
                        principalColumn: "Series_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShow_Actors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actors_Id = table.Column<int>(type: "int", nullable: false),
                    Tvshow_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShow_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShow_Actors_Actors_Actors_Id",
                        column: x => x.Actors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Actors",
                        principalColumn: "Actors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShow_Actors_TvShows_Tvshow_Id",
                        column: x => x.Tvshow_Id,
                        principalSchema: "CMDB",
                        principalTable: "TvShows",
                        principalColumn: "Tvshow_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShow_Directors",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Directors_Id = table.Column<int>(type: "int", nullable: false),
                    Tvshow_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShow_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShow_Directors_Directors_Directors_Id",
                        column: x => x.Directors_Id,
                        principalSchema: "CMDB",
                        principalTable: "Directors",
                        principalColumn: "Directors_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShow_Directors_TvShows_Tvshow_Id",
                        column: x => x.Tvshow_Id,
                        principalSchema: "CMDB",
                        principalTable: "TvShows",
                        principalColumn: "Tvshow_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShow_Genres",
                schema: "CMDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genres_Id = table.Column<int>(type: "int", nullable: false),
                    Tvshow_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShow_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShow_Genres_Genres_Genres_Id",
                        column: x => x.Genres_Id,
                        principalSchema: "CMDB",
                        principalTable: "Genres",
                        principalColumn: "Genre_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShow_Genres_TvShows_Tvshow_Id",
                        column: x => x.Tvshow_Id,
                        principalSchema: "CMDB",
                        principalTable: "TvShows",
                        principalColumn: "Tvshow_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Actors_Name",
                schema: "CMDB",
                table: "Actors",
                column: "Actors_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Genre_Name",
                schema: "CMDB",
                table: "Genres",
                column: "Genre_Name");

            migrationBuilder.CreateIndex(
                name: "IX_MediaType_Media_Type_Name",
                schema: "CMDB",
                table: "MediaType",
                column: "Media_Type_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MediaTypeId",
                schema: "CMDB",
                table: "Movie",
                column: "MediaTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Title",
                schema: "CMDB",
                table: "Movie",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Actors_Actors_Id",
                schema: "CMDB",
                table: "Movie_Actors",
                column: "Actors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Actors_Movies_Id",
                schema: "CMDB",
                table: "Movie_Actors",
                column: "Movies_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Directors_Directors_Id",
                schema: "CMDB",
                table: "Movie_Directors",
                column: "Directors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Directors_Movies_Id",
                schema: "CMDB",
                table: "Movie_Directors",
                column: "Movies_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Genres_Genres_Id",
                schema: "CMDB",
                table: "Movie_Genres",
                column: "Genres_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Genres_Movie_Id",
                schema: "CMDB",
                table: "Movie_Genres",
                column: "Movie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_MediaTypeId",
                schema: "CMDB",
                table: "Series",
                column: "MediaTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Series_Title",
                schema: "CMDB",
                table: "Series",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Series_Actors_Actors_Id",
                schema: "CMDB",
                table: "Series_Actors",
                column: "Actors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Actors_Series_Id",
                schema: "CMDB",
                table: "Series_Actors",
                column: "Series_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Directors_Directors_Id",
                schema: "CMDB",
                table: "Series_Directors",
                column: "Directors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Directors_Series_Id",
                schema: "CMDB",
                table: "Series_Directors",
                column: "Series_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Genres_Genres_Id",
                schema: "CMDB",
                table: "Series_Genres",
                column: "Genres_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Genres_Series_Id",
                schema: "CMDB",
                table: "Series_Genres",
                column: "Series_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Actors_Actors_Id",
                schema: "CMDB",
                table: "TvShow_Actors",
                column: "Actors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Actors_Tvshow_Id",
                schema: "CMDB",
                table: "TvShow_Actors",
                column: "Tvshow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Directors_Directors_Id",
                schema: "CMDB",
                table: "TvShow_Directors",
                column: "Directors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Directors_Tvshow_Id",
                schema: "CMDB",
                table: "TvShow_Directors",
                column: "Tvshow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Genres_Genres_Id",
                schema: "CMDB",
                table: "TvShow_Genres",
                column: "Genres_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_Genres_Tvshow_Id",
                schema: "CMDB",
                table: "TvShow_Genres",
                column: "Tvshow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TvShows_MediaTypeId",
                schema: "CMDB",
                table: "TvShows",
                column: "MediaTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TvShows_Title",
                schema: "CMDB",
                table: "TvShows",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Actors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Movie_Directors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Movie_Genres",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Series_Actors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Series_Directors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Series_Genres",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "TvShow_Actors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "TvShow_Directors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "TvShow_Genres",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Movie",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Series",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Actors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Directors",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "TvShows",
                schema: "CMDB");

            migrationBuilder.DropTable(
                name: "MediaType",
                schema: "CMDB");
        }
    }
}
