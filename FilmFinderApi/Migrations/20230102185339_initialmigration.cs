using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmFinderApi.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCatalog",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Boxoffice = table.Column<string>(name: "Box_office", type: "TEXT", nullable: true),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    imdbID = table.Column<string>(type: "TEXT", nullable: true),
                    Poster = table.Column<string>(type: "TEXT", nullable: true),
                    Metascore = table.Column<string>(type: "TEXT", nullable: true),
                    Language = table.Column<string>(type: "TEXT", nullable: true),
                    Writer = table.Column<string>(type: "TEXT", nullable: true),
                    imdbVotes = table.Column<string>(type: "TEXT", nullable: true),
                    Runtime = table.Column<string>(type: "TEXT", nullable: true),
                    Response = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Actors = table.Column<string>(type: "TEXT", nullable: true),
                    Awards = table.Column<string>(type: "TEXT", nullable: true),
                    imdbRating = table.Column<string>(type: "TEXT", nullable: true),
                    Rated = table.Column<string>(type: "TEXT", nullable: true),
                    Released = table.Column<string>(type: "TEXT", nullable: true),
                    imagefile = table.Column<string>(name: "image_file", type: "TEXT", nullable: true),
                    Musical = table.Column<int>(type: "INTEGER", nullable: false),
                    Family = table.Column<int>(type: "INTEGER", nullable: false),
                    RealityTV = table.Column<int>(type: "INTEGER", nullable: false),
                    Western = table.Column<int>(type: "INTEGER", nullable: false),
                    Comedy = table.Column<int>(type: "INTEGER", nullable: false),
                    Mystery = table.Column<int>(type: "INTEGER", nullable: false),
                    Music = table.Column<int>(type: "INTEGER", nullable: false),
                    Fantasy = table.Column<int>(type: "INTEGER", nullable: false),
                    News = table.Column<int>(type: "INTEGER", nullable: false),
                    Adventure = table.Column<int>(type: "INTEGER", nullable: false),
                    Documentary = table.Column<int>(type: "INTEGER", nullable: false),
                    Crime = table.Column<int>(type: "INTEGER", nullable: false),
                    Horror = table.Column<int>(type: "INTEGER", nullable: false),
                    Romance = table.Column<int>(type: "INTEGER", nullable: false),
                    SciFi = table.Column<int>(name: "Sci_Fi", type: "INTEGER", nullable: false),
                    Sport = table.Column<int>(type: "INTEGER", nullable: false),
                    Animation = table.Column<int>(type: "INTEGER", nullable: false),
                    Biography = table.Column<int>(type: "INTEGER", nullable: false),
                    War = table.Column<int>(type: "INTEGER", nullable: false),
                    History = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<int>(type: "INTEGER", nullable: false),
                    Short = table.Column<int>(type: "INTEGER", nullable: false),
                    Thriller = table.Column<int>(type: "INTEGER", nullable: false),
                    Drama = table.Column<int>(type: "INTEGER", nullable: false),
                    TwoThousand = table.Column<int>(name: "Two_Thousand", type: "INTEGER", nullable: false),
                    Nineties = table.Column<int>(type: "INTEGER", nullable: false),
                    Twentytens = table.Column<int>(name: "Twenty_tens", type: "INTEGER", nullable: false),
                    Eighties = table.Column<int>(type: "INTEGER", nullable: false),
                    NOTRATED = table.Column<int>(name: "NOT_RATED", type: "INTEGER", nullable: false),
                    RatedG = table.Column<int>(name: "Rated_G", type: "INTEGER", nullable: false),
                    PASSED = table.Column<int>(type: "INTEGER", nullable: false),
                    UNRATED = table.Column<int>(type: "INTEGER", nullable: false),
                    TVG = table.Column<int>(name: "TV_G", type: "INTEGER", nullable: false),
                    AO = table.Column<int>(type: "INTEGER", nullable: false),
                    NA = table.Column<int>(name: "N_A", type: "INTEGER", nullable: false),
                    TV14 = table.Column<int>(name: "TV_14", type: "INTEGER", nullable: false),
                    R = table.Column<int>(type: "INTEGER", nullable: false),
                    TVMA = table.Column<int>(name: "TV_MA", type: "INTEGER", nullable: false),
                    PG = table.Column<int>(type: "INTEGER", nullable: false),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    PG13 = table.Column<int>(name: "PG_13", type: "INTEGER", nullable: false),
                    NC17 = table.Column<int>(name: "NC_17", type: "INTEGER", nullable: false),
                    MPG = table.Column<int>(name: "M_PG", type: "INTEGER", nullable: false),
                    TVPG = table.Column<int>(name: "TV_PG", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCatalog", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TempPassword = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MovieCatalogModelUserModel",
                columns: table => new
                {
                    MovieCatalogsMovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCatalogModelUserModel", x => new { x.MovieCatalogsMovieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MovieCatalogModelUserModel_MovieCatalog_MovieCatalogsMovieId",
                        column: x => x.MovieCatalogsMovieId,
                        principalTable: "MovieCatalog",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCatalogModelUserModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAverageFeatures",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Musical = table.Column<int>(type: "INTEGER", nullable: false),
                    Family = table.Column<int>(type: "INTEGER", nullable: false),
                    RealityTV = table.Column<int>(name: "Reality_TV", type: "INTEGER", nullable: false),
                    Western = table.Column<int>(type: "INTEGER", nullable: false),
                    Comedy = table.Column<int>(type: "INTEGER", nullable: false),
                    Mystery = table.Column<int>(type: "INTEGER", nullable: false),
                    Music = table.Column<int>(type: "INTEGER", nullable: false),
                    Fantasy = table.Column<int>(type: "INTEGER", nullable: false),
                    News = table.Column<int>(type: "INTEGER", nullable: false),
                    Adventure = table.Column<int>(type: "INTEGER", nullable: false),
                    Documentary = table.Column<int>(type: "INTEGER", nullable: false),
                    Crime = table.Column<int>(type: "INTEGER", nullable: false),
                    Horror = table.Column<int>(type: "INTEGER", nullable: false),
                    Romance = table.Column<int>(type: "INTEGER", nullable: false),
                    SciFi = table.Column<int>(name: "Sci_Fi", type: "INTEGER", nullable: false),
                    Sport = table.Column<int>(type: "INTEGER", nullable: false),
                    Animation = table.Column<int>(type: "INTEGER", nullable: false),
                    Biography = table.Column<int>(type: "INTEGER", nullable: false),
                    War = table.Column<int>(type: "INTEGER", nullable: false),
                    History = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<int>(type: "INTEGER", nullable: false),
                    Short = table.Column<int>(type: "INTEGER", nullable: false),
                    Thriller = table.Column<int>(type: "INTEGER", nullable: false),
                    Drama = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAverageFeatures", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserAverageFeatures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFeatures",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovieCatalogMovieId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Musical = table.Column<int>(type: "INTEGER", nullable: false),
                    Family = table.Column<int>(type: "INTEGER", nullable: false),
                    RealityTV = table.Column<int>(name: "Reality_TV", type: "INTEGER", nullable: false),
                    Western = table.Column<int>(type: "INTEGER", nullable: false),
                    Comedy = table.Column<int>(type: "INTEGER", nullable: false),
                    Mystery = table.Column<int>(type: "INTEGER", nullable: false),
                    Music = table.Column<int>(type: "INTEGER", nullable: false),
                    Fantasy = table.Column<int>(type: "INTEGER", nullable: false),
                    News = table.Column<int>(type: "INTEGER", nullable: false),
                    Adventure = table.Column<int>(type: "INTEGER", nullable: false),
                    Documentary = table.Column<int>(type: "INTEGER", nullable: false),
                    Crime = table.Column<int>(type: "INTEGER", nullable: false),
                    Horror = table.Column<int>(type: "INTEGER", nullable: false),
                    Romance = table.Column<int>(type: "INTEGER", nullable: false),
                    SciFi = table.Column<int>(name: "Sci_Fi", type: "INTEGER", nullable: false),
                    Sport = table.Column<int>(type: "INTEGER", nullable: false),
                    Animation = table.Column<int>(type: "INTEGER", nullable: false),
                    Biography = table.Column<int>(type: "INTEGER", nullable: false),
                    War = table.Column<int>(type: "INTEGER", nullable: false),
                    History = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<int>(type: "INTEGER", nullable: false),
                    Short = table.Column<int>(type: "INTEGER", nullable: false),
                    Thriller = table.Column<int>(type: "INTEGER", nullable: false),
                    Drama = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeatures", x => x.FeaturesId);
                    table.ForeignKey(
                        name: "FK_UserFeatures_MovieCatalog_MovieCatalogMovieId",
                        column: x => x.MovieCatalogMovieId,
                        principalTable: "MovieCatalog",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_UserFeatures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserRatings",
                columns: table => new
                {
                    RatingsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovieCatalogMovieId = table.Column<int>(type: "INTEGER", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRatings", x => x.RatingsId);
                    table.ForeignKey(
                        name: "FK_UserRatings_MovieCatalog_MovieCatalogMovieId",
                        column: x => x.MovieCatalogMovieId,
                        principalTable: "MovieCatalog",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_UserRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCatalogModelUserModel_UserId",
                table: "MovieCatalogModelUserModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatures_MovieCatalogMovieId",
                table: "UserFeatures",
                column: "MovieCatalogMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeatures_UserId",
                table: "UserFeatures",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_MovieCatalogMovieId",
                table: "UserRatings",
                column: "MovieCatalogMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRatings_UserId",
                table: "UserRatings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCatalogModelUserModel");

            migrationBuilder.DropTable(
                name: "UserAverageFeatures");

            migrationBuilder.DropTable(
                name: "UserFeatures");

            migrationBuilder.DropTable(
                name: "UserRatings");

            migrationBuilder.DropTable(
                name: "MovieCatalog");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
