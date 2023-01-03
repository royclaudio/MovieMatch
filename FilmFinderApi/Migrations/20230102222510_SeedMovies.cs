using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmFinderApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieCatalog",
                columns: new[] { "MovieId", "AO", "Action", "Actors", "Adventure", "Animation", "Awards", "Biography", "Box_office", "Comedy", "Country", "Crime", "Director", "Documentary", "Drama", "Eighties", "Family", "Fantasy", "Genre", "History", "Horror", "Language", "M_PG", "Metascore", "Music", "Musical", "Mystery", "NC_17", "NOT_RATED", "N_A", "News", "Nineties", "PASSED", "PG", "PG_13", "Poster", "R", "Rated", "Rated_G", "RealityTV", "Released", "Response", "Romance", "Runtime", "Sci_Fi", "Short", "Sport", "TV_14", "TV_G", "TV_MA", "TV_PG", "Thriller", "Title", "Twenty_tens", "Two_Thousand", "Type", "UNRATED", "War", "Western", "Writer", "X", "image_file", "imdbID", "imdbRating", "imdbVotes" },
                values: new object[,]
                {
                    { 1, 0, 1, "Bruce Allpress, Sean Astin, John Bach, Sala Baker", 1, 0, "Won 2 Oscars. Another 114 wins & 126 nominations.", 0, "49,935,319", 0, "USA, New Zealand", 0, "Peter Jackson", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "English, Sindarin, Old English", 0, "88", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Dec-02", "TRUE", 0, "179 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lord of the Rings: The Two Towers", 0, 0, "movie", 0, 0, 0, "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Stephen Sinclair (screenplay), Peter Jackson (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0167261.jpg", "tt0167261", "8.7", "1,061,460" },
                    { 2, 0, 1, "Ewan McGregor, Natalie Portman, Hayden Christensen, Christopher Lee", 1, 0, "Nominated for 1 Oscar. Another 13 wins & 53 nominations.", 0, "310,675,583", 0, "USA", 0, "George Lucas", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "16-May-02", "TRUE", 0, "142 min", 0, 0, 0, 0, 0, 0, 0, 0, "Star Wars: Episode II - Attack of the Clones", 0, 0, "movie", 0, 0, 0, "George Lucas (screenplay), Jonathan Hales (screenplay), George Lucas (story)", 0, "data/Movie_Poster_Dataset/2002/tt0121765.jpg", "tt0121765", "6.7", "449,355" },
                    { 3, 0, 0, "Daniel Radcliffe, Rupert Grint, Emma Watson, Richard Griffiths", 1, 0, "Nominated for 3 BAFTA Film Awards. Another 11 wins & 39 nominations.", 0, "261,970,615", 0, "UK, USA, Germany", 0, "Chris Columbus", 0, 0, 0, 1, 1, "Adventure, Family, Fantasy", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "15-Nov-02", "TRUE", 0, "161 min", 0, 0, 0, 0, 0, 0, 0, 0, "Harry Potter and the Chamber of Secrets", 0, 0, "movie", 0, 0, 0, "J.K. Rowling (novel), Steve Kloves (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0295297.jpg", "tt0295297", "7.4", "373,701" },
                    { 4, 0, 0, "Nia Vardalos, Michael Constantine, Christina Eleusiniotis, Kaylee Vieira", 0, 0, "Nominated for 1 Oscar. Another 20 wins & 27 nominations.", 0, "1,680,732", 1, "USA, Canada", 0, "Joel Zwick", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Greek", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "2-Aug-02", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "My Big Fat Greek Wedding", 0, 0, "movie", 0, 0, 0, "Nia Vardalos", 0, "data/Movie_Poster_Dataset/2002/tt0259446.jpg", "tt0259446", "6.6", "95,556" },
                    { 5, 0, 0, "Mel Gibson, Joaquin Phoenix, Rory Culkin, Abigail Breslin", 0, 0, "3 wins & 30 nominations.", 0, "227,965,690", 0, "USA", 0, "M. Night Shyamalan", 0, 1, 0, 0, 0, "Drama, Sci-Fi, Thriller", 0, 0, "English, Portuguese", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Aug-02", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "Signs", 0, 0, "movie", 0, 0, 0, "M. Night Shyamalan", 0, "data/Movie_Poster_Dataset/2002/tt0286106.jpg", "tt0286106", "6.7", "266,105" },
                    { 6, 0, 1, "Mike Myers, Beyoncé Knowles, Seth Green, Michael York", 0, 0, "5 wins & 21 nominations.", 0, "461,193", 1, "USA", 1, "Jay Roach", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, Japanese, German, French", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Jul-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Austin Powers in Goldmember", 0, 0, "movie", 0, 0, 0, "Mike Myers, Michael McCullers, Mike Myers (characters created by)", 0, "data/Movie_Poster_Dataset/2002/tt0295178.jpg", "tt0295178", "6.2", "158,815" },
                    { 7, 0, 1, "Tommy Lee Jones, Will Smith, Rip Torn, Lara Flynn Boyle", 1, 0, "3 wins & 10 nominations.", 0, "null", 1, "USA", 0, "Barry Sonnenfeld", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Jul-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Men in Black II", 0, 0, "movie", 0, 0, 0, "Lowell Cunningham (comic book \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0120912.jpg", "tt0120912", "6.1", "260,988" },
                    { 8, 0, 0, "Ray Romano, John Leguizamo, Denis Leary, Goran Visnjic", 1, 1, "Nominated for 1 Oscar. Another 5 wins & 28 nominations.", 0, "4,158,805", 1, "USA", 0, "Chris Wedge, Carlos Saldanha", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English, Croatian", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "15-Mar-02", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ice Age", 0, 0, "movie", 0, 0, 0, "Michael J. Wilson (story), Michael Berg (screenplay), Michael J. Wilson (screenplay), Peter Ackerman (screenplay), James Bresnahan (additional story), Doug Compton (additional story), Mike Thurmeier (additional story), Jeff Siergey (additional story), Galen T. Chu (additional story), Xeth Feinberg (additional story)", 0, "data/Movie_Poster_Dataset/2002/tt0268380.jpg", "tt0268380", "7.6", "314,165" },
                    { 9, 0, 0, "Taye Diggs, Cliff Saunders, Catherine Zeta-Jones, Renée Zellweger", 0, 0, "Won 6 Oscars. Another 49 wins & 116 nominations.", 0, "170,684,505", 1, "USA, Germany, Canada", 1, "Rob Marshall", 0, 0, 0, 0, 0, "Comedy, Crime, Musical", 0, 0, "English, Hungarian", 0, "82", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Jan-03", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chicago", 0, 0, "movie", 0, 0, 0, "Bill Condon (screenplay), Bob Fosse (book), Fred Ebb (book), Maurine Dallas Watkins (play)", 0, "data/Movie_Poster_Dataset/2002/tt0299658.jpg", "tt0299658", "7.2", "168,004" },
                    { 10, 0, 0, "Leonardo DiCaprio, Tom Hanks, Christopher Walken, Martin Sheen", 0, 0, "Nominated for 2 Oscars. Another 11 wins & 34 nominations.", 1, "9,493,232", 0, "USA, Canada", 1, "Steven Spielberg", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English, French", 0, "76", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Dec-02", "TRUE", 0, "141 min", 0, 0, 0, 0, 0, 0, 0, 0, "Catch Me If You Can", 0, 0, "movie", 0, 0, 0, "Jeff Nathanson (screenplay), Frank Abagnale Jr. (book), Stan Redding (book)", 0, "data/Movie_Poster_Dataset/2002/tt0264464.jpg", "tt0264464", "8", "488,689" },
                    { 11, 0, 1, "Pierce Brosnan, Halle Berry, Toby Stephens, Rosamund Pike", 1, 0, "Nominated for 1 Golden Globe. Another 5 wins & 31 nominations.", 0, "7,463,693", 0, "UK, USA", 0, "Lee Tamahori", 0, 0, 0, 0, 0, "Action, Adventure, Thriller", 0, 0, "English, Korean, Cantonese, Spanish, German, Icelandic, Italian", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Nov-02", "TRUE", 0, "133 min", 0, 0, 0, 0, 0, 0, 0, 1, "Die Another Day", 0, 0, "movie", 0, 0, 0, "Ian Fleming (characters), Neal Purvis, Robert Wade", 0, "data/Movie_Poster_Dataset/2002/tt0246460.jpg", "tt0246460", "6.1", "166,075" },
                    { 12, 0, 0, "Freddie Prinze Jr., Sarah Michelle Gellar, Matthew Lillard, Linda Cardellini", 1, 0, "3 wins & 8 nominations.", 0, "4,942,107", 1, "USA, Australia", 0, "Raja Gosnell", 0, 0, 0, 0, 0, "Adventure, Comedy, Mystery", 0, 0, "English", 0, "35", 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOTQ5NDI3MTI4MF5BMl5BanBnXkFtZTgwNDQ4ODE5MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "14-Jun-02", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Scooby-Doo", 0, 0, "movie", 0, 0, 0, "James Gunn (screenplay), Craig Titley (story), James Gunn (story), William Hanna (characters), Joseph Barbera (characters)", 0, "data/Movie_Poster_Dataset/2002/tt0267913.jpg", "tt0267913", "4.9", "69,196" },
                    { 13, 0, 0, "Daveigh Chase, Chris Sanders, Tia Carrere, David Ogden Stiers", 1, 1, "Nominated for 1 Oscar. Another 10 wins & 27 nominations.", 0, "6,236,068", 1, "USA", 0, "Dean DeBlois, Chris Sanders", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English, Hawaiian", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Jun-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lilo & Stitch", 0, 0, "movie", 0, 0, 0, "Chris Sanders (idea), Chris Sanders, Dean DeBlois", 0, "data/Movie_Poster_Dataset/2002/tt0275847.jpg", "tt0275847", "7.2", "111,034" },
                    { 14, 0, 1, "Vin Diesel, Asia Argento, Marton Csokas, Samuel L. Jackson", 1, 0, "4 wins & 13 nominations.", 0, "4,327,240", 0, "USA", 0, "Rob Cohen", 0, 0, 0, 0, 0, "Action, Adventure", 0, 0, "English, German, Spanish, Russian, Czech", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Aug-02", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "xXx", 0, 0, "movie", 0, 0, 0, "Rich Wilkes", 0, "data/Movie_Poster_Dataset/2002/tt0295701.jpg", "tt0295701", "5.8", "139,207" },
                    { 15, 0, 0, "Tim Allen, Elizabeth Mitchell, David Krumholtz, Eric Lloyd", 0, 0, "1 win & 3 nominations.", 0, "139,225,854", 1, "USA", 0, "Michael Lembeck", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "1-Nov-02", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Santa Clause 2", 0, 0, "movie", 0, 0, 0, "Don Rhymer (screenplay), Cinco Paul (screenplay), Ken Daurio (screenplay), Ed Decter (screenplay), John J. Strauss (screenplay), Leo Benvenuti (characters), Steve Rudnick (characters), Leo Benvenuti (story), Steve Rudnick (story)", 0, "data/Movie_Poster_Dataset/2002/tt0304669.jpg", "tt0304669", "5.5", "33,639" },
                    { 16, 0, 1, "Tom Cruise, Max von Sydow, Steve Harris, Neal McDonough", 0, 0, "Nominated for 1 Oscar. Another 18 wins & 72 nominations.", 0, "15,916,084", 0, "USA", 0, "Steven Spielberg", 0, 0, 0, 0, 0, "Action, Mystery, Sci-Fi", 0, 0, "English, Swedish", 0, "80", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Jun-02", "TRUE", 0, "145 min", 0, 0, 0, 0, 0, 0, 0, 0, "Minority Report", 0, 0, "movie", 0, 0, 0, "Philip K. Dick (short story), Scott Frank (screenplay), Jon Cohen (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0181689.jpg", "tt0181689", "7.7", "387,712" },
                    { 17, 0, 0, "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox", 0, 0, "14 wins & 11 nominations.", 0, "null", 0, "USA, Japan", 0, "Gore Verbinski", 0, 0, 0, 0, 0, "Horror, Mystery, Sci-Fi", 0, 1, "English", 0, "57", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Oct-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Ring", 0, 0, "movie", 0, 0, 0, "Ehren Kruger (screenplay), Kôji Suzuki (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0298130.jpg", "tt0298130", "7.1", "240,685" },
                    { 18, 0, 0, "Reese Witherspoon, Josh Lucas, Patrick Dempsey, Candice Bergen", 0, 0, "3 wins & 6 nominations.", 0, "526,003", 1, "USA", 0, "Andy Tennant", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjViNWRjYWEtZTI0NC00N2E3LTk0NGQtMjY4NTM3OGNkZjY0XkEyXkFqcGdeQXVyMjUxMTY3ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Sep-02", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sweet Home Alabama", 0, 0, "movie", 0, 0, 0, "Douglas J. Eboch (story), C. Jay Cox (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0256415.jpg", "tt0256415", "6.1", "81,627" },
                    { 19, 0, 0, "Adam Sandler, Winona Ryder, John Turturro, Allen Covert", 0, 0, "4 wins & 7 nominations.", 0, "482,818", 1, "USA", 0, "Steven Brill", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "24", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Jun-02", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mr. Deeds", 0, 0, "movie", 0, 0, 0, "Clarence Budington Kelland (short story \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0280590.jpg", "tt0280590", "5.8", "107,322" },
                    { 20, 0, 1, "Matt Damon, Franka Potente, Chris Cooper, Clive Owen", 0, 0, "3 wins & 5 nominations.", 0, "4,874,565", 0, "USA, Germany, Czech Republic", 0, "Doug Liman", 0, 0, 0, 0, 0, "Action, Mystery, Thriller", 0, 0, "English, French, German, Dutch, Italian", 0, "68", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTc2ZTlmYmItMDBhYS00YmMzLWI4ZjAtMTI5YTBjOTFiMGEwXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Jun-02", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Bourne Identity", 0, 0, "movie", 0, 0, 0, "Tony Gilroy (screenplay), W. Blake Herron (screenplay), Robert Ludlum (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0258463.jpg", "tt0258463", "7.9", "387,915" },
                    { 21, 0, 1, "Ian Mongrain, Russell Bobbitt, James Cromwell, Ken Jenkins", 0, 0, "2 wins & 4 nominations.", 0, "621,647", 0, "USA, Germany", 0, "Phil Alden Robinson", 0, 1, 0, 0, 0, "Action, Drama, Thriller", 0, 0, "English, Russian, Ukrainian, German, Arabic", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-May-02", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Sum of All Fears", 0, 0, "movie", 0, 0, 0, "Tom Clancy (novel), Paul Attanasio (screenplay), Daniel Pyne (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0164184.jpg", "tt0164184", "6.4", "84,622" },
                    { 22, 0, 0, "Eminem, Kim Basinger, Mekhi Phifer, Brittany Murphy", 0, 0, "Won 1 Oscar. Another 12 wins & 20 nominations.", 0, "5,240,354", 0, "USA, Germany", 0, "Curtis Hanson", 0, 1, 0, 0, 0, "Drama, Music", 0, 0, "English", 0, "77", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTMwYjc5ZmItYTFjZC00ZGQ3LTlkNTMtMjZiNTZlMWQzNzI5XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Nov-02", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "8 Mile", 0, 0, "movie", 0, 0, 0, "Scott Silver", 0, "data/Movie_Poster_Dataset/2002/tt0298203.jpg", "tt0298203", "7", "178,567" },
                    { 23, 0, 0, "Tyler Hoechlin, Rob Maxey, Liam Aiken, Jennifer Jason Leigh", 0, 0, "Won 1 Oscar. Another 20 wins & 71 nominations.", 0, "40,935,560", 0, "USA", 1, "Sam Mendes", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjlmZmI5MDctNDE2YS00YWE0LWE5ZWItZDBhYWQ0NTcxNWRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Jul-02", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 1, "Road to Perdition", 0, 0, "movie", 0, 0, 0, "Max Allan Collins (graphic novel), Richard Piers Rayner (graphic novel), David Self (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0257044.jpg", "tt0257044", "7.7", "195,408" },
                    { 24, 0, 0, "Jodie Foster, Kristen Stewart, Forest Whitaker, Dwight Yoakam", 0, 0, "1 win & 9 nominations.", 0, "null", 0, "USA", 1, "David Fincher", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjhkMDM4MWItZTVjOC00ZDRhLThmYTAtM2I5NzBmNmNlMzI1XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Mar-02", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 1, "Panic Room", 0, 0, "movie", 0, 0, 0, "David Koepp", 0, "data/Movie_Poster_Dataset/2002/tt0258000.jpg", "tt0258000", "6.8", "200,387" },
                    { 25, 0, 0, "Jennifer Lopez, Ralph Fiennes, Natasha Richardson, Stanley Tucci", 0, 0, "8 nominations.", 0, "1,328,858", 1, "USA", 0, "Wayne Wang", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, French, Spanish", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Dec-02", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Maid in Manhattan", 0, 0, "movie", 0, 0, 0, "John Hughes (story), Kevin Wade (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0252076.jpg", "tt0252076", "5", "66,616" },
                    { 26, 0, 0, "Sandra Bullock, Hugh Grant, Alicia Witt, Dana Ivey", 0, 0, "1 win & 3 nominations.", 0, "2,503,631", 1, "USA, Australia", 0, "Marc Lawrence", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmJmM2Q4NmMtYThmNC00ZjRlLWEyZmItZTIwOTBlZDQ3NTQ1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Dec-02", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Two Weeks Notice", 0, 0, "movie", 0, 0, 0, "Marc Lawrence", 0, "data/Movie_Poster_Dataset/2002/tt0313737.jpg", "tt0313737", "6.1", "83,278" },
                    { 27, 0, 0, "Anthony Hopkins, Edward Norton, Ralph Fiennes, Harvey Keitel", 0, 0, "4 wins & 10 nominations.", 0, "6,317,081", 0, "Germany, USA", 1, "Brett Ratner", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, French", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Oct-02", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 1, "Red Dragon", 0, 0, "movie", 0, 0, 0, "Thomas Harris (novel), Ted Tally (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0289765.jpg", "tt0289765", "7.2", "199,537" },
                    { 28, 0, 1, "Dwayne Johnson, Steven Brand, Michael Clarke Duncan, Kelly Hu", 1, 0, "2 wins & 3 nominations.", 0, "90,341,670", 0, "USA, Germany, Belgium", 0, "Chuck Russell", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjNhZTk0ZmEtNjJhMi00YzFlLWE1MmEtYzM1M2ZmMGMwMTU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Apr-02", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Scorpion King", 0, 0, "movie", 0, 0, 0, "Stephen Sommers (story), Jonathan Hales (story), Stephen Sommers (screenplay), William Osborne (screenplay), David Hayter (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0277296.jpg", "tt0277296", "5.5", "98,543" },
                    { 29, 0, 1, "Wesley Snipes, Kris Kristofferson, Ron Perlman, Leonor Varela", 0, 0, "6 wins & 9 nominations.", 0, "60,999", 0, "USA, Germany", 0, "Guillermo del Toro", 0, 0, 0, 0, 0, "Action, Horror, Sci-Fi", 0, 1, "English, Romanian, Czech", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzVlY2MwMjktM2E4OS00Y2Y3LWE3ZjctYzhkZGM3YzA1ZWM2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Mar-02", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blade II", 0, 0, "movie", 0, 0, 0, "Marv Wolfman (character), Gene Colan (character), David S. Goyer", 0, "data/Movie_Poster_Dataset/2002/tt0187738.jpg", "tt0187738", "6.7", "152,749" },
                    { 30, 0, 0, "Cuba Gooding Jr., James Coburn, Sisqó, Nichelle Nichols", 1, 0, "1 win.", 0, "643,681", 1, "Canada, USA", 0, "Brian Levant", 0, 0, 0, 1, 0, "Adventure, Comedy, Family", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYjBmYTQ1NjItZWU5MS00YjI0LTg2OTYtYmFkN2JkMmNiNWVkXkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "PG", 0, 0, "18-Jan-02", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Snow Dogs", 0, 0, "movie", 0, 0, 0, "Jim Kouf (screenplay), Tommy Swerdlow (screenplay), Michael Goldberg (screenplay), Mark Gibson (screenplay), Philip Halprin (screenplay), Gary Paulsen (book)", 0, "data/Movie_Poster_Dataset/2002/tt0281373.jpg", "tt0281373", "5.1", "19,703" },
                    { 31, 0, 1, "Mel Gibson, Madeleine Stowe, Greg Kinnear, Sam Elliott", 0, 0, "1 win & 5 nominations.", 0, "495,567", 0, "USA, Germany", 0, "Randall Wallace", 0, 1, 0, 0, 0, "Action, Drama, History", 1, 0, "English, Vietnamese, French", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWE4ZDdhNmMtNzE5ZC00NzExLTlhNGMtY2ZhYjYzODEzODA1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Mar-02", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "We Were Soldiers", 0, 0, "movie", 0, 0, 0, "Harold G. Moore (book), Joseph L. Galloway (book), Randall Wallace (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0277434.jpg", "tt0277434", "7.1", "100,064" },
                    { 32, 0, 0, "Leonardo DiCaprio, Daniel Day-Lewis, Cameron Diaz, Jim Broadbent", 0, 0, "Nominated for 10 Oscars. Another 45 wins & 102 nominations.", 0, "77,679,638", 0, "USA, Italy", 1, "Martin Scorsese", 0, 1, 0, 0, 0, "Crime, Drama, History", 1, 0, "English, Irish, Chinese, Latin", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjc4NDZhZWMtNGEzYS00ZWU2LThlM2ItNTA0YzQ0OTExMTE2XkEyXkFqcGdeQXVyNjUwMzI2NzU@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Dec-02", "TRUE", 0, "167 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gangs of New York", 0, 0, "movie", 0, 0, 0, "Jay Cocks (story), Jay Cocks (screenplay), Steven Zaillian (screenplay), Kenneth Lonergan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0217505.jpg", "tt0217505", "7.5", "304,336" },
                    { 33, 0, 0, "Ice Cube, Anthony Anderson, Cedric the Entertainer, Sean Patrick Thomas", 0, 0, "1 win & 17 nominations.", 0, "null", 1, "USA", 0, "Tim Story", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Sep-02", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Barbershop", 0, 0, "movie", 0, 0, 0, "Mark Brown (story), Mark Brown (screenplay), Don D. Scott (screenplay), Marshall Todd (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0303714.jpg", "tt0303714", "6.3", "20,764" },
                    { 34, 0, 0, "Dennis Quaid, Rachel Griffiths, Jay Hernandez, Beth Grant", 0, 0, "5 wins & 4 nominations.", 0, "1,173,179", 0, "USA", 0, "John Lee Hancock", 0, 1, 0, 1, 0, "Drama, Family, Sport", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTA5NDZlZGUtMjAxOS00YTRkLTkwYmMtYWQ0NWEwZDZiNjEzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "29-Mar-02", "TRUE", 0, "127 min", 0, 0, 1, 0, 0, 0, 0, 0, "The Rookie", 0, 0, "movie", 0, 0, 0, "Mike Rich", 0, "data/Movie_Poster_Dataset/2002/tt0265662.jpg", "tt0265662", "7", "25,673" },
                    { 35, 0, 0, "Matt Damon, James Cromwell, Daniel Studi, Chopper Bernet", 1, 1, "Nominated for 1 Oscar. Another 8 wins & 19 nominations.", 0, "128,531", 0, "USA", 0, "Kelly Asbury, Lorna Cook", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "24-May-02", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spirit: Stallion of the Cimarron", 0, 0, "movie", 0, 0, 0, "John Fusco (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0166813.jpg", "tt0166813", "7", "42,199" },
                    { 36, 0, 0, "Gabriela Oltean, Denzel Washington, Kimberly Elise, Ron Annabelle", 0, 0, "2 wins & 8 nominations.", 0, "2,606,250", 0, "USA", 1, "Nick Cassavetes", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, Spanish", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA4NDI0MTIxNF5BMl5BanBnXkFtZTYwNTM0MzY2._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Feb-02", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 1, "John Q", 0, 0, "movie", 0, 0, 0, "James Kearns", 0, "data/Movie_Poster_Dataset/2002/tt0251160.jpg", "tt0251160", "7", "96,383" },
                    { 37, 0, 0, "Sandra Bullock, Ellen Burstyn, Fionnula Flanagan, James Garner", 0, 0, "3 nominations.", 0, "199,958", 0, "USA", 0, "Callie Khouri", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Jun-02", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Divine Secrets of the Ya-Ya Sisterhood", 0, 0, "movie", 0, 0, 0, "Rebecca Wells (novels), Mark Andrus (adaptation), Callie Khouri (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0279778.jpg", "tt0279778", "5.9", "15,012" },
                    { 38, 0, 0, "Al Pacino, Martin Donovan, Oliver 'Ole' Zemen, Hilary Swank", 0, 0, "1 win & 10 nominations.", 0, "4,663,332", 0, "USA, Canada", 0, "Christopher Nolan", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English", 0, "78", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWRiZDIxZjktMTA1NC00MDQ2LWEzMjUtMTliZmY3NjQ3ODJiXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-May-02", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 1, "Insomnia", 0, 0, "movie", 0, 0, 0, "Hillary Seitz (screenplay), Nikolaj Frobenius, Erik Skjoldbjærg", 0, "data/Movie_Poster_Dataset/2002/tt0278504.jpg", "tt0278504", "7.2", "212,725" },
                    { 39, 0, 0, "Ben Affleck, Samuel L. Jackson, Kim Staunton, Toni Collette", 0, 0, "7 nominations.", 0, "1,538,066", 0, "USA", 0, "Roger Michell", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDliMmNhNDEtODUyOS00MjNlLTgxODEtN2U3NzIxMGVkZTA1L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Apr-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Changing Lanes", 0, 0, "movie", 0, 0, 0, "Chap Taylor (story), Chap Taylor (screenplay), Michael Tolkin (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0264472.jpg", "tt0264472", "6.5", "56,304" },
                    { 40, 0, 0, "Jack Nicholson, Kathy Bates, Hope Davis, Dermot Mulroney", 0, 0, "Nominated for 2 Oscars. Another 24 wins & 67 nominations.", 0, "787,649", 1, "USA", 0, "Alexander Payne", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "85", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjA0MTM4MTQtNzY5MC00NzY3LWI1ZTgtYzcxMjkyMzU4MDZiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Jan-03", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "About Schmidt", 0, 0, "movie", 0, 0, 0, "Louis Begley (novel), Alexander Payne (screenplay), Jim Taylor (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0257360.jpg", "tt0257360", "7.2", "106,181" },
                    { 41, 0, 0, "Michael J. Fox, Geena Davis, Hugh Laurie, Jonathan Lipnicki", 1, 1, "1 win & 4 nominations.", 0, "2,816,122", 1, "USA", 0, "Rob Minkoff", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYTViNjMyNmUtNDFkNC00ZDRlLThmMDUtZDU2YWE4NGI2ZjVmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "19-Jul-02", "TRUE", 0, "77 min", 0, 0, 0, 0, 0, 0, 0, 0, "Stuart Little 2", 0, 0, "movie", 0, 0, 0, "E.B. White (characters from the book \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0243585.jpg", "tt0243585", "5.4", "34,831" },
                    { 42, 0, 0, "Johnny Knoxville, Bam Margera, Steve-O, Chris Pontius", 0, 0, "1 win & 7 nominations.", 0, "208,878", 1, "USA", 0, "Jeff Tremaine", 1, 0, 0, 0, 0, "Documentary, Comedy", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODllNWE0MmEtYjUwZi00ZjY3LThmNmQtZjZlMjI2YTZjYmQ0XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Oct-02", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jackass: The Movie", 0, 0, "movie", 0, 0, 0, "Jeff Tremaine (concepts by), Spike Jonze (concepts by), Johnny Knoxville (concepts by), Bam Margera (concepts by), Steve-O (concepts by), Preston Lacy (concepts by), Chris Pontius (concepts by), Dave England (concepts by), Ryan Dunn (concepts by), Ehren McGhehey (concepts by), Brandon DiCamillo (concepts by), Dimitry Elyashkevich (concepts by), Whitey McConnaughy (concepts by), Sean Cliver (concepts by), Loomis Fall (concepts by), Phil Clapp (concepts by), Vernon Chatman (concepts by)", 0, "data/Movie_Poster_Dataset/2002/tt0322802.jpg", "tt0322802", "6.6", "66,432" },
                    { 43, 0, 1, "Guy Pearce, Mark Addy, Phyllida Law, Sienna Guillory", 1, 0, "Nominated for 1 Oscar. Another 1 win & 2 nominations.", 0, "4,156,558", 0, "USA", 0, "Simon Wells", 0, 0, 0, 0, 0, "Sci-Fi, Adventure, Action", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTYxNGMyZTYtMjE3MS00MzNjLWFjNmYtMDk3N2FmM2JiM2M1XkEyXkFqcGdeQXVyNjY5NDU4NzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Mar-02", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Time Machine", 0, 0, "movie", 0, 0, 0, "H.G. Wells (novel), David Duncan (earlier screenplay), John Logan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0268695.jpg", "tt0268695", "5.9", "101,989" },
                    { 44, 0, 0, "Nick Cannon, Zoe Saldana, Orlando Jones, Leonard Roberts", 0, 0, "12 nominations.", 0, "56,398,162", 1, "USA", 0, "Charles Stone III", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGU2NzRmZjUtOGUxYS00ZjdjLWEwZWItY2NlM2JhNjkxNTFmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Dec-02", "TRUE", 1, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Drumline", 0, 0, "movie", 0, 0, 0, "Shawn Schepps (story), Tina Gordon Chism (screenplay), Shawn Schepps (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0303933.jpg", "tt0303933", "5.6", "28,299" },
                    { 45, 0, 1, "Jim Caviezel, Guy Pearce, Richard Harris, James Frain", 1, 0, "N/A", 0, "54,228,104", 0, "UK, USA, Ireland", 0, "Kevin Reynolds", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2FhYjEyYmYtMDI1Yy00YTdlLWI2NWQtYmEzNzAxOGY1NjY2XkEyXkFqcGdeQXVyNTA3NTIyNDg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Jan-02", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Count of Monte Cristo", 0, 0, "movie", 0, 0, 0, "Alexandre Dumas père (novel), Jay Wolpert (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0245844.jpg", "tt0245844", "7.7", "101,864" },
                    { 46, 0, 0, "Diane Lane, Erik Per Sullivan, Richard Gere, Olivier Martinez", 0, 0, "Nominated for 1 Oscar. Another 3 wins & 13 nominations.", 0, "1,704,384", 0, "USA, Germany, France", 0, "Adrian Lyne", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English, French", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmY2NjUzNDQtNTgxNC00M2Q4LTljOWQtMjNjNDBjNWUxNmJlXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-May-02", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 1, "Unfaithful", 0, 0, "movie", 0, 0, 0, "Claude Chabrol (film \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0250797.jpg", "tt0250797", "6.7", "61,488" },
                    { 47, 0, 0, "Shad Moss, Morris Chestnut, Jonathan Lipnicki, Brenda Song", 0, 0, "1 win & 6 nominations.", 0, "null", 1, "USA", 0, "John Schultz", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "3-Jul-02", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Like Mike", 0, 0, "movie", 0, 0, 0, "Michael Elliot (story), Michael Elliot (screenplay), Jordan Moffet (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0308506.jpg", "tt0308506", "5.1", "14,641" },
                    { 48, 0, 1, "Jackie Chan, Jennifer Love Hewitt, Jason Isaacs, Debi Mazar", 0, 0, "2 wins & 1 nomination.", 0, "288,760", 1, "USA", 0, "Kevin Donovan", 0, 0, 0, 0, 0, "Action, Comedy, Sci-Fi", 0, 0, "English, Cantonese", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGI5MjBmYzYtMzJhZi00NGI1LTk3MzItYjBjMzcxM2U3MDdiXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Sep-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Tuxedo", 0, 0, "movie", 0, 0, 0, "Phil Hay (story), Matt Manfredi (story), Michael J. Wilson (story), Michael J. Wilson (screenplay), Michael Leeson (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0290095.jpg", "tt0290095", "5.3", "59,978" },
                    { 49, 0, 0, "Harriet Owen, Blayne Weaver, Corey Burton, Jeff Bennett", 1, 1, "5 nominations.", 0, "4,198,085", 0, "USA, Canada, Australia", 0, "Robin Budd, Donovan Cook", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTQwNDM1YzItNDAxZC00NWY2LTk0M2UtNDIwNWI5OGUyNWUxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "15-Feb-02", "TRUE", 0, "72 min", 0, 0, 0, 0, 0, 0, 0, 0, "Return to Never Land", 0, 0, "movie", 0, 0, 0, "Temple Mathews (screenplay), Carter Crocker (additional written material), J.M. Barrie (play)", 0, "data/Movie_Poster_Dataset/2002/tt0280030.jpg", "tt0280030", "5.8", "12,836" },
                    { 50, 0, 0, "Frankie Muniz, Paul Giamatti, Amanda Bynes, Amanda Detmer", 1, 0, "1 win & 3 nominations.", 0, "201,334", 1, "USA, Germany", 0, "Shawn Levy", 0, 0, 0, 1, 0, "Adventure, Comedy, Family", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BY2IzZGY2YmEtYzljNS00NTM5LTgwMzUtMzM1NjQ4NGI0OTk0XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "8-Feb-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Big Fat Liar", 0, 0, "movie", 0, 0, 0, "Dan Schneider (story), Brian Robbins (story), Dan Schneider (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0265298.jpg", "tt0265298", "5.4", "28,339" },
                    { 51, 0, 1, "Patrick Stewart, Jonathan Frakes, Brent Spiner, LeVar Burton", 1, 0, "1 win & 4 nominations.", 0, "495,134", 0, "USA", 0, "Stuart Baird", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjJiZjMzYzktNjU0NS00OTkxLWEwYzItYzdhYWJjN2QzMTRlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Dec-02", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Star Trek: Nemesis", 0, 0, "movie", 0, 0, 0, "Gene Roddenberry (television series Star Trek), John Logan (story), Rick Berman (story), Brent Spiner (story), John Logan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0253754.jpg", "tt0253754", "6.4", "56,620" },
                    { 52, 0, 1, "Christian Bale, Matthew McConaughey, Izabella Scorupco, Gerard Butler", 1, 0, "1 win & 2 nominations.", 0, "1,720,747", 0, "USA, UK, Ireland", 0, "Rob Bowman", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2I4MmM1N2EtM2YzOS00OWUzLTkzYzctNDc5NDg2N2IyODJmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jul-02", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Reign of Fire", 0, 0, "movie", 0, 0, 0, "Gregg Chabot (story), Kevin Peterka (story), Gregg Chabot (screenplay), Kevin Peterka (screenplay), Matt Greenberg (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0253556.jpg", "tt0253556", "6.2", "105,176" },
                    { 53, 0, 0, "Nicole Kidman, Julianne Moore, Meryl Streep, Stephen Dillane", 0, 0, "Won 1 Oscar. Another 41 wins & 120 nominations.", 0, "3,246,655", 0, "USA, UK", 0, "Stephen Daldry", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmExNzU2ZWMtYzUwYi00YmM2LTkxZTQtNmVhNjY0NTMyMWI2XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Feb-03", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hours", 0, 0, "movie", 0, 0, 0, "Michael Cunningham (novel), David Hare (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0274558.jpg", "tt0274558", "7.6", "100,148" },
                    { 54, 0, 0, "Ashley Judd, Morgan Freeman, Jim Caviezel, Adam Scott", 0, 0, "2 nominations.", 0, "490,529", 0, "USA", 1, "Carl Franklin", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Spanish", 0, "48", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWJhMDlmZGUtYzcxNS00NDRiLWIwNjktNDY1Mjg3ZjBkYzY0XkEyXkFqcGdeQXVyMTU4MjUwMjI@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Apr-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "High Crimes", 0, 0, "movie", 0, 0, 0, "Joseph Finder (novel), Yuri Zeltser (screenplay), Grace Cary Bickley (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0257756.jpg", "tt0257756", "6.3", "29,158" },
                    { 55, 0, 0, "Hugh Grant, Nicholas Hoult, Sharon Small, Madison Cook", 0, 0, "Nominated for 1 Oscar. Another 11 wins & 28 nominations.", 0, "2,834,577", 1, "UK, USA, France, Germany", 0, "Chris Weitz, Paul Weitz", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2FiMTFmMzMtZDI2ZC00NDQyLWExYTUtOWNmZWM1ZDg5YjVjXkEyXkFqcGdeQXVyODIwMDI1NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-May-02", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "About a Boy", 0, 0, "movie", 0, 0, 0, "Nick Hornby (novel), Peter Hedges (screenplay), Chris Weitz (screenplay), Paul Weitz (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0276751.jpg", "tt0276751", "7.1", "141,447" },
                    { 56, 0, 0, "Shane West, Mandy Moore, Peter Coyote, Daryl Hannah", 0, 0, "4 wins & 2 nominations.", 0, "110,657", 0, "USA", 0, "Adam Shankman", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BODRmZDVmNzUtZDA4ZC00NjhkLWI2M2UtN2M0ZDIzNDcxYThjL2ltYWdlXkEyXkFqcGdeQXVyNTk0MzMzODA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Jan-02", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Walk to Remember", 0, 0, "movie", 0, 0, 0, "Nicholas Sparks (novel), Karen Janszen (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0281358.jpg", "tt0281358", "7.4", "157,679" },
                    { 57, 0, 0, "Colin Hanks, Jack Black, Schuyler Fisk, Bret Harrison", 0, 0, "3 nominations.", 0, "null", 1, "USA", 0, "Jake Kasdan", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Spanish", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ4MzQzMzM2Nl5BMl5BanBnXkFtZTgwMTQ1NzU3MDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Jan-02", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Orange County", 0, 0, "movie", 0, 0, 0, "Mike White", 0, "data/Movie_Poster_Dataset/2002/tt0273923.jpg", "tt0273923", "6.2", "40,962" },
                    { 58, 0, 1, "Nicolas Cage, Adam Beach, Peter Stormare, Noah Emmerich", 0, 0, "1 win & 4 nominations.", 0, "368,655", 0, "USA", 0, "John Woo", 0, 1, 0, 0, 0, "Action, Drama, War", 0, 0, "English, Navajo, Japanese", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjMwNDkxMTgzOF5BMl5BanBnXkFtZTgwNTkwNTQ3NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Jun-02", "TRUE", 0, "134 min", 0, 0, 0, 0, 0, 0, 0, 0, "Windtalkers", 0, 0, "movie", 0, 1, 0, "John Rice, Joe Batteer", 0, "data/Movie_Poster_Dataset/2002/tt0245562.jpg", "tt0245562", "6", "54,528" },
                    { 59, 0, 0, "Kate Bosworth, Matthew Davis, Michelle Rodriguez, Sanoe Lake", 0, 0, "1 win & 7 nominations.", 0, "502,907", 0, "USA, Germany", 0, "John Stockwell", 0, 1, 0, 0, 0, "Drama, Romance, Sport", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Aug-02", "TRUE", 1, "104 min", 0, 0, 1, 0, 0, 0, 0, 0, "Blue Crush", 0, 0, "movie", 0, 0, 0, "Susan Orlean (magazine article \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0300532.jpg", "tt0300532", "5.6", "25,653" },
                    { 60, 0, 0, "Dana Carvey, Jennifer Esposito, Harold Gould, James Brolin", 0, 0, "3 nominations.", 0, "24,194", 1, "USA", 0, "Perry Andelin Blake", 0, 0, 0, 1, 0, "Comedy, Family", 0, 0, "English", 0, "12", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjMxNjY2MDU1OV5BMl5BanBnXkFtZTgwNzY1MTUwNTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "2-Aug-02", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Master of Disguise", 0, 0, "movie", 0, 0, 0, "Dana Carvey, Harris Goldberg", 0, "data/Movie_Poster_Dataset/2002/tt0295427.jpg", "tt0295427", "3.3", "17,858" },
                    { 61, 0, 1, "Ryan McCluskey, Oscar Pearce, Indra Ové, Anna Bolt", 0, 0, "6 nominations.", 0, "4,936,317", 0, "UK, Germany, France, USA", 0, "Paul W.S. Anderson", 0, 0, 0, 0, 0, "Action, Horror, Sci-Fi", 0, 1, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjQ5NjM0Y2YtNjZkNC00ZDhkLWJjMWItN2QyNzFkMDE3ZjAxXkEyXkFqcGdeQXVyODIxMzk5NjA@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Mar-02", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Resident Evil", 0, 0, "movie", 0, 0, 0, "Paul W.S. Anderson", 0, "data/Movie_Poster_Dataset/2002/tt0120804.jpg", "tt0120804", "6.7", "193,094" },
                    { 62, 0, 0, "Lacey Chabert, Tom Kane, Cree Summer, Tim Curry", 1, 1, "Nominated for 1 Oscar. Another 10 nominations.", 0, "2,170,249", 0, "USA", 0, "Cathy Malkasian, Jeff McGrath", 0, 0, 0, 1, 0, "Adventure, Animation, Family", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Dec-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Wild Thornberrys Movie", 0, 0, "movie", 0, 0, 0, "Arlene Klasky (characters), Gabor Csupo (characters), Steve Pepoon (characters), David Silverman (characters), Stephen Sustarsic (characters), Kate Boutilier", 0, "data/Movie_Poster_Dataset/2002/tt0282120.jpg", "tt0282120", "5.2", "11,994" },
                    { 63, 0, 1, "Arnold Schwarzenegger, Francesca Neri, Elias Koteas, Cliff Curtis", 0, 0, "N/A", 0, "766,543", 0, "USA", 0, "Andrew Davis", 0, 1, 0, 0, 0, "Action, Drama, Thriller", 0, 0, "English, Spanish", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Feb-02", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 1, "Collateral Damage", 0, 0, "movie", 0, 0, 0, "Ronald Roose (story), David Griffiths (story), Peter Griffiths (story), David Griffiths (screenplay), Peter Griffiths (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0233469.jpg", "tt0233469", "5.5", "60,070" },
                    { 64, 0, 0, "Jennifer Lopez, Billy Campbell, Tessa Allen, Juliette Lewis", 0, 0, "3 nominations.", 0, "null", 0, "USA", 1, "Michael Apted", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTkyOGVjMGEtNmQzZi00NzFlLTlhOWQtODYyMDc2ZGJmYzFhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-May-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 1, "Enough", 0, 0, "movie", 0, 0, 0, "Nicholas Kazan", 0, "data/Movie_Poster_Dataset/2002/tt0278435.jpg", "tt0278435", "5.6", "29,588" },
                    { 65, 0, 1, "Eddie Griffin, Chris Kattan, Denise Richards, Aunjanue Ellis", 0, 0, "1 win & 7 nominations.", 0, "null", 1, "USA", 0, "Malcolm D. Lee", 0, 0, 0, 0, 0, "Action, Comedy", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDhjZWViN2MtNzgxOS00NmI4LThiZDQtZDI3MzM4MDE4NTc0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-May-02", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Undercover Brother", 0, 0, "movie", 0, 0, 0, "John Ridley (internet series), John Ridley (story), John Ridley (screenplay), Michael McCullers (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0279493.jpg", "tt0279493", "5.8", "29,299" },
                    { 66, 0, 0, "Roscoe Lee Browne, Corey Burton, Dane A. Davis, Joseph Gordon-Levitt", 1, 1, "Nominated for 1 Oscar. Another 1 win & 13 nominations.", 0, "1,003,172", 0, "USA", 0, "Ron Clements, John Musker", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjExMTg5OTU0NF5BMl5BanBnXkFtZTcwMjMxMzMzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "27-Nov-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Treasure Planet", 0, 0, "movie", 0, 0, 0, "Robert Louis Stevenson (novel), Ron Clements (screenplay), John Musker (screenplay), Rob Edwards (screenplay), Ron Clements (animation story), John Musker (animation story), Ted Elliott (animation story), Terry Rossio (animation story)", 0, "data/Movie_Poster_Dataset/2002/tt0133240.jpg", "tt0133240", "7.1", "67,829" },
                    { 67, 0, 1, "Robert De Niro, Rachael Harris, Eddie Murphy, Zaid Farid", 0, 0, "1 win & 4 nominations.", 0, "944,537", 1, "USA, Australia", 1, "Tom Dey", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOThkM2EzYmMtNDE3NS00NjlhLTg4YzktYTdhNzgyOWY3ZDYzXkEyXkFqcGdeQXVyNzQzNzQxNzI@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Mar-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Showtime", 0, 0, "movie", 0, 0, 0, "Jorge Saralegui (story), Keith Sharon (screenplay), Alfred Gough (screenplay), Miles Millar (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0284490.jpg", "tt0284490", "5.5", "51,723" },
                    { 68, 0, 0, "Josh Hartnett, Shannyn Sossamon, Paulo Costanzo, Adam Trese", 0, 0, "1 win & 2 nominations.", 0, "42,259,967", 1, "USA, UK, France", 0, "Michael Lehmann", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI3NTQyMzU5M15BMl5BanBnXkFtZTcwMTM2MjgyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Mar-02", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "40 Days and 40 Nights", 0, 0, "movie", 0, 0, 0, "Rob Perez", 0, "data/Movie_Poster_Dataset/2002/tt0243736.jpg", "tt0243736", "5.6", "61,227" },
                    { 69, 0, 0, "Britney Spears, Anson Mount, Zoe Saldana, Taryn Manning", 0, 0, "2 wins & 11 nominations.", 0, "null", 1, "USA", 0, "Tamra Davis", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "27", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTcyNjk1MjgtOWI3Mi00YzQwLWI5MTktMzY4ZmI2NDAyNzYzXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Feb-02", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Crossroads", 0, 0, "movie", 0, 0, 0, "Shonda Rhimes", 0, "data/Movie_Poster_Dataset/2002/tt0275022.jpg", "tt0275022", "3.3", "33,754" },
                    { 70, 0, 1, "Jesse Bradford, French Stewart, Paula Garcés, Michael Biehn", 1, 0, "N/A", 0, "null", 1, "USA", 0, "Jonathan Frakes", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNGIzY2IzODQtNThmMi00ZDE4LWI5YzAtNzNlZTM1ZjYyYjUyXkEyXkFqcGdeQXVyODEzNjM5OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "29-Mar-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Clockstoppers", 0, 0, "movie", 0, 0, 0, "Rob Hedden (story), Andy Hedden (story), J. David Stem (story), David N. Weiss (story), Rob Hedden (screenplay), J. David Stem (screenplay), David N. Weiss (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0157472.jpg", "tt0157472", "5.2", "11,035" },
                    { 71, 0, 0, "Richard Gere, David Eigenberg, Bob Tracey, Ron Emanuel", 0, 0, "1 win & 2 nominations.", 0, "565,307", 0, "USA", 0, "Mark Pellington", 0, 1, 0, 0, 0, "Drama, Horror, Mystery", 0, 1, "English", 0, "52", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Jan-02", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Mothman Prophecies", 0, 0, "movie", 0, 0, 0, "Richard Hatem (screenplay), John A. Keel (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0265349.jpg", "tt0265349", "6.5", "62,406" },
                    { 72, 0, 0, "Sam Spruell, Peter Stebbings, Christian Camargo, Roman Podhora", 0, 0, "2 nominations.", 0, "4,112,806", 0, "UK, Germany, USA, Canada", 0, "Kathryn Bigelow", 0, 1, 0, 0, 0, "Drama, History, Thriller", 1, 0, "English, Russian", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA0ODEzMTc1Nl5BMl5BanBnXkFtZTcwODM2MjAxNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Jul-02", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 1, "K-19: The Widowmaker", 0, 0, "movie", 0, 0, 0, "Louis Nowra (story), Christopher Kyle (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0267626.jpg", "tt0267626", "6.6", "48,348" },
                    { 73, 0, 0, "Rob Schneider, Anna Faris, Matthew Lawrence, Eric Christian Olsen", 0, 0, "3 nominations.", 0, "559,910", 1, "USA", 0, "Tom Brady", 0, 0, 0, 0, 1, "Comedy, Fantasy", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWFlYmY2MGEtZjVkYS00YzU4LTg0YjQtYzY1ZGE3NTA5NGQxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Dec-02", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hot Chick", 0, 0, "movie", 0, 0, 0, "Tom Brady, Rob Schneider", 0, "data/Movie_Poster_Dataset/2002/tt0302640.jpg", "tt0302640", "5.5", "72,765" },
                    { 74, 0, 1, "Eddie Murphy, Owen Wilson, Famke Janssen, Malcolm McDowell", 1, 0, "1 win & 4 nominations.", 0, "172,077", 1, "USA", 0, "Betty Thomas", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Hungarian, Russian", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDdhODg0MjYtYzBiOS00ZmI5LWEwZGYtZDEyNDU4MmQyNzFkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Nov-02", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "I Spy", 0, 0, "movie", 0, 0, 0, "Morton S. Fine (characters), David Friedkin (characters), Marianne Wibberley (story), Cormac Wibberley (story), Marianne Wibberley (screenplay), Cormac Wibberley (screenplay), Jay Scherick (screenplay), David Ronn (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0297181.jpg", "tt0297181", "5.4", "40,983" },
                    { 75, 0, 0, "Ice Cube, Mike Epps, John Witherspoon, Don 'D.C.' Curry", 0, 0, "N/A", 0, "32,983,713", 1, "USA", 0, "Marcus Raboy", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmQ2MmU3NzktZjAxOC00ZDZhLTk4YzEtMDMyMzcxY2IwMDAyXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Nov-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Friday After Next", 0, 0, "movie", 0, 0, 0, "Ice Cube (characters), DJ Pooh (characters), Ice Cube", 0, "data/Movie_Poster_Dataset/2002/tt0293815.jpg", "tt0293815", "5.8", "18,430" },
                    { 76, 0, 0, "Adrien Brody, Emilia Fox, Michal Zebrowski, Ed Stoppard", 0, 0, "Won 3 Oscars. Another 51 wins & 68 nominations.", 1, "32,519,322", 0, "France, Poland, Germany, UK", 0, "Roman Polanski", 0, 1, 0, 0, 0, "Biography, Drama, War", 0, 0, "English, German, Russian", 0, "85", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmYzNmM2MDctZGY3Yi00NjRiLWIxZjctYjgzYTcxYTNhYTMyXkEyXkFqcGdeQXVyMjUxMTY3ODM@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Mar-03", "TRUE", 0, "150 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Pianist", 0, 0, "movie", 0, 1, 0, "Ronald Harwood (screenplay), Wladyslaw Szpilman (book)", 0, "data/Movie_Poster_Dataset/2002/tt0253474.jpg", "tt0253474", "8.5", "476,443" },
                    { 77, 0, 0, "Robert De Niro, Billy Crystal, Lisa Kudrow, Joe Viterelli", 0, 0, "N/A", 0, "731,816", 1, "USA, Australia", 1, "Harold Ramis", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTI4NTNhZDMtMWNkZi00MTRmLWJmZDQtMmJkMGVmZTEzODlhXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Dec-02", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Analyze That", 0, 0, "movie", 0, 0, 0, "Kenneth Lonergan (characters), Peter Tolan (characters), Peter Steinfeld, Harold Ramis, Peter Tolan", 0, "data/Movie_Poster_Dataset/2002/tt0289848.jpg", "tt0289848", "5.9", "67,724" },
                    { 78, 0, 0, "Sandra Bullock, Ben Chaplin, Ryan Gosling, Michael Pitt", 0, 0, "2 nominations.", 0, "685,907", 0, "USA", 1, "Barbet Schroeder", 0, 0, 0, 0, 0, "Crime, Mystery, Thriller", 0, 0, "English", 0, "50", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWI3ZTMxNjctMjdlNS00NmUwLWFiM2YtZDUyY2I3N2MxYTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Apr-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 1, "Murder by Numbers", 0, 0, "movie", 0, 0, 0, "Tony Gayton", 0, "data/Movie_Poster_Dataset/2002/tt0264935.jpg", "tt0264935", "6.1", "42,661" },
                    { 79, 0, 0, "Robin Williams, Connie Nielsen, Michael Vartan, Dylan Smith", 0, 0, "6 wins & 20 nominations.", 0, "1,557,340", 0, "USA", 0, "Mark Romanek", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDQwODU5OWYtNDcyNi00MDQ1LThiOGMtZDkwNWJiM2Y3MDg0XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Sep-02", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 1, "One Hour Photo", 0, 0, "movie", 0, 0, 0, "Mark Romanek", 0, "data/Movie_Poster_Dataset/2002/tt0265459.jpg", "tt0265459", "6.8", "96,187" },
                    { 80, 0, 0, "Jamie Lee Curtis, Brad Loree, Busta Rhymes, Bianca Kajlich", 0, 0, "1 nomination.", 0, "212,443", 1, "USA", 0, "Rick Rosenthal", 0, 0, 0, 0, 0, "Comedy, Horror, Thriller", 0, 1, "English", 0, "19", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjViMmRkOTEtM2ViOS00ODg0LWJhYWEtNTBlOGQxNDczOGY3XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Jul-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 1, "Halloween: Resurrection", 0, 0, "movie", 0, 0, 0, "Debra Hill (characters), John Carpenter (characters), Larry Brand (story), Larry Brand (screenplay), Sean Hood (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0220506.jpg", "tt0220506", "4.1", "26,282" },
                    { 81, 0, 0, "Aaliyah, Stuart Townsend, Marguerite Moreau, Vincent Perez", 0, 0, "6 nominations.", 0, "690,809", 0, "USA, Australia", 0, "Michael Rymer", 0, 1, 0, 0, 1, "Drama, Fantasy, Horror", 0, 1, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Feb-02", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Queen of the Damned", 0, 0, "movie", 0, 0, 0, "Anne Rice (novels), Scott Abbott (screenplay), Michael Petroni (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0238546.jpg", "tt0238546", "5.2", "42,889" },
                    { 82, 0, 0, "Kevin Costner, Susanna Thompson, Joe Morton, Ron Rifkin", 0, 0, "1 nomination.", 0, "1,912,216", 0, "USA, Germany", 0, "Tom Shadyac", 0, 1, 0, 0, 1, "Drama, Fantasy, Mystery", 0, 0, "English, Spanish", 0, "25", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU0NTkyNzYwMF5BMl5BanBnXkFtZTgwMDU0NDk5MTI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Feb-02", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dragonfly", 0, 0, "movie", 0, 0, 0, "Brandon Camp (story), Mike Thompson (story), David Seltzer (screenplay), Brandon Camp (screenplay), Mike Thompson (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0259288.jpg", "tt0259288", "6.1", "31,261" },
                    { 83, 0, 0, "Goldie Hawn, Susan Sarandon, Geoffrey Rush, Erika Christensen", 0, 0, "Nominated for 1 Golden Globe. Another 1 win.", 0, "256,084", 1, "USA", 0, "Bob Dolman", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmExYWJjNTktNGUyZS00ODhmLTkxYzAtNWIzOGEyMGNiMmUwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Sep-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Banger Sisters", 0, 0, "movie", 0, 0, 0, "Bob Dolman", 0, "data/Movie_Poster_Dataset/2002/tt0280460.jpg", "tt0280460", "5.6", "12,169" },
                    { 84, 0, 1, "Anthony Hopkins, Chris Rock, Peter Stormare, Gabriel Macht", 1, 0, "N/A", 0, "2,385,636", 1, "USA, Czech Republic", 0, "Joel Schumacher", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTdmNTFjNDEtNzg0My00ZjkxLTg1ZDAtZTdkMDc2ZmFiNWQ1XkEyXkFqcGdeQXVyNTAzNzgwNTg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Jun-02", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bad Company", 0, 0, "movie", 0, 0, 0, "Gary M. Goodman (story), David Himmelstein (story), Jason Richman (screenplay), Michael Browning (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0280486.jpg", "tt0280486", "5.6", "38,945" },
                    { 85, 0, 0, "Gabriel Byrne, Julianna Margulies, Ron Eldard, Desmond Harrington", 0, 0, "1 nomination.", 0, "1,057,934", 0, "USA, Australia", 0, "Steve Beck", 0, 0, 0, 0, 0, "Horror, Mystery", 0, 1, "English, Italian, Spanish", 0, "28", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmQxNmU4ZjgtYzE5Mi00ZDlhLTlhOTctMzJkNjk2ZGUyZGEwXkEyXkFqcGdeQXVyMzgxMDA0Nzk@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Oct-02", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ghost Ship", 0, 0, "movie", 0, 0, 0, "Mark Hanlon (story), Mark Hanlon (screenplay), John Pogue (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0288477.jpg", "tt0288477", "5.5", "73,993" },
                    { 86, 0, 0, "DJ Qualls, Eliza Dushku, Zooey Deschanel, Jerod Mixon", 0, 0, "N/A", 0, "26,906", 1, "USA", 0, "Ed Decter", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "24", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWZhMjhhZmYtOTIzOC00MGYzLWI1OGYtM2ZkN2IxNTI4ZWI3XkEyXkFqcGdeQXVyNDAzNDk0MTQ@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-May-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The New Guy", 0, 0, "movie", 0, 0, 0, "David Kendall", 0, "data/Movie_Poster_Dataset/2002/tt0241760.jpg", "tt0241760", "5.9", "28,390" },
                    { 87, 0, 0, "Jesse Bradford, Erika Christensen, Shiri Appleby, Kate Burton", 0, 0, "N/A", 0, "44,246", 0, "USA", 0, "John Polson", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmY3MzYwMGUtOWMxYS00OGVhLWFjNmUtYzlkNGVmY2ZkMjA3XkEyXkFqcGdeQXVyMTExNDQ2MTI@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "6-Sep-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 1, "Swimfan", 0, 0, "movie", 0, 0, 0, "Charles F. Bohl, Phillip Schneider", 0, "data/Movie_Poster_Dataset/2002/tt0283026.jpg", "tt0283026", "5", "16,031" },
                    { 88, 0, 1, "Steve Irwin, Terri Irwin, Magda Szubanski, David Wenham", 1, 0, "1 win & 1 nomination.", 0, "1,373,838", 1, "Australia, USA", 0, "John Stainton", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg2NDg3ODg4NF5BMl5BanBnXkFtZTcwNzk3NTc3Nw@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "12-Jul-02", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Crocodile Hunter: Collision Course", 0, 0, "movie", 0, 0, 0, "John Stainton (story), Holly Goldberg Sloan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0305396.jpg", "tt0305396", "5.4", "5,600" },
                    { 89, 0, 0, "Taye Diggs, Sanaa Lathan, Yasiin Bey, Nicole Ari Parker", 0, 0, "2 wins & 18 nominations.", 0, "null", 1, "USA", 0, "Rick Famuyiwa", 0, 1, 0, 0, 0, "Romance, Comedy, Drama", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2JmMjViMjMtZTM5Mi00ZGZkLTk5YzctZDg5MjFjZDE4NjNkXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Oct-02", "TRUE", 1, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Brown Sugar", 0, 0, "movie", 0, 0, 0, "Michael Elliot (story), Michael Elliot (screenplay), Rick Famuyiwa (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0297037.jpg", "tt0297037", "6.5", "5,817" },
                    { 90, 0, 1, "Clint Eastwood, Jeff Daniels, Anjelica Huston, Wanda De Jesus", 0, 0, "1 win.", 0, "null", 0, "USA", 1, "Clint Eastwood", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Spanish", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWE3MGYzZjktY2Q5Mi00Y2NiLWIyYWUtMmIyNzA3YmZlMGFhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Aug-02", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blood Work", 0, 0, "movie", 0, 0, 0, "Michael Connelly (novel), Brian Helgeland (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0309377.jpg", "tt0309377", "6.4", "33,691" },
                    { 91, 0, 1, "Ice Cube, Mike Epps, Tommy Flanagan, Carmen Chaplin", 0, 0, "N/A", 0, "25,482,931", 1, "USA, Germany", 1, "Kevin Bray", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, French", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGE3N2QxN2YtM2ZlNS00MWIyLWE1NDAtYWFlN2FiYjY1MjczXkEyXkFqcGdeQXVyOTUwNzc0ODc@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Mar-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "All About the Benjamins", 0, 0, "movie", 0, 0, 0, "Ronald Lang, Ice Cube", 0, "data/Movie_Poster_Dataset/2002/tt0278295.jpg", "tt0278295", "5.7", "9,443" },
                    { 92, 0, 0, "Salma Hayek, Mía Maestro, Alfred Molina, Antonio Banderas", 0, 0, "Won 2 Oscars. Another 14 wins & 41 nominations.", 1, "14,164,253", 0, "USA, Canada, Mexico", 0, "Julie Taymor", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English, French, Russian", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjAzMzEwYzctNjc1MC00Nzg5LWFmMGItMTgzYmMyNTY2OTQ4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Nov-02", "TRUE", 1, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Frida", 0, 0, "movie", 0, 0, 0, "Hayden Herrera (book), Clancy Sigal (screenplay), Diane Lake (screenplay), Gregory Nava (screenplay), Anna Thomas (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0120679.jpg", "tt0120679", "7.4", "59,932" },
                    { 93, 0, 0, "Phil Vischer, Mike Nawrocki, Tim Hodge, Lisa Vischer", 1, 1, "1 nomination.", 0, "25,571,351", 1, "USA", 0, "Mike Nawrocki, Phil Vischer", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTJiNDEzOWYtMTVjOC00ZjlmLWE0NGMtZmE1OWVmZDQ2OWJhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "4-Oct-02", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jonah: A VeggieTales Movie", 0, 0, "movie", 0, 0, 0, "Phil Vischer, Mike Nawrocki, Tim Hodge (story)", 0, "data/Movie_Poster_Dataset/2002/tt0298388.jpg", "tt0298388", "6.6", "3,081" },
                    { 94, 0, 1, "Jason Statham, Qi Shu, Matt Schulze, François Berléand", 0, 0, "N/A", 0, "428,179", 0, "France, USA", 1, "Louis Leterrier, Corey Yuen", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, French, Mandarin", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY4NzcwODg3Nl5BMl5BanBnXkFtZTcwNTEwOTMyMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Oct-02", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Transporter", 0, 0, "movie", 0, 0, 0, "Luc Besson, Robert Mark Kamen", 0, "data/Movie_Poster_Dataset/2002/tt0293662.jpg", "tt0293662", "6.8", "230,102" },
                    { 95, 0, 0, "Lillian Adams, Herbert W. Ankrom, Bryan Anthony, Christina Applegate", 0, 0, "4 nominations.", 0, "1,741,972", 1, "USA", 0, "Roger Kumble", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDg4NjM1YjMtYmNhZC00MjM0LWFiZmYtNGY1YjA3MzZmODc5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Apr-02", "TRUE", 1, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Sweetest Thing", 0, 0, "movie", 0, 0, 0, "Nancy Pimental", 0, "data/Movie_Poster_Dataset/2002/tt0253867.jpg", "tt0253867", "5.1", "45,266" },
                    { 96, 0, 0, "Adam Sandler, Jackie Sandler, Austin Stout, Kevin Nealon", 0, 1, "1 win & 2 nominations.", 0, "23,443,124", 1, "USA", 0, "Seth Kearsley", 0, 0, 0, 0, 0, "Animation, Comedy, Musical", 0, 0, "English", 0, "23", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA2NDYxOGYtYjU1Mi00Y2QzLTgxMTQtMWI1MGI0ZGQ5MmU4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Nov-02", "TRUE", 0, "76 min", 0, 0, 0, 0, 0, 0, 0, 0, "Eight Crazy Nights", 0, 0, "movie", 0, 0, 0, "Brooks Arthur, Allen Covert, Brad Isaacs, Adam Sandler", 0, "data/Movie_Poster_Dataset/2002/tt0271263.jpg", "tt0271263", "5.4", "17,816" },
                    { 97, 0, 0, "Nicolas Cage, Tilda Swinton, Meryl Streep, Chris Cooper", 0, 0, "Won 1 Oscar. Another 60 wins & 94 nominations.", 0, "89,971", 1, "USA", 0, "Spike Jonze", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Latin", 0, "83", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTdiNzJlOWUtNWMwNS00NmFlLWI0YTEtZmI3YjIzZWUyY2Y3XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Feb-03", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Adaptation.", 0, 0, "movie", 0, 0, 0, "Susan Orlean (book), Charlie Kaufman (screenplay), Donald Kaufman (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0268126.jpg", "tt0268126", "7.7", "139,432" },
                    { 98, 0, 0, "Robert De Niro, Frances McDormand, James Franco, Eliza Dushku", 0, 0, "1 nomination.", 0, "566,358", 0, "USA", 1, "Michael Caton-Jones", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "50", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTBmZWJkNjctNDhiNC00MGE2LWEwOTctZTk5OGVhMWMyNmVhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Sep-02", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "City by the Sea", 0, 0, "movie", 0, 0, 0, "Mike McAlary (article), Ken Hixon (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0269095.jpg", "tt0269095", "6.2", "21,009" },
                    { 99, 0, 0, "Michael Moore, Salvador Allende, Jacobo Arbenz, Mike Bradley", 0, 0, "Won 1 Oscar. Another 38 wins & 11 nominations.", 0, "312,914", 0, "Canada, USA, Germany", 1, "Michael Moore", 1, 1, 0, 0, 0, "Documentary, Crime, Drama", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTI0MzcxMTYtZDVkMy00NjY1LTgyMTYtZmUxN2M3NmQ2NWJhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Nov-02", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bowling for Columbine", 0, 0, "movie", 0, 0, 0, "Michael Moore", 0, "data/Movie_Poster_Dataset/2002/tt0310793.jpg", "tt0310793", "8", "121,074" },
                    { 100, 0, 0, "Derek Luke, Malcolm David Kelley, Cory Hodges, Denzel Washington", 0, 0, "19 wins & 20 nominations.", 1, "null", 0, "USA", 0, "Denzel Washington", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English, Japanese", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTYwZWQ4ZTQtZWU0MS00N2YwLWEzMDItZWFkZWY0MWVjODVhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Jan-03", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Antwone Fisher", 0, 0, "movie", 0, 0, 0, "Antwone Fisher", 0, "data/Movie_Poster_Dataset/2002/tt0168786.jpg", "tt0168786", "7.3", "25,797" },
                    { 101, 0, 0, "Martin Lawrence, Nancy O'Dell, Paul Keeley, Art Cohan", 0, 0, "N/A", 1, "19,184,015", 1, "USA", 0, "David Raynr", 1, 0, 0, 0, 0, "Documentary, Biography, Comedy", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDU2ZWJlMjktMTRhMy00ZTA5LWEzNDgtYmNmZTEwZTViZWJkXkEyXkFqcGdeQXVyNDQ2OTk4MzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Aug-02", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Martin Lawrence Live: Runteldat", 0, 0, "movie", 0, 0, 0, "Martin Lawrence", 0, "data/Movie_Poster_Dataset/2002/tt0327036.jpg", "tt0327036", "5.4", "1,457" },
                    { 102, 0, 0, "Alexis Bledel, William Hurt, Sissy Spacek, Jonathan Jackson", 0, 0, "1 win & 3 nominations.", 0, "19,158,074", 0, "USA", 0, "Jay Russell", 0, 1, 0, 1, 0, "Drama, Romance, Family", 0, 0, "English, French", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzkzMmU0YTYtOWM3My00YzBmLWI0YzctOGYyNTkwMWE5MTJkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "11-Oct-02", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tuck Everlasting", 0, 0, "movie", 0, 0, 0, "Natalie Babbitt (novel), Jeffrey Lieber (screenplay), James V. Hart (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0283084.jpg", "tt0283084", "6.7", "17,555" },
                    { 103, 0, 0, "Bruce Willis, Colin Farrell, Terrence Howard, Cole Hauser", 0, 0, "1 win.", 0, "1,229,194", 0, "USA", 0, "Gregory Hoblit", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English, German", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmExNmEwYWItYmQzOS00YjA5LTk2MjktZjEyZDE1Y2QxNjA1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Feb-02", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hart's War", 0, 0, "movie", 0, 1, 0, "John Katzenbach (novel), Billy Ray (screenplay), Terry George (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0251114.jpg", "tt0251114", "6.3", "42,832" },
                    { 104, 0, 1, "Chris Klein, Jean Reno, LL Cool J, Rebecca Romijn", 0, 0, "1 win & 2 nominations.", 0, "84,494", 0, "USA, Germany, Japan", 0, "John McTiernan", 0, 0, 0, 0, 0, "Action, Sci-Fi, Sport", 0, 0, "English, Russian, French, Arabic, Korean, German, Japanese", 0, "14", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzkxODk0NjEtYjc4Mi00ZDI0LTgyYjEtYzc1NDkxY2YzYTgyXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Feb-02", "TRUE", 0, "98 min", 0, 0, 1, 0, 0, 0, 0, 0, "Rollerball", 0, 0, "movie", 0, 0, 0, "William Harrison (short story \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0246894.jpg", "tt0246894", "3", "21,943" },
                    { 105, 0, 0, "Wes Bentley, Mohamed Bouich, Campbell Brown, Daniel Caltagirone", 1, 0, "N/A", 0, "495,874", 0, "UK, USA", 0, "Shekhar Kapur", 0, 1, 0, 0, 0, "Adventure, Drama, Romance", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODM4Njg0NTAtYjI5Ny00ZjAxLTkwNmItZTMxMWU5M2U3M2RjXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Sep-02", "TRUE", 1, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Four Feathers", 0, 0, "movie", 0, 0, 0, "A.E.W. Mason (novel), Michael Schiffer (screenplay), Hossein Amini (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0240510.jpg", "tt0240510", "6.5", "27,652" },
                    { 106, 0, 0, "Adam Sandler, Jason Andrews, Don McManus, Emily Watson", 0, 0, "Nominated for 1 Golden Globe. Another 14 wins & 33 nominations.", 0, "null", 1, "USA", 0, "Paul Thomas Anderson", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGU2OGY5ZTYtMWNhYy00NjZiLWI0NjUtZmNhY2JhNDRmODU3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Nov-02", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Punch-Drunk Love", 0, 0, "movie", 0, 0, 0, "Paul Thomas Anderson", 0, "data/Movie_Poster_Dataset/2002/tt0272338.jpg", "tt0272338", "7.3", "106,408" },
                    { 107, 0, 0, "John Leguizamo, Peter Sarsgaard, Denise Richards, Vincent Laresca", 0, 0, "N/A", 0, "31,948", 0, "USA", 1, "Franc. Reyes", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, Spanish", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWJlNzUzNGMtYTAwMS00ZjI2LWFmNWQtODcxNWUxODA5YmU1XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Dec-02", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "Empire", 0, 0, "movie", 0, 0, 0, "Franc. Reyes", 0, "data/Movie_Poster_Dataset/2002/tt0262396.jpg", "tt0262396", "6", "6,408" },
                    { 108, 0, 1, "David Arquette, Kari Wuhrer, Scott Terra, Scarlett Johansson", 0, 0, "1 nomination.", 0, "17,266,505", 1, "USA, Australia", 0, "Ellory Elkayem", 0, 0, 0, 0, 0, "Action, Comedy, Horror", 0, 1, "English", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjdjNGQ4NDEtNTEwYS00MTgxLTliYzQtYzE2ZDRiZjFhZmNlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Jul-02", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Eight Legged Freaks", 0, 0, "movie", 0, 0, 0, "Ellory Elkayem (story), Randy Kornfield (story), Jesse Alexander (screenplay), Ellory Elkayem (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0271367.jpg", "tt0271367", "5.4", "42,770" },
                    { 109, 0, 0, "Haley Joel Osment, Diedrich Bader, Candy Ford, James Gammon", 0, 0, "1 nomination.", 0, "16,988,996", 1, "USA", 0, "Peter Hastings", 0, 0, 0, 1, 0, "Comedy, Family, Music", 0, 0, "English", 0, "37", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWZlMjFiYzgtMTUzNC00Y2IzLTk1NTMtZmNhMTczNTk0ODk1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "26-Jul-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Country Bears", 0, 0, "movie", 0, 0, 0, "Mark Perez", 0, "data/Movie_Poster_Dataset/2002/tt0276033.jpg", "tt0276033", "4", "3,778" },
                    { 110, 0, 0, "Matthew Perry, Elizabeth Hurley, Vincent Pastore, Bruce Campbell", 0, 0, "N/A", 0, "64,726", 1, "Germany, USA", 0, "Reginald Hudlin", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Spanish", 0, "18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGZhZDIzNWMtNjkxMS00MDQ1LThkMTYtZWQzYWU3MWMxMGU5XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-Aug-02", "TRUE", 1, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Serving Sara", 0, 0, "movie", 0, 0, 0, "Jay Scherick, David Ronn", 0, "data/Movie_Poster_Dataset/2002/tt0261289.jpg", "tt0261289", "5.3", "13,946" },
                    { 111, 0, 0, "Amy Aquino, John Billingsley, Elisa Bocanegra, Darlene Bohorquez", 0, 0, "3 wins & 7 nominations.", 0, "436,812", 0, "USA", 0, "Peter Kosminsky", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Russian", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2M1MmVhNDgtNmI0YS00ZDNmLTkyNjctNTJiYTQ2N2NmYzc2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Oct-02", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "White Oleander", 0, 0, "movie", 0, 0, 0, "Janet Fitch (novel), Mary Agnes Donoghue (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0283139.jpg", "tt0283139", "7.2", "25,084" },
                    { 112, 0, 0, "Dick Clark, Sam Rockwell, Michelle Sweeney, Drew Barrymore", 0, 0, "7 wins & 11 nominations.", 1, "null", 1, "USA, Germany, Canada", 1, "George Clooney", 0, 0, 0, 0, 0, "Biography, Comedy, Crime", 0, 0, "English, Spanish", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGU3NjQ4YTMtZGJjOS00YTQ3LThmNmItMTI5MDE2ODI3NzY3XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Jan-03", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Confessions of a Dangerous Mind", 0, 0, "movie", 0, 0, 0, "Chuck Barris (book), Charlie Kaufman (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0270288.jpg", "tt0270288", "7.1", "70,313" },
                    { 113, 0, 0, "Julianne Moore, Dennis Quaid, Dennis Haysbert, Patricia Clarkson", 0, 0, "Nominated for 4 Oscars. Another 100 wins & 86 nominations.", 0, "74,530", 0, "USA, France", 0, "Todd Haynes", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "84", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY3MjM1Mzc4N15BMl5BanBnXkFtZTgwODM0NzAxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Jan-03", "TRUE", 1, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Far from Heaven", 0, 0, "movie", 0, 0, 0, "Todd Haynes", 0, "data/Movie_Poster_Dataset/2002/tt0297884.jpg", "tt0297884", "7.4", "35,945" },
                    { 114, 0, 1, "Steven Seagal, Morris Chestnut, Ja Rule, Nia Peeples", 0, 0, "3 nominations.", 0, "409,207", 0, "Germany, USA", 1, "Don Michael Paul", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English", 0, "23", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmNlYzRiNDctZWNhMi00MzI4LThkZTctMTUzMmZkMmFmNThmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Nov-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Half Past Dead", 0, 0, "movie", 0, 0, 0, "Don Michael Paul", 0, "data/Movie_Poster_Dataset/2002/tt0297162.jpg", "tt0297162", "4.6", "12,058" },
                    { 115, 0, 0, "George Clooney, Natascha McElhone, Viola Davis, Jeremy Davies", 0, 0, "2 wins & 11 nominations.", 0, "384,509", 0, "USA", 0, "Steven Soderbergh", 0, 1, 0, 0, 0, "Drama, Mystery, Romance", 0, 0, "English", 0, "65", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWM1NmYyM2ItMTFhNy00NDU0LThlYWUtYjQyYTJmOTY0ZmM0XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Nov-02", "TRUE", 1, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Solaris", 0, 0, "movie", 0, 0, 0, "Stanislaw Lem (novel), Steven Soderbergh (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0307479.jpg", "tt0307479", "6.2", "66,542" },
                    { 116, 0, 0, "Angelina Jolie, Edward Burns, Tony Shalhoub, Christian Kane", 0, 0, "1 nomination.", 0, "40,525", 1, "USA", 0, "Stephen Herek", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWY5ZjhjNGYtZmI2Ny00ODM0LWFkNzgtZmI1YzA2N2MxMzA0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Apr-02", "TRUE", 1, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Life or Something Like It", 0, 0, "movie", 0, 0, 0, "John Scott Shepherd (story), John Scott Shepherd (screenplay), Dana Stevens (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0282687.jpg", "tt0282687", "5.8", "18,945" },
                    { 117, 0, 1, "Antonio Banderas, Lucy Liu, Gregg Henry, Ray Park", 0, 0, "4 nominations.", 0, "104,495", 0, "USA, Germany", 1, "Wych Kaosayananda", 0, 0, 0, 0, 0, "Action, Crime, Sci-Fi", 0, 0, "English", 0, "19", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzkwODFjNzItMmMwNi00MTU5LWE2MzktM2M4ZDczZGM1MmViXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Sep-02", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ballistic: Ecks vs. Sever", 0, 0, "movie", 0, 0, 0, "Alan B. McElroy", 0, "data/Movie_Poster_Dataset/2002/tt0308208.jpg", "tt0308208", "3.6", "16,578" },
                    { 118, 0, 0, "Kevin Kline, Emile Hirsch, Embeth Davidtz, Rob Morrow", 0, 0, "2 nominations.", 0, "14,060,950", 0, "USA", 0, "Michael Hoffman", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDA3NDExMTUtMDlhOC00MmQ5LWExZGUtYmI1NGVlZWI4OWNiXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Nov-02", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Emperor's Club", 0, 0, "movie", 0, 0, 0, "Ethan Canin (short story \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0283530.jpg", "tt0283530", "6.9", "14,024" },
                    { 119, 0, 0, "Jason Lee, Tom Green, Leslie Mann, Megan Mullally", 0, 0, "1 nomination.", 0, "13,973,532", 1, "USA", 1, "Bruce McCulloch", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTE4ODEwZDUtNDFjOC00NjAxLWEzYTQtYTI1NGVmZmFlNjdiL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Sep-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Stealing Harvard", 0, 0, "movie", 0, 0, 0, "Martin Hynes (story), Peter Tolan (story), Peter Tolan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0265808.jpg", "tt0265808", "5.1", "11,031" },
                    { 120, 0, 0, "Jennifer Aniston, Deborah Rush, Mike White, John Carroll Lynch", 0, 0, "5 wins & 16 nominations.", 0, "null", 1, "USA, Germany, Netherlands", 0, "Miguel Arteta", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDRjNGViMjQtOThlMi00MTA3LThkYzQtNzJkYjBkMGE0YzE1XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Aug-02", "TRUE", 1, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Good Girl", 0, 0, "movie", 0, 0, 0, "Mike White", 0, "data/Movie_Poster_Dataset/2002/tt0279113.jpg", "tt0279113", "6.5", "37,206" },
                    { 121, 0, 0, "Spencer Klein, Francesca Marie Smith, Jamil Walker Smith, Dan Castellaneta", 1, 1, "1 nomination.", 0, "null", 1, "USA", 0, "Tuck Tucker", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZmM0NGY3Y2MtMTA1YS00YmQzLTk2YTctYWFhMDkzMDRjZWQzXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "28-Jun-02", "TRUE", 0, "76 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hey Arnold! The Movie", 0, 0, "movie", 0, 0, 0, "Craig Bartlett (characters), Craig Bartlett, Steve Viksten", 0, "data/Movie_Poster_Dataset/2002/tt0314166.jpg", "tt0314166", "5.9", "4,357" },
                    { 122, 0, 0, "Miguel A. Núñez Jr., Vivica A. Fox, Kevin Pollak, Tommy Davidson", 0, 0, "1 nomination.", 0, "13,571,817", 1, "USA", 0, "Jesse Vaughan", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "24", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmI1ODdjODctMDlmMC00ZWViLWI5MzYtYzRhNDdjYmM3MzFjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Jun-02", "TRUE", 1, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Juwanna Mann", 0, 0, "movie", 0, 0, 0, "Bradley Allenstein", 0, "data/Movie_Poster_Dataset/2002/tt0247444.jpg", "tt0247444", "4.5", "5,238" },
                    { 125, 0, 0, "Edward Norton, Philip Seymour Hoffman, Barry Pepper, Rosario Dawson", 0, 0, "Nominated for 1 Golden Globe. Another 4 wins & 14 nominations.", 0, "32,399", 0, "USA", 0, "Spike Lee", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTdlNjgyZGUtOTczYi00MDdhLTljZmMtYTEwZmRiOWFkYjRhXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jan-03", "TRUE", 0, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "25th Hour", 0, 0, "movie", 0, 0, 0, "David Benioff (novel), David Benioff (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0307901.jpg", "tt0307901", "7.7", "147,226" },
                    { 126, 0, 0, "Michael Caine, Brendan Fraser, Do Thi Hai Yen, Rade Serbedzija", 0, 0, "Nominated for 1 Oscar. Another 13 wins & 13 nominations.", 0, "12,987,647", 0, "UK, Germany, USA, Australia, France", 0, "Phillip Noyce", 0, 1, 0, 0, 0, "Drama, Mystery, Romance", 0, 0, "English, French, Vietnamese", 0, "84", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjBiOTYxZWItMzdiZi00NjlkLWIzZTYtYmFhZjhiMTljOTdkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Mar-03", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Quiet American", 0, 0, "movie", 0, 0, 0, "Graham Greene (novel), Christopher Hampton (screenplay), Robert Schenkkan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0258068.jpg", "tt0258068", "7.1", "23,722" },
                    { 127, 0, 1, "Wesley Snipes, Ving Rhames, Peter Falk, Michael Rooker", 0, 0, "1 nomination.", 0, "12,398,628", 0, "USA, Germany", 1, "Walter Hill", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODA4ODk3OTEzMF5BMl5BanBnXkFtZTgwMTQ2ODMwMzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Aug-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Undisputed", 0, 0, "movie", 0, 0, 0, "David Giler, Walter Hill", 0, "data/Movie_Poster_Dataset/2002/tt0281322.jpg", "tt0281322", "6.1", "20,827" },
                    { 128, 0, 1, "Cathy Cavadini, Tara Strong, Elizabeth Daily, Roger Jackson", 1, 1, "N/A", 0, "null", 0, "USA", 0, "Craig McCracken", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg5YWIyMWUtZDY5My00Zjc1LTljOTctYmI0MWRmY2M2NmRkXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "3-Jul-02", "TRUE", 0, "73 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Powerpuff Girls Movie", 0, 0, "movie", 0, 0, 0, "Charlie Bean, Lauren Faust, Craig McCracken, Paul Rudish, Don Shank, Charlie Bean (story), Craig McCracken (story), Amy Keating Rogers (story), Paul Rudish (story), Don Shank (story), Lauren Faust (story), Craig McCracken (creator)", 0, "data/Movie_Poster_Dataset/2002/tt0289408.jpg", "tt0289408", "6.5", "7,483" },
                    { 129, 0, 0, "Katie Holmes, Benjamin Bratt, Charlie Hunnam, Zooey Deschanel", 0, 0, "1 nomination.", 0, "10,719,367", 0, "USA, Germany, Canada", 0, "Stephen Gaghan", 0, 1, 0, 0, 0, "Drama, Music, Mystery", 0, 0, "English, Italian", 0, "36", 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjhhMThhNDItNTY2MC00MmU1LTliNDEtNDdhZjdlNTY5ZDQ1XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Oct-02", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Abandon", 0, 0, "movie", 0, 0, 0, "Stephen Gaghan", 0, "data/Movie_Poster_Dataset/2002/tt0267248.jpg", "tt0267248", "4.9", "7,819" },
                    { 130, 0, 0, "Dan Leis, Jason Patric, Lloyd Adams, Meagan Issa", 0, 0, "1 win & 8 nominations.", 0, "16,236", 0, "USA, Canada", 1, "Joe Carnahan", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Spanish", 0, "70", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjg2ZDI2YTYtN2EwYi00YWI5LTgyMWQtMWFkYmE3NmJkOGVhXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jan-03", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Narc", 0, 0, "movie", 0, 0, 0, "Joe Carnahan", 0, "data/Movie_Poster_Dataset/2002/tt0272207.jpg", "tt0272207", "7.2", "33,547" },
                    { 131, 0, 0, "Barry Watson, Michael Rosenbaum, Harland Williams, Melissa Sagemiller", 0, 0, "1 win & 1 nomination.", 0, "121,309", 1, "USA", 0, "Wallace Wolodarsky", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWU4ZjNlNTQtOGE2MS00NDI0LWFlYjMtMmY3ZWVkMjJkNGRmXkEyXkFqcGdeQXVyNjE1OTQ0NjA@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Mar-02", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sorority Boys", 0, 0, "movie", 0, 0, 0, "Joe Jarvis, Greg Coolidge", 0, "data/Movie_Poster_Dataset/2002/tt0279781.jpg", "tt0279781", "5.4", "11,804" },
                    { 132, 0, 0, "Javier Cámara, Darío Grandinetti, Leonor Watling, Rosario Flores", 0, 0, "Won 1 Oscar. Another 41 wins & 42 nominations.", 0, "9,284,265", 0, "Spain", 0, "Pedro Almodóvar", 0, 1, 0, 0, 0, "Drama, Mystery, Romance", 0, 0, "Spanish", 0, "86", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDNlNzBjMGUtYTA0Yy00OTI2LWJmZjMtODliYmUyYTI0OGFmXkEyXkFqcGdeQXVyODIwMDI1NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Feb-03", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Talk to Her", 0, 0, "movie", 0, 0, 0, "Pedro Almodóvar", 0, "data/Movie_Poster_Dataset/2002/tt0287467.jpg", "tt0287467", "8", "84,399" },
                    { 133, 0, 0, "Rupert Everett, Colin Firth, Frances O'Connor, Reese Witherspoon", 0, 0, "2 wins & 2 nominations.", 0, "null", 1, "UK, USA", 0, "Oliver Parker", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, German", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYzIzYmJlYTYtNGNiYy00N2EwLTk4ZjItMGYyZTJiOTVkM2RlXkEyXkFqcGdeQXVyODY1NDk1NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Jun-02", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Importance of Being Earnest", 0, 0, "movie", 0, 0, 0, "Oscar Wilde (play), Oliver Parker (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0278500.jpg", "tt0278500", "6.9", "18,643" },
                    { 134, 0, 0, "Robin Williams, Edward Norton, Catherine Keener, Danny DeVito", 0, 0, "2 nominations.", 0, "8,355,815", 1, "UK, Germany, USA", 1, "Danny DeVito", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjI0ODcxNzM1N15BMl5BanBnXkFtZTgwMzIwMTEwNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Mar-02", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Death to Smoochy", 0, 0, "movie", 0, 0, 0, "Adam Resnick", 0, "data/Movie_Poster_Dataset/2002/tt0266452.jpg", "tt0266452", "6.4", "34,334" },
                    { 135, 0, 0, "Tim Allen, Rene Russo, Stanley Tucci, Tom Sizemore", 0, 0, "N/A", 0, "7,262,288", 1, "USA", 1, "Barry Sonnenfeld", 0, 0, 0, 0, 0, "Comedy, Crime, Thriller", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYzODg0Mjc4M15BMl5BanBnXkFtZTgwNzY4Mzc3NjE@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Apr-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 1, "Big Trouble", 0, 0, "movie", 0, 0, 0, "Dave Barry (novel), Robert Ramsey (screenplay), Matthew Stone (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0246464.jpg", "tt0246464", "6.5", "16,971" },
                    { 136, 0, 0, "Charlize Theron, Courtney Love, Stuart Townsend, Kevin Bacon", 0, 0, "N/A", 0, "62,536", 0, "USA, Germany", 1, "Luis Mandoki", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGNlNmRkMjctNDgxMC00NzFhLWIzY2YtZDk3ZDE0NWZhZDBlXkEyXkFqcGdeQXVyODIwMDI1NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Sep-02", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "Trapped", 0, 0, "movie", 0, 0, 0, "Greg Iles (novel), Greg Iles (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0280380.jpg", "tt0280380", "6.2", "19,198" },
                    { 137, 0, 0, "Jake Gyllenhaal, Dustin Hoffman, Susan Sarandon, Alexia Landeau", 0, 0, "1 win & 4 nominations.", 0, "380,376", 0, "USA", 0, "Brad Silberling", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, Hebrew", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWYwOThjM2ItZGYxNy00NTQwLWFlZWEtM2MzM2Q5MmY3NDU5XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Oct-02", "TRUE", 1, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Moonlight Mile", 0, 0, "movie", 0, 0, 0, "Brad Silberling", 0, "data/Movie_Poster_Dataset/2002/tt0179098.jpg", "tt0179098", "6.7", "11,805" },
                    { 138, 0, 0, "Pierre Lebeau, Karine Vanasse, Roy Dupuis, Rémy Girard", 0, 0, "8 wins & 10 nominations.", 0, "null", 0, "Canada", 0, "Charles Binamé", 0, 1, 0, 0, 0, "Drama", 0, 0, "French, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmJhZmJlYTItZmZlNy00MGY0LTg0ZGMtNWFkYWU5NTA1YTNhXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Dec-02", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Séraphin: un homme et son péché", 0, 0, "movie", 0, 0, 0, "Pierre Billon, Charles Binamé, Claude-Henri Grignon (novel), Antonine Maillet, Lorraine Richard", 0, "data/Movie_Poster_Dataset/2002/tt0221013.jpg", "tt0221013", "6.7", "849" },
                    { 139, 0, 0, "Rebecca Romijn, Antonio Banderas, Peter Coyote, Eriq Ebouaney", 0, 0, "1 win & 1 nomination.", 0, "567,253", 0, "France, Switzerland", 1, "Brian De Palma", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, French, Spanish", 0, "59", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWYyOWRlOWItZWM5MS00ZjJkLWI0MTUtYTE3NTI5MDAwYjgyXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Nov-02", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Femme Fatale", 0, 0, "movie", 0, 0, 0, "Brian De Palma", 0, "data/Movie_Poster_Dataset/2002/tt0280665.jpg", "tt0280665", "6.3", "28,151" },
                    { 140, 0, 0, "James Van Der Beek, Shannyn Sossamon, Jessica Biel, Kip Pardue", 0, 0, "2 wins & 3 nominations.", 0, "null", 1, "USA, Germany", 0, "Roger Avary", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, German", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgwNzA3MDQzOV5BMl5BanBnXkFtZTgwNTE5MDE5NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Oct-02", "TRUE", 1, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Rules of Attraction", 0, 0, "movie", 0, 0, 0, "Bret Easton Ellis (novel), Roger Avary (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0292644.jpg", "tt0292644", "6.7", "43,720" },
                    { 142, 0, 0, "Everlyn Sampi, Tianna Sansbury, Laura Monaghan, David Gulpilil", 1, 0, "Nominated for 1 Golden Globe. Another 23 wins & 23 nominations.", 1, "6,165,429", 0, "Australia", 0, "Phillip Noyce", 0, 1, 0, 0, 0, "Adventure, Biography, Drama", 0, 0, "Aboriginal, English", 0, "80", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTY1Nzg4MjcwN15BMl5BanBnXkFtZTcwOTc1NTk1OQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "31-Jan-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rabbit-Proof Fence", 0, 0, "movie", 0, 0, 0, "Doris Pilkington (book), Christine Olsen (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0252444.jpg", "tt0252444", "7.5", "23,064" },
                    { 143, 0, 1, "Stephen Dorff, Brad Renfro, Fairuza Balk, Norman Reedus", 0, 0, "1 nomination.", 0, "6,044,618", 0, "USA, Germany", 1, "Scott Kalvert", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "16", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5NjY4MjUwNF5BMl5BanBnXkFtZTgwODM3NzM5MzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-May-02", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Deuces Wild", 0, 0, "movie", 0, 0, 0, "Paul Kimatian, Christopher Gambale", 0, "data/Movie_Poster_Dataset/2002/tt0231448.jpg", "tt0231448", "5.6", "6,099" },
                    { 144, 0, 0, "America Ferrera, Lupe Ontiveros, Ingrid Oliu, George Lopez", 0, 0, "7 wins & 4 nominations.", 0, "5,844,929", 1, "USA", 0, "Patricia Cardoso", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Spanish", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzgxMzExMzUwNV5BMl5BanBnXkFtZTcwMDc2MjUwNA@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Nov-02", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Real Women Have Curves", 0, 0, "movie", 0, 0, 0, "Josefina Lopez (play), George LaVoo (teleplay), Josefina Lopez (teleplay)", 0, "data/Movie_Poster_Dataset/2002/tt0296166.jpg", "tt0296166", "7", "5,916" },
                    { 145, 0, 0, "Gael García Bernal, Ana Claudia Talancón, Sancho Gracia, Angélica Aragón", 0, 0, "Nominated for 1 Oscar. Another 21 wins & 14 nominations.", 0, "5,709,616", 0, "Mexico, Spain, Argentina, France", 0, "Carlos Carrera", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Spanish", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTgwODM5OTMzN15BMl5BanBnXkFtZTcwMTA3NzI1Nw@@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Dec-02", "TRUE", 1, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "El crimen del padre Amaro", 0, 0, "movie", 0, 0, 0, "Vicente Leñero, Eça de Queirós (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0313196.jpg", "tt0313196", "6.8", "10,843" },
                    { 146, 0, 0, "Olga Sékulic, Stephen Dillane, Françoise Bertin, Thandie Newton", 0, 0, "2 nominations.", 0, "34,676", 0, "Germany, USA", 0, "Jonathan Demme", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English, French, Arabic", 0, "55", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2FhZGI5M2QtZWFiZS00NjkwLWE4NWQtMzg3ZDZjNjdkYTJiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Oct-02", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Truth About Charlie", 0, 0, "movie", 0, 0, 0, "Peter Stone (based on the motion picture \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0270707.jpg", "tt0270707", "4.8", "8,525" },
                    { 147, 0, 0, "Devon Sawa, Jason Segel, Michael C. Maronna, Jason Schwartzman", 0, 0, "N/A", 0, "null", 1, "Canada, USA", 0, "Dewey Nicks", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "12", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk4ODk5MTMyNV5BMl5BanBnXkFtZTcwMDMyNTg0Ng@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Feb-02", "TRUE", 1, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Slackers", 0, 0, "movie", 0, 0, 0, "David H. Steinberg", 0, "data/Movie_Poster_Dataset/2002/tt0240900.jpg", "tt0240900", "5.3", "12,270" },
                    { 149, 0, 0, "Téa Leoni, Bob Dorian, Ivan Martin, Gregg Edelman", 0, 0, "N/A", 0, "92,283", 1, "USA", 0, "Woody Allen", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Mandarin", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzhiNDkyNzktNTZmYS00ZTBkLTk2MDAtM2U0YjU1MzgxZjgzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-May-02", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hollywood Ending", 0, 0, "movie", 0, 0, 0, "Woody Allen", 0, "data/Movie_Poster_Dataset/2002/tt0278823.jpg", "tt0278823", "6.6", "21,110" },
                    { 150, 0, 1, "Devon Sawa, Bridgette Wilson-Sampras, Rupert Graves, Rufus Sewell", 1, 0, "1 nomination.", 0, "56,496", 0, "UK, Germany, Luxembourg", 0, "Christian Duguay", 0, 0, 0, 0, 0, "Action, Adventure, Thriller", 0, 0, "English, German, Japanese, Serbo-Croatian", 0, "17", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk3NDE2NzI4NF5BMl5BanBnXkFtZTgwNzE1MzEyMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Nov-02", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 1, "Extreme Ops", 0, 0, "movie", 0, 0, 0, "Timothy Scott Bogart (story), Mark Mullin (story), Michael Zaidan (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0283160.jpg", "tt0283160", "4.5", "4,756" },
                    { 151, 0, 0, "Kieran Culkin, Claire Danes, Jeff Goldblum, Jared Harris", 0, 0, "Nominated for 2 Golden Globes. Another 7 wins & 15 nominations.", 0, "null", 1, "USA", 0, "Burr Steers", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Oct-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Igby Goes Down", 0, 0, "movie", 0, 0, 0, "Burr Steers", 0, "data/Movie_Poster_Dataset/2002/tt0280760.jpg", "tt0280760", "7", "28,635" },
                    { 152, 0, 1, "Eddie Murphy, Randy Quaid, Rosario Dawson, Joe Pantoliano", 0, 0, "1 win & 6 nominations.", 0, "135,054", 1, "USA, Australia", 0, "Ron Underwood", 0, 0, 0, 0, 0, "Comedy, Action, Sci-Fi", 0, 0, "English", 0, "12", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUzODMyNzk4NV5BMl5BanBnXkFtZTgwNTk1NTYyNTM@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Aug-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Adventures of Pluto Nash", 0, 0, "movie", 0, 0, 0, "Neil Cuthbert", 0, "data/Movie_Poster_Dataset/2002/tt0180052.jpg", "tt0180052", "3.7", "19,900" },
                    { 153, 0, 0, "James B. Douglas, Molly Parker, Paul Gross, Barbara Gordon", 0, 0, "1 win & 9 nominations.", 0, "4,239,767", 1, "Canada", 0, "Paul Gross", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, American Sign Language, German", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjAxODQ4MDU5NV5BMl5BanBnXkFtZTcwMDU4MjU1MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Nov-02", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Men with Brooms", 0, 0, "movie", 0, 0, 0, "Paul Gross (story), John Krizanc (story), Paul Quarrington (story), Paul Gross (screenplay), John Krizanc (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0263734.jpg", "tt0263734", "6", "3,660" },
                    { 154, 0, 0, "James Spader, Maggie Gyllenhaal, Jeremy Davies, Lesley Ann Warren", 0, 0, "Nominated for 1 Golden Globe. Another 15 wins & 24 nominations.", 0, "null", 1, "USA", 0, "Steven Shainberg", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU3ODg2NjQ5NF5BMl5BanBnXkFtZTcwMDEwODgzMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Oct-02", "TRUE", 1, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Secretary", 0, 0, "movie", 0, 0, 0, "Erin Cressida Wilson (screenplay), Mary Gaitskill (short story), Steven Shainberg (story), Erin Cressida Wilson (story)", 0, "data/Movie_Poster_Dataset/2002/tt0274812.jpg", "tt0274812", "7.1", "66,622" },
                    { 155, 0, 0, "Roberto Benigni, Nicoletta Braschi, Mino Bellei, Carlo Giuffrè", 0, 0, "4 wins & 11 nominations.", 0, "1,132,243", 1, "Italy, USA", 0, "Roberto Benigni", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "Italian", 0, "11", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgxOTY4Mjc0MF5BMl5BanBnXkFtZTcwNTA4MDQyMw@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "G", 0, 0, "25-Dec-02", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pinocchio", 0, 0, "movie", 0, 0, 0, "Roberto Benigni, Vincenzo Cerami, Carlo Collodi (novel), Brendan Donnison (English adaptation)", 0, "data/Movie_Poster_Dataset/2002/tt0255477.jpg", "tt0255477", "4.2", "6,218" },
                    { 156, 0, 0, "Danielle Darrieux, Catherine Deneuve, Isabelle Huppert, Emmanuelle Béart", 0, 0, "10 wins & 29 nominations.", 0, "null", 1, "France, Italy", 1, "François Ozon", 0, 0, 0, 0, 0, "Comedy, Crime, Musical", 0, 0, "French, English", 0, "64", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTI5ODc3NzExNV5BMl5BanBnXkFtZTcwNzYxNzQzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Oct-02", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "8 Women", 0, 0, "movie", 0, 0, 0, "François Ozon, Robert Thomas (play), Marina de Van", 0, "data/Movie_Poster_Dataset/2002/tt0283832.jpg", "tt0283832", "7.1", "23,255" },
                    { 157, 0, 1, "Wood Harris, Mekhi Phifer, Kevin Carroll, Esai Morales", 0, 0, "1 nomination.", 0, "25,657", 0, "USA", 1, "Charles Stone III", 0, 1, 0, 0, 0, "Drama, Action, Crime", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYThmZDA0YmQtMWJhNy00MDQwLTk0Y2YtMDhmZTE5ZjhlNjliXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Oct-02", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Paid in Full", 0, 0, "movie", 0, 0, 0, "Azie Faison Jr. (earlier screenplay), Austin Phillips (earlier screenplay), Matthew Cirulnick (screenplay), Thulani Davis (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0259484.jpg", "tt0259484", "7.1", "6,719" },
                    { 158, 0, 0, "Alex Lewis, Alan King, Cullen Douglas, Clifton James", 0, 0, "7 wins & 3 nominations.", 0, "3,064,356", 0, "USA", 0, "John Sayles", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTI5MmE5M2UtZjIzYS00M2JjLWIwNDItYTY2ZWNiODBmYTBiXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jul-02", "TRUE", 1, "141 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sunshine State", 0, 0, "movie", 0, 0, 0, "John Sayles", 0, "data/Movie_Poster_Dataset/2002/tt0286179.jpg", "tt0286179", "6.9", "3,411" },
                    { 159, 0, 0, "Jerry Seinfeld, Greg Giraldo, Sherrod Small, Jim Norton", 0, 0, "2 nominations.", 0, "2,744,253", 1, "USA", 0, "Christian Charles", 1, 0, 0, 0, 0, "Documentary, Comedy", 0, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Nov-02", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Comedian", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0328962.jpg", "tt0328962", "7", "5,118" },
                    { 160, 0, 0, "Shah Rukh Khan, Madhuri Dixit, Aishwarya Rai Bachchan, Jackie Shroff", 0, 0, "Nominated for 1 BAFTA Film Award. Another 44 wins & 7 nominations.", 0, "null", 0, "India", 0, "Sanjay Leela Bhansali", 0, 0, 0, 0, 0, "Musical, Romance", 0, 0, "Hindi, Urdu, Bengali", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzExOTcwNjYtZTljMC00YTQ2LWI2YjYtNWFlYzQ0YTJhNzJmXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "12-Jul-02", "TRUE", 1, "185 min", 0, 0, 0, 0, 0, 0, 0, 0, "Devdas", 0, 0, "movie", 0, 0, 0, "Saratchandra Chatterjee (based on the novel by), Prakash Kapadia (screenplay), Sanjay Leela Bhansali (screenplay), Prakash Kapadia (dialogue)", 0, "data/Movie_Poster_Dataset/2002/tt0238936.jpg", "tt0238936", "7.6", "24,534" },
                    { 161, 0, 0, "David Duchovny, Nicky Katt, Catherine Keener, Mary McCormack", 0, 0, "1 nomination.", 0, "2,506,446", 1, "USA", 0, "Steven Soderbergh", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU0NTU5NTAyMl5BMl5BanBnXkFtZTYwNzYwMDg2._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Aug-02", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Full Frontal", 0, 0, "movie", 0, 0, 0, "Coleman Hough", 0, "data/Movie_Poster_Dataset/2002/tt0290212.jpg", "tt0290212", "4.8", "8,597" },
                    { 162, 0, 0, "Sergey Dreyden, Mariya Kuznetsova, Leonid Mozgovoy, Mikhail Piotrovsky", 0, 0, "10 wins & 14 nominations.", 0, "37,439", 0, "Russia, Germany, Japan, Canada, Finland, Denmark", 0, "Aleksandr Sokurov", 0, 1, 0, 0, 1, "Drama, Fantasy, History", 1, 0, "Russian, Persian", 0, "86", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmM4YTFmMmItMGE3Yy00MmRkLTlmZGEtMzZlOTQzYjk3MzA2XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "19-Apr-03", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Russian Ark", 0, 0, "movie", 0, 0, 0, "Boris Khaimsky (dialogue), Anatoli Nikiforov, Svetlana Proskurina (dialogue), Aleksandr Sokurov (dialogue), Aleksandr Sokurov", 0, "data/Movie_Poster_Dataset/2002/tt0318034.jpg", "tt0318034", "7.4", "13,683" },
                    { 163, 0, 1, "Beanie Sigel, Omillio Sparks, Memphis Bleek, Damon Dash", 0, 0, "N/A", 0, "2,099,719", 0, "USA", 1, "Abdul Malik Abbott", 0, 1, 0, 0, 0, "Drama, Crime, Action", 0, 0, "English", 0, "9", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzcwYWFkYzktZjAzNC00OGY1LWI4YTgtNzc5MzVjMDVmNjY0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jan-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "State Property", 0, 0, "movie", 0, 0, 0, "Abdul Malik Abbott, Ernest 'Tron' Anderson", 0, "data/Movie_Poster_Dataset/2002/tt0301893.jpg", "tt0301893", "4.2", "1,615" },
                    { 164, 0, 0, "Greg Kinnear, Willem Dafoe, Rita Wilson, Maria Bello", 0, 0, "6 nominations.", 1, "2,062,066", 0, "USA", 1, "Paul Schrader", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGMzZjY2ZWQtZjQxYS00NWY3LThhNjItNWQzNTkzOTllODljXkEyXkFqcGdeQXVyNjY1MTg4Mzc@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Nov-02", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Auto Focus", 0, 0, "movie", 0, 0, 0, "Robert Graysmith (book), Michael Gerbosi", 0, "data/Movie_Poster_Dataset/2002/tt0298744.jpg", "tt0298744", "6.6", "11,260" },
                    { 166, 0, 0, "Sophie Lorain, Martin Drainville, Pierrette Robitaille, Marc Labrèche", 0, 0, "2 nominations.", 0, "null", 1, "Canada", 0, "Denise Filiatrault", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAyN2JmZmEtNjAyMy00NzYwLThmY2MtYWQ3OGNhNjExMmM4XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "28-Jun-02", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "L'odyssée d'Alice Tremblay", 0, 0, "movie", 0, 0, 0, "Sylvie Lussier, Pierre Poirier", 0, "data/Movie_Poster_Dataset/2002/tt0302882.jpg", "tt0302882", "5.1", "415" },
                    { 167, 0, 0, "Richard 'Pistol' Allen, Jack Ashford, Bob Babbitt, Benny 'Papa Zita' Benjamin", 0, 0, "7 wins & 12 nominations.", 0, "1,600,547", 0, "USA", 0, "Paul Justman", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "76", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMDQ2YzEyZGItYWRhOS00MjBmLTkzMDUtMTdjYzkyMmQxZTJlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "29-Nov-02", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Standing in the Shadows of Motown", 0, 0, "movie", 0, 0, 0, "Walter Dallas (Narration), Ntozake Shange (Narration), Alan Slutsky (book)", 0, "data/Movie_Poster_Dataset/2002/tt0314725.jpg", "tt0314725", "7.8", "2,879" },
                    { 168, 0, 0, "Ralph Fiennes, Miranda Richardson, Gabriel Byrne, Lynn Redgrave", 0, 0, "13 wins & 24 nominations.", 0, "1,641,788", 0, "Canada, UK, France", 0, "David Cronenberg", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English", 0, "83", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGQ4ZjFmYjktOGNkNS00OWYyLWIyZjgtMGJjM2U1ZTA0ZTlhXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Nov-02", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Spider", 0, 0, "movie", 0, 0, 0, "Patrick McGrath (novel), Patrick McGrath", 0, "data/Movie_Poster_Dataset/2002/tt0278731.jpg", "tt0278731", "6.9", "29,608" },
                    { 169, 0, 0, "Stella Gonet, Andrew Havill, Henry McGrath, Hugh Mitchell", 0, 0, "Nominated for 1 Golden Globe. Another 1 win & 4 nominations.", 0, "null", 0, "UK, USA", 0, "Douglas McGrath", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNGMwNzUwNjYtZWM5NS00YzMyLWI4NjAtNjM0ZDBiMzE1YWExXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "27-Jun-03", "TRUE", 1, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "Nicholas Nickleby", 0, 0, "movie", 0, 0, 0, "Charles Dickens (novel), Douglas McGrath (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0309912.jpg", "tt0309912", "7.2", "9,228" },
                    { 170, 0, 0, "Simon Abkarian, Charles Aznavour, Christopher Plummer, Arsinée Khanjian", 0, 0, "12 wins & 13 nominations.", 0, "1,554,566", 0, "Canada, France", 0, "Atom Egoyan", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English, Armenian, French, German, Turkish", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTcxOWYzNDYtYmM4YS00N2NkLTk0NTAtNjg1ODgwZjAxYzI3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Dec-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ararat", 0, 0, "movie", 0, 1, 0, "Atom Egoyan", 0, "data/Movie_Poster_Dataset/2002/tt0273435.jpg", "tt0273435", "6.6", "8,542" },
                    { 171, 0, 0, "Sophie Vavasseur, Niall Beagan, Hugh McDonagh, Pierce Brosnan", 0, 0, "2 wins & 7 nominations.", 0, "230,830", 0, "Germany, Ireland, USA, UK, Netherlands", 0, "Bruce Beresford", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZTIwYzRjMGYtZWQ0Ni00NDZhLThhZDYtOGViZGJiZTkwMzk2XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Dec-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Evelyn", 0, 0, "movie", 0, 0, 0, "Paul Pender", 0, "data/Movie_Poster_Dataset/2002/tt0298856.jpg", "tt0298856", "7.1", "5,293" },
                    { 172, 0, 0, "Rahul Khanna, Lisa Ray, Moushumi Chatterjee, Dina Pathak", 0, 0, "3 wins & 8 nominations.", 0, "1,491,083", 1, "Canada", 0, "Deepa Mehta", 0, 1, 0, 0, 0, "Romance, Comedy, Drama", 0, 0, "English, Hindi, Spanish", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODM3YWY4NmQtN2Y3Ni00OTg0LWFhZGQtZWE3ZWY4MTJlOWU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Oct-02", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bollywood/Hollywood", 0, 0, "movie", 0, 0, 0, "Deepa Mehta", 0, "data/Movie_Poster_Dataset/2002/tt0303785.jpg", "tt0303785", "6", "2,236" },
                    { 173, 0, 0, "Robert Evans, Eddie Albert, Peter Bart, Charlie Bluhdorn", 0, 0, "4 wins & 12 nominations.", 1, "1,434,436", 0, "USA", 0, "Nanette Burstein, Brett Morgen", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjNkMzc2N2QtNjVlNS00ZTk5LTg0MTgtODY2MDAwNTMwZjBjXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Aug-02", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Kid Stays in the Picture", 0, 0, "movie", 0, 0, 0, "Robert Evans (book), Brett Morgen (screen adaptation)", 0, "data/Movie_Poster_Dataset/2002/tt0303353.jpg", "tt0303353", "7.4", "5,915" },
                    { 174, 0, 0, "D. David Morin, Gavin MacLeod, Hal Linden, Jennifer O'Neill", 0, 0, "N/A", 0, "1,283,925", 0, "USA", 0, "Rich Christiano", 0, 1, 0, 0, 1, "Drama, Fantasy, Sci-Fi", 0, 0, "English", 0, "26", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BODI2ZjVlMGQtMWE5ZS00MjJiLWIyMWYtMGU5NmIxNDc0OTMyXkEyXkFqcGdeQXVyMTQ3Njg3MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Oct-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Time Changer", 0, 0, "movie", 0, 0, 0, "Rich Christiano", 0, "data/Movie_Poster_Dataset/2002/tt0295725.jpg", "tt0295725", "5.6", "1,696" },
                    { 175, 0, 0, "Campbell Scott, Jesse Eisenberg, Isabella Rossellini, Elizabeth Berkley", 0, 0, "12 wins & 14 nominations.", 0, "1,260,761", 1, "USA", 0, "Dylan Kidd", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, German", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzJjMTYyMjQtZDI0My00ZjE2LTkyNGYtOTllNGQxNDMyZjE0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Nov-02", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Roger Dodger", 0, 0, "movie", 0, 0, 0, "Dylan Kidd", 0, "data/Movie_Poster_Dataset/2002/tt0299117.jpg", "tt0299117", "7", "14,976" },
                    { 176, 0, 0, "Will Swenson, Connie Young, Daryn Tufts, Kirby Heyborne", 0, 0, "N/A", 0, "1,250,798", 1, "USA", 0, "Kurt Hale", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZjRlNDUxZjAtOGQ4OC00OTNlLTgxNmQtYTBmMDgwZmNmNjkxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "30-Jan-02", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Singles Ward", 0, 0, "movie", 0, 0, 0, "Kurt Hale, John E. Moyer", 0, "data/Movie_Poster_Dataset/2002/tt0306069.jpg", "tt0306069", "6.5", "1,068" },
                    { 177, 0, 1, "Christian Bale, Dominic Purcell, Sean Bean, Christian Kahrmann", 0, 0, "2 nominations.", 0, "104,843", 0, "USA", 0, "Kurt Wimmer", 0, 1, 0, 0, 0, "Action, Drama, Sci-Fi", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDBjZTM4ZmEtOTA5ZC00NTQzLTkyNzYtMmUxNGU2YjI5YjU5L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Dec-02", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Equilibrium", 0, 0, "movie", 0, 0, 0, "Kurt Wimmer", 0, "data/Movie_Poster_Dataset/2002/tt0238380.jpg", "tt0238380", "7.5", "254,898" },
                    { 178, 0, 0, "Steve Coogan, John Thomson, Paul Popplewell, Lennie James", 0, 0, "1 win & 13 nominations.", 1, "1,130,379", 1, "UK", 0, "Michael Winterbottom", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English", 0, "85", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjRmODkzNDItMTNhNi00YjJlLTg0ZjAtODlhZTM0YzgzYThlXkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Sep-02", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "24 Hour Party People", 0, 0, "movie", 0, 0, 0, "Frank Cottrell Boyce (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0274309.jpg", "tt0274309", "7.4", "26,360" },
                    { 179, 0, 0, "Kate Bosworth, Matthew Davis, Michelle Rodriguez, Sanoe Lake", 0, 0, "1 win & 7 nominations.", 0, "502,907", 0, "USA, Germany", 0, "John Stockwell", 0, 1, 0, 0, 0, "Drama, Romance, Sport", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDgwODNmMGItMDcwYi00OWZjLTgyZjAtMGYwMmI4N2Q0NmJmXkEyXkFqcGdeQXVyNzY1MTU0Njk@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Aug-02", "TRUE", 1, "104 min", 0, 0, 1, 0, 0, 0, 0, 0, "Blue Crush", 0, 0, "movie", 0, 0, 0, "Susan Orlean (magazine article \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0300532.jpg", "tt0300532", "5.6", "25,653" },
                    { 180, 0, 1, "Amitabh Bachchan, Sanjay Dutt, Sunil Shetty, Mahesh Manjrekar", 0, 0, "3 wins & 7 nominations.", 0, "1,002,066", 0, "India", 1, "Sanjay Gupta", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "Hindi, English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGIyMWRlYTctMWNlMi00ZGIzLThjOTgtZjQzZjRjNmRhMDdlXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Dec-02", "TRUE", 0, "150 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kaante", 0, 0, "movie", 0, 0, 0, "Sanjay Gupta, Vinay, Yash, Milap Zaveri (dialogue)", 0, "data/Movie_Poster_Dataset/2002/tt0294662.jpg", "tt0294662", "6.5", "3,427" },
                    { 181, 0, 0, "Margaret Cho", 0, 0, "N/A", 0, "1,031,495", 1, "USA", 0, "Lorene Machado", 1, 0, 0, 0, 0, "Documentary, Comedy", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjk3YjJmYTctMTAzZC00MzE4LWFlZGMtNDM5OTMyMDEzZWIxXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Jun-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Notorious C.H.O.", 0, 0, "movie", 0, 0, 0, "Margaret Cho", 0, "data/Movie_Poster_Dataset/2002/tt0300274.jpg", "tt0300274", "7", "905" },
                    { 182, 0, 0, "Polly Walker, Luc Picard, Isabelle Blais, Louis Ferreira", 0, 0, "3 wins & 5 nominations.", 0, "null", 0, "Canada, UK", 0, "Mario Azzopardi", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "French, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGZiM2IwODktNTdiMC00MGU1LWEyZTYtOTk4NTkwYmJkNmI1L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Apr-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 1, "Savage Messiah", 0, 0, "movie", 0, 0, 0, "Sharon Riis (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0303010.jpg", "tt0303010", "6.5", "836" },
                    { 183, 0, 0, "Michael Jai White, Monica Calhoun, Kristoff St. John, Joey Lawrence", 0, 0, "1 win & 1 nomination.", 0, "44,792", 0, "USA", 0, "Rob Hardy", 0, 0, 0, 0, 0, "Thriller", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2IyNTE4YzUtZWU0Mi00MGIwLTgyMmQtMzQ4YzQxYWNlYWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Sep-02", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 1, "Pandora's Box", 0, 0, "movie", 0, 0, 0, "Gregory Ramon Anderson (screenplay), Gregory Ramon Anderson (story), Rob Hardy (screenplay), William Packer (story)", 0, "data/Movie_Poster_Dataset/2002/tt0285869.jpg", "tt0285869", "5", "545" },
                    { 184, 0, 0, "Jeremy Hoop, Randy King, Heather Beers, Lindsay Killian", 0, 0, "N/A", 0, "813,685", 1, "USA", 0, "Adam Thomas Anderegg", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNzA2NmYxMWUtNzBlMC00MWM2LTkwNmQtYTFlZjQwODNhOWE0XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Sep-02", "TRUE", 1, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Charly", 0, 0, "movie", 0, 0, 0, "Jack Weyland (novel), Janine Whetten Gilbert (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0330136.jpg", "tt0330136", "7.2", "616" },
                    { 185, 0, 0, "Kyra Sedgwick, Parker Posey, Fairuza Balk, John Ventimiglia", 0, 0, "6 wins & 5 nominations.", 0, "765,540", 0, "USA", 0, "Rebecca Miller", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmVmYzcwNzMtMWM1NS00MWIyLThlMDEtYzUwZDgzODE1NmE2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Dec-02", "TRUE", 1, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Personal Velocity: Three Portraits", 0, 0, "movie", 0, 0, 0, "Rebecca Miller (book), Rebecca Miller", 0, "data/Movie_Poster_Dataset/2002/tt0295238.jpg", "tt0295238", "6.6", "3,130" },
                    { 186, 0, 0, "Cate Blanchett, Giovanni Ribisi, Remo Girone, Stefania Rocca", 0, 0, "6 wins & 7 nominations.", 0, "774,317", 0, "Germany, Italy, USA, France, UK", 1, "Tom Tykwer", 0, 1, 0, 0, 0, "Crime, Drama, Romance", 0, 0, "Italian, English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZThiZjAzZjgtNDU3MC00YThhLThjYWUtZGRkYjc2ZWZlOTVjXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Feb-02", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Heaven", 0, 0, "movie", 0, 0, 0, "Krzysztof Kieslowski (trilogy \\\\", 0, "data/Movie_Poster_Dataset/2002/tt0246677.jpg", "tt0246677", "7.1", "20,137" },
                    { 187, 0, 0, "James Nesbitt, Allan Gildea, Gerard Crossan, Mary Moulds", 0, 0, "19 wins & 21 nominations.", 0, "768,045", 0, "UK, Ireland", 0, "Paul Greengrass", 0, 1, 0, 0, 0, "Drama, History, War", 1, 0, "English", 0, "90", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDc2ODQ5NTE2MV5BMl5BanBnXkFtZTcwODExMjUyNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Apr-02", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bloody Sunday", 0, 0, "movie", 0, 1, 0, "Paul Greengrass", 0, "data/Movie_Poster_Dataset/2002/tt0280491.jpg", "tt0280491", "7.7", "19,286" },
                    { 188, 0, 0, "Val Kilmer, Vincent D'Onofrio, Adam Goldberg, Luis Guzmán", 0, 0, "1 win.", 0, "334,276", 0, "USA", 1, "D.J. Caruso", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "41", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzAyOGIxYjAtMGY2NC00ZTgyLWIwMWEtYzY0OWQ4NDFjOTc5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-May-02", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Salton Sea", 0, 0, "movie", 0, 0, 0, "Tony Gayton", 0, "data/Movie_Poster_Dataset/2002/tt0235737.jpg", "tt0235737", "7.2", "26,374" },
                    { 189, 0, 0, "Irene Eber, I. Betty Grebenschikoff, Harold Janklowicz, Alfred Kohn", 0, 0, "2 wins.", 0, "711,598", 0, "USA", 0, "Dana Janklowicz-Mann, Amir Mann", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, German, Mandarin", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjJhNTBmNTgtMDViOC00NDY2LWE4N2ItMDJiM2ZiYmQzYzliXkEyXkFqcGdeQXVyMzg1ODEwNQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "28-Feb-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shanghai Ghetto", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0318068.jpg", "tt0318068", "7.1", "184" },
                    { 190, 0, 0, "Matthew Davis, Bruce Greenwood, Holt McCallany, Dexter Fletcher", 0, 0, "2 nominations.", 0, "192,654", 0, "USA", 0, "David Twohy", 0, 0, 0, 0, 0, "Horror, Mystery, Thriller", 0, 1, "English", 0, "55", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2I1ZWU4YjMtYzU0My00YmMzLWFmNTAtZDJhZGYwMmI3YWQ5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Oct-02", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 1, "Below", 0, 0, "movie", 0, 0, 0, "Lucas Sussman, Darren Aronofsky, David Twohy", 0, "data/Movie_Poster_Dataset/2002/tt0276816.jpg", "tt0276816", "6.2", "17,459" },
                    { 191, 0, 0, "Bruce Greenwood, Madonna, Elizabeth Banks, Michael Beattie", 0, 0, "5 wins & 5 nominations.", 0, "598,645", 1, "UK, Italy", 0, "Guy Ritchie", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Greek, Italian", 0, "18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjZmZGRiMDgtNDkwNi00OTZhLWFhZmMtYTdkYjgyNThhOWY3XkEyXkFqcGdeQXVyMTA1NTM1NDI2._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Oct-02", "TRUE", 1, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Swept Away", 0, 0, "movie", 0, 0, 0, "Guy Ritchie (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0291502.jpg", "tt0291502", "3.6", "13,001" },
                    { 193, 0, 0, "John Cusack, Noah Taylor, Leelee Sobieski, Molly Parker", 0, 0, "2 wins & 5 nominations.", 0, "527,019", 0, "Hungary, Canada, UK", 0, "Menno Meyjes", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWIwODIxYWItZDI4MS00YzhhLWE3MmYtMzlhZDIwOTMzZmE5L2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Jun-03", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Max", 0, 0, "movie", 0, 1, 0, "Menno Meyjes", 0, "data/Movie_Poster_Dataset/2002/tt0290210.jpg", "tt0290210", "6.6", "6,218" },
                    { 194, 0, 0, "Brian Cox, Henry Kissinger, Anna Chennault, Amy Goodman", 0, 0, "1 win & 1 nomination.", 0, "515,678", 0, "USA, UK, Denmark, France, Canada, Australia", 0, "Eugene Jarecki", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWQ4ZTRiODktNjAzZC00Nzg1LTk1YWQtNDFmNDI0NmZiNGIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-May-03", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Trials of Henry Kissinger", 0, 0, "movie", 0, 0, 0, "Alex Gibney, Christopher Hitchens (book)", 0, "data/Movie_Poster_Dataset/2002/tt0326306.jpg", "tt0326306", "7.7", "1,672" },
                    { 195, 0, 0, "Shirley Jones, Cloris Leachman, Louise Fletcher, Seymour Cassel", 0, 0, "4 wins.", 0, "505,675", 1, "USA", 0, "Gabrielle Burton, Maria Burton", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjEzMzA4NDE2OF5BMl5BanBnXkFtZTcwNTc5MDI2NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "14-Sep-02", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Manna from Heaven", 0, 0, "movie", 0, 0, 0, "Gabrielle B. Burton", 0, "data/Movie_Poster_Dataset/2002/tt0248169.jpg", "tt0248169", "5.9", "408" },
                    { 197, 0, 0, "Jeff Tweedy, John Stirratt, Leroy Bach, Glenn Kotche", 0, 0, "N/A", 0, "445,521", 0, "USA", 0, "Sam Jones", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "66", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY2MTAzODI5NV5BMl5BanBnXkFtZTgwMjM4NzQ0MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "21-Jun-02", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "I Am Trying to Break Your Heart", 0, 0, "movie", 1, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0327920.jpg", "tt0327920", "7.6", "1,720" },
                    { 198, 0, 0, "Eul-boon Kim, Seung-ho Yoo, Hyo-hee Dong, Kyung-hyun Min", 0, 0, "8 wins & 1 nomination.", 0, "444,931", 0, "South Korea", 0, "Jeong-hyang Lee", 0, 1, 0, 0, 0, "Drama", 0, 0, "Korean", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOTJlZWMxYzEtMjlkMS00ODE0LThlM2ItMDI3NGQ2YjhmMzkxXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "5-Apr-02", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Way Home", 0, 0, "movie", 0, 0, 0, "Jeong-hyang Lee", 0, "data/Movie_Poster_Dataset/2002/tt0312841.jpg", "tt0312841", "7.9", "3,764" },
                    { 200, 0, 0, "Dina Meyer, Michele Hicks, Dylan Walsh, Craig Sheffer", 0, 0, "N/A", 0, "null", 0, "Canada", 0, "Fiona Mackenzie", 0, 0, 0, 0, 0, "Thriller", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTIwNDcyMjktMTczMy00NDM5LTlhNDEtMmE3NGVjOTM2YjQ3XkEyXkFqcGdeQXVyNjc0MzMzNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Feb-03", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Deadly Little Secrets", 0, 0, "movie", 0, 0, 0, "Tim Redman (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0253028.jpg", "tt0253028", "4.4", "166" },
                    { 202, 0, 0, "William H. Macy, Isaiah Washington, Sam Rockwell, Michael Jeter", 0, 0, "1 nomination.", 0, "null", 1, "USA, Germany", 1, "Anthony Russo, Joe Russo", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjEyOTE4MzMtNmMzMy00Mzc3LWJlOTQtOGJiNDE0ZmJiOTU4L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Oct-02", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Welcome to Collinwood", 0, 0, "movie", 0, 0, 0, "Anthony Russo (screenplay), Joe Russo (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0271259.jpg", "tt0271259", "6.4", "12,289" },
                    { 203, 0, 0, "Vivek Oberoi, Rani Mukerji, Tanuja, Satish Shah", 0, 0, "13 wins & 6 nominations.", 0, "null", 0, "India", 0, "Shaad Ali", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWFhOGU5NDctY2Q3YS00Y2VlLWI1NzEtZmIwY2ZiZjY4OTA2XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Dec-02", "TRUE", 1, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "Saathiya", 0, 0, "movie", 0, 0, 0, "Mani Ratnam (story), Gulzar (dialogue)", 0, "data/Movie_Poster_Dataset/2002/tt0330843.jpg", "tt0330843", "7", "4,638" },
                    { 204, 0, 0, "Christina Ricci, Hank Harris, Brenda Blethyn, Dominique Swain", 0, 0, "3 nominations.", 0, "305,690", 1, "USA", 0, "Anthony Abrams, Adam Larson Broder", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjgwNjkwOWYtYmM3My00NzI1LTk5OGItYWY0OTMyZTY4OTg2XkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Mar-04", "TRUE", 1, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pumpkin", 0, 0, "movie", 0, 0, 0, "Adam Larson Broder", 0, "data/Movie_Poster_Dataset/2002/tt0265591.jpg", "tt0265591", "6.3", "7,394" },
                    { 206, 0, 0, "Noam Chomsky", 0, 0, "N/A", 0, "288,372", 0, "USA, Japan", 0, "John Junkerman", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGI1MTI1YTQtY2QwYi00YzUzLTg3NWYtNzExZDlhOTZmZWU0XkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "22-Nov-02", "TRUE", 0, "74 min", 0, 0, 0, 0, 0, 0, 0, 0, "Power and Terror: Noam Chomsky in Our Times", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0338357.jpg", "tt0338357", "7", "517" },
                    { 209, 0, 0, "Samantha Morton, Kathleen McDermott, Paul Popplewell, Ruby Milton", 0, 0, "10 wins & 16 nominations.", 0, "267,194", 0, "UK, Canada", 0, "Lynne Ramsay", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Spanish", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGRkOGMxYTUtZTBhYS00NzI3LWEzMDQtOWRhMmNjNjJjMzM4XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Nov-02", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Morvern Callar", 0, 0, "movie", 0, 0, 0, "Liana Dognini, Lynne Ramsay, Alan Warner (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0300214.jpg", "tt0300214", "6.7", "6,807" },
                    { 210, 0, 0, "Natasha Richardson, Holmes Osborne, Billy Bob Thornton, Patrick Swayze", 0, 0, "N/A", 0, "261,603", 1, "USA", 0, "Jordan Brady", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDk0YzAwYjktMWFiZi00Y2FmLWJmMmMtMzUyZDZmMmU5MjkzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Dec-02", "TRUE", 1, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Waking Up in Reno", 0, 0, "movie", 0, 0, 0, "Brent Briscoe, Mark Fauser", 0, "data/Movie_Poster_Dataset/2002/tt0219400.jpg", "tt0219400", "5.5", "4,746" },
                    { 211, 0, 0, "N/A", 0, 0, "N/A", 0, "247,740", 0, "USA", 0, "Harry Gantz, Joe Gantz", 1, 1, 0, 0, 0, "Documentary, Drama", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDJhYTk2MTctZmVmOS00OTViLTgxNjQtMzQxOTRiMDdmNGRjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "22-Feb-02", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sex with Strangers", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0304692.jpg", "tt0304692", "4.7", "274" },
                    { 212, 0, 0, "Eric Schweig, Graham Greene, Gary Farmer, Noah Watts", 0, 0, "2 wins & 3 nominations.", 0, "238,987", 0, "USA", 1, "Chris Eyre", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGI3YWFmNDQtNjc0Ny00ZDBjLThlNjYtZTc1ZTk5MzU2YTVjXkEyXkFqcGdeQXVyNzA4ODc3ODU@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Jan-02", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Skins", 0, 0, "movie", 0, 0, 0, "Adrian C. Louis (novel), Jennifer D. Lyne", 0, "data/Movie_Poster_Dataset/2002/tt0284494.jpg", "tt0284494", "7.3", "1,146" },
                    { 214, 0, 1, "Olivier Gruner, Simon Kim, James Kim, Bryan Genesse", 0, 0, "N/A", 0, "null", 0, "Canada", 0, "Jalal Merhi", 0, 1, 0, 0, 0, "Action, Drama, Sport", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA1NTEwMDMxMF5BMl5BanBnXkFtZTgwODkzMzI0MjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-May-02", "TRUE", 0, "91 min", 0, 0, 1, 0, 0, 0, 0, 0, "The Circuit", 0, 0, "movie", 0, 0, 0, "Glen G. Doyle", 0, "data/Movie_Poster_Dataset/2002/tt0309452.jpg", "tt0309452", "3.8", "248" },
                    { 215, 0, 0, "Matt Czuchry, Ben Savage, Jeffrey DeMunn, Kelly Rutherford", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Robert J. Emery", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzc5MTU4N2EtYTkyMi00NjdhLTg3NWEtMTY4OTEyMzJhZTAzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "N/A", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Swimming Upstream", 0, 0, "movie", 0, 0, 0, "Robert J. Emery, Don Robertson (novel)", 0, "data/Movie_Poster_Dataset/2002/tt0259017.jpg", "tt0259017", "6.6", "163" },
                    { 216, 0, 0, "Larry Brinkin, Peggy Cass, Pristine Condition, Jackie Curtis", 0, 0, "4 wins & 7 nominations.", 0, "220,077", 0, "USA", 0, "Bill Weber, David Weissman", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE4NzgzNzEwMl5BMl5BanBnXkFtZTgwMTMzMDE0NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Jan-02", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Cockettes", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0303321.jpg", "tt0303321", "7.4", "455" },
                    { 217, 0, 0, "Philip Seymour Hoffman, J.D. Walsh, Jimmy Raskin, Kathy Bates", 0, 0, "2 wins & 3 nominations.", 0, "211,724", 1, "France, Germany, USA", 0, "Todd Louiso", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGQzY2Y0MTgtMDA4OC00NjM3LWI0ZGQtNTJlM2UxZDQxZjI0XkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Jan-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love Liza", 0, 0, "movie", 0, 0, 0, "Gordy Hoffman (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0282698.jpg", "tt0282698", "7", "6,188" },
                    { 218, 0, 0, "Alison Garland, Jean Ainslie, Timothy Spall, Badi Uzzaman", 0, 0, "3 wins & 13 nominations.", 0, "null", 0, "UK, France", 0, "Mike Leigh", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Arabic, French", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGE1MDg5M2MtNTkyZS00MTY5LTg1YzUtZTlhZmM1Y2EwNmFmXkEyXkFqcGdeQXVyNjA3OTI0MDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Oct-02", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "All or Nothing", 0, 0, "movie", 0, 0, 0, "Mike Leigh", 0, "data/Movie_Poster_Dataset/2002/tt0286261.jpg", "tt0286261", "7.6", "8,017" },
                    { 219, 0, 0, "Brad Hunt, Robin Tunney, Liz Phair, Lindsay Crouse", 0, 0, "2 nominations.", 0, "160,268", 1, "USA", 0, "Finn Taylor", 0, 1, 0, 0, 0, "Comedy, Drama, Thriller", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzE2MjEwMTQtOTQ2Mi00ZWExLTkyMjUtNmJjMjBlYWFjZDdlXkEyXkFqcGdeQXVyMTI3ODAyMzE2._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Jan-03", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 1, "Cherish", 0, 0, "movie", 0, 0, 0, "Finn Taylor", 0, "data/Movie_Poster_Dataset/2002/tt0298798.jpg", "tt0298798", "6.8", "2,314" },
                    { 220, 0, 0, "Evan Adams, Michelle St. John, Gene Tagaban, Swil Kanim", 0, 0, "7 wins.", 0, "174,682", 0, "USA", 0, "Sherman Alexie", 0, 1, 0, 0, 0, "Drama, Music", 0, 0, "English", 0, "49", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYzOTE2NjkxN15BMl5BanBnXkFtZTgwMDgzMTg0MzE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Jan-02", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Business of Fancydancing", 0, 0, "movie", 0, 0, 0, "Sherman Alexie", 0, "data/Movie_Poster_Dataset/2002/tt0303313.jpg", "tt0303313", "6.9", "454" },
                    { 221, 0, 0, "Jacques Derrida, Marguerite Derrida, René Major, Chantal Major", 0, 0, "1 win & 1 nomination.", 0, "156,450", 0, "USA", 0, "Kirby Dick, Amy Ziering", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, French", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGNhYjUwNmYtNDQxNi00NDdmLTljMDAtZWM1NDQyZTk3ZDYwXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "31-Jan-03", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Derrida", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0303326.jpg", "tt0303326", "6.5", "666" },
                    { 222, 0, 0, "Jeremy Renner, Bruce Davison, Artel Great, Matt Newton", 0, 0, "3 nominations.", 1, "null", 0, "USA", 1, "David Jacobson", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzM5NjUxOTEyMl5BMl5BanBnXkFtZTgwNjEyMDM0MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Mar-03", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dahmer", 0, 0, "movie", 0, 0, 0, "David Jacobson", 0, "data/Movie_Poster_Dataset/2002/tt0285728.jpg", "tt0285728", "5.6", "7,353" },
                    { 224, 0, 0, "Manoj Bajpayee, Vivek Oberoi, Antara Mali, Sayaji Shinde", 0, 0, "1 win & 2 nominations.", 0, "73,636", 0, "India", 0, "Rajat Mukherjee", 0, 0, 0, 0, 0, "Thriller", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk0MDQ3MzAzOV5BMl5BanBnXkFtZTgwNzU1NzE3MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Sep-02", "TRUE", 0, "134 min", 0, 0, 0, 0, 0, 0, 0, 1, "Road", 0, 0, "movie", 0, 0, 0, "Rajnish Thakur", 0, "data/Movie_Poster_Dataset/2002/tt0315632.jpg", "tt0315632", "5.6", "915" },
                    { 225, 0, 0, "Aidan Quinn, Bonnie Hunt, Kevin Pollak, Eddie Kaye Thomas", 0, 0, "N/A", 0, "18,288", 0, "USA", 0, "Pete Jones", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYzQxNDZhNDUtNDUwOC00NjQyLTg2OWUtZWVlYThjYjYyMTc2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Jul-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Stolen Summer", 0, 0, "movie", 0, 0, 0, "Pete Jones", 0, "data/Movie_Poster_Dataset/2002/tt0286162.jpg", "tt0286162", "6.5", "2,378" },
                    { 226, 0, 0, "Marlon Brando, Elton John, Julia Louis-Dreyfus, Madonna", 0, 0, "N/A", 0, "132,026", 0, "USA", 0, "Godfrey Reggio", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "59", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjQ1NjM3MTUxNV5BMl5BanBnXkFtZTgwMDc5MTY5OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Jan-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Naqoyqatsi", 0, 0, "movie", 0, 0, 0, "Godfrey Reggio", 0, "data/Movie_Poster_Dataset/2002/tt0145937.jpg", "tt0145937", "6.7", "4,024" },
                    { 227, 0, 0, "Mariam Parris, David Ackert, Shaun Toub, Shohreh Aghdashloo", 0, 0, "2 wins.", 0, "104,209", 0, "USA", 0, "Ramin Serry", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTgxMDQwMDk0OF5BMl5BanBnXkFtZTgwNjU5OTg2NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "22-Feb-02", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Maryam", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0184719.jpg", "tt0184719", "7", "253" },
                    { 228, 0, 0, "Víctor Huggo Martin, Gael García Bernal, Patricia Velasquez, Cecilia Suárez", 0, 0, "3 nominations.", 1, "null", 0, "USA", 0, "David Attwood", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQzMTEyODY2Ml5BMl5BanBnXkFtZTgwMjA0MDUyMjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Jan-02", "TRUE", 0, "206 min", 0, 0, 0, 0, 0, 0, 0, 0, "Fidel", 0, 0, "movie", 0, 0, 0, "Stephen Tolkin (teleplay)", 0, "data/Movie_Poster_Dataset/2002/tt0258351.jpg", "tt0258351", "6.5", "1,116" },
                    { 229, 0, 0, "Anil Kapoor, Karisma Kapoor, Shilpa Shetty, Kaivalya Chheda", 0, 0, "2 nominations.", 0, "null", 0, "India", 0, "Indra Kumar", 0, 0, 0, 1, 0, "Family", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjExMTEzODkyN15BMl5BanBnXkFtZTcwNTU4NTc4OQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Dec-02", "TRUE", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, "Rishtey", 0, 0, "movie", 0, 0, 0, "Rajeev Kaul (screenplay), Rajeev Kaul (story), Tanveer Khan (dialogue), Praful Parekh (screenplay), Praful Parekh (story)", 0, "data/Movie_Poster_Dataset/2002/tt0341549.jpg", "tt0341549", "4.4", "594" },
                    { 230, 0, 0, "Terry O'Quinn, Lacey Chabert, Nick Cornish, Kirk B.R. Woller", 0, 0, "N/A", 0, "null", 0, "USA", 0, "James Anderson", 0, 1, 0, 1, 0, "Drama, Family, Sport", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOWEwODJmZDItYTNmZC00OGM4LThlNDktOTQzZjIzMGQxODA4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Jan-02", "TRUE", 0, "120 min", 0, 0, 1, 0, 0, 0, 0, 0, "Hometown Legend", 0, 0, "movie", 0, 0, 0, "Shawn Hoffman, Michael Patwin (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0260695.jpg", "tt0260695", "5.7", "637" },
                    { 232, 0, 0, "Jaelan Petrie, Stephanie Albach, Chris Kendrick, Shannon Skinner", 0, 0, "N/A", 0, "98,666", 0, "USA", 0, "Kels Goodman", 0, 0, 0, 0, 0, "History", 1, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BM2UwMDVmMDItM2I2Yi00NGZmLTk4ZTUtY2JjNTQ3OGQ5ZjM2XkEyXkFqcGdeQXVyMTA1OTYzOTUx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "11-Oct-02", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Handcart", 0, 0, "movie", 0, 0, 0, "Mark Bowers", 0, "data/Movie_Poster_Dataset/2002/tt0337632.jpg", "tt0337632", "4.5", "51" },
                    { 233, 0, 0, "The Notorious B.I.G., Tupac Shakur, Nick Broomfield, Russell Poole", 0, 0, "1 nomination.", 1, "null", 0, "UK", 1, "Nick Broomfield", 1, 0, 0, 0, 0, "Documentary, Biography, Crime", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-May-02", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Biggie and Tupac", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0303356.jpg", "tt0303356", "6.9", "3,271" },
                    { 235, 0, 0, "John Bell, David Blackmon, Eric Carter, Vic Chesnutt", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Christopher Hanson", 0, 0, 0, 0, 0, "Music, War", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2MDMwNjEwNV5BMl5BanBnXkFtZTgwOTkxMzI0MzE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Widespread Panic: The Earth Will Swallow You", 0, 0, "movie", 0, 1, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt1736672.jpg", "tt1736672", "N/A", "N/A" },
                    { 237, 0, 0, "Ben Kingsley, Mercedes Ruehl, Matt Weinberg, Jason Fuchs", 0, 0, "2 wins.", 0, "null", 0, "USA", 0, "William Sachs", 0, 0, 0, 1, 0, "Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTQ1NDI0NzkyOF5BMl5BanBnXkFtZTcwNzAyNzE2Nw@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "24-Apr-04", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spooky House", 0, 0, "movie", 0, 0, 0, "Margaret Sachs, William Sachs", 0, "data/Movie_Poster_Dataset/2002/tt0160905.jpg", "tt0160905", "5.4", "318" },
                    { 238, 0, 0, "Marley Shelton, Ron Eldard, Patrick Breen, Sanjiv Jhaveri", 0, 0, "1 win & 2 nominations.", 0, "63,797", 1, "USA", 0, "Fisher Stevens", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGFmMjM5OWMtZTRiNC00ODhlLThlYTItYTcyZDMyYmMyYjFjXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-May-03", "TRUE", 1, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Just a Kiss", 0, 0, "movie", 0, 0, 0, "Patrick Breen (play), Patrick Breen (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0245479.jpg", "tt0245479", "5.2", "1,239" },
                    { 239, 0, 0, "Eddie Malavarca, Maurizio Nichetti, Violante Placido, Nathaniel Marston", 0, 0, "N/A", 0, "null", 1, "USA, Italy", 0, "Frank Ciota", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg0NTIzMjQ1NV5BMl5BanBnXkFtZTcwNDc3MzM5OQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Sep-02", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ciao America", 0, 0, "movie", 0, 0, 0, "Joseph A. Ciota", 0, "data/Movie_Poster_Dataset/2002/tt0275263.jpg", "tt0275263", "7.2", "74" },
                    { 240, 0, 0, "Jackie Shroff, Kumar Iyengar, Raveena Tandon, Nagarjuna Akkineni", 0, 0, "1 nomination.", 0, "25,049", 0, "India", 0, "Arjun Sajnani", 0, 1, 0, 0, 1, "Drama, Fantasy", 0, 0, "Hindi", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2EwM2I5OWMtMGQyMi00Zjg1LWJkNTctZTdjYTA4OGUwZjMyXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Aug-02", "TRUE", 0, "126 min", 0, 0, 0, 0, 0, 0, 0, 0, "Agnivarsha: The Fire and the Rain", 0, 0, "movie", 0, 0, 0, "Girish Karnad (play), Anil Mehta (screenplay), Arjun Sajnani (screenplay), Jayshree T. (screenplay), Atul Tiwari (dialogue)", 0, "data/Movie_Poster_Dataset/2002/tt0326722.jpg", "tt0326722", "4.9", "294" },
                    { 241, 0, 0, "Raymond J. Barry, Dylan Haggerty, Renee Faia, Kelsey Kemper", 0, 0, "2 wins & 3 nominations.", 0, "47,329", 0, "USA", 0, "Neil Burger", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTcwMzdiMWItMjZlOS00MzAzLTg5OTItNTA4OGYyMjBhMmRiXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-May-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Interview with the Assassin", 0, 0, "movie", 0, 0, 0, "Neil Burger", 0, "data/Movie_Poster_Dataset/2002/tt0308411.jpg", "tt0308411", "6.6", "1,641" },
                    { 242, 0, 0, "Mia Kirshner, Meredith Monroe, Dominique Swain, Scott Bairstow", 0, 0, "N/A", 0, "28,658", 0, "USA", 0, "Zoe Clarke-Williams", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English", 0, "13", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5NTk2OTU1Nl5BMl5BanBnXkFtZTcwMDc3NjAwMg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Apr-02", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 1, "New Best Friend", 0, 0, "movie", 0, 0, 0, "Victoria Strouse", 0, "data/Movie_Poster_Dataset/2002/tt0191074.jpg", "tt0191074", "5.3", "2,811" },
                    { 243, 0, 0, "Juliet Stevenson, Kevin Bishop, Allan Corduner, Paul Rhys", 0, 0, "3 wins & 1 nomination.", 0, "3,692", 0, "Spain, Germany", 0, "Ventura Pons", 0, 1, 0, 0, 0, "Drama, Music", 0, 0, "English", 0, "46", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGVmMWNiMDktYjQ0Mi00MWIxLTk0N2UtN2ZlYTdkN2IzNDNlXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Feb-02", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Food of Love", 0, 0, "movie", 0, 0, 0, "David Leavitt (novel), Ventura Pons", 0, "data/Movie_Poster_Dataset/2002/tt0309600.jpg", "tt0309600", "6.2", "1,242" },
                    { 244, 0, 0, "James Franco, Brenda Blethyn, Harry Dean Stanton, Mena Suvari", 0, 0, "1 nomination.", 0, "19,782", 0, "USA", 1, "Nicolas Cage", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUzOTcwOTA2NV5BMl5BanBnXkFtZTcwNDczMzczMg@@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Mar-03", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sonny", 0, 0, "movie", 0, 0, 0, "John Carlen", 0, "data/Movie_Poster_Dataset/2002/tt0305973.jpg", "tt0305973", "5.7", "3,464" },
                    { 245, 0, 0, "John Michael Higgins, Ming-Na Wen, Henry Gibson, David Rasche", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Harry Shearer", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzE4NDg5OWMtMzg3NC00ZDRjLTllMDMtZTRjNWZmNjBmMGZlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Mar-02", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "Teddy Bears' Picnic", 0, 0, "movie", 0, 0, 0, "Harry Shearer", 0, "data/Movie_Poster_Dataset/2002/tt0250282.jpg", "tt0250282", "3.3", "356" },
                    { 246, 0, 0, "Jacques Gamblin, Denis Podalydès, Charlotte Kady, Marie Desgranges", 0, 0, "7 wins & 3 nominations.", 1, "26,617", 0, "France, Germany, Spain", 0, "Bertrand Tavernier", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "French", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDgzYjQwMDMtNGUzYi00MTRmLWIyMGMtNjE1OGZkNzY2YWIzL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Jan-02", "TRUE", 0, "170 min", 0, 0, 0, 0, 0, 0, 0, 0, "Safe Conduct", 0, 0, "movie", 0, 0, 0, "Jean Cosmos, Jean-Devaivre (book), Bertrand Tavernier", 0, "data/Movie_Poster_Dataset/2002/tt0269461.jpg", "tt0269461", "7", "1,070" },
                    { 248, 0, 0, "Michael Beach, Ronny Cox, Sinbad, Jane Carr", 0, 0, "1 win & 2 nominations.", 0, "null", 0, "USA", 0, "Eriq La Salle", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA5NDQyMjc2NF5BMl5BanBnXkFtZTcwMjg5ODcyMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Feb-02", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 1, "Crazy as Hell", 0, 0, "movie", 0, 0, 0, "Jeremy Leven (novel), Jeremy Leven (screenplay), Erik Jendresen (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0285487.jpg", "tt0285487", "6", "846" },
                    { 250, 0, 1, "Anthony 'Treach' Criss, Kent King, Charles Guardino, Shireen Crutchfield", 0, 0, "N/A", 0, "16,853", 1, "USA", 1, "Kantz, Ben Ramsey", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAwNDEyODU1MjheQTJeQWpwZ15BbWU2MDc3NDQwNw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Aug-02", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love and a Bullet", 0, 0, "movie", 0, 0, 0, "Ben Ramsey, Kantz", 0, "data/Movie_Poster_Dataset/2002/tt0235553.jpg", "tt0235553", "5.2", "1,124" },
                    { 253, 0, 0, "Martin Donovan, Anthony Arkin, Marla Sucharetza, Mary-Louise Parker", 0, 0, "N/A", 0, "null", 1, "USA", 0, "John Walsh", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Dec-05", "TRUE", 1, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pipe Dream", 0, 0, "movie", 0, 0, 0, "Cynthia Kaplan, John Walsh", 0, "data/Movie_Poster_Dataset/2002/tt0164810.jpg", "tt0164810", "6.2", "883" },
                    { 254, 0, 0, "Karen Alexander, Steve Alexander, Colin Andrews, Bob Bates", 0, 0, "N/A", 0, "null", 0, "USA", 0, "William Gazecki", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2ZmMDMwODgtMzA5MS00MGU0LWEyYTgtYzQ5MmQzMzU2NTVkXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "23-Aug-02", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Crop Circles: Quest for Truth", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0331225.jpg", "tt0331225", "7.1", "202" },
                    { 255, 0, 0, "Neil Patrick Harris, Jessica Capshaw, Howard Hesseman, Jason Carter", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Gil Cates Jr.", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkxNzA1NDQxOV5BMl5BanBnXkFtZTcwNTkyMTIzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Mar-02", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Mesmerist", 0, 0, "movie", 0, 0, 0, "Michael A. Goorjian, Ron Marasco, Edgar Allan Poe (original story)", 0, "data/Movie_Poster_Dataset/2002/tt0272730.jpg", "tt0272730", "5.4", "203" },
                    { 256, 0, 0, "Cynthia Alardo, Phil Alardo, Heather Beberay, Brian Bennett", 0, 0, "2 nominations.", 0, "null", 0, "USA", 0, "Arthur Dong", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGJjYmIzZmQtNWE4Yy00ZGVmLWJkZGEtMzUzNmQ4ZWFlMjRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jan-02", "TRUE", 0, "75 min", 0, 0, 0, 0, 0, 0, 0, 0, "Family Fundamentals", 0, 0, "movie", 0, 0, 0, "Arthur Dong", 0, "data/Movie_Poster_Dataset/2002/tt0303334.jpg", "tt0303334", "7", "88" },
                    { 257, 0, 0, "Vera Farmiga, Domenick Lombardozzi, Jill Hennessy, Malcolm Gets", 0, 0, "2 nominations.", 0, "6,259", 1, "USA", 0, "Peter Mattei", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjAxZTEzNzQtYjdlNy00ZTJmLTkwZDUtOTAwNTM3YjI2MWUyL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Jan-02", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love in the Time of Money", 0, 0, "movie", 0, 0, 0, "Peter Mattei", 0, "data/Movie_Poster_Dataset/2002/tt0292501.jpg", "tt0292501", "5.4", "536" },
                    { 259, 0, 0, "Carrie Brownstein, Kari Fillipi, S. Ann Hall, Vicki Hollenberg", 0, 0, "3 wins.", 0, "null", 1, "USA", 0, "Anne de Marcken, Marilyn Freeman", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ1MjAwNTM5Ml5BMl5BanBnXkFtZTYwNDM0MTc3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "5-Jul-02", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Group", 0, 0, "movie", 0, 0, 0, "Marilyn Freeman, Anne de Marcken (head writer)", 0, "data/Movie_Poster_Dataset/2002/tt0332636.jpg", "tt0332636", "6.4", "59" },
                    { 260, 0, 0, "Eddie Mui, Calvin Jung, Helen Ota, Louise Mita", 0, 0, "N/A", 0, "null", 0, "USA", 1, "Brian T. Maeda", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzQ4MTBlYTQtMzJkYS00OGNjLTk1MWYtNzQ0OTQ0OWEyOWU1XkEyXkFqcGdeQXVyNDgyODgxNjE@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Aug-02", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Buddha Heads", 0, 0, "movie", 0, 0, 0, "Brian T. Maeda", 0, "data/Movie_Poster_Dataset/2002/tt0328913.jpg", "tt0328913", "4.2", "22" },
                    { 261, 0, 0, "Adam Garcia, Rosario Dawson, Jake Busey, Enrico Colantoni", 0, 0, "N/A", 0, "2,535", 1, "USA", 0, "Mick Jackson", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "20", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGViNTg4YTktYTQ2Ni00MTU0LTk2NWUtMTI4OTc1YTM0NzQ2XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Oct-02", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "The First $20 Million Is Always the Hardest", 0, 0, "movie", 0, 0, 0, "Po Bronson (novel), Jon Favreau (screenplay), Gary Tieche (screenplay)", 0, "data/Movie_Poster_Dataset/2002/tt0280674.jpg", "tt0280674", "5.6", "2,759" },
                    { 262, 0, 0, "Wendy Crewson, Barbara Williams, Alison Pill, Rachel McAdams", 0, 0, "1 win & 2 nominations.", 0, "null", 0, "Canada", 0, "Barbara Willis Sweete", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjRjMTYwMTYtMmRkNi00MmVkLWE0MjQtNmM3YjI0NWFhZDNmXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Sep-02", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Perfect Pie", 0, 0, "movie", 0, 0, 0, "Judith Thompson (screenplay), Judith Thompson (play)", 0, "data/Movie_Poster_Dataset/2002/tt0293899.jpg", "tt0293899", "6.3", "201" },
                    { 263, 0, 0, "Jade Henham, Sam Bottoms, Robert Glen Keith, Essence Atkins", 0, 0, "1 win.", 0, "null", 0, "USA", 0, "Jake Torem", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzM3NDFhYTAtYmU5Mi00NGRmLTljYjgtMDkyODQ4MjNkMGY2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "2-Aug-06", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Looking Through Lillian", 0, 0, "movie", 1, 0, 0, "Jade Henham, Jake Torem", 0, "data/Movie_Poster_Dataset/2002/tt0285681.jpg", "tt0285681", "5.8", "256" },
                    { 264, 0, 0, "Brian Burns, Vincent Rubino, Jimmy Cummings, Elijah Wood", 0, 0, "N/A", 0, "2,942", 0, "USA", 1, "Edward Burns", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English, Spanish", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTAzNWZlNmUtZDEzYi00ZjA5LWIwYjEtZGM1NWE1MjE4YWRhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Mar-04", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ash Wednesday", 0, 0, "movie", 0, 0, 0, "Edward Burns", 0, "data/Movie_Poster_Dataset/2002/tt0280438.jpg", "tt0280438", "6", "2,648" },
                    { 265, 0, 0, "Shô Aikawa, Maria Chen, Richard Chen, Jason Chu", 0, 0, "N/A", 0, "null", 1, "Japan", 1, "Takashi Miike", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "Japanese, Cantonese", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "12-Jan-02", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dead or Alive: Final", 0, 0, "movie", 0, 0, 0, "Hitoshi Ishikawa, Yoshinobu Kamo, Ichiro Ryu", 0, "data/Movie_Poster_Dataset/2002/tt0301167.jpg", "tt0301167", "5.9", "1,841" },
                    { 267, 0, 0, "Rodney Dangerfield, Anita De Simone, Annabelle Gurwitch, Charles Fleischer", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Harry Basil", 0, 0, 0, 0, 0, "Comedy, Music, Romance", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjQxMWJhMzMtMzllZi00NzMwLTllYjktNTcwZmU4ZmU3NTA0XkEyXkFqcGdeQXVyMTAzMDM4MjM0._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Dec-04", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "The 4th Tenor", 0, 0, "movie", 0, 0, 0, "Rodney Dangerfield, Harry Basil", 0, "data/Movie_Poster_Dataset/2002/tt0275170.jpg", "tt0275170", "5.2", "267" },
                    { 271, 0, 0, "Larry Pine, Alex Feldman, J.D. Williams, Benjamin Hendrickson", 0, 0, "N/A", 0, "1,583", 0, "USA", 1, "Ian McCrudden", 0, 1, 0, 0, 0, "Crime, Drama, Romance", 0, 0, "English", 0, "22", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY1NTI0ODUyOF5BMl5BanBnXkFtZTgwNTEyNjQ0MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Jul-03", "TRUE", 1, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mr. Smith Gets a Hustler", 0, 0, "movie", 0, 0, 0, "Matthew Swan", 0, "data/Movie_Poster_Dataset/2002/tt0298071.jpg", "tt0298071", "4.9", "191" },
                    { 272, 0, 0, "Rehane Abrahams, Damien Chamley, Ivan D. Lucas, Denise Newman", 0, 0, "N/A", 0, "1,581", 0, "Burkina Faso, France", 0, "Fanta Régina Nacro, Zulfah Otto Sallies, Ingrid Sinclair", 0, 0, 0, 0, 0, "N/A", 0, 0, "N/A", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjJhMThkNTQtNjkxNy00MDdjLTg4MWQtMTI2MmQ3MDVmODUzXkEyXkFqcGdeQXVyMTAwOTA3NzY3._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Jun-02", "TRUE", 0, "78 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mama Africa", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0322650.jpg", "tt0322650", "6.7", "47" },
                    { 274, 0, 0, "Wanda Jean Allen, Jesse Jackson, David Presson", 0, 0, "1 win & 2 nominations.", 0, "1,386", 0, "USA", 0, "Liz Garbus", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDYxNWUzZmYtOGQxMC00MTdkLTkxOTctYzkyOGIwNWQxZjhmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jan-02", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Execution of Wanda Jean", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2002/tt0303282.jpg", "tt0303282", "7.7", "169" },
                    { 275, 0, 0, "Rumi Sakakibara, Masakane Yonekura, Kazuya Takahashi, Megumi Sakakibara", 0, 0, "N/A", 0, "null", 0, "Japan", 0, "Junichi Suzuki", 0, 1, 0, 0, 0, "Drama", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWM4NTFhYjctNzUyNi00NGMwLTk3NTYtMDIyNTZmMzRlYmQyXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "16-Mar-02", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lonely Affair of the Heart", 0, 0, "movie", 0, 0, 0, "Masaru Baba", 0, "data/Movie_Poster_Dataset/2002/tt0335265.jpg", "tt0335265", "4.4", "8" },
                    { 276, 0, 0, "Noel Appleby, Ali Astin, Sean Astin, David Aston", 1, 0, "Won 11 Oscars. Another 170 wins & 112 nominations.", 0, "377,019,252", 0, "USA, New Zealand", 0, "Peter Jackson", 0, 1, 0, 0, 1, "Adventure, Drama, Fantasy", 0, 0, "English, Quenya, Old English, Sindarin", 0, "94", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzIwOTdmNjQtOWQ1ZS00ZWQ4LWIxYTMtOWFkM2NjODJiMGY4L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Dec-03", "TRUE", 0, "201 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lord of the Rings: The Return of the King", 0, 0, "movie", 0, 0, 0, "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0167260.jpg", "tt0167260", "8.9", "1,173,526" },
                    { 277, 0, 0, "Albert Brooks, Ellen DeGeneres, Alexander Gould, Willem Dafoe", 1, 1, "Won 1 Oscar. Another 44 wins & 56 nominations.", 0, "380,838,870", 1, "USA", 0, "Andrew Stanton, Lee Unkrich", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "90", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDIzODcyY2EtMmY2MC00ZWVlLTgwMzAtMjQwOWUyNmJjNTYyXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "30-May-03", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Finding Nemo", 0, 0, "movie", 0, 0, 0, "Andrew Stanton (original story by), Andrew Stanton (screenplay), Bob Peterson (screenplay), David Reynolds (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0266543.jpg", "tt0266543", "8.1", "653,218" },
                    { 278, 0, 1, "Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley", 1, 0, "Nominated for 5 Oscars. Another 31 wins & 86 nominations.", 0, "305,388,685", 0, "USA", 0, "Gore Verbinski", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmExZTZhN2QtMzg5Mi00Y2M5LTlmMWYtNTUzMzUwMGM2OGQ3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Jul-03", "TRUE", 0, "143 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pirates of the Caribbean: The Curse of the Black Pearl", 0, 0, "movie", 0, 0, 0, "Ted Elliott (screen story), Terry Rossio (screen story), Stuart Beattie (screen story), Jay Wolpert (screen story), Ted Elliott (screenplay), Terry Rossio (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0325980.jpg", "tt0325980", "8.1", "785,039" },
                    { 279, 0, 1, "Ray Anthony, Christine Anu, Andy Arness, Alima Ashton-Sheibu", 0, 0, "5 wins & 23 nominations.", 0, "281,492,479", 0, "USA, Australia", 0, "Lana Wachowski, Lilly Wachowski", 0, 0, 0, 0, 0, "Action, Sci-Fi", 0, 0, "English, French", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ0NjUzMDMyOF5BMl5BanBnXkFtZTgwODA1OTU0MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-May-03", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Matrix Reloaded", 0, 0, "movie", 0, 0, 0, "Lilly Wachowski, Lana Wachowski, Lilly Wachowski (characters), Lana Wachowski (characters)", 0, "data/Movie_Poster_Dataset/2003/tt0234215.jpg", "tt0234215", "7.2", "411,966" },
                    { 280, 0, 0, "Jim Carrey, Morgan Freeman, Jennifer Aniston, Philip Baker Hall", 0, 0, "7 wins & 7 nominations.", 0, "3,408,154", 1, "USA", 0, "Tom Shadyac", 0, 1, 0, 0, 1, "Comedy, Drama, Fantasy", 0, 0, "English, Spanish", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjZjODRlMjQtMjJlYy00ZDBjLTkyYTQtZGQxZTk5NzJhYmNmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-May-03", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bruce Almighty", 0, 0, "movie", 0, 0, 0, "Steve Koren (story), Mark O'Keefe (story), Steve Koren (screenplay), Mark O'Keefe (screenplay), Steve Oedekerk (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0315327.jpg", "tt0315327", "6.7", "287,265" },
                    { 281, 0, 0, "Will Ferrell, James Caan, Bob Newhart, Edward Asner", 0, 0, "2 wins & 7 nominations.", 0, "173,381,405", 1, "USA, Germany", 0, "Jon Favreau", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzA5Zjc3ZTMtMmU5YS00YTMwLWI4MWUtYTU0YTVmNjVmODZhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "7-Nov-03", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Elf", 0, 0, "movie", 0, 0, 0, "David Berenbaum", 0, "data/Movie_Poster_Dataset/2003/tt0319343.jpg", "tt0319343", "6.9", "144,715" },
                    { 282, 0, 1, "Arnold Schwarzenegger, Nick Stahl, Claire Danes, Kristanna Loken", 0, 0, "2 wins & 17 nominations.", 0, "150,350,192", 0, "USA, Germany, UK", 0, "Jonathan Mostow", 0, 0, 0, 0, 0, "Action, Sci-Fi", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDJiZDgyZjctYmRjMS00ZjdkLTkwMTEtNGU1NDg3NDQ0Yzk1XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Jul-03", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Terminator 3: Rise of the Machines", 0, 0, "movie", 0, 0, 0, "James Cameron (characters), Gale Anne Hurd (characters), John D. Brancato (story), Michael Ferris (story), Tedi Sarafian (story), John D. Brancato (screenplay), Michael Ferris (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0181852.jpg", "tt0181852", "6.4", "295,666" },
                    { 283, 0, 1, "Mary Alice, Tanveer K. Atwal, Helmut Bakaitis, Kate Beahan", 0, 0, "1 win & 22 nominations.", 0, "139,259,759", 0, "Australia, USA", 0, "Lana Wachowski, Lilly Wachowski", 0, 0, 0, 0, 0, "Action, Sci-Fi", 0, 0, "English, French", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzI4YTVmMWEtMWQ3MS00OGE1LWE5YjMtNjc4NWJmYjRmZTQyXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Nov-03", "TRUE", 0, "129 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Matrix Revolutions", 0, 0, "movie", 0, 0, 0, "Lilly Wachowski, Lana Wachowski, Lilly Wachowski (characters), Lana Wachowski (characters)", 0, "data/Movie_Poster_Dataset/2003/tt0242653.jpg", "tt0242653", "6.7", "356,304" },
                    { 284, 0, 0, "Steve Martin, Bonnie Hunt, Piper Perabo, Tom Welling", 0, 0, "2 wins & 7 nominations.", 0, "138,614,544", 1, "USA", 0, "Shawn Levy", 0, 0, 0, 1, 0, "Comedy, Family", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNDNiOTA5YjktY2Q0Ni00ODgzLWE5MWItNGExOWRlYjY2MjBlXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Dec-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cheaper by the Dozen", 0, 0, "movie", 0, 0, 0, "Frank B. Gilbreth Jr. (novel), Ernestine Gilbreth Carey (novel), Craig Titley (screen story), Sam Harper (screenplay), Joel Cohen (screenplay), Alec Sokolow (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0349205.jpg", "tt0349205", "5.8", "73,019" },
                    { 285, 0, 1, "Martin Lawrence, Will Smith, Jordi Mollà, Gabrielle Union", 0, 0, "5 wins & 12 nominations.", 0, "4,368,957", 1, "USA", 1, "Michael Bay", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, Spanish", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmNjYzRlM2YtZTZjZC00ODVmLTljZWMtODg1YmYyNDBiNzU3XkEyXkFqcGdeQXVyNTkzNDQ4ODc@._V1_UY98_CR3,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jul-03", "TRUE", 0, "147 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bad Boys II", 0, 0, "movie", 0, 0, 0, "George Gallo (characters), Marianne Wibberley (story), Cormac Wibberley (story), Ron Shelton (story), Ron Shelton (screenplay), Jerry Stahl (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0172156.jpg", "tt0172156", "6.6", "173,930" },
                    { 286, 0, 0, "Adam Sandler, Jack Nicholson, Marisa Tomei, Luis Guzmán", 0, 0, "2 wins & 5 nominations.", 0, "1,271,246", 1, "USA", 0, "Peter Segal", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDdiZTAwYzAtMDI3Ni00OTRjLTkzN2UtMGE3MDMyZmU4NTU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Apr-03", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Anger Management", 0, 0, "movie", 0, 0, 0, "David Dorfman", 0, "data/Movie_Poster_Dataset/2003/tt0305224.jpg", "tt0305224", "6.2", "167,376" },
                    { 287, 0, 0, "Steve Martin, Queen Latifah, Eugene Levy, Joan Plowright", 0, 0, "4 wins & 13 nominations.", 0, "884,848", 1, "USA", 0, "Adam Shankman", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTg1MmNiMjItMmY4Yy00ZDQ3LThjMzYtZGQ0ZTQzNTdkMGQ1L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Mar-03", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bringing Down the House", 0, 0, "movie", 0, 0, 0, "Jason Filardi", 0, "data/Movie_Poster_Dataset/2003/tt0305669.jpg", "tt0305669", "5.5", "29,518" },
                    { 288, 0, 1, "Eric Bana, Jennifer Connelly, Sam Elliott, Josh Lucas", 0, 0, "2 wins & 8 nominations.", 0, "132,122,995", 0, "USA", 0, "Ang Lee", 0, 0, 0, 0, 0, "Action, Sci-Fi", 0, 0, "English, Spanish", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGQ5MzljNzYtMDM1My00NmI0LThlYzQtMTg0ZmQ0MTk1YjkxXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Jun-03", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hulk", 0, 0, "movie", 0, 0, 0, "Stan Lee (Marvel comic book character), Jack Kirby (Marvel comic book character), James Schamus (story), John Turman (screenplay), Michael France (screenplay), James Schamus (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0286716.jpg", "tt0286716", "5.7", "205,737" },
                    { 289, 0, 1, "Paul Walker, Tyrese Gibson, Eva Mendes, Cole Hauser", 0, 0, "3 wins & 13 nominations.", 0, "204,052", 0, "USA, Germany", 1, "John Singleton", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, Spanish", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "6-Jun-03", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 1, "2 Fast 2 Furious", 0, 0, "movie", 0, 0, 0, "Gary Scott Thompson (characters), Michael Brandt (story), Derek Haas (story), Gary Scott Thompson (story), Michael Brandt (screenplay), Derek Haas (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0322259.jpg", "tt0322259", "5.8", "183,743" },
                    { 290, 0, 0, "Jack Nicholson, Diane Keaton, Keanu Reeves, Frances McDormand", 0, 0, "Nominated for 1 Oscar. Another 7 wins & 12 nominations.", 0, "4,558,255", 1, "USA", 0, "Nancy Meyers", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, French", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmYyOTgwYWItYmU3Ny00M2E2LTk0NWMtMDVlNmQ0MWZiMTMxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Dec-03", "TRUE", 1, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Something's Gotta Give", 0, 0, "movie", 0, 0, 0, "Nancy Meyers", 0, "data/Movie_Poster_Dataset/2003/tt0337741.jpg", "tt0337741", "6.7", "89,213" },
                    { 291, 0, 0, "David McCullough, Jeff Bridges, Paul Vincent O'Connor, Chris Cooper", 0, 0, "Nominated for 7 Oscars. Another 6 wins & 34 nominations.", 0, "4,439,434", 0, "USA", 0, "Gary Ross", 0, 1, 0, 0, 0, "Drama, History, Sport", 1, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmFhZmM3Y2MtNDA1Ny00NjkzLWJkM2EtYWU1ZjEwYmNjZDQ0XkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Jul-03", "TRUE", 0, "140 min", 0, 0, 1, 0, 0, 0, 0, 0, "Seabiscuit", 0, 0, "movie", 0, 0, 0, "Laura Hillenbrand (book), Gary Ross (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0329575.jpg", "tt0329575", "7.3", "56,648" },
                    { 292, 0, 1, "Samuel L. Jackson, Colin Farrell, Michelle Rodriguez, LL Cool J", 0, 0, "4 wins & 5 nominations.", 0, "null", 0, "USA", 1, "Clark Johnson", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, Spanish, French", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEzNjY5NDcwNV5BMl5BanBnXkFtZTcwNzEwMzg4NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Aug-03", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 1, "S.W.A.T.", 0, 0, "movie", 0, 0, 0, "Robert Hamner (characters), Ron Mita (story), Jim McClain (story), David Ayer (screenplay), David McKenna (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0257076.jpg", "tt0257076", "6", "117,518" },
                    { 293, 0, 1, "Ken Watanabe, Tom Cruise, William Atherton, Chad Lindberg", 0, 0, "Nominated for 4 Oscars. Another 19 wins & 47 nominations.", 0, "111,110,575", 0, "USA, New Zealand, Japan", 0, "Edward Zwick", 0, 1, 0, 0, 0, "Action, Drama, History", 1, 0, "English, Japanese", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGYwYWNjMzgtNGU4ZC00NWQ2LWEwZjUtMzE1Zjc3NjY3YTU1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Dec-03", "TRUE", 0, "154 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Last Samurai", 0, 0, "movie", 0, 0, 0, "John Logan (story), John Logan (screenplay), Edward Zwick (screenplay), Marshall Herskovitz (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0325710.jpg", "tt0325710", "7.7", "308,336" },
                    { 294, 0, 0, "Jamie Lee Curtis, Lindsay Lohan, Mark Harmon, Harold Gould", 0, 0, "Nominated for 1 Golden Globe. Another 5 wins & 9 nominations.", 0, "274,059", 1, "USA", 0, "Mark Waters", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English, Mandarin", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BODJmY2Y2OGQtMDg2My00N2Q3LWJmZTUtYTc2ODBjZDVlNDlhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "6-Aug-03", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Freaky Friday", 0, 0, "movie", 0, 0, 0, "Mary Rodgers (novel), Heather Hach (screenplay), Leslie Dixon (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0322330.jpg", "tt0322330", "6.1", "93,192" },
                    { 295, 0, 0, "Pamela Anderson, Jenny McCarthy, Marny Eng, Charlie Sheen", 0, 0, "2 wins & 2 nominations.", 0, "50,529,578", 1, "USA, Canada", 0, "David Zucker", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzRjZjdlMjQtODVkYS00N2YzLWJlYWYtMGVlN2E5MWEwMWQzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Oct-03", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Scary Movie 3", 0, 0, "movie", 0, 0, 0, "Craig Mazin, Pat Proft, Shawn Wayans (characters), Marlon Wayans (characters), Buddy Johnson (characters), Phil Beauman (characters), Jason Friedberg (characters), Aaron Seltzer (characters)", 0, "data/Movie_Poster_Dataset/2003/tt0306047.jpg", "tt0306047", "5.4", "108,585" },
                    { 296, 0, 1, "Mark Wahlberg, Charlize Theron, Donald Sutherland, Jason Statham", 0, 0, "7 wins & 7 nominations.", 0, "1,498,261", 0, "USA, France, UK", 1, "F. Gary Gray", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, Russian, Italian", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2RjMmU3ZWItYzBlMy00ZmJkLWE5YzgtNTVkODdhOWM3NGZhXkEyXkFqcGdeQXVyNDA5Mjg5MjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-May-03", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Italian Job", 0, 0, "movie", 0, 0, 0, "Troy Kennedy-Martin, Donna Powers (screenplay), Wayne Powers (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0317740.jpg", "tt0317740", "7", "278,529" },
                    { 297, 0, 0, "Kate Hudson, Matthew McConaughey, Kathryn Hahn, Annie Parisse", 0, 0, "1 win & 7 nominations.", 0, "817,360", 1, "USA, Germany", 0, "Donald Petrie", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWFkN2ZhODAtYTNkZS00Y2NjLWIzNDYtNzJjNDNlMzAyNTIyXkEyXkFqcGdeQXVyODEzNjM5OTQ@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Feb-03", "TRUE", 1, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "How to Lose a Guy in 10 Days", 0, 0, "movie", 0, 0, 0, "Michele Alexander (book), Jeannie Long (book), Kristen Buckley (screenplay), Brian Regan (screenplay), Burr Steers (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0251127.jpg", "tt0251127", "6.4", "151,106" },
                    { 298, 0, 0, "Jason Biggs, Seann William Scott, Alyson Hannigan, Eddie Kaye Thomas", 0, 0, "3 wins & 6 nominations.", 0, "2,283,276", 1, "USA, Germany", 0, "Jesse Dylan", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Aug-03", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Wedding", 0, 0, "movie", 0, 0, 0, "Adam Herz (characters), Adam Herz", 0, "data/Movie_Poster_Dataset/2003/tt0328828.jpg", "tt0328828", "6.3", "158,410" },
                    { 299, 0, 0, "Eddie Murphy, Jeff Garlin, Steve Zahn, Regina King", 0, 0, "1 win & 7 nominations.", 0, "1,894,325", 1, "USA", 0, "Steve Carr", 0, 0, 0, 1, 0, "Comedy, Family", 0, 0, "English, Klingon, German", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZDhlZTYxOTYtYTk3Ny00ZDljLTk3ZmItZTcxZWU5YTIyYmFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "9-May-03", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Daddy Day Care", 0, 0, "movie", 0, 0, 0, "Geoff Rodkey", 0, "data/Movie_Poster_Dataset/2003/tt0317303.jpg", "tt0317303", "5.5", "47,893" },
                    { 300, 0, 1, "Ben Affleck, Jennifer Garner, Colin Farrell, Michael Clarke Duncan", 0, 0, "4 wins & 16 nominations.", 0, "431,881", 0, "USA", 1, "Mark Steven Johnson", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, Greek, Italian", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjIzNTYxMTctZjAwNS00YzI3LWExMGMtMGQxNGM5ZTc1NzhlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Feb-03", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 1, "Daredevil", 0, 0, "movie", 0, 0, 0, "Mark Steven Johnson (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0287978.jpg", "tt0287978", "5.3", "169,687" },
                    { 301, 0, 0, "Mike Myers, Alec Baldwin, Kelly Preston, Dakota Fanning", 1, 0, "3 wins & 13 nominations.", 0, "null", 1, "USA", 0, "Bo Welch", 0, 0, 0, 1, 0, "Adventure, Comedy, Family", 0, 0, "English", 0, "19", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZmQzMDE5ZWQtOTU3ZS00ZjdhLWI0OTctZDNkODk4YThmOTRhL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Nov-03", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Cat in the Hat", 0, 0, "movie", 0, 0, 0, "Dr. Seuss (book), Alec Berg (screenplay), David Mandel (screenplay), Jeff Schaffer (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0312528.jpg", "tt0312528", "3.8", "34,990" },
                    { 302, 0, 1, "Cameron Diaz, Drew Barrymore, Lucy Liu, Bernie Mac", 1, 0, "7 wins & 14 nominations.", 0, "100,685,880", 1, "USA", 0, "McG", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Mandarin, Spanish", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzQzMzJhZTEtOWM4NS00MTdhLTg0YjgtMjM4MDRkZjUwZDBlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Jun-03", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Charlie's Angels: Full Throttle", 0, 0, "movie", 0, 0, 0, "Ivan Goff (television series), Ben Roberts (television series), John August (story), John August (screenplay), Cormac Wibberley (screenplay), Marianne Wibberley (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0305357.jpg", "tt0305357", "4.8", "99,133" },
                    { 303, 0, 0, "Jude Law, Nicole Kidman, Renée Zellweger, Eileen Atkins", 0, 0, "Won 1 Oscar. Another 17 wins & 92 nominations.", 0, "95,632,614", 0, "USA, UK, Romania, Italy", 0, "Anthony Minghella", 0, 1, 0, 0, 0, "Drama, History, Romance", 1, 0, "English", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDVjNjIwOGItNDE3Ny00OThjLWE0NzQtZTU3YjMzZTZjMzhkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Dec-03", "TRUE", 1, "154 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cold Mountain", 0, 0, "movie", 0, 0, 0, "Charles Frazier (book), Anthony Minghella (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0159365.jpg", "tt0159365", "7.2", "116,529" },
                    { 304, 0, 1, "Russell Crowe, Paul Bettany, James D'Arcy, Edward Woodall", 1, 0, "Won 2 Oscars. Another 21 wins & 77 nominations.", 0, "93,926,386", 0, "USA", 0, "Peter Weir", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "English, French, Portuguese", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzAwNjU1OTktYjY3Mi00NDY5LWFlZWUtZjhjNGE0OTkwZDkwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Nov-03", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "Master and Commander: The Far Side of the World", 0, 0, "movie", 0, 0, 0, "Patrick O'Brian (novels), Peter Weir (screenplay), John Collee (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0311113.jpg", "tt0311113", "7.4", "164,673" },
                    { 305, 0, 0, "Sean Penn, Tim Robbins, Kevin Bacon, Laurence Fishburne", 0, 0, "Won 2 Oscars. Another 52 wins & 121 nominations.", 0, "90,135,191", 0, "USA, Australia", 1, "Clint Eastwood", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "84", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDhmNTA0ZDMtYjhkNS00NzEzLWIzYTItOGNkMTVmYjE2YmI3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Oct-03", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mystic River", 0, 0, "movie", 0, 0, 0, "Brian Helgeland (screenplay), Dennis Lehane (novel)", 0, "data/Movie_Poster_Dataset/2003/tt0327056.jpg", "tt0327056", "8", "329,599" },
                    { 306, 0, 0, "Joaquin Phoenix, Jeremy Suarez, Jason Raize, Rick Moranis", 1, 1, "Nominated for 1 Oscar. Another 2 wins & 19 nominations.", 0, "80,239,025", 0, "USA", 0, "Aaron Blaise, Robert Walker", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "English, Inuktitut, Croatian, Serbian", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5MDMzODUyOF5BMl5BanBnXkFtZTcwMTQ3NTMyNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "1-Nov-03", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Brother Bear", 0, 0, "movie", 0, 0, 0, "Tab Murphy (screenplay), Lorne Cameron (screenplay), David Hoselton (screenplay), Steve Bencich (screenplay), Ron J. Friedman (screenplay), Stephen J. Anderson (story), Stevie Wermers (story), Kevin Deters (story), Woody Woodman (story), Thom Enriquez (story), Kevin Harkey (story), Broose Johnson (story), John Norton (story), John Puglisi (story), Tim Hodge (additional story), Tom LaBaff (additional story), Ray Shenusay (additional story), Brian Pimental (additional story), Jim Story (additional story), Don Dougherty (additional story), Don Hall (additional story), Samuel Levine (additional story), Aurian Redson (additional story), Chris Williams (additional story), Jeff Hand (additional story material)", 0, "data/Movie_Poster_Dataset/2003/tt0328880.jpg", "tt0328880", "6.8", "66,838" },
                    { 308, 0, 0, "Jack Black, Adam Pascal, Lucas Papaelias, Chris Stack", 0, 0, "Nominated for 1 Golden Globe. Another 7 wins & 16 nominations.", 0, "709,247", 1, "USA, Germany", 0, "Richard Linklater", 0, 0, 0, 0, 0, "Comedy, Music", 0, 0, "English", 0, "82", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGNjYjM2MzItZGQzZi00NmY3LTgxOGUtMTQ2MWQxNWQ2MmMwXkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Oct-03", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "School of Rock", 0, 0, "movie", 0, 0, 0, "Mike White", 0, "data/Movie_Poster_Dataset/2003/tt0332379.jpg", "tt0332379", "7.1", "203,628" },
                    { 309, 0, 0, "Jessica Biel, Jonathan Tucker, Erica Leerhsen, Mike Vogel", 0, 0, "4 wins & 14 nominations.", 0, "562,521", 0, "USA", 0, "Marcus Nispel", 0, 0, 0, 0, 0, "Horror", 0, 1, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmY0MWY2NDctZDdmMi00MjA1LTk0ZTQtZDMyZTQ1NTNlYzVjXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Oct-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Texas Chainsaw Massacre", 0, 0, "movie", 0, 0, 0, "Kim Henkel, Tobe Hooper, Scott Kosar (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0324216.jpg", "tt0324216", "6.2", "105,902" },
                    { 310, 0, 0, "Eddie Murphy, Terence Stamp, Nathaniel Parker, Marsha Thomason", 0, 0, "1 win & 4 nominations.", 0, "7,776,947", 1, "USA", 0, "Rob Minkoff", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg1MDg3OTk3M15BMl5BanBnXkFtZTgwMDEzMzE5MTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "26-Nov-03", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Haunted Mansion", 0, 0, "movie", 0, 0, 0, "David Berenbaum", 0, "data/Movie_Poster_Dataset/2003/tt0338094.jpg", "tt0338094", "4.9", "31,021" },
                    { 311, 0, 0, "Luke Wilson, Will Ferrell, Vince Vaughn, Jeremy Piven", 0, 0, "4 nominations.", 0, "1,300,030", 1, "USA", 0, "Todd Phillips", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGMwYmY5ZmEtMzY1Yi00OWJiLTk1Y2MtMzI2MjBhYmZkNTQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Feb-03", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Old School", 0, 0, "movie", 0, 0, 0, "Court Crandall (story), Todd Phillips (story), Scot Armstrong (story), Todd Phillips (screenplay), Scot Armstrong (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0302886.jpg", "tt0302886", "7.2", "181,969" },
                    { 312, 0, 1, "Uma Thurman, Lucy Liu, Vivica A. Fox, Daryl Hannah", 0, 0, "Nominated for 1 Golden Globe. Another 24 wins & 81 nominations.", 0, "70,098,138", 0, "USA", 0, "Quentin Tarantino", 0, 0, 0, 0, 0, "Action", 0, 0, "English, Japanese, French", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWVmYzQwY2MtOTBjNi00MDNhLWI5OGMtN2RiMDYxODI3MjU5XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Oct-03", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kill Bill: Vol. 1", 0, 0, "movie", 0, 0, 0, "Quentin Tarantino, Quentin Tarantino (character The Bride), Uma Thurman (character The Bride)", 0, "data/Movie_Poster_Dataset/2003/tt0266697.jpg", "tt0266697", "8.1", "709,183" },
                    { 313, 0, 0, "Sigourney Weaver, Jon Voight, Tim Blake Nelson, Shia LaBeouf", 1, 0, "3 wins & 9 nominations.", 0, "null", 1, "USA", 0, "Andrew Davis", 0, 1, 0, 0, 0, "Adventure, Comedy, Drama", 0, 0, "English", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg3NzYzOTEtNmE2Ni00M2EyLWJhMjctNjMyMTk4ZTViOGUzXkEyXkFqcGdeQXVyNzQxNDExNTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "18-Apr-03", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Holes", 0, 0, "movie", 0, 0, 0, "Louis Sachar (novel), Louis Sachar (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0311289.jpg", "tt0311289", "7.1", "55,883" },
                    { 314, 0, 1, "Jerry O'Connell, Anthony Anderson, Estella Warren, Christopher Walken", 1, 0, "1 win & 5 nominations.", 0, "259,928", 1, "USA, Australia", 0, "David McNally", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "16", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZmY4Yjc0OWQtZDRhMy00ODc2LWI2NGYtMWFlODYyN2VlNDQyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "17-Jan-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kangaroo Jack", 0, 0, "movie", 0, 0, 0, "Steve Bing (story), Barry O'Brien (story), Steve Bing (screenplay), Scott Rosenberg (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0257568.jpg", "tt0257568", "4.4", "22,911" },
                    { 315, 0, 0, "Ewan McGregor, Albert Finney, Billy Crudup, Jessica Lange", 1, 0, "Nominated for 1 Oscar. Another 1 win & 52 nominations.", 0, "3,559,255", 0, "USA", 0, "Tim Burton", 0, 1, 0, 0, 1, "Adventure, Drama, Fantasy", 0, 0, "English, Cantonese", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWFjZjRiM2QtZmRkOC00MDUxLTlhYmQtYmY5ZTNiMTI5Nzc2L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Jan-04", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Big Fish", 0, 0, "movie", 0, 0, 0, "Daniel Wallace (novel), John August (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0319061.jpg", "tt0319061", "8", "343,709" },
                    { 316, 0, 1, "Sean Connery, Naseeruddin Shah, Peta Wilson, Tony Curran", 1, 0, "6 nominations.", 0, "null", 0, "USA, Germany, Czech Republic, UK", 0, "Stephen Norrington", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English, German, Italian", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWFlNzZhYmYtYTI5YS00MDQyLWIyNTUtNTRjMWUwNTEzNjA0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Jul-03", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "The League of Extraordinary Gentlemen", 0, 0, "movie", 0, 0, 0, "Alan Moore (comic books), Kevin O'Neill (comic books), James Robinson (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0311429.jpg", "tt0311429", "5.8", "138,119" },
                    { 317, 0, 1, "Angelina Jolie, Gerard Butler, Ciarán Hinds, Chris Barrie", 1, 0, "1 win & 2 nominations.", 0, "65,653,758", 0, "USA, Germany, Japan, UK", 0, "Jan de Bont", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English, Mandarin", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM0YzExY2EtMjUyZi00ZmIwLWFkYTktNjY5NmVkYTdkMjI5XkEyXkFqcGdeQXVyNzQxNDExNTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Jul-03", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lara Croft Tomb Raider: The Cradle of Life", 0, 0, "movie", 0, 0, 0, "Dean Georgaris (screenplay), Steven E. de Souza (story), James V. Hart (story)", 0, "data/Movie_Poster_Dataset/2003/tt0325703.jpg", "tt0325703", "5.5", "99,765" },
                    { 318, 0, 0, "Julia Roberts, Kirsten Dunst, Julia Stiles, Maggie Gyllenhaal", 0, 0, "Nominated for 1 Golden Globe. Another 5 nominations.", 0, "11,289", 0, "USA", 0, "Mike Newell", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Italian", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjM2MjMwNzUzN15BMl5BanBnXkFtZTgwMjEzMzE5MTE@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Dec-03", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mona Lisa Smile", 0, 0, "movie", 0, 0, 0, "Lawrence Konner, Mark Rosenthal", 0, "data/Movie_Poster_Dataset/2003/tt0304415.jpg", "tt0304415", "6.4", "59,968" },
                    { 319, 0, 1, "Jackie Chan, Owen Wilson, Aaron Taylor-Johnson, Tom Fisher", 1, 0, "4 nominations.", 0, "701,287", 1, "USA, Hong Kong", 0, "David Dobkin", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Mandarin", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWEzMGY4OTQtYTdmMy00M2QwLTliYTQtYWUzYzc3OTA5YzIwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Feb-03", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shanghai Knights", 0, 0, "movie", 0, 0, 0, "Alfred Gough (characters), Miles Millar (characters), Alfred Gough, Miles Millar", 0, "data/Movie_Poster_Dataset/2003/tt0300471.jpg", "tt0300471", "6.2", "78,496" },
                    { 320, 0, 0, "Billy Bob Thornton, Tony Cox, Brett Kelly, Lauren Graham", 0, 0, "Nominated for 1 Golden Globe. Another 1 win & 10 nominations.", 0, "2,983", 1, "USA, Germany", 1, "Terry Zwigoff", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTg3M2ExY2EtZmI5Yy00YWM1LTg4NzItZWEzZTgxNzE2MjhhXkEyXkFqcGdeQXVyNDE5MTU2MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Nov-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bad Santa", 0, 0, "movie", 0, 0, 0, "Glenn Ficarra, John Requa", 0, "data/Movie_Poster_Dataset/2003/tt0307987.jpg", "tt0307987", "7.1", "105,948" },
                    { 321, 0, 0, "Bill Nighy, Gregor Fisher, Rory MacGregor, Colin Firth", 0, 0, "Nominated for 2 Golden Globes. Another 10 wins & 24 nominations.", 0, "5,010,288", 1, "UK, USA, France", 0, "Richard Curtis", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, Portuguese, French", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmI0M2VmNTgtMWVhYS00Zjg1LTk1YTYtNmJmMjRkZmMwYTc2XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Nov-03", "TRUE", 1, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love Actually", 0, 0, "movie", 0, 0, 0, "Richard Curtis", 0, "data/Movie_Poster_Dataset/2003/tt0314331.jpg", "tt0314331", "7.7", "311,218" },
                    { 322, 0, 0, "Halle Berry, Robert Downey Jr., Charles S. Dutton, John Carroll Lynch", 0, 0, "2 wins & 7 nominations.", 0, "4,220,276", 0, "USA", 0, "Mathieu Kassovitz", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmY3MDlmODctYTY3Yi00NzYyLWIxNTUtYjVlZWZjMmMwZTBkXkEyXkFqcGdeQXVyMzAxNjg3MjQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Nov-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Gothika", 0, 0, "movie", 0, 0, 0, "Sebastian Gutierrez", 0, "data/Movie_Poster_Dataset/2003/tt0348836.jpg", "tt0348836", "5.8", "87,450" },
                    { 323, 0, 0, "Robert Duvall, Kevin Costner, Annette Bening, Michael Gambon", 0, 0, "1 win & 4 nominations.", 0, "null", 0, "USA", 0, "Kevin Costner", 0, 1, 0, 0, 0, "Drama, Romance, Western", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGEyNzhkYzktMGMyZS00YzRiLWJlYjktZjJkOTU5ZDY0ZGI4XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Aug-03", "TRUE", 1, "139 min", 0, 0, 0, 0, 0, 0, 0, 0, "Open Range", 0, 0, "movie", 0, 0, 1, "Lauran Paine (novel), Craig Storper (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0316356.jpg", "tt0316356", "7.5", "52,905" },
                    { 324, 0, 1, "Antonio Banderas, Salma Hayek, Johnny Depp, Mickey Rourke", 0, 0, "3 wins & 4 nominations.", 0, "3,112,845", 0, "USA", 0, "Robert Rodriguez", 0, 0, 0, 0, 0, "Action, Thriller", 0, 0, "English, Spanish", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTYzYzBhYjQtNDQxYS00MmUwLTkyZjgtZWVkOWFjNzE5OTI2XkEyXkFqcGdeQXVyNjMxMjkwMjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Sep-03", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 1, "Once Upon a Time in Mexico", 0, 0, "movie", 0, 0, 0, "Robert Rodriguez", 0, "data/Movie_Poster_Dataset/2003/tt0285823.jpg", "tt0285823", "6.4", "127,220" },
                    { 325, 0, 0, "Ashton Kutcher, Brittany Murphy, Christian Kane, David Moscow", 0, 0, "9 nominations.", 0, "519,013", 1, "USA, Germany", 0, "Shawn Levy", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Italian, French, German", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjgyMzZkMGUtNTBhZC00OTkzLWI4ZmMtYzcwMzc5MjQ0YTM3XkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Jan-03", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Just Married", 0, 0, "movie", 0, 0, 0, "Sam Harper", 0, "data/Movie_Poster_Dataset/2003/tt0305711.jpg", "tt0305711", "5.4", "56,314" },
                    { 326, 0, 1, "Ben Affleck, Aaron Eckhart, Uma Thurman, Paul Giamatti", 0, 0, "2 wins & 2 nominations.", 0, "2,141,356", 0, "USA, Canada", 0, "John Woo", 0, 0, 0, 0, 0, "Action, Mystery, Sci-Fi", 0, 0, "English", 0, "43", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGQ5ODNkNWYtYTgxZS00YjJkLThhODAtYzUwNGNiYjRmNjdkXkEyXkFqcGdeQXVyMTg2NTc4MzA@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Dec-03", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Paycheck", 0, 0, "movie", 0, 0, 0, "Philip K. Dick (short story), Dean Georgaris (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0338337.jpg", "tt0338337", "6.3", "88,122" },
                    { 327, 0, 1, "Al Pacino, Colin Farrell, Bridget Moynahan, Gabriel Macht", 0, 0, "2 nominations.", 0, "676,129", 0, "USA", 1, "Roger Donaldson", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Persian, Russian", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTQ4MjA4NmYtYjRhNi00MTEwLTg0NjgtNjk3ODJlZGU4NjRkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-Jan-03", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Recruit", 0, 0, "movie", 0, 0, 0, "Roger Towne, Kurt Wimmer, Mitch Glazer", 0, "data/Movie_Poster_Dataset/2003/tt0292506.jpg", "tt0292506", "6.6", "110,821" },
                    { 328, 0, 0, "Cuba Gooding Jr., Ed Harris, Alfre Woodard, S. Epatha Merkerson", 0, 0, "3 wins & 3 nominations.", 1, "34,379", 0, "USA", 0, "Michael Tollin", 0, 1, 0, 0, 0, "Biography, Drama, Sport", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNjgxY2JiZDYtZmMwOC00ZmJjLWJmODUtMTNmNWNmYWI5ODkwL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "24-Oct-03", "TRUE", 0, "109 min", 0, 0, 1, 0, 0, 0, 0, 0, "Radio", 0, 0, "movie", 0, 0, 0, "Mike Rich", 0, "data/Movie_Poster_Dataset/2003/tt0316465.jpg", "tt0316465", "6.9", "31,793" },
                    { 329, 0, 0, "John Cusack, Ray Liotta, Amanda Peet, John Hawkes", 0, 0, "6 nominations.", 0, "205,203", 0, "USA", 0, "James Mangold", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "64", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjJkN2Y5MTktZDRhOS00NTUwLWFiMzEtMTVlNWU4ODM0Y2E5XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Apr-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "Identity", 0, 0, "movie", 0, 0, 0, "Michael Cooney", 0, "data/Movie_Poster_Dataset/2003/tt0309698.jpg", "tt0309698", "7.3", "172,379" },
                    { 330, 0, 1, "Kate Beckinsale, Scott Speedman, Michael Sheen, Shane Brolly", 0, 0, "1 win & 8 nominations.", 0, "903,637", 0, "UK, Germany, Hungary, USA", 0, "Len Wiseman", 0, 0, 0, 0, 1, "Action, Fantasy", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTdhNmUxZmQtNmMwNC00MzE3LWE1MTUtZDgxZTYwYjEzZjcwXkEyXkFqcGdeQXVyNTA1NjYyMDk@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-03", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Underworld", 0, 0, "movie", 0, 0, 0, "Kevin Grevioux (story), Len Wiseman (story), Danny McBride (story), Danny McBride (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0320691.jpg", "tt0320691", "7", "202,111" },
                    { 331, 0, 0, "John Cusack, Gene Hackman, Dustin Hoffman, Rachel Weisz", 0, 0, "3 nominations.", 0, "12,083,403", 0, "USA", 0, "Gary Fleder", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English, French, Italian", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGYxZjA2M2ItYTRmNS00NzRmLWJkYzgtYTdiNGFlZDI5ZjNmXkEyXkFqcGdeQXVyNDE5MTU2MDE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Oct-03", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 1, "Runaway Jury", 0, 0, "movie", 0, 0, 0, "John Grisham (novel), Brian Koppelman (screenplay), David Levien (screenplay), Rick Cleveland (screenplay), Matthew Chapman (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0313542.jpg", "tt0313542", "7.1", "75,353" },
                    { 332, 0, 0, "Jason Isaacs, Jeremy Sumpter, Rachel Hurd-Wood, Lynn Redgrave", 1, 0, "3 wins & 12 nominations.", 0, "406,564", 0, "Australia, USA, UK", 0, "P.J. Hogan", 0, 0, 0, 1, 1, "Adventure, Family, Fantasy", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMGVhNjhjODktODgxYS00MDdhLTlkZjktYTkyNzQxMTU0ZDYxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Dec-03", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Peter Pan", 0, 0, "movie", 0, 0, 0, "J.M. Barrie (play), P.J. Hogan (screenplay), Michael Goldenberg (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0316396.jpg", "tt0316396", "6.9", "52,790" },
                    { 333, 0, 1, "Frankie Muniz, Hilary Duff, Angie Harmon, Keith David", 1, 0, "4 nominations.", 0, "2,124,462", 1, "USA, Canada", 0, "Harald Zwart", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BY2I0MWFiZDMtNWQyYy00Njk5LTk3MDktZjZjNTNmZmVkYjkxXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "14-Mar-03", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Agent Cody Banks", 0, 0, "movie", 0, 0, 0, "Ashley Miller (screenplay), Zack Stentz (screenplay), Scott Alexander (screenplay), Larry Karaszewski (screenplay), Jeffrey Jurgensen (story)", 0, "data/Movie_Poster_Dataset/2003/tt0313911.jpg", "tt0313911", "5", "25,844" },
                    { 334, 0, 0, "John Goodman, Haley Joel Osment, Mae Whitman, Connor Funk", 1, 1, "1 win & 9 nominations.", 0, "null", 0, "USA, Australia", 0, "Steve Trenbirth", 0, 0, 0, 1, 0, "Adventure, Animation, Family", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDdkNzMwZmUtY2Q5MS00ZmM2LWJhYjItYTBjMWY0MGM4MDRjXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "14-Feb-03", "TRUE", 0, "72 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Jungle Book 2", 0, 0, "movie", 0, 0, 0, "Karl Geurs (screenplay), Carter Crocker (additional written material), Evan Spiliotopoulos (additional written material), David Reynolds (additional written material), Roger S.H. Schulman (additional written material), Tom Rogers (additional written material)", 0, "data/Movie_Poster_Dataset/2003/tt0283426.jpg", "tt0283426", "5.4", "10,828" },
                    { 335, 0, 1, "Dwayne Johnson, Seann William Scott, Rosario Dawson, Christopher Walken", 1, 0, "2 wins & 3 nominations.", 0, "null", 1, "USA", 0, "Peter Berg", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Portuguese", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDUzZjlhZTYtN2E5MS00ODQ3LWI1ZjgtNzdiZmI0NTZiZTljXkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Sep-03", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Rundown", 0, 0, "movie", 0, 0, 0, "R.J. Stewart (story), R.J. Stewart (screenplay), James Vanderbilt (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0327850.jpg", "tt0327850", "6.7", "80,888" },
                    { 336, 0, 0, "Ali Larter, A.J. Cook, Michael Landes, David Paetkau", 0, 0, "4 nominations.", 0, "694,669", 0, "USA, Canada", 0, "David R. Ellis", 0, 0, 0, 0, 1, "Fantasy, Horror, Thriller", 0, 1, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmI5NTA3MjItYzdhMi00MWMxLTg3OWMtYWQyYjg5MTFmM2U0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Jan-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "Final Destination 2", 0, 0, "movie", 0, 0, 0, "J. Mackye Gruber (screenplay), Eric Bress (screenplay), J. Mackye Gruber (story), Eric Bress (story), Jeffrey Reddick (story), Jeffrey Reddick (characters)", 0, "data/Movie_Poster_Dataset/2003/tt0309593.jpg", "tt0309593", "6.2", "117,289" },
                    { 337, 0, 0, "Scarlett Johansson, Bill Murray, Akiko Takeshita, Kazuyoshi Minamimagoe", 0, 0, "Won 1 Oscar. Another 92 wins & 105 nominations.", 0, "null", 0, "USA, Japan", 0, "Sofia Coppola", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, Japanese, German, French", 0, "89", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjE2OTdhMWUtOGJlMy00ZDViLWIzZjgtYjZkZGZmMDZjYmEyXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Oct-03", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lost in Translation", 0, 0, "movie", 0, 0, 0, "Sofia Coppola", 0, "data/Movie_Poster_Dataset/2003/tt0335266.jpg", "tt0335266", "7.8", "312,086" },
                    { 338, 0, 1, "Bruce Willis, Monica Bellucci, Cole Hauser, Eamonn Walker", 0, 0, "2 nominations.", 0, "1,825,961", 0, "USA", 0, "Antoine Fuqua", 0, 1, 0, 0, 0, "Action, Drama, Thriller", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWRmNGEwZjUtZjEwNS00OGZmLThhMmEtZTJlMTU5MGQ3ZWUwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Mar-03", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 1, "Tears of the Sun", 0, 0, "movie", 0, 0, 0, "Alex Lasker, Patrick Cirillo", 0, "data/Movie_Poster_Dataset/2003/tt0314353.jpg", "tt0314353", "6.6", "90,916" },
                    { 339, 0, 0, "Diane Lane, Sandra Oh, Lindsay Duncan, Raoul Bova", 0, 0, "Nominated for 1 Golden Globe. Another 4 nominations.", 0, "null", 1, "USA, Italy", 0, "Audrey Wells", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, Italian, Polish, French, Spanish, German", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzc1MTcyNTQ5N15BMl5BanBnXkFtZTgwMzgwMDI0MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Sep-03", "TRUE", 1, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Under the Tuscan Sun", 0, 0, "movie", 0, 0, 0, "Frances Mayes (book), Audrey Wells (screen story), Audrey Wells (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0328589.jpg", "tt0328589", "6.7", "34,566" },
                    { 340, 0, 0, "Hilary Duff, Adam Lamberg, Hallie Todd, Robert Carradine", 1, 0, "2 wins & 3 nominations.", 0, "null", 1, "USA", 0, "Jim Fall", 0, 0, 0, 1, 0, "Adventure, Comedy, Family", 0, 0, "English, Italian", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYTcxYWExOTMtMWFmYy00ZjgzLWI0YjktNWEzYzJkZTg0NDdmL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "2-May-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lizzie McGuire Movie", 0, 0, "movie", 0, 0, 0, "Susan Estelle Jansen, Ed Decter, John J. Strauss, Terri Minsky (characters)", 0, "data/Movie_Poster_Dataset/2003/tt0306841.jpg", "tt0306841", "5.3", "26,502" },
                    { 341, 0, 0, "Michael Caine, Robert Duvall, Haley Joel Osment, Kyra Sedgwick", 0, 0, "6 nominations.", 0, "521,208", 1, "USA", 0, "Tim McCanlies", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZTYwYjYxYzgtMDE1Ni00NzU4LWJlMTEtODQ5YmJmMGJhZjI5L2ltYWdlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "19-Sep-03", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Secondhand Lions", 0, 0, "movie", 0, 0, 0, "Tim McCanlies", 0, "data/Movie_Poster_Dataset/2003/tt0327137.jpg", "tt0327137", "7.6", "42,431" },
                    { 342, 0, 0, "Denzel Washington, Eva Mendes, Sanaa Lathan, Dean Cain", 0, 0, "4 wins & 7 nominations.", 0, "397,228", 0, "USA", 1, "Carl Franklin", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjUyZWZkM2UtMzYxYy00ZmQ3LWFmZTQtOGE2YjBkNjA3YWZlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Oct-03", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 1, "Out of Time", 0, 0, "movie", 0, 0, 0, "David Collard", 0, "data/Movie_Poster_Dataset/2003/tt0313443.jpg", "tt0313443", "6.5", "44,801" },
                    { 343, 0, 0, "Elizabeth Daily, Nancy Cartwright, Kath Soucie, Dionne Quan", 1, 1, "2 nominations.", 0, "294,380", 1, "USA", 0, "John Eng, Norton Virgien", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg3MTI5NTk0N15BMl5BanBnXkFtZTgwMjU1MDM5MTE@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "PG", 0, 0, "13-Jun-03", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rugrats Go Wild", 0, 0, "movie", 0, 0, 0, "Kate Boutilier", 0, "data/Movie_Poster_Dataset/2003/tt0337711.jpg", "tt0337711", "5.6", "5,451" },
                    { 344, 0, 0, "Chris Rock, Bernie Mac, Dylan Baker, Nick Searcy", 0, 0, "9 nominations.", 0, "37,788,228", 1, "USA", 0, "Chris Rock", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzJmMWE5NjAtNWMyZS00NmFiLWIwMDgtZDE2NzczYWFhNzIzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Mar-03", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Head of State", 0, 0, "movie", 0, 0, 0, "Chris Rock, Ali LeRoi", 0, "data/Movie_Poster_Dataset/2003/tt0325537.jpg", "tt0325537", "5.4", "14,804" },
                    { 345, 0, 0, "Molly Shannon, Liam Aiken, Kevin Nealon, Brittany Moldowan", 0, 0, "4 nominations.", 0, "270,851", 1, "USA", 0, "John Hoffman", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNjBjNDJiYTUtOWY0OS00OGVmLTg2YzctMTE0NzVhODM1ZWJmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "10-Oct-03", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Good Boy!", 0, 0, "movie", 0, 0, 0, "Zeke Richardson (story), Zeke Richardson (screen story), John Hoffman (screen story), John Hoffman (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0326900.jpg", "tt0326900", "5.1", "3,324" },
                    { 346, 0, 0, "Brittany Murphy, Dakota Fanning, Marley Shelton, Donald Faison", 0, 0, "1 nomination.", 0, "null", 1, "USA", 0, "Boaz Yakin", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2QwYWQ0MWMtNzcwOC00N2Q2LWE1MDEtZmQxZjhiM2U1YzFhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Aug-03", "TRUE", 1, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Uptown Girls", 0, 0, "movie", 0, 0, 0, "Julia Dahl (screenplay), Mo Ogrodnik (screenplay), Lisa Davidowitz (screenplay), Allison Jacobs (story)", 0, "data/Movie_Poster_Dataset/2003/tt0263757.jpg", "tt0263757", "6.1", "28,389" },
                    { 347, 0, 0, "Nicolas Cage, Sam Rockwell, Alison Lohman, Bruce Altman", 0, 0, "3 nominations.", 0, "54,290", 0, "USA", 1, "Ridley Scott", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDVkYmYwM2ItNzRiMy00NWQ4LTlhMjMtNDI1ZDYyOGVmMzJjXkEyXkFqcGdeQXVyNTgzMzU5MDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Sep-03", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 1, "Matchstick Men", 0, 0, "movie", 0, 0, 0, "Eric Garcia (book), Nicholas Griffin (screenplay), Ted Griffin (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0325805.jpg", "tt0325805", "7.3", "104,070" },
                    { 348, 0, 1, "Martin Lawrence, Steve Zahn, Colm Feore, Bill Duke", 0, 0, "N/A", 0, "901,698", 1, "USA", 1, "Dennis Dugan", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmRiMDFlYjYtOTMwYy00OGY2LWE0Y2QtYzQxOGNhZmUwNTIxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Jan-03", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "National Security", 0, 0, "movie", 0, 0, 0, "Jay Scherick, David Ronn", 0, "data/Movie_Poster_Dataset/2003/tt0271668.jpg", "tt0271668", "5.6", "38,182" },
                    { 349, 0, 0, "Amanda Bynes, Colin Firth, Kelly Preston, Eileen Atkins", 0, 0, "1 win.", 0, "401,212", 1, "USA", 0, "Dennie Gordon", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNWJiNGJiMTEtMGM3OC00ZWNlLTgwZTgtMzdhNTRiZjk5MTQ1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "4-Apr-03", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "What a Girl Wants", 0, 0, "movie", 0, 0, 0, "William Douglas-Home (play), William Douglas-Home, Jenny Bicks (screenplay), Elizabeth Chandler (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0286788.jpg", "tt0286788", "5.8", "46,745" },
                    { 351, 0, 0, "George Clooney, Catherine Zeta-Jones, Geoffrey Rush, Cedric the Entertainer", 0, 0, "3 nominations.", 0, "537,646", 1, "USA", 1, "Joel Coen, Ethan Coen", 0, 0, 0, 0, 0, "Comedy, Crime, Romance", 0, 0, "English, French", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjZlMDdmN2YtYThmZi00NGQzLTk0ZTQtNTUyZDFmODExOGNiXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Oct-03", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Intolerable Cruelty", 0, 0, "movie", 0, 0, 0, "Robert Ramsey (story), Matthew Stone (story), John Romano (story), Robert Ramsey (screenplay), Matthew Stone (screenplay), Ethan Coen (screenplay), Joel Coen (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0138524.jpg", "tt0138524", "6.3", "74,652" },
                    { 352, 0, 1, "Jet Li, DMX, Anthony Anderson, Kelly Hu", 0, 0, "6 nominations.", 0, "158,897", 0, "USA", 1, "Andrzej Bartkowiak", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Mandarin, Korean", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjJkYTc5N2UtMGRlMC00M2FmLTk0ZWMtOTYxNDUwNjI2YzljXkEyXkFqcGdeQXVyNDg4NjY5OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Feb-03", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cradle 2 the Grave", 0, 0, "movie", 0, 0, 0, "John O'Brien (story), John O'Brien (screenplay), Channing Gibson (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0306685.jpg", "tt0306685", "5.8", "34,116" },
                    { 353, 0, 0, "Charlize Theron, Christina Ricci, Bruce Dern, Lee Tergesen", 0, 0, "Won 1 Oscar. Another 26 wins & 23 nominations.", 1, "null", 0, "USA, Germany", 1, "Patty Jenkins", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "74", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGE1ZTkyOTMtMTdiZS00YzI2LTlmYWQtOTE5YWY0NWVlNjlmXkEyXkFqcGdeQXVyNjQ3ODkxMjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Jan-04", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monster", 0, 0, "movie", 0, 0, 0, "Patty Jenkins", 0, "data/Movie_Poster_Dataset/2003/tt0340855.jpg", "tt0340855", "7.3", "102,847" },
                    { 354, 0, 0, "Jamie Kennedy, Taye Diggs, Anthony Anderson, Regina Hall", 0, 0, "3 nominations.", 0, "116,358", 1, "USA", 1, "John Whitesell", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE1NjQ5ODc2NV5BMl5BanBnXkFtZTgwOTM5ODIxNjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Apr-03", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Malibu's Most Wanted", 0, 0, "movie", 0, 0, 0, "Fax Bahr, Adam Small, Jamie Kennedy, Nick Swardson", 0, "data/Movie_Poster_Dataset/2003/tt0328099.jpg", "tt0328099", "5.1", "15,732" },
                    { 355, 0, 1, "Tommy Lee Jones, Benicio Del Toro, Connie Nielsen, Leslie Stefanson", 0, 0, "2 nominations.", 0, "190,769", 0, "USA", 1, "William Friedkin", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTdhNjBjZDctYTlkYy00ZGIxLWFjYTktODk5ZjNlMzI4NjI3XkEyXkFqcGdeQXVyMjY1MjkzMjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Mar-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hunted", 0, 0, "movie", 0, 0, 0, "David Griffiths, Peter Griffiths, Art Monterastelli", 0, "data/Movie_Poster_Dataset/2003/tt0269347.jpg", "tt0269347", "6", "34,886" },
                    { 356, 0, 0, "Matt Damon, Greg Kinnear, Eva Mendes, Wen Yann Shih", 0, 0, "3 nominations.", 0, "127,548", 1, "USA", 0, "Bobby Farrelly, Peter Farrelly", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzUzNDM2NzM2MV5BMl5BanBnXkFtZTgwNTM3NTg4OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Dec-03", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Stuck on You", 0, 0, "movie", 0, 0, 0, "Charles B. Wessler (story), Bennett Yellin (story), Peter Farrelly (story), Bobby Farrelly (story), Peter Farrelly (screenplay), Bobby Farrelly (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0338466.jpg", "tt0338466", "5.8", "43,651" },
                    { 357, 0, 0, "Morgan Freeman, Thomas Jane, Jason Lee, Damian Lewis", 0, 0, "4 nominations.", 0, "33,685,268", 0, "USA", 0, "Lawrence Kasdan", 0, 1, 0, 0, 0, "Drama, Horror, Sci-Fi", 0, 1, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA3NjkzNjg2MF5BMl5BanBnXkFtZTgwMDkyMzgzMDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Mar-03", "TRUE", 0, "134 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dreamcatcher", 0, 0, "movie", 0, 0, 0, "Stephen King (novel), William Goldman (screenplay), Lawrence Kasdan (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0285531.jpg", "tt0285531", "5.5", "73,985" },
                    { 358, 0, 0, "Chaney Kley, Emma Caulfield, Lee Cormie, Grant Piro", 0, 0, "1 win & 2 nominations.", 0, "519,725", 0, "USA, Australia", 0, "Jonathan Liebesman", 0, 0, 0, 0, 0, "Horror, Mystery, Thriller", 0, 1, "English", 0, "23", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Jan-03", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 1, "Darkness Falls", 0, 0, "movie", 0, 0, 0, "Joe Harris (story), John Fasano (screenplay), James Vanderbilt (screenplay), Joe Harris (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0282209.jpg", "tt0282209", "4.9", "25,316" },
                    { 360, 0, 1, "Christopher Shyer, Ray Galletti, Eileen Pedde, Rekha Sharma", 1, 0, "N/A", 0, "3,592,088", 0, "USA, Germany, Canada, UK", 0, "Jon Amiel", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTMyMjEyNzIzMV5BMl5BanBnXkFtZTgwNzIyNjU0NzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Mar-03", "TRUE", 0, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Core", 0, 0, "movie", 0, 0, 0, "Cooper Layne, John Rogers", 0, "data/Movie_Poster_Dataset/2003/tt0298814.jpg", "tt0298814", "5.4", "75,258" },
                    { 361, 0, 0, "Helen Mirren, Julie Walters, John Alderton, Linda Bassett", 0, 0, "Nominated for 1 Golden Globe. Another 2 wins & 14 nominations.", 0, "31,011,616", 1, "UK, USA", 0, "Nigel Cole", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWVlMjVhZWYtNWViNC00ODFkLTk1MmItYjU1MDY5ZDdhMTU3XkEyXkFqcGdeQXVyODIwMDI1NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jan-04", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Calendar Girls", 0, 0, "movie", 0, 0, 0, "Juliette Towhidi, Tim Firth", 0, "data/Movie_Poster_Dataset/2003/tt0337909.jpg", "tt0337909", "6.9", "19,041" },
                    { 362, 0, 1, "Harrison Ford, Josh Hartnett, Lena Olin, Bruce Greenwood", 0, 0, "N/A", 0, "584,587", 1, "USA", 1, "Ron Shelton", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNThmMWMyMWMtOWRiNy00MGY0LTg1OTUtNjYzODg2MjdlZGU5XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Jun-03", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hollywood Homicide", 0, 0, "movie", 0, 0, 0, "Robert Souza, Ron Shelton", 0, "data/Movie_Poster_Dataset/2003/tt0329717.jpg", "tt0329717", "5.3", "30,795" },
                    { 363, 0, 0, "Jessica Alba, Mekhi Phifer, Romeo Miller, Joy Bryant", 0, 0, "8 nominations.", 0, "1,360,300", 0, "USA", 0, "Bille Woodruff", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English", 0, "37", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjFhOWY0OTgtNDkzMC00YWJkLTk1NGEtYWUxNjhmMmQ5ZjYyXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Dec-03", "TRUE", 1, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Honey", 0, 0, "movie", 0, 0, 0, "Alonzo Brown, Kim Watson", 0, "data/Movie_Poster_Dataset/2003/tt0322589.jpg", "tt0322589", "5.3", "35,686" },
                    { 364, 0, 0, "Nigel Washington, Chloe Bailey, Demetress Long, Ann Nesby", 0, 0, "4 wins & 9 nominations.", 0, "null", 1, "USA", 0, "Jonathan Lynn", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "53", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDkzMTQ1YTMtMWY4Ny00MzExLTkzYzEtNzZhOTczNzU2NTU1XkEyXkFqcGdeQXVyODY3NjMyMDU@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Sep-03", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Fighting Temptations", 0, 0, "movie", 0, 0, 0, "Elizabeth Hunter (story), Elizabeth Hunter (screenplay), Saladin K. Patterson (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0191133.jpg", "tt0191133", "5.5", "5,683" },
                    { 365, 0, 1, "Rowan Atkinson, Tasha de Vasconcelos, Ben Miller, Greg Wise", 1, 0, "4 nominations.", 0, "734,283", 1, "UK, France, USA", 0, "Peter Howitt", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, French, Japanese", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTQ1NDI5MjMzNF5BMl5BanBnXkFtZTcwMTc0MDQwOQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "18-Jul-03", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Johnny English", 0, 0, "movie", 0, 0, 0, "Neal Purvis, Robert Wade, William Davies", 0, "data/Movie_Poster_Dataset/2003/tt0274166.jpg", "tt0274166", "6.1", "111,902" },
                    { 366, 0, 0, "Tommy Lee Jones, Cate Blanchett, Evan Rachel Wood, Jenna Boyd", 1, 0, "2 wins & 7 nominations.", 0, "90,340", 0, "USA", 0, "Ron Howard", 0, 0, 0, 0, 0, "Adventure, Thriller, Western", 0, 0, "English, Apache languages, Spanish", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTEwNjE2OTM4NDZeQTJeQWpwZ15BbWU3MDE2MTE4OTk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Nov-03", "TRUE", 0, "137 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Missing", 0, 0, "movie", 0, 0, 1, "Thomas Eidson (novel), Ken Kaufman (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0338188.jpg", "tt0338188", "6.5", "26,915" },
                    { 367, 0, 1, "John Travolta, Connie Nielsen, Samuel L. Jackson, Tim Daly", 0, 0, "1 nomination.", 0, "1,196,015", 0, "USA, Germany", 1, "John McTiernan", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg5MTE2NjA4OV5BMl5BanBnXkFtZTgwMTUyMjczMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Mar-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Basic", 0, 0, "movie", 0, 0, 0, "James Vanderbilt", 0, "data/Movie_Poster_Dataset/2003/tt0264395.jpg", "tt0264395", "6.5", "48,725" },
                    { 368, 0, 1, "Vin Diesel, Larenz Tate, Timothy Olyphant, Geno Silva", 0, 0, "1 nomination.", 0, "790,742", 0, "USA, Germany", 1, "F. Gary Gray", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Spanish", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTgwMzFiMWYtZDhlNS00ODNkLWJiODAtZDVhNzgyNzJhYjQ4L2ltYWdlXkEyXkFqcGdeQXVyNzEzOTYxNTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Apr-03", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Man Apart", 0, 0, "movie", 0, 0, 0, "Christian Gudegast, Paul Scheuring", 0, "data/Movie_Poster_Dataset/2003/tt0266465.jpg", "tt0266465", "6.1", "37,639" },
                    { 369, 0, 0, "Brad Pitt, Catherine Zeta-Jones, Michelle Pfeiffer, Joseph Fiennes", 1, 1, "8 nominations.", 0, "506,493", 1, "USA", 0, "Patrick Gilmore, Tim Johnson", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English, Cantonese, Italian", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTAwMjU5OTgxNjZeQTJeQWpwZ15BbWU4MDUxNDYxODEx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "2-Jul-03", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sinbad: Legend of the Seven Seas", 0, 0, "movie", 0, 0, 0, "John Logan (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0165982.jpg", "tt0165982", "6.7", "34,994" },
                    { 370, 0, 0, "Timothy Stack, Mimi Rogers, Wayne Federman, Lucas Gregory", 0, 0, "5 nominations.", 0, "53,800", 1, "USA", 0, "Troy Miller", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "19", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Jun-03", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dumb and Dumberer: When Harry Met Lloyd", 0, 0, "movie", 0, 0, 0, "Peter Farrelly (characters), Bennett Yellin (characters), Bobby Farrelly (characters), Robert Brener (story), Robert Brener (screenplay), Troy Miller (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0329028.jpg", "tt0329028", "3.4", "30,174" },
                    { 371, 0, 1, "Yun-Fat Chow, Seann William Scott, Jaime King, Karel Roden", 0, 0, "1 nomination.", 0, "131,427", 1, "USA, Canada", 0, "Paul Hunter", 0, 0, 0, 0, 1, "Action, Comedy, Fantasy", 0, 0, "English, Tibetan, Panjabi, German", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA1Nzk0OTM2OF5BMl5BanBnXkFtZTgwNjU2NjEwMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Apr-03", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bulletproof Monk", 0, 0, "movie", 0, 0, 0, "Ethan Reiff, Cyrus Voris", 0, "data/Movie_Poster_Dataset/2003/tt0245803.jpg", "tt0245803", "5.5", "41,682" },
                    { 372, 0, 0, "John Fiedler, Jim Cummings, Andre Stojka, Kath Soucie", 1, 1, "1 nomination.", 0, "2,920,216", 0, "USA", 0, "Francis Glebas", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA2NDc3Njg5NDVeQTJeQWpwZ15BbWU4MDc1NDcxNTUz._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "21-Mar-03", "TRUE", 0, "75 min", 0, 0, 0, 0, 0, 0, 0, 0, "Piglet's Big Movie", 0, 0, "movie", 0, 0, 0, "Brian Hohlfeld (screenplay), A.A. Milne (books), Ted Henning (additional screenplay material)", 0, "data/Movie_Poster_Dataset/2003/tt0323642.jpg", "tt0323642", "6", "4,501" },
                    { 373, 0, 0, "David Spade, Mary McCormack, Craig Bierko, Scott Terra", 0, 0, "1 win & 1 nomination.", 0, "321,157", 1, "USA", 0, "Sam Weisman", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDE5OWMzM2QtOTU2ZS00NzAyLWI2MDEtOTRlYjIxZGM0OWRjXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Sep-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dickie Roberts: Former Child Star", 0, 0, "movie", 0, 0, 0, "Fred Wolf, David Spade", 0, "data/Movie_Poster_Dataset/2003/tt0325258.jpg", "tt0325258", "5.6", "11,582" },
                    { 374, 0, 1, "Jackie Chan, Lee Evans, Claire Forlani, Julian Sands", 0, 0, "2 nominations.", 0, "130,927", 1, "Hong Kong, USA", 0, "Gordon Chan", 0, 0, 0, 0, 1, "Action, Comedy, Fantasy", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZThjMmQ5YjktMTUyMC00MjljLWJmMTAtOWIzNDIzY2VhNzQ0XkEyXkFqcGdeQXVyMTAyNjg4NjE0._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Aug-03", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Medallion", 0, 0, "movie", 0, 0, 0, "Alfred Cheung (story), Bennett Davlin, Alfred Cheung, Gordon Chan, Paul Wheeler, Bey Logan", 0, "data/Movie_Poster_Dataset/2003/tt0288045.jpg", "tt0288045", "5.1", "28,742" },
                    { 375, 0, 1, "Laurence Fishburne, Derek Luke, Orlando Jones, Djimon Hounsou", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Reggie Rock Bythewood", 0, 1, 0, 0, 0, "Action, Drama", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEzMzMxOTUyNV5BMl5BanBnXkFtZTcwNjI3MDc5Ng@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-Jan-03", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Biker Boyz", 0, 0, "movie", 0, 0, 0, "Michael Gougis (article), Craig Fernandez, Reggie Rock Bythewood", 0, "data/Movie_Poster_Dataset/2003/tt0326769.jpg", "tt0326769", "4.6", "10,854" },
                    { 376, 0, 0, "Nick Cannon, Jordan Burg, Jackie Benoit, George Cedar", 0, 0, "6 nominations.", 0, "21,897,389", 1, "USA", 0, "Troy Byer", 0, 1, 0, 0, 0, "Comedy, Romance, Drama", 0, 0, "English", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzU5MjEwMTg2Nl5BMl5BanBnXkFtZTcwNzM3MTYxNA@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Dec-03", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love Don't Cost a Thing", 0, 0, "movie", 0, 0, 0, "Michael Swerdlick (screenplay), Troy Byer (screenplay), Michael Swerdlick (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0337592.jpg", "tt0337592", "5", "5,659" },
                    { 377, 0, 0, "Dennis Quaid, Sharon Stone, Stephen Dorff, Juliette Lewis", 0, 0, "1 nomination.", 0, "null", 0, "USA, Canada, UK", 0, "Mike Figgis", 0, 1, 0, 0, 0, "Drama, Horror, Mystery", 0, 1, "English", 0, "37", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM5OTMyMjIxOV5BMl5BanBnXkFtZTcwNzU4MjIwNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-03", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cold Creek Manor", 0, 0, "movie", 0, 0, 0, "Richard Jefferies", 0, "data/Movie_Poster_Dataset/2003/tt0331468.jpg", "tt0331468", "4.9", "17,976" },
                    { 379, 0, 0, "Brendan Fraser, Jenna Elfman, Steve Martin, Timothy Dalton", 1, 1, "9 nominations.", 0, "null", 1, "Germany, USA", 0, "Joe Dante", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYzE5MjY1ZDgtMTkyNC00MTMyLThhMjAtZGI5OTE1NzFlZGJjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "14-Nov-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Looney Tunes: Back in Action", 0, 0, "movie", 0, 0, 0, "Larry Doyle", 0, "data/Movie_Poster_Dataset/2003/tt0318155.jpg", "tt0318155", "5.7", "23,009" },
                    { 381, 0, 1, "Michael Douglas, Michael Bodnar, Vladimir Radian, Robin Tunney", 0, 0, "N/A", 0, "360,302", 1, "USA, Germany, Canada", 0, "Andrew Fleming", 0, 0, 0, 0, 0, "Action, Comedy, Thriller", 0, 0, "English, French, Mandarin", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ0MzQxODQ0MV5BMl5BanBnXkFtZTgwNTQ0NzY4NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-May-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "The In-Laws", 0, 0, "movie", 0, 0, 0, "Andrew Bergman (screenplay), Nat Mauldin (screenplay), Ed Solomon (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0314786.jpg", "tt0314786", "5.7", "13,559" },
                    { 382, 0, 0, "Renée Zellweger, Ewan McGregor, Sarah Paulson, David Hyde Pierce", 0, 0, "3 wins & 8 nominations.", 0, "null", 1, "USA, Germany", 0, "Peyton Reed", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjU1NjczNzYtYmFjOC00NzkxLTg4YTUtNGYzMTk3NTU0ZDE3XkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-May-03", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Down with Love", 0, 0, "movie", 0, 0, 0, "Eve Ahlert, Dennis Drake", 0, "data/Movie_Poster_Dataset/2003/tt0309530.jpg", "tt0309530", "6.3", "32,504" },
                    { 383, 0, 0, "Kate Winslet, Cleo King, Constance Jones, Kevin Spacey", 0, 0, "3 nominations.", 0, "205,747", 0, "USA, Germany, UK", 1, "Alan Parker", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, Spanish", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTFmMjM3M2UtOTIyZC00Zjk3LTkzODUtYTdhNGRmNzFhYzcyXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Feb-03", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Life of David Gale", 0, 0, "movie", 0, 0, 0, "Charles Randolph", 0, "data/Movie_Poster_Dataset/2003/tt0289992.jpg", "tt0289992", "7.5", "85,970" },
                    { 384, 0, 1, "Paul Walker, Frances O'Connor, Gerard Butler, Billy Connolly", 1, 0, "N/A", 0, "549,289", 0, "USA", 0, "Richard Donner", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English, French", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUyMTA4NDYzMV5BMl5BanBnXkFtZTcwMjk5MzcxMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Nov-03", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Timeline", 0, 0, "movie", 0, 0, 0, "Michael Crichton (novel), Jeff Maguire (screenplay), George Nolfi (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0300556.jpg", "tt0300556", "5.6", "52,141" },
                    { 385, 0, 0, "Jim Moret, Stuart Luce, Mary Gross, Marty Belafsky", 0, 0, "Nominated for 1 Oscar. Another 14 wins & 24 nominations.", 0, "null", 1, "USA", 0, "Christopher Guest", 0, 0, 0, 0, 0, "Comedy, Music", 0, 0, "English", 0, "81", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE2NjEyMDg0M15BMl5BanBnXkFtZTcwODYyODg5Mg@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-May-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Mighty Wind", 0, 0, "movie", 0, 0, 0, "Christopher Guest, Eugene Levy", 0, "data/Movie_Poster_Dataset/2003/tt0310281.jpg", "tt0310281", "7.3", "22,131" },
                    { 386, 0, 0, "LL Cool J, Gabrielle Union, Duane Martin, Essence Atkins", 0, 0, "4 wins & 12 nominations.", 0, "17,334,912", 1, "USA", 0, "Gary Hardwick", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmNjZWI3NzktYWI1Mi00OTAyLWJkNTYtMzUwYTFlZDA0Y2UwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Feb-03", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Deliver Us from Eva", 0, 0, "movie", 0, 0, 0, "James Iver Mattson (story), B.E. Brauner (story), James Iver Mattson (screenplay), B.E. Brauner (screenplay), Gary Hardwick (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0301181.jpg", "tt0301181", "6.1", "4,472" },
                    { 387, 0, 0, "Sean Penn, Naomi Watts, Danny Huston, Carly Nahon", 0, 0, "Nominated for 2 Oscars. Another 26 wins & 66 nominations.", 0, "1,529,028", 0, "USA", 0, "Alejandro González Iñárritu", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Jan-04", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "21 Grams", 0, 0, "movie", 0, 0, 0, "Guillermo Arriaga", 0, "data/Movie_Poster_Dataset/2003/tt0315733.jpg", "tt0315733", "7.7", "185,028" },
                    { 388, 0, 0, "Gwyneth Paltrow, Christina Applegate, Mark Ruffalo, Candice Bergen", 0, 0, "1 nomination.", 0, "396,628", 1, "USA", 0, "Bruno Barreto", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmI1ODU5ZjMtNWUyNC00YzllLThjNzktODE1M2E4OTVmY2E5XkEyXkFqcGdeQXVyMTExNzQzMDE0._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Mar-03", "TRUE", 1, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "View from the Top", 0, 0, "movie", 0, 0, 0, "Eric Wald", 0, "data/Movie_Poster_Dataset/2003/tt0264150.jpg", "tt0264150", "5.2", "20,655" },
                    { 389, 0, 0, "Mark Aisbett, Ashton Kutcher, Jon Abrahams, Tara Reid", 0, 0, "4 nominations.", 0, "251,843", 1, "USA", 0, "David Zucker", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Aug-03", "TRUE", 1, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "My Boss's Daughter", 0, 0, "movie", 0, 0, 0, "David Dorfman", 0, "data/Movie_Poster_Dataset/2003/tt0270980.jpg", "tt0270980", "4.6", "23,421" },
                    { 390, 0, 0, "Jason Lee, Julia Stiles, Selma Blair, James Brolin", 0, 0, "N/A", 0, "87,054", 1, "USA", 0, "Chris Koch", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGRkZThmYzEtYjQxZC00OWEzLThjYjAtYzFkMjY0NGZkZWI4XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Jan-03", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Guy Thing", 0, 0, "movie", 0, 0, 0, "Greg Glienna (story), Greg Glienna (screenplay), Pete Schwaba (screenplay), Matt Tarses (screenplay), Bill Wrubel (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0295289.jpg", "tt0295289", "5.6", "13,850" },
                    { 392, 0, 0, "Desmond Harrington, Eliza Dushku, Emmanuelle Chriqui, Jeremy Sisto", 0, 0, "3 nominations.", 0, "656,153", 0, "USA, Germany", 0, "Rob Schmidt", 0, 0, 0, 0, 0, "Horror", 0, 1, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYwMTA4MzgyNF5BMl5BanBnXkFtZTgwMjEyMjE0MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-May-03", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Wrong Turn", 0, 0, "movie", 0, 0, 0, "Alan B. McElroy", 0, "data/Movie_Poster_Dataset/2003/tt0295700.jpg", "tt0295700", "6.1", "85,042" },
                    { 393, 0, 0, "Mandy Moore, Allison Janney, Trent Ford, Alexandra Holden", 0, 0, "N/A", 0, "61,305", 1, "USA", 0, "Clare Kilner", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ5NjQ0NDI3NF5BMl5BanBnXkFtZTcwNDI0MjEzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Jul-03", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "How to Deal", 0, 0, "movie", 0, 0, 0, "Sarah Dessen (novels), Neena Beber (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0319524.jpg", "tt0319524", "5.7", "8,112" },
                    { 394, 0, 0, "Jennifer Connelly, Ben Kingsley, Ron Eldard, Frances Fisher", 0, 0, "Nominated for 3 Oscars. Another 12 wins & 34 nominations.", 0, "13,005,485", 0, "USA", 0, "Vadim Perelman", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Persian", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDMxOGZhNWYtMzRlYy00Mzk5LWJjMjEtNmQ4NDU4M2QxM2UzXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Jan-04", "TRUE", 0, "126 min", 0, 0, 0, 0, 0, 0, 0, 0, "House of Sand and Fog", 0, 0, "movie", 0, 0, 0, "Andre Dubus III (novel), Vadim Perelman (screenplay), Shawn Lawrence Otto (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0315983.jpg", "tt0315983", "7.6", "55,794" },
                    { 395, 0, 0, "Donzaleigh Abernathy, Mark Aldrich, George Allen, Keith Allison", 0, 0, "1 win & 2 nominations.", 0, "12,870,569", 0, "USA", 0, "Ron Maxwell", 0, 1, 0, 0, 0, "Drama, History, War", 1, 0, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGNiNmU2YTMtZmU4OS00MjM0LTlmYWUtMjVlYjAzYjE2N2RjXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Feb-03", "TRUE", 0, "219 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gods and Generals", 0, 0, "movie", 0, 1, 0, "Jeff Shaara (book), Ron Maxwell (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0279111.jpg", "tt0279111", "6.3", "13,005" },
                    { 396, 0, 0, "Sid Haig, William Bassett, Karen Black, Erin Daniels", 0, 0, "3 wins & 5 nominations.", 0, "268,127", 0, "USA", 0, "Rob Zombie", 0, 0, 0, 0, 0, "Horror", 0, 1, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM1ODIwNzM5OV5BMl5BanBnXkFtZTcwNjk5MDkyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Apr-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "House of 1000 Corpses", 0, 0, "movie", 0, 0, 0, "Rob Zombie", 0, "data/Movie_Poster_Dataset/2003/tt0251736.jpg", "tt0251736", "6", "59,384" },
                    { 397, 0, 0, "Edward Burns, Rachel Weisz, Morris Chestnut, Leland Orser", 0, 0, "N/A", 0, "104,242", 0, "USA, Canada, Germany", 1, "James Foley", 0, 0, 0, 0, 0, "Crime, Thriller", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODZmYjMwNzEtNzVhNC00ZTRmLTk2M2UtNzE1MTQ2ZDAxNjc2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Apr-03", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Confidence", 0, 0, "movie", 0, 0, 0, "Doug Jung", 0, "data/Movie_Poster_Dataset/2003/tt0310910.jpg", "tt0310910", "6.7", "30,366" },
                    { 398, 0, 0, "Colin Firth, Scarlett Johansson, Tom Wilkinson, Judy Parfitt", 0, 0, "Nominated for 3 Oscars. Another 17 wins & 41 nominations.", 1, "11,634,362", 0, "UK, Luxembourg", 0, "Peter Webber", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc3MjkzMDkxN15BMl5BanBnXkFtZTcwODAyMTU1MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Jan-04", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Girl with a Pearl Earring", 0, 0, "movie", 0, 0, 0, "Tracy Chevalier (novel), Olivia Hetreed (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0335119.jpg", "tt0335119", "7", "58,711" },
                    { 399, 0, 1, "Jonathan Cherry, Tyron Leitso, Clint Howard, Ona Grauer", 0, 0, "2 wins.", 0, "null", 0, "Germany, Canada, USA", 0, "Uwe Boll", 0, 0, 0, 0, 0, "Action, Horror", 0, 1, "English", 0, "15", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE0MTY2MDI3NV5BMl5BanBnXkFtZTcwNTc1MzEzMQ@@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Oct-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "House of the Dead", 0, 0, "movie", 0, 0, 0, "Mark A. Altman (story), Dan Bates (story), Dave Parker (screenplay), Mark A. Altman (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0317676.jpg", "tt0317676", "2", "31,640" },
                    { 400, 0, 0, "Charlotte Rampling, Ludivine Sagnier, Charles Dance, Jean-Marie Lamour", 0, 0, "2 wins & 18 nominations.", 0, "50,726", 0, "France, UK", 1, "François Ozon", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, French", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Aug-03", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 1, "Swimming Pool", 0, 0, "movie", 0, 0, 0, "François Ozon (screenplay), Emmanuèle Bernheim, Sionann O'Neill (translation: English)", 0, "data/Movie_Poster_Dataset/2003/tt0324133.jpg", "tt0324133", "6.8", "34,453" },
                    { 401, 0, 0, "Ben Stiller, Drew Barrymore, Eileen Essell, Harvey Fierstein", 0, 0, "1 nomination.", 0, "493,046", 1, "USA, Germany", 0, "Danny DeVito", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDI5ZWJhOWItYTlhOC00YWNhLTlkNzctNDU5YTI1M2E1MWZhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Sep-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Duplex", 0, 0, "movie", 0, 0, 0, "Larry Doyle", 0, "data/Movie_Poster_Dataset/2003/tt0266489.jpg", "tt0266489", "5.8", "45,091" },
                    { 402, 0, 0, "Kate Hudson, Jean-Marie Lhomme, Naomi Watts, Esmée Buchet-Deàk", 0, 0, "2 wins.", 0, "66,323", 1, "USA", 0, "James Ivory", 0, 1, 0, 0, 0, "Drama, Romance, Comedy", 0, 0, "English, French", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmFiYmJmN2QtNWQwMi00MzliLThiOWMtZjQxNGRhZTQ1MjgyXkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-Aug-03", "TRUE", 1, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Le divorce", 0, 0, "movie", 0, 0, 0, "Diane Johnson (novel), Ruth Prawer Jhabvala (screenplay), James Ivory (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0306734.jpg", "tt0306734", "4.9", "9,581" },
                    { 403, 0, 0, "William H. Macy, Alec Baldwin, Maria Bello, Shawn Hatosy", 0, 0, "Nominated for 1 Oscar. Another 9 wins & 25 nominations.", 0, "null", 0, "USA", 1, "Wayne Kramer", 0, 1, 0, 0, 1, "Crime, Drama, Fantasy", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmViZTY1OWEtMTQxMy00OGQ5LTgzZjAtYTQzOTYxNjliYTI4XkEyXkFqcGdeQXVyNjkxOTM4ODY@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Jan-04", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Cooler", 0, 0, "movie", 0, 0, 0, "Frank Hannah, Wayne Kramer", 0, "data/Movie_Poster_Dataset/2003/tt0318374.jpg", "tt0318374", "7", "28,412" },
                    { 404, 0, 0, "Tupac Shakur, Rappin' 4-Tay, Conrad Bain, Bill Bellamy", 0, 0, "Nominated for 1 Oscar. Another 1 win & 5 nominations.", 1, "7,707,563", 0, "USA", 0, "Lauren Lazin", 1, 0, 0, 0, 0, "Documentary, Biography, Music", 0, 0, "English", 0, "66", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGYxOTRlM2MtNWRjZS00NDk2LWExM2EtMDFiYTgyMGJkZGYyXkEyXkFqcGdeQXVyMTA1NTM1NDI2._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Nov-03", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tupac: Resurrection", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0343121.jpg", "tt0343121", "8", "7,539" },
                    { 405, 0, 1, "Heath Ledger, Shannyn Sossamon, Benno Fürmann, Mark Addy", 0, 0, "N/A", 0, "7,659,747", 0, "USA, Germany", 0, "Brian Helgeland", 0, 0, 0, 0, 0, "Action, Mystery, Thriller", 0, 0, "English, Syriac, Aramaic, Italian, Latin", 0, "21", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE0NDk2NjgwMV5BMl5BanBnXkFtZTYwMTgyMzA3._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Sep-03", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Order", 0, 0, "movie", 0, 0, 0, "Brian Helgeland", 0, "data/Movie_Poster_Dataset/2003/tt0304711.jpg", "tt0304711", "5.1", "14,762" },
                    { 406, 0, 0, "Michael Douglas, Kirk Douglas, Rory Culkin, Cameron Douglas", 0, 0, "N/A", 0, "7,375,836", 1, "USA", 0, "Fred Schepisi", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English, Hebrew, Spanish", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODEyYmQxZjUtZGQ0NS00ZTAwLTkwOGQtNGY2NzEwMWE0MDc3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Apr-03", "TRUE", 1, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "It Runs in the Family", 0, 0, "movie", 0, 0, 0, "Jesse Wigutow", 0, "data/Movie_Poster_Dataset/2003/tt0311110.jpg", "tt0311110", "5.6", "3,934" },
                    { 407, 0, 0, "Béatrice Bonifassi, Lina Boudreau, Michèle Caucheteux, Jean-Claude Donda", 0, 1, "Nominated for 2 Oscars. Another 19 wins & 29 nominations.", 0, "7,002,255", 1, "France, Belgium, Canada, UK, Latvia", 0, "Sylvain Chomet", 0, 1, 0, 0, 0, "Animation, Comedy, Drama", 0, 0, "French, Portuguese", 0, "91", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmVjNDIxODAtNWZiZi00ZDBlLWJmOTUtNDNjMGExNTViMzE1XkEyXkFqcGdeQXVyNTE0MDc0NTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Feb-04", "TRUE", 0, "78 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Triplets of Belleville", 0, 0, "movie", 0, 0, 0, "Sylvain Chomet", 0, "data/Movie_Poster_Dataset/2003/tt0286244.jpg", "tt0286244", "7.8", "41,337" },
                    { 408, 0, 0, "Crispin Glover, R. Lee Ermey, Laura Harring, Jackie Burroughs", 0, 0, "1 win & 4 nominations.", 0, "107,689", 0, "Canada, USA", 0, "Glen Morgan", 0, 1, 0, 0, 0, "Drama, Horror, Sci-Fi", 0, 1, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2U0NTcxOTktN2MwZS00N2Q2LWJlYWItMTg0NWIyMDIxNzU5L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Mar-03", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Willard", 0, 0, "movie", 0, 0, 0, "Glen Morgan (screenplay), Gilbert Ralston, Stephen Gilbert (book)", 0, "data/Movie_Poster_Dataset/2003/tt0310357.jpg", "tt0310357", "6.1", "14,958" },
                    { 409, 0, 0, "Roselyn Sanchez, Sofía Vergara, Jaci Velasquez, Eduardo Verástegui", 0, 0, "1 nomination.", 0, "6,126,237", 1, "USA", 0, "Linda Mendoza", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Spanish", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNGYyZGM5MGMtYTY2Ni00M2Y1LWIzNjQtYWUzM2VlNGVhMDNhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "16-Apr-03", "TRUE", 1, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chasing Papi", 0, 0, "movie", 0, 0, 0, "Laura Angelica Simon (story), Steve Antin (story), Laura Angelica Simon (screenplay), Steve Antin (screenplay), Alison Balian (screenplay), Elizabeth Sarnoff (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0323572.jpg", "tt0323572", "4.8", "3,367" },
                    { 410, 0, 0, "Ben Affleck, Terry Camilleri, David Backus, Lenny Venito", 0, 0, "7 wins & 8 nominations.", 0, "50,385", 1, "USA", 1, "Martin Brest", 0, 0, 0, 0, 0, "Comedy, Crime, Romance", 0, 0, "English", 0, "18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmU3NzIyODctYjVhOC00NzBmLTlhNWItMzBlODEwZTlmMjUzXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Aug-03", "TRUE", 1, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gigli", 0, 0, "movie", 0, 0, 0, "Martin Brest", 0, "data/Movie_Poster_Dataset/2003/tt0299930.jpg", "tt0299930", "2.4", "41,182" },
                    { 411, 0, 0, "Chris Ambrose, Joey Krajcar, Josh Hutcherson, Cameron Carter", 0, 0, "Nominated for 1 Oscar. Another 31 wins & 46 nominations.", 1, "null", 1, "USA", 0, "Shari Springer Berman, Robert Pulcini", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English", 0, "90", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5OTU0OTc2NV5BMl5BanBnXkFtZTcwMzU4MDcyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Sep-03", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Splendor", 0, 0, "movie", 0, 0, 0, "Harvey Pekar (comic book series American Splendor), Joyce Brabner (comic book series Our Cancer Year), Shari Springer Berman, Robert Pulcini", 0, "data/Movie_Poster_Dataset/2003/tt0305206.jpg", "tt0305206", "7.5", "41,338" },
                    { 412, 0, 0, "Joseph Fiennes, Alfred Molina, Jonathan Firth, Claire Cox", 0, 0, "4 wins & 1 nomination.", 1, "8,330,360", 0, "Germany, USA", 0, "Eric Till", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English, Latin", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjM2NTYxMTE3OV5BMl5BanBnXkFtZTgwNDgwNjgwMzE@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Sep-03", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Luther", 0, 0, "movie", 0, 0, 0, "Camille Thomasson, Bart Gavigan", 0, "data/Movie_Poster_Dataset/2003/tt0309820.jpg", "tt0309820", "6.6", "12,559" },
                    { 413, 0, 0, "Peter Dinklage, Paul Benjamin, Jase Blankfort, Paula Garcés", 0, 0, "Won 1 BAFTA Film Award. Another 28 wins & 31 nominations.", 0, "null", 1, "USA", 0, "Tom McCarthy", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Spanish", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkwNTg2MTI1NF5BMl5BanBnXkFtZTcwMDM1MzUyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Dec-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Station Agent", 0, 0, "movie", 0, 0, 0, "Tom McCarthy", 0, "data/Movie_Poster_Dataset/2003/tt0340377.jpg", "tt0340377", "7.7", "56,611" },
                    { 414, 0, 0, "Anthony Hopkins, Nicole Kidman, Ed Harris, Gary Sinise", 0, 0, "3 wins & 5 nominations.", 0, "705,018", 0, "USA, Germany, France", 0, "Robert Benton", 0, 1, 0, 0, 0, "Drama, Romance, Thriller", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA2MzM4NjkyMF5BMl5BanBnXkFtZTYwMTQ2ODc5._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Oct-03", "TRUE", 1, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Human Stain", 0, 0, "movie", 0, 0, 0, "Philip Roth (novel), Nicholas Meyer (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0308383.jpg", "tt0308383", "6.3", "25,129" },
                    { 415, 0, 0, "Mike Vogel, Vince Vieluf, Adam Brody, Joey Kern", 1, 0, "N/A", 0, "5,111,630", 1, "USA", 0, "Casey La Scala", 0, 0, 0, 0, 0, "Adventure, Comedy, Sport", 0, 0, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjZlZDlkYTktMmU1My00ZDBiLWFlNjEtYTBhNjVhOTM4ZjJjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Aug-03", "TRUE", 0, "105 min", 0, 0, 1, 0, 0, 0, 0, 0, "Grind", 0, 0, "movie", 0, 0, 0, "Ralph Sall", 0, "data/Movie_Poster_Dataset/2003/tt0338077.jpg", "tt0338077", "6", "10,210" },
                    { 416, 0, 0, "Kelly Clarkson, Justin Guarini, Katherine Bailess, Anika Noni Rose", 0, 0, "2 wins & 11 nominations.", 0, "4,922,166", 1, "USA", 0, "Robert Iscove", 0, 0, 0, 0, 0, "Comedy, Musical, Romance", 0, 0, "English", 0, "14", 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZjk3YThkNDktNjZjMS00MTBiLTllNTAtYzkzMTU0N2QwYjJjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Jun-03", "TRUE", 1, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "From Justin to Kelly", 0, 0, "movie", 0, 0, 0, "Kim Fuller", 0, "data/Movie_Poster_Dataset/2003/tt0339034.jpg", "tt0339034", "2.1", "23,465" },
                    { 417, 0, 0, "Jennifer Jason Leigh, Meg Ryan, Michael Nuccio, Allison Nega", 0, 0, "1 win & 2 nominations.", 0, "239,152", 0, "Australia, USA, UK", 0, "Jane Campion", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "46", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDVkYWMxNWEtNjc2MC00OGI5LWI3NmUtYWUwNDQyOTc3YmY5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Oct-03", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 1, "In the Cut", 0, 0, "movie", 0, 0, 0, "Jane Campion (screenplay), Susanna Moore (screenplay), Susanna Moore (novel), Stavros Kazantzidis (additional writer)", 0, "data/Movie_Poster_Dataset/2003/tt0199626.jpg", "tt0199626", "5.3", "18,376" },
                    { 418, 0, 0, "Nikki Reed, Evan Rachel Wood, Vanessa Hudgens, Holly Hunter", 0, 0, "Nominated for 1 Oscar. Another 14 wins & 45 nominations.", 1, "null", 0, "USA", 0, "Catherine Hardwicke", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English, Spanish, Portuguese", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmE1MDk4OWEtYjk1NS00MWU2LTk5ZWItYjZhYmRkODRjMDc0XkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-03", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Thirteen", 0, 0, "movie", 0, 0, 0, "Catherine Hardwicke, Nikki Reed", 0, "data/Movie_Poster_Dataset/2003/tt0328538.jpg", "tt0328538", "6.9", "66,716" },
                    { 419, 0, 0, "Angelina Jolie, Clive Owen, Teri Polo, Linus Roache", 1, 0, "2 nominations.", 0, "66,237", 0, "USA, Germany", 0, "Martin Campbell", 0, 1, 0, 0, 0, "Adventure, Drama, Romance", 0, 0, "English, Amharic, Khmer, German, Chechen", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmMzOWNhNTYtYmY0My00OGJiLWIzNDUtZWRhNGY0NWFjNzFmXkEyXkFqcGdeQXVyNjUxMDQ0MTg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Oct-03", "TRUE", 1, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Beyond Borders", 0, 0, "movie", 0, 0, 0, "Caspian Tredwell-Owen", 0, "data/Movie_Poster_Dataset/2003/tt0294357.jpg", "tt0294357", "6.5", "22,149" },
                    { 420, 0, 0, "Robert McNamara", 0, 0, "Won 1 Oscar. Another 11 wins & 14 nominations.", 1, "4,193,943", 0, "USA", 0, "Errol Morris", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "English", 0, "87", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTg3Yjc4N2QtZDdlNC00NmU2LWFiYjktYjI3NTMwMjk4M2FmXkEyXkFqcGdeQXVyMjgyNjk3MzE@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Mar-04", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Fog of War: Eleven Lessons from the Life of Robert S. McNamara", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0317910.jpg", "tt0317910", "8.2", "18,946" },
                    { 421, 0, 0, "Christopher Plummer, Henry Ian Cusick, Stuart Bunce, Daniel Kash", 0, 0, "1 win & 3 nominations.", 1, "4,068,087", 0, "Canada, UK", 0, "Philip Saville", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE3ZDA5ZmUtYTk1ZS00NmZmLWJhNTItYjIwZjUwN2RjNzIyXkEyXkFqcGdeQXVyMTkzODUwNzk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Nov-03", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Visual Bible: The Gospel of John", 0, 0, "movie", 0, 0, 0, "John Goldsmith (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0377992.jpg", "tt0377992", "7.7", "2,074" },
                    { 422, 0, 0, "Benjamin Fletcher, Nicole Frilot, Roxanne Frilot, David Ingber", 0, 0, "3 nominations.", 0, "308,603", 0, "USA", 0, "Rick de Oliveira", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIxNDU2Njk0OV5BMl5BanBnXkFtZTgwODc3Njc3NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Apr-03", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Real Cancun", 0, 0, "movie", 0, 0, 0, "Brian Caldirola", 0, "data/Movie_Poster_Dataset/2003/tt0360916.jpg", "tt0360916", "2.7", "3,598" },
                    { 424, 0, 0, "Robert August, Rochelle Ballard, Shawn Barron, Layne Beachley", 0, 0, "1 nomination.", 0, "3,672,451", 0, "USA", 0, "Dana Brown", 1, 0, 0, 0, 0, "Documentary, Sport", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTk2MjcxNjMzN15BMl5BanBnXkFtZTgwMTE3OTEwNjE@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG", 0, 0, "29-Aug-03", "TRUE", 0, "88 min", 0, 0, 1, 0, 0, 0, 0, 0, "Step Into Liquid", 0, 0, "movie", 0, 0, 0, "Dana Brown", 0, "data/Movie_Poster_Dataset/2003/tt0308508.jpg", "tt0308508", "7.5", "2,296" },
                    { 425, 0, 0, "Rémy Girard, Stéphane Rousseau, Marie-Josée Croze, Marina Hands", 0, 0, "Won 1 Oscar. Another 47 wins & 31 nominations.", 0, "9,499", 1, "Canada, France", 1, "Denys Arcand", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "French, English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGY5NWIxMjAtODBjNC00MmZhLTk1ZTAtNGRhYThlOTNjMTQwXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Mar-04", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Barbarian Invasions", 0, 0, "movie", 0, 0, 0, "Denys Arcand", 0, "data/Movie_Poster_Dataset/2003/tt0338135.jpg", "tt0338135", "7.7", "24,619" },
                    { 426, 0, 0, "Woody Allen, Jason Biggs, Fisher Stevens, Anthony Arkin", 0, 0, "N/A", 0, "null", 1, "USA, France, UK", 0, "Woody Allen", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2QzMTIxNjItNGQyNy00MjQzLWJiYTItMzIyZjdkYjYyYjRlXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-03", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Anything Else", 0, 0, "movie", 0, 0, 0, "Woody Allen", 0, "data/Movie_Poster_Dataset/2003/tt0313792.jpg", "tt0313792", "6.4", "24,539" },
                    { 427, 0, 0, "Luke Kirby, Ginette Reno, Paul Sorvino, Mary Walsh", 0, 0, "14 nominations.", 0, "305,428", 1, "Canada", 0, "Émile Gaudreault", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Italian, French", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2Y2OWU4MWMtNmIyMy00YzMyLWI0Y2ItMTcyZDc3MTdmZDU4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-03", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mambo Italiano", 0, 0, "movie", 0, 0, 0, "Steve Galluccio (play), Steve Galluccio (screenplay), Émile Gaudreault (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0330602.jpg", "tt0330602", "6.8", "5,403" },
                    { 428, 0, 0, "Arnold Friedman, Elaine Friedman, David Friedman, Seth Friedman", 0, 0, "Nominated for 1 Oscar. Another 25 wins & 12 nominations.", 1, "null", 0, "USA", 0, "Andrew Jarecki", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "90", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWRiYjQyOGItNzQ1Mi00MGI1LWE3NjItNTg1ZDQwNjUwNDM2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "18-Jul-03", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Capturing the Friedmans", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0342172.jpg", "tt0342172", "7.8", "18,441" },
                    { 429, 0, 0, "Omar Sharif, Pierre Boulanger, Gilbert Melki, Isabelle Renauld", 0, 0, "Nominated for 1 Golden Globe. Another 5 wins & 5 nominations.", 0, "2,823,837", 1, "France", 0, "François Dupeyron", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "French, Turkish", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWE4OTNiM2ItMjY4Ni00ZTViLWFiZmEtZGEyNGY2ZmNlMzIyXkEyXkFqcGdeQXVyMDU5NDcxNw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Apr-04", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monsieur Ibrahim", 0, 0, "movie", 0, 0, 0, "François Dupeyron, Eric-Emmanuel Schmitt (novel), Eric-Emmanuel Schmitt (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0329388.jpg", "tt0329388", "7.5", "9,278" },
                    { 430, 0, 0, "Edmund Bacon, Edwina Pattison Daniels, Balkrishna Doshi, Frank Gehry", 0, 0, "Nominated for 1 Oscar. Another 7 wins & 3 nominations.", 1, "2,748,981", 0, "USA", 0, "Nathaniel Kahn", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWIxNzM5YzQtY2FmMS00Yjc3LWI1ZjUtNGVjMjMzZTIxZTIxXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "12-Nov-03", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "My Architect", 0, 0, "movie", 0, 0, 0, "Nathaniel Kahn", 0, "data/Movie_Poster_Dataset/2003/tt0373175.jpg", "tt0373175", "7.4", "2,675" },
                    { 431, 0, 0, "Katie Holmes, Derek Luke, Oliver Platt, Alison Pill", 0, 0, "Nominated for 1 Oscar. Another 15 wins & 21 nominations.", 0, "2,360,184", 1, "USA", 0, "Peter Hedges", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Mandarin", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzZmMjAxNjQtZjQzOS00NjU4LWI0NDktZjlkZTgwNjVmNzU3XkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Nov-03", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pieces of April", 0, 0, "movie", 0, 0, 0, "Peter Hedges", 0, "data/Movie_Poster_Dataset/2003/tt0311648.jpg", "tt0311648", "7.1", "17,782" },
                    { 433, 0, 0, "Neve Campbell, Malcolm McDowell, James Franco, Barbara E. Robertson", 0, 0, "2 nominations.", 0, "12,525", 0, "Germany, USA", 0, "Robert Altman", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English", 0, "73", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTM3ZjA3NTctZThkYy00ODYyLTk2ZjItZmE0MmZlMTk3YjQwXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-May-04", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Company", 0, 0, "movie", 0, 0, 0, "Neve Campbell (story), Barbara Turner (story), Barbara Turner (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0335013.jpg", "tt0335013", "6.4", "5,493" },
                    { 434, 0, 0, "Eddie Griffin, Joe Howard, Matthew Brent, Robert Noble", 0, 0, "N/A", 0, "2,223,990", 1, "USA", 0, "George Gallo", 1, 0, 0, 0, 0, "Comedy, Documentary", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2Q2NDI1MjUtM2Q5ZS00MTFlLWJiYWEtNTZmNjQ3OGJkZDgxXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Apr-03", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "DysFunktional Family", 0, 0, "movie", 0, 0, 0, "Eddie Griffin (head writer)", 0, "data/Movie_Poster_Dataset/2003/tt0337996.jpg", "tt0337996", "6.6", "753" },
                    { 435, 0, 0, "Hayden Christensen, Peter Sarsgaard, Chloë Sevigny, Rosario Dawson", 0, 0, "Nominated for 1 Golden Globe. Another 11 wins & 27 nominations.", 0, "null", 0, "USA, Canada", 0, "Billy Ray", 0, 1, 0, 0, 0, "Drama, History", 1, 0, "English", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjYyODExMDctZjgwYy00ZjQwLWI4OWYtOGFlYjA4ZjEzNmY1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Nov-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shattered Glass", 0, 0, "movie", 0, 0, 0, "Buzz Bissinger (article), Billy Ray", 0, "data/Movie_Poster_Dataset/2003/tt0323944.jpg", "tt0323944", "7.2", "28,518" },
                    { 436, 0, 0, "Michel Côté, Patrick Huard, Catherine Florent, Albert Millaire", 0, 0, "1 nomination.", 0, "null", 0, "Canada", 0, "Éric Tessier", 0, 1, 0, 0, 0, "Drama, Horror, Thriller", 0, 1, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzE5MDM1NDktY2I0OC00YWI5LTk2NzUtYjczNDczOWQxYjM0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Mar-05", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Sur le seuil", 0, 0, "movie", 0, 0, 0, "Patrick Senécal (novel), Éric Tessier", 0, "data/Movie_Poster_Dataset/2003/tt0380732.jpg", "tt0380732", "6.6", "983" },
                    { 437, 0, 0, "Shah Rukh Khan, Preity Zinta, Saif Ali Khan, Jaya Bhaduri", 0, 0, "32 wins & 39 nominations.", 0, "null", 1, "India", 0, "Nikhil Advani", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "Hindi, Urdu, Gujarati, Panjabi", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY3OTI5NDczN15BMl5BanBnXkFtZTcwNDA0NDY3Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "28-Nov-03", "TRUE", 1, "186 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kal Ho Naa Ho", 0, 0, "movie", 0, 0, 0, "Niranjan Iyengar (dialogue), Karan Johar (screenplay), Karan Johar (story)", 0, "data/Movie_Poster_Dataset/2003/tt0347304.jpg", "tt0347304", "8", "40,804" },
                    { 438, 0, 1, "George Henare, Rawiri Paratene, Joe Folau, Alvin Fitisemanu", 1, 0, "1 win.", 0, "null", 0, "New Zealand", 0, "Steven Ramirez", 0, 0, 0, 1, 0, "Action, Adventure, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODA2MjU1NTI1MV5BMl5BanBnXkFtZTgwOTU4ODIwMjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "29-Aug-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Legend of Johnny Lingo", 0, 0, "movie", 0, 0, 0, "Riwia Brown (screenplay), John Garbett (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0367960.jpg", "tt0367960", "6.3", "579" },
                    { 440, 0, 0, "Lisa Kudrow, Damon Wayans, Richard Benjamin, Jane Krakowski", 0, 0, "N/A", 0, "1,646,664", 1, "USA", 0, "Richard Benjamin", 0, 0, 0, 0, 0, "Comedy, Music", 0, 0, "English", 0, "20", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzVjNzI4NzYtMjE4NS00M2IzLWFkOWMtOTYwMWUzN2ZlNGVjL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Aug-03", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Marci X", 0, 0, "movie", 0, 0, 0, "Paul Rudnick", 0, "data/Movie_Poster_Dataset/2003/tt0266747.jpg", "tt0266747", "2.7", "4,487" },
                    { 441, 0, 0, "Daniel Letterle, Joanna Chilcoat, Robin de Jesus, Steven Cutts", 0, 0, "6 nominations.", 0, "1,628,154", 1, "USA", 0, "Todd Graff", 0, 1, 0, 0, 0, "Comedy, Musical, Drama", 0, 0, "English, Spanish", 0, "55", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2ZiZTk1ODgtMTZkNS00NTYxLWIxZTUtNWExZGYwZTRjODViXkEyXkFqcGdeQXVyMTE2MzA3MDM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-Aug-03", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Camp", 0, 0, "movie", 0, 0, 0, "Todd Graff", 0, "data/Movie_Poster_Dataset/2003/tt0342167.jpg", "tt0342167", "6.4", "4,954" },
                    { 442, 0, 0, "Cate Blanchett, Gerard McSorley, Ciarán Hinds, Brenda Fricker", 0, 0, "Nominated for 1 Golden Globe. Another 3 wins & 13 nominations.", 1, "1,569,918", 0, "Ireland, UK, USA", 1, "Joel Schumacher", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGM4M2Q5N2MtNThkZS00NTc1LTk1NTItNWEyZjJjNDRmNDk5XkEyXkFqcGdeQXVyMjA0MDQ0Mjc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Oct-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Veronica Guerin", 0, 0, "movie", 0, 0, 0, "Carol Doyle (story), Carol Doyle (screenplay), Mary Agnes Donoghue (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0312549.jpg", "tt0312549", "6.9", "15,922" },
                    { 443, 0, 0, "James Woods, Nick Nolte, Douglas Sebern, Claire Forlani", 0, 0, "3 wins & 3 nominations.", 0, "1,420,578", 0, "USA", 0, "Michael Polish", 0, 1, 0, 0, 1, "Drama, Fantasy", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzMxZjUzOGQtOTFlOS00MzliLWJhNTUtOTgyNzYzMWQ2YzhmXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Aug-03", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Northfork", 0, 0, "movie", 0, 0, 0, "Mark Polish, Michael Polish", 0, "data/Movie_Poster_Dataset/2003/tt0322659.jpg", "tt0322659", "6.4", "4,851" },
                    { 444, 0, 0, "David Birkin, Alison Bruce, Amira Casar, Daniel Craig", 0, 0, "1 win.", 1, "12,583", 0, "UK", 0, "Christine Jeffs", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmYxOTA5YTEtNDY3Ni00YTE5LWE1MTgtYjc4ZWUxNWY3ZTkxXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Oct-03", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sylvia", 0, 0, "movie", 0, 0, 0, "John Brownlow (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0325055.jpg", "tt0325055", "6.3", "8,820" },
                    { 445, 0, 0, "Alex Frost, Eric Deulen, John Robinson, Elias McConnell", 0, 0, "8 wins & 11 nominations.", 0, "1,227,000", 0, "USA", 1, "Gus Van Sant", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, German", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTg0NmI1ZGQtZTUxNC00NTgxLThjMDUtZmRlYmEzM2MwOWYwXkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Nov-03", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 1, "Elephant", 0, 0, "movie", 0, 0, 0, "Gus Van Sant", 0, "data/Movie_Poster_Dataset/2003/tt0363589.jpg", "tt0363589", "7.2", "69,464" },
                    { 446, 0, 0, "Hrithik Roshan, Kareena Kapoor, Abhishek Bachchan, Johnny Lever", 0, 0, "3 nominations.", 0, "1,225,908", 0, "India", 0, "Sooraj R. Barjatya", 0, 1, 0, 0, 0, "Musical, Drama, Romance", 0, 0, "Hindi, English", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTViNzMxZjEtZGEwNy00MDNiLWIzNGQtZDY2MjQ1OWViZjFmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Jun-03", "TRUE", 1, "197 min", 0, 0, 0, 0, 0, 0, 0, 0, "Main Prem Ki Diwani Hoon", 0, 0, "movie", 0, 0, 0, "Sooraj R. Barjatya", 0, "data/Movie_Poster_Dataset/2003/tt0265148.jpg", "tt0265148", "4", "2,990" },
                    { 447, 0, 0, "Romola Garai, Sophie Stuckey, Bill Nighy, Helena Little", 0, 0, "2 wins & 4 nominations.", 0, "1,174,139", 0, "UK", 0, "Tim Fywell", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzJiZDRmOWUtYjE2MS00Mjc1LTg1ZDYtNTQxYWJkZTg1OTM4XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Aug-03", "TRUE", 1, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "I Capture the Castle", 0, 0, "movie", 0, 0, 0, "Dodie Smith (novel), Heidi Thomas (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0300015.jpg", "tt0300015", "7.1", "5,493" },
                    { 448, 0, 0, "Tai Anderson, Brad Avery, David Carr, Mark Lee", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Carl Diebold", 0, 0, 0, 0, 0, "Music", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzFhNWVmNWItNGM5OC00NjZhLTk3YTQtMjE1ODUyOThlMjNmL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "1-Apr-03", "TRUE", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, "Third Day Live in Concert: The Come Together Tour", 0, 0, "movie", 1, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0462044.jpg", "tt0462044", "7.9", "15" },
                    { 449, 0, 0, "Kirby Heyborne, Daryn Tufts, Will Swenson, Britani Bateman", 0, 0, "N/A", 0, "1,111,615", 1, "USA", 1, "Kurt Hale", 0, 0, 0, 1, 0, "Comedy, Crime, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNjAzNzJjYzQtMGFmNS00ZjAzLTkwMjgtMWIzYzFkMzM4Njg3XkEyXkFqcGdeQXVyMTY5Nzc4MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "31-Jan-03", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The R.M.", 0, 0, "movie", 0, 0, 0, "Kurt Hale, John E. Moyer", 0, "data/Movie_Poster_Dataset/2003/tt0341540.jpg", "tt0341540", "5.9", "636" },
                    { 450, 0, 0, "Amitabh Bachchan, Hema Malini, Aman Verma, Samir Soni", 0, 0, "2 wins & 20 nominations.", 0, "null", 0, "India", 0, "Ravi Chopra", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Hindi, Awadhi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDg1OGQ4YzgtM2Y2NS00NjA3LWFjYTctMDRlMDI3NWE1OTUyXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "3-Oct-03", "TRUE", 1, "181 min", 0, 0, 0, 0, 0, 0, 0, 0, "Baghban", 0, 0, "movie", 0, 0, 0, "Shafiq Ansari (screenplay), Satish Bhatnagar (screenplay), B.R. Chopra (story), Ram Govind (screenplay), Achala Nagar (dialogue), Achala Nagar (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0337578.jpg", "tt0337578", "7.5", "7,946" },
                    { 451, 0, 0, "Philip Seymour Hoffman, Minnie Driver, John Hurt, Maury Chaykin", 0, 0, "3 wins & 5 nominations.", 0, "1,011,054", 0, "Canada, UK", 1, "Richard Kwietniowski", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmVmODY1MzEtYTMwZC00MzNhLWFkNDMtZjAwM2EwODUxZTA5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Sep-03", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 1, "Owning Mahowny", 0, 0, "movie", 0, 0, 0, "Gary Stephen Ross (book), Maurice Chauvet (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0285861.jpg", "tt0285861", "7.2", "10,413" },
                    { 453, 0, 0, "Shah Rukh Khan, Rani Mukerji, Jas Arora, Satish Shah", 0, 0, "16 nominations.", 0, "null", 0, "India", 0, "Aziz Mirza", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODExZmE2ZWItYTIzOC00MzI1LTgyNTktMDBhNmFhY2Y4OTQ3XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Jun-03", "TRUE", 1, "167 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chalte Chalte", 0, 0, "movie", 0, 0, 0, "Aziz Mirza (story), Robin Bhatt (story), Aziz Mirza (screenplay), Robin Bhatt (screenplay), Pramod Sharma (dialogue), Ashish Kariya (dialogue), Rumi Jaffery (dialogue)", 0, "data/Movie_Poster_Dataset/2003/tt0346723.jpg", "tt0346723", "6.6", "10,919" },
                    { 454, 0, 0, "Michael Caine, Tilda Swinton, Jeremy Northam, Alan Bates", 0, 0, "4 wins.", 0, "763,044", 0, "Canada, France, UK", 0, "Norman Jewison", 0, 1, 0, 0, 0, "Thriller, Drama", 0, 0, "English, German, Italian, Latin, French", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTEwNjg2MjM2ODFeQTJeQWpwZ15BbWU4MDQ1MDU5OTEx._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Feb-04", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Statement", 0, 0, "movie", 0, 0, 0, "Ronald Harwood (screenplay), Brian Moore (novel)", 0, "data/Movie_Poster_Dataset/2003/tt0340376.jpg", "tt0340376", "6.2", "4,179" },
                    { 455, 0, 0, "Gary Sweet, Helen Buday, Bogdan Koca, Samantha Knigge", 0, 0, "3 wins & 18 nominations.", 0, "210,316", 0, "Australia", 0, "Rolf de Heer", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English", 0, "62", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGRjZjQ0NzAtYmZlNS00Zjc1LTk1YWItMDY5YzQxMzA4MTAzXkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "8-May-03", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 1, "Alexandra's Project", 0, 0, "movie", 1, 0, 0, "Rolf de Heer", 0, "data/Movie_Poster_Dataset/2003/tt0338706.jpg", "tt0338706", "6.6", "4,230" },
                    { 456, 0, 0, "Seth Green, Macaulay Culkin, Diana Scarwid, Chloë Sevigny", 0, 0, "3 nominations.", 1, "296,665", 0, "USA, Netherlands", 1, "Fenton Bailey, Randy Barbato", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjhmMGMxZDYtMTkyNy00YWVmLTgyYmUtYTU3ZjcwNTBjN2I1XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Oct-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Party Monster", 0, 0, "movie", 0, 0, 0, "Fenton Bailey, Randy Barbato, James St. James (book)", 0, "data/Movie_Poster_Dataset/2003/tt0320244.jpg", "tt0320244", "6.3", "12,440" },
                    { 457, 0, 0, "Gretchen Mol, Paul Rudd, Rachel Weisz, Frederick Weller", 0, 0, "1 nomination.", 0, "732,241", 1, "USA, France, UK", 0, "Neil LaBute", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2EzZmFmMmItODY3Zi00NjdjLWE0MTYtZWQ3MGIyM2M4YjZhXkEyXkFqcGdeQXVyMzg2MzE2OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-May-03", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Shape of Things", 0, 0, "movie", 0, 0, 0, "Neil LaBute (play), Neil LaBute (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0308878.jpg", "tt0308878", "6.8", "9,524" },
                    { 458, 0, 0, "Rekha, Hrithik Roshan, Preity Zinta, Rakesh Roshan", 0, 0, "25 wins & 30 nominations.", 0, "null", 0, "India", 0, "Rakesh Roshan", 0, 1, 0, 0, 1, "Drama, Fantasy, Romance", 0, 0, "Hindi, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmVjNzZkZjQtYmM5ZC00M2I0LWJhNzktNDk3MGU1NWMxMjFjXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "8-Aug-03", "TRUE", 1, "171 min", 0, 0, 0, 0, 0, 0, 0, 0, "Koi... Mil Gaya", 0, 0, "movie", 0, 0, 0, "Rakesh Roshan (story), Rakesh Roshan (screenplay), Honey Irani (screenplay), Sachin Bhowmick (screenplay), Robin Bhatt (screenplay), Javed Siddiqui (dialogue)", 0, "data/Movie_Poster_Dataset/2003/tt0254481.jpg", "tt0254481", "7.1", "11,632" },
                    { 459, 0, 0, "Toni Collette, Gotaro Tsunashima, Matthew Dyktynski, Lynette Curran", 0, 0, "20 wins & 12 nominations.", 0, "5,860", 0, "Australia", 0, "Sue Brooks", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, Japanese", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWMxNDYzNmUtYjFmNC00MGM2LWFmNzMtODhlMGNkNDg5MjE5XkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Sep-03", "TRUE", 1, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Japanese Story", 0, 0, "movie", 0, 0, 0, "Alison Tilson", 0, "data/Movie_Poster_Dataset/2003/tt0304229.jpg", "tt0304229", "6.7", "5,516" },
                    { 461, 0, 0, "Sanjay Dutt, Ajay Devgn, Saif Ali Khan, Sunil Shetty", 0, 0, "3 wins & 10 nominations.", 0, "null", 0, "India", 0, "J.P. Dutta", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODFlYzU4YTItN2EwYi00ODI3LTkwNTQtMDdkNjM3YjMyMTgyXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "12-Dec-03", "TRUE", 0, "255 min", 0, 0, 0, 0, 0, 0, 0, 0, "LOC: Kargil", 0, 0, "movie", 0, 1, 0, "J.P. Dutta, O.P. Dutta (dialogue)", 0, "data/Movie_Poster_Dataset/2003/tt0347416.jpg", "tt0347416", "5.1", "1,693" },
                    { 462, 0, 0, "Jeff Foxworthy, Bill Engvall, Ron White, Larry the Cable Guy", 0, 0, "N/A", 0, "null", 1, "USA", 0, "C.B. Harding", 1, 0, 0, 0, 0, "Comedy, Documentary", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkyMTM2NDk5Nl5BMl5BanBnXkFtZTgwNzY1NzEyMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Mar-03", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blue Collar Comedy Tour: The Movie", 0, 0, "movie", 0, 0, 0, "Bill Engvall, Jeff Foxworthy, Larry the Cable Guy, Ron White", 0, "data/Movie_Poster_Dataset/2003/tt0330069.jpg", "tt0330069", "7.2", "3,789" },
                    { 464, 0, 0, "Paul Schneider, Zooey Deschanel, Shea Whigham, Danny McBride", 0, 0, "4 wins & 10 nominations.", 0, "548,712", 0, "USA", 0, "David Gordon Green", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmEwZGU2NzctYzlmNi00MGJkLWE3N2MtYjBlN2ZhMGJkZTZiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Aug-03", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "All the Real Girls", 0, 0, "movie", 0, 0, 0, "David Gordon Green (story), Paul Schneider (story), David Gordon Green", 0, "data/Movie_Poster_Dataset/2003/tt0299458.jpg", "tt0299458", "6.9", "9,108" },
                    { 465, 0, 0, "Bob Dylan, Jeff Bridges, Penélope Cruz, John Goodman", 0, 0, "N/A", 0, "533,344", 1, "USA, UK", 0, "Larry Charles", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "32", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg0NjUwMzg5NF5BMl5BanBnXkFtZTgwNDQ0NjcwMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Aug-03", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Masked and Anonymous", 0, 0, "movie", 0, 0, 0, "Bob Dylan, Larry Charles", 0, "data/Movie_Poster_Dataset/2003/tt0319829.jpg", "tt0319829", "5.5", "3,925" },
                    { 467, 0, 0, "Paul Bates, Brenda Blethyn, Brittany Bristow, Leif Bristow", 0, 0, "2 wins & 5 nominations.", 0, "null", 1, "USA, Canada", 0, "LeVar Burton", 0, 0, 0, 1, 0, "Comedy, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ0ODc4MDk4Nl5BMl5BanBnXkFtZTcwMTEzNzgzNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "24-Dec-03", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blizzard", 0, 0, "movie", 0, 0, 0, "Agnes Bristow (story), Leif Bristow (story), Murray McRae", 0, "data/Movie_Poster_Dataset/2003/tt0309372.jpg", "tt0309372", "5.7", "724" },
                    { 468, 0, 1, "Samy Naceri, Frédéric Diefenthal, Bernard Farcy, Bai Ling", 0, 0, "N/A", 0, "1,777,719", 1, "France", 0, "Gérard Krawczyk", 0, 0, 0, 0, 0, "Action, Comedy", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjQ5ODI1MjQtMDc0Zi00OGQ1LWE2NTYtMTg1YTkxM2E5NzFkXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "29-Jan-03", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Taxi 3", 0, 0, "movie", 0, 0, 0, "Luc Besson (scenario)", 0, "data/Movie_Poster_Dataset/2003/tt0295721.jpg", "tt0295721", "5.7", "30,567" },
                    { 469, 0, 0, "Angelina Peláez, Lizzie Curry Martinez, Vanessa Martinez, Amanda Álvarez", 0, 0, "1 nomination.", 0, "475,940", 0, "USA, Mexico", 0, "John Sayles", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Spanish", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODIxNjhkYjEtYzUyMi00YTNjLWE1YjktNjAyY2I2MWNkNmNmL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Jan-04", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Casa de los babys", 0, 0, "movie", 0, 0, 0, "John Sayles", 0, "data/Movie_Poster_Dataset/2003/tt0303830.jpg", "tt0303830", "6.5", "1,866" },
                    { 470, 0, 1, "Ryan Reynolds, Kristin Booth, Joris Jarsky, Sean Sullivan", 0, 0, "N/A", 0, "null", 1, "Canada", 1, "William Phillips", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzdmZTk4MTktZmExNi00OWEwLTgxZDctNTE4NWMwNjc1Nzg2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Oct-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Foolproof", 0, 0, "movie", 0, 0, 0, "William Phillips", 0, "data/Movie_Poster_Dataset/2003/tt0356614.jpg", "tt0356614", "6.5", "7,965" },
                    { 473, 0, 0, "Sarah Polley, Amanda Plummer, Scott Speedman, Leonor Watling", 0, 0, "16 wins & 15 nominations.", 0, "395,592", 0, "Spain, Canada", 0, "Isabel Coixet", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjA1MGVlMGItNzgxMC00OWY4LWI4YjEtNTNmYWIzMGUxOGQzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Mar-03", "TRUE", 1, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "My Life Without Me", 0, 0, "movie", 0, 0, 0, "Isabel Coixet, Nanci Kincaid (book)", 0, "data/Movie_Poster_Dataset/2003/tt0314412.jpg", "tt0314412", "7.6", "20,843" },
                    { 474, 0, 0, "N/A", 0, 1, "N/A", 0, "null", 1, "USA", 0, "N/A", 0, 0, 0, 0, 0, "Animation, Comedy", 0, 0, "English, Japanese, German", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ4MTA0NjEzMF5BMl5BanBnXkFtZTgwMDg4NDYxMzE@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jul-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Animation Show", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0372763.jpg", "tt0372763", "7.6", "469" },
                    { 476, 0, 0, "Robert Downey Jr., Robin Wright, Mel Gibson, Jeremy Northam", 0, 0, "1 win & 3 nominations.", 0, "336,456", 1, "USA", 1, "Keith Gordon", 0, 0, 0, 0, 0, "Comedy, Crime, Musical", 0, 0, "English", 0, "45", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjMyZmI5NmItY2JlMi00NzU3LWI5ZGItZjhkOTE0YjEyN2Q4XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Nov-03", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Singing Detective", 0, 0, "movie", 0, 0, 0, "Dennis Potter (screenplay), Dennis Potter (television series)", 0, "data/Movie_Poster_Dataset/2003/tt0314676.jpg", "tt0314676", "5.6", "6,997" },
                    { 477, 0, 0, "Charles Busch, Angela Paton, Jason Priestley, Natasha Lyonne", 0, 0, "4 wins & 2 nominations.", 0, "null", 1, "USA", 0, "Mark Rucker", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjhjODI2NTItMGE1ZS00NThiLWE1MmYtOWE3YzcyNzY1MTJlXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Oct-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Die, Mommie, Die!", 0, 0, "movie", 0, 0, 0, "Charles Busch (play), Charles Busch (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0322023.jpg", "tt0322023", "6.5", "1,762" },
                    { 478, 0, 1, "Heather Shrake, Courtney Cole-Fendley, Larry Bagby, Heather Elizabeth", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Mark Cross", 0, 0, 0, 0, 0, "Horror, Action, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODQ0NzY5NGEtYTc5NC00Yjg4LTg4Y2QtZjE2MTkyYTNmNmU2L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Trip", 0, 0, "movie", 0, 0, 0, "Mark Cross", 0, "data/Movie_Poster_Dataset/2003/tt0293961.jpg", "tt0293961", "2.8", "126" },
                    { 479, 0, 1, "Fardeen Khan, Kareena Kapoor, Amrish Puri, Amitabh Bachchan", 0, 0, "N/A", 0, "305,205", 0, "India", 0, "Surya S.J., Sunil Kumar Agrawal", 0, 1, 0, 0, 0, "Action, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDVhMTk1NjUtYjc0OS00OTE1LTk1NTYtYWMzMDI5OTlmYzU2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Feb-03", "TRUE", 1, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, "Khushi", 0, 0, "movie", 0, 0, 0, "Aman Jaffery (dialogue), Bolu Khan (dialogue), Surya S.J. (story)", 0, "data/Movie_Poster_Dataset/2003/tt0348656.jpg", "tt0348656", "4.5", "1,173" },
                    { 480, 0, 0, "Martin Doblmeier, Klaus Maria Brandauer, Adele Schmidt, Richard Mancini", 0, 0, "N/A", 1, "163,720", 0, "USA", 0, "Martin Doblmeier", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "English, German", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzM0MzE2ZTAtZTBjZS00MTk5LTg5OTEtNjNmYmQ5NzU2OTUyXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Jun-03", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bonhoeffer", 0, 0, "movie", 0, 0, 0, "Martin Doblmeier", 0, "data/Movie_Poster_Dataset/2003/tt0371583.jpg", "tt0371583", "7.2", "286" },
                    { 481, 0, 1, "Sunny Deol, Preity Zinta, Priyanka Chopra, Amrish Puri", 1, 0, "6 nominations.", 0, "269,194", 0, "India", 0, "Anil Sharma", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTA1MjA3M2EtMmJjZS00OWViLTkwMTEtM2E5ZDk0NTAyNGJiXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Apr-03", "TRUE", 0, "160 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hero: Love Story of a Spy", 0, 0, "movie", 0, 0, 0, "Shaktimaan Talwar", 0, "data/Movie_Poster_Dataset/2003/tt0347167.jpg", "tt0347167", "5.2", "1,288" },
                    { 482, 0, 0, "Shia LaBeouf, Elden Henson, Amy Smart, Billy Kay", 0, 0, "N/A", 0, "279,282", 1, "USA", 0, "Efram Potelle, Kyle Rankin", 0, 1, 0, 0, 0, "Drama, Romance, Comedy", 0, 0, "English, German", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzFhNTMwNDMtZjY3Yy00NzY3LWI1ZWQtZTQxMWJmODVhZWFkXkEyXkFqcGdeQXVyNjQzNDI3NzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Aug-03", "TRUE", 1, "79 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Battle of Shaker Heights", 0, 0, "movie", 0, 0, 0, "Erica Beeney", 0, "data/Movie_Poster_Dataset/2003/tt0357470.jpg", "tt0357470", "6.1", "3,746" },
                    { 483, 0, 0, "Adrián Suar, Leticia Brédice, Alfredo Casero, Jorge Marrale", 0, 0, "2 wins.", 0, "null", 0, "Argentina", 0, "Daniel Barone", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE5NTU3YWYtOWIxNi00YWZhLTg2NzktYzVjZWY5MDQ4NzVlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "12-Jun-03", "TRUE", 1, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "El día que me amen", 0, 0, "movie", 0, 0, 0, "Marcos Carnevale, Marcela Guerty, Adrián Suar (idea)", 0, "data/Movie_Poster_Dataset/2003/tt0362582.jpg", "tt0362582", "6.3", "225" },
                    { 484, 0, 0, "Cecilia Roth, Carlos Álvarez-Nóvoa, Kuno Becker, Margarita Isabel", 1, 0, "4 nominations.", 0, "267,495", 1, "Mexico, Spain", 1, "Antonio Serrano", 0, 0, 0, 0, 0, "Adventure, Comedy, Crime", 0, 0, "Spanish", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDE5ZjAwY2YtOWM5Yi00ZWNlLWE5ODQtYjA4NzA1NGFkZDU5XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Jul-03", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lucía, Lucía", 0, 0, "movie", 0, 0, 0, "Rosa Montero (novel), Antonio Serrano (screenplay), Marcela Fuentes-Berain (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0314170.jpg", "tt0314170", "6.2", "941" },
                    { 487, 0, 0, "Aishwarya Rai Bachchan, Abhishek Bachchan, Satish Shah, Suhasini Mulay", 0, 0, "1 win & 1 nomination.", 0, "null", 0, "India", 0, "Rohan Sippy", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTNjN2M2MzYtZGEwMi00Mzc5LWEwYTMtODM1ZmRiZjFiNTU0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "26-Aug-03", "TRUE", 1, "169 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kuch Naa Kaho", 0, 0, "movie", 0, 0, 0, "Rohena Gera (story), Naushil Mehta (dialogue), Nidhi Tuli (dialogue), Neeraj Vora (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0369637.jpg", "tt0369637", "5.5", "1,816" },
                    { 488, 0, 0, "Billy Bob Thornton, Morgan Freeman, Holly Hunter, Kirsten Dunst", 0, 0, "1 win.", 0, "209,151", 0, "USA, France", 1, "Ed Solomon", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjUyOGMyMTQtYTM5Yy00MjFiLTk2OGItMWYwMDc2YmM1YzhiXkEyXkFqcGdeQXVyMjA0MzYwMDY@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Aug-03", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Levity", 0, 0, "movie", 0, 0, 0, "Ed Solomon", 0, "data/Movie_Poster_Dataset/2003/tt0304328.jpg", "tt0304328", "6.5", "5,712" },
                    { 490, 0, 0, "Santino Majok Chuor, Jarrid Geduld, Peter Kon Dut", 0, 0, "3 wins & 3 nominations.", 0, "120,651", 0, "USA", 0, "Megan Mylan, Jon Shenk", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, Arabic, Dinka, Swahili", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGJmNmU5OTAtOTQyYy00MmM3LTk4MzUtMGFiZDYzODdmMmU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "24-Apr-03", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lost Boys of Sudan", 0, 0, "movie", 1, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0383475.jpg", "tt0383475", "7.6", "505" },
                    { 491, 0, 0, "Nathalie Baye, Benoît Magimel, Suzanne Flon, Bernard Le Coq", 0, 0, "2 nominations.", 0, "181,798", 0, "France", 0, "Claude Chabrol", 0, 1, 0, 0, 0, "Drama", 0, 0, "French", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDMyNGU0NjUtNTIxMC00ZmU2LWE0ZGItZTdkNGVlODI2ZDcyL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Feb-03", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Flower of Evil", 0, 0, "movie", 0, 0, 0, "Caroline Eliacheff (original scenario), Louise L. Lambrichs (original scenario), Claude Chabrol (adaptation)", 0, "data/Movie_Poster_Dataset/2003/tt0322289.jpg", "tt0322289", "6.6", "2,556" },
                    { 492, 0, 0, "David Keith, Mel Harris, Leighton Meester, Douglas Smith", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Rafal Zielinski", 0, 0, 0, 0, 0, "Horror, Mystery, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTE2MDM4MTMtZmNkZC00Y2QyLWE0YjUtMTAxZGJmODMxMDM0XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Sep-03", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "Hangman's Curse", 0, 0, "movie", 0, 0, 0, "Frank Peretti (novel), Kathy Mackel (screenplay), Stan Foster (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0342508.jpg", "tt0342508", "5", "2,098" },
                    { 493, 0, 0, "Alison Elliott, Leo Burmester, Lois Smith, Chad Lowe", 0, 0, "1 win.", 0, "null", 0, "USA", 0, "Chris Boebel", 0, 1, 0, 1, 0, "Drama, Family, Romance", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNzk2M2Y3MzYtNGMzMi00Y2FjLTkwODQtNmExYWU3ZWY3NzExXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "27-Mar-03", "TRUE", 1, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Red Betsy", 0, 0, "movie", 0, 0, 0, "Charles E. Boebel (story), Chris Boebel", 0, "data/Movie_Poster_Dataset/2003/tt0284426.jpg", "tt0284426", "7.2", "73" },
                    { 496, 0, 1, "Shawn Barron, Fred Basse, Layne Beachley, Ken Bradshaw", 1, 0, "N/A", 0, "54,000", 0, "USA", 0, "Philip Boston", 1, 0, 0, 0, 0, "Documentary, Action, Adventure", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNjRmZjcwZTQtYWY0ZS00ODAwLTg4YTktZDhlZDMwMTM1MGFkXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Mar-04", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Billabong Odyssey", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0379713.jpg", "tt0379713", "6.9", "441" },
                    { 499, 0, 0, "Jack Plotnick, Clinton Leupp, Jeffery Roberson, Ron Mathews", 0, 0, "5 wins.", 0, "147,235", 1, "USA", 0, "Richard Day", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjc1Yzc0ZmItMzU1OS00OWVlLThmYTctMWNlYmFlMjkxMzc0XkEyXkFqcGdeQXVyNTA1NjYyMDk@._V1_UY98_CR32,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Jul-06", "TRUE", 1, "79 min", 0, 0, 0, 0, 0, 0, 0, 0, "Girls Will Be Girls", 0, 0, "movie", 0, 0, 0, "Richard Day", 0, "data/Movie_Poster_Dataset/2003/tt0339071.jpg", "tt0339071", "6.9", "1,235" },
                    { 500, 0, 0, "Joe Brown, Eric Clapton, Jools Holland, Sam Brown", 0, 0, "1 win.", 0, "70,000", 0, "UK, USA", 0, "David Leland", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "82", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWFjMDNlYzItY2VlMS00ZTRkLWJjYTEtYjI5NmFlMGE3MzQ2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Mar-04", "TRUE", 0, "146 min", 0, 0, 0, 0, 0, 0, 0, 0, "Concert for George", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0380275.jpg", "tt0380275", "8.7", "1,425" },
                    { 501, 0, 0, "Sameera Reddy, Antara Mali, Sohail Khan, Saif Ali Khan", 1, 0, "2 nominations.", 0, "null", 0, "India", 0, "Prawaal Raman", 0, 0, 0, 0, 0, "Horror, Adventure", 0, 1, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDE0MjYxYmMtM2VhMC00MjhiLTg5NjItMDkzZGM5MGVlYjMxL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "25-Jul-03", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Darna Mana Hai", 0, 0, "movie", 0, 0, 0, "Atul Sabharwal, Rajnish Thakur, Abbas Tyrewala", 0, "data/Movie_Poster_Dataset/2003/tt0349333.jpg", "tt0349333", "6.3", "1,965" },
                    { 502, 0, 0, "Vikram Dasu, Purva Bedi, Deep Katdare, Chayton Arvin", 0, 0, "N/A", 0, "112,746", 1, "USA", 0, "Bala Rajasekharuni", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWQ0MGNjOTYtMWJlNi00YWMxLWFmMzktYjAyNTVkY2U1NWNhL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "29-Aug-03", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Green Card Fever", 0, 0, "movie", 0, 0, 0, "Bala Rajasekharuni", 0, "data/Movie_Poster_Dataset/2003/tt0292527.jpg", "tt0292527", "5.8", "171" },
                    { 503, 0, 0, "Ajay Devgn, Urmila Matondkar, Nana Patekar, Rekha", 0, 0, "10 wins & 11 nominations.", 0, "null", 0, "India", 0, "Ram Gopal Varma", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjkxOGM5OTktNTRmZi00MjhlLWE2MDktNzY3NjY3NmRjNDUyXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-May-03", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 1, "Bhoot", 0, 0, "movie", 0, 0, 0, "Lalit Marathe, Sameer Sharma", 0, "data/Movie_Poster_Dataset/2003/tt0341266.jpg", "tt0341266", "6.4", "2,268" },
                    { 505, 0, 0, "Galley Molina", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Steve Race", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2RmNTRjYzctODI4Ni00MzQyLWEyNTAtNjU0N2JkMTNhNjJkXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-May-03", "TRUE", 0, "77 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kings and Queens of Freestyle: Best of Stevie B", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0374803.jpg", "tt0374803", "N/A", "N/A" },
                    { 506, 0, 0, "Eishy Hayata, Lucho Velasco, Juan Pablo Shuk, John K. Anderson", 0, 0, "N/A", 0, "100,976", 0, "Colombia", 0, "Andrew Molina", 1, 1, 0, 0, 0, "Documentary, Drama", 0, 0, "English, Spanish, Japanese", 0, "21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDVlNTBjMjctNjAzNS00ZGJhLTg2NzMtNzIwYTIzYTBiMDkyXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Nov-04", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Emerald Cowboy", 0, 0, "movie", 0, 0, 0, "Eishy Hayata", 0, "data/Movie_Poster_Dataset/2003/tt0289176.jpg", "tt0289176", "7.1", "48" },
                    { 507, 0, 1, "Vivek Oberoi, Dia Mirza, Atul Kulkarni, Mukesh Rishi", 0, 0, "6 nominations.", 0, "101,000", 0, "India", 1, "Eeshwar Nivas", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjIwNGM1ZTUtOThjYS00NDdiLTk2ZDYtNGY5YjJkNzliM2JjL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "24-Jan-03", "TRUE", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, "Dum", 0, 0, "movie", 0, 0, 0, "Mehran (dialogue), Mehran (screenplay), Eeshwar Nivas (screenplay), Bunty Soorma (story)", 0, "data/Movie_Poster_Dataset/2003/tt0314006.jpg", "tt0314006", "5.5", "1,233" },
                    { 508, 0, 0, "Diwakar Pathak, Sunil Malhotra, Indravadan Tridevi, Arun Bakshi", 0, 0, "N/A", 0, "48,832", 1, "USA", 0, "Benny Mathews", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Hindi, English", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzJiOGI2MjctYjUyMS00ZjkzLWE2ZmUtOTg4NTZkOTNhZDc1L2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-May-04", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Where's the Party Yaar?", 0, 0, "movie", 0, 0, 0, "Benny Mathews, Soham Mehta, Sunil Thakkar", 0, "data/Movie_Poster_Dataset/2003/tt0306228.jpg", "tt0306228", "5.1", "958" },
                    { 509, 0, 0, "Adam Goldberg, Judy Greer, Andy Dick, Mario Van Peebles", 0, 0, "N/A", 0, "19,539", 1, "USA", 0, "Jonathan Kesselman", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English, Hebrew, Yiddish", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjUyMTc4MDExMV5BMl5BanBnXkFtZTgwNDg0NDIwMjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Mar-04", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hebrew Hammer", 0, 0, "movie", 0, 0, 0, "Jonathan Kesselman", 0, "data/Movie_Poster_Dataset/2003/tt0317640.jpg", "tt0317640", "6.2", "4,132" },
                    { 511, 0, 0, "Stefany Mathias, Eric Blais, Andrew Jackson, Peter Kent", 0, 0, "N/A", 0, "null", 0, "Canada", 0, "Eduardo Arnal", 0, 0, 0, 0, 0, "Short", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTE4NjYxMGEtZmQxZi00YWVmLWJjZTctYTJmNDFmZGEwNDVhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "N/A", "TRUE", 0, "30 min", 0, 1, 0, 0, 0, 0, 0, 0, "The Sea", 0, 0, "movie", 0, 0, 0, "Eduardo Arnal", 0, "data/Movie_Poster_Dataset/2003/tt0351708.jpg", "tt0351708", "7.9", "42" },
                    { 513, 0, 0, "Giovanna Antonelli, Luigi Baricelli, Ana Beatriz Cisneiros, Padre Marcelo Rossi", 0, 0, "N/A", 0, "4,167,807", 0, "Brazil", 0, "Moacyr Góes", 0, 1, 0, 0, 0, "Drama", 0, 0, "Portuguese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmFlOWMwMjAtMDMyMC00N2JjLTllODUtZjY3YWU3NGRkM2I2L2ltYWdlXkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Oct-03", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mary, Mother of the Son of God", 0, 0, "movie", 0, 0, 0, "Thiego Balteiro, Marta Borges, Moacyr Góes, Marco Ribas de Farias, Maria de Souza", 0, "data/Movie_Poster_Dataset/2003/tt0380531.jpg", "tt0380531", "4.3", "135" },
                    { 515, 0, 0, "John Livingston, Sabrina Lloyd, Bruno Campos, Rueben Grundy", 0, 0, "1 win & 1 nomination.", 0, "22,278", 1, "USA", 0, "Mark Decena", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzg2MWQ4MDEtOGZlNi00MTg0LWIwMjQtYWY5NTQwYmUzMWNmXkEyXkFqcGdeQXVyMzg2MzE2OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Jan-03", "TRUE", 1, "79 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dopamine", 0, 0, "movie", 0, 0, 0, "Timothy Breitbach, Mark Decena", 0, "data/Movie_Poster_Dataset/2003/tt0342300.jpg", "tt0342300", "5.9", "1,018" },
                    { 516, 0, 0, "Judith Ivey, Bill Raymond, Emily Grace, Jane Lincoln Taylor", 0, 0, "2 wins & 1 nomination.", 0, "null", 0, "USA", 1, "A. Dean Bell", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTEyMTQzMjQ0MTJeQTJeQWpwZ15BbWU4MDcyMjg4OTEx._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Jan-03", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "What Alice Found", 0, 0, "movie", 0, 0, 0, "A. Dean Bell", 0, "data/Movie_Poster_Dataset/2003/tt0343172.jpg", "tt0343172", "6.6", "868" },
                    { 517, 0, 0, "Urmila Matondkar, Manoj Bajpayee, Sanjay Suri, Sandali Sinha", 0, 0, "9 wins & 12 nominations.", 0, "null", 0, "India", 0, "Chandra Prakash Dwivedi", 0, 1, 0, 0, 0, "Drama", 0, 0, "Hindi, Urdu", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGUwZjliMTAtNzAxZi00MWNiLWE2NzgtZGUxMGQxZjhhNDRiXkEyXkFqcGdeQXVyNjU1NzU3MzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "188 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pinjar", 0, 0, "movie", 0, 0, 0, "Chandra Prakash Dwivedi (additional dialogue), Chandra Prakash Dwivedi (screenplay), Amrita Pritam (dialogue), Amrita Pritam (novel), Amrita Pritam (story)", 0, "data/Movie_Poster_Dataset/2003/tt0347779.jpg", "tt0347779", "8.1", "1,908" },
                    { 518, 0, 0, "Sheila Myjo, Anna Ruscigno, Troy Robert, Steven Janji", 0, 0, "N/A", 0, "null", 0, "USA", 1, "Derek Maki", 0, 0, 0, 0, 0, "Crime, Short", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmI0MTliMTAtMmJhNC00NTJmLTllMzQtMDI3NzA1ODMyZWI1XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR5,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "26-Jul-03", "TRUE", 0, "39 min", 0, 1, 0, 0, 0, 0, 0, 0, "Carnage & Deception: A Killer's Perfect Murder", 0, 0, "movie", 0, 0, 0, "Derek Maki", 0, "data/Movie_Poster_Dataset/2003/tt0373746.jpg", "tt0373746", "5.5", "35" },
                    { 519, 0, 0, "Randy Quaid, Will Rothhaar, Jennifer Wigmore, David Gallagher", 0, 0, "1 win & 1 nomination.", 0, "null", 1, "Germany, Canada", 0, "Stuart Gillard", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYWZmOTY0MDAtMGRlMS00YjFlLWFkZTUtYmJhYWNlN2JjMmZkXkEyXkFqcGdeQXVyODAzODU1NDQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Oct-04", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kart Racer", 0, 0, "movie", 0, 0, 0, "Nicholas DiBella", 0, "data/Movie_Poster_Dataset/2003/tt0300069.jpg", "tt0300069", "5.7", "479" },
                    { 520, 0, 0, "Tatyana Ali, Boti Bliss, Gable Carr, Patrick Cavanaugh", 0, 0, "N/A", 0, "null", 1, "USA", 1, "David Hillenbrand, Scott Hillenbrand", 0, 0, 0, 0, 0, "Comedy, Crime, Mystery", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGVmY2RjNDgtMTc3Yy00YmY0LTgwODItYzBjNWJhNTRlYjdkXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Aug-04", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "National Lampoon Presents Dorm Daze", 0, 0, "movie", 0, 0, 0, "Patrick Casey, Josh Miller", 0, "data/Movie_Poster_Dataset/2003/tt0362511.jpg", "tt0362511", "4.6", "6,772" },
                    { 521, 0, 0, "Cole Williams, Weston Mueller, Aimee Garcia, Michael Azria", 0, 0, "N/A", 0, "11,845", 1, "USA", 0, "Phillip J. Bartell, Alan Brown, Eric Mueller, Brian Sloan", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDk3NTEwNjc0MV5BMl5BanBnXkFtZTgwNzYxNTMwMzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Aug-03", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "Boys Life 4: Four Play", 0, 0, "movie", 0, 0, 0, "Phillip J. Bartell (segment), Alan Brown (segment), Andrew Peterson (segment), Brian Sloan (segment)", 0, "data/Movie_Poster_Dataset/2003/tt0369295.jpg", "tt0369295", "6.3", "168" },
                    { 523, 0, 0, "Leonardo Pieraccioni, Angie Cepeda, Alessandro Haber, Rocco Papaleo", 0, 0, "3 nominations.", 0, "14,640,147", 1, "Italy", 0, "Leonardo Pieraccioni", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Italian", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ4NTMzMTk4NV5BMl5BanBnXkFtZTgwNTU5MjE4MDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "19-Dec-03", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Suddenly Paradise", 0, 0, "movie", 0, 0, 0, "Leonardo Pieraccioni (story), Giovanni Veronesi (story)", 0, "data/Movie_Poster_Dataset/2003/tt0392591.jpg", "tt0392591", "5.3", "833" },
                    { 525, 0, 0, "Anthony Tom, Faith Tom, Joe Tom, Margaret Tom", 0, 0, "6 wins & 4 nominations.", 0, "null", 0, "USA", 0, "Jonathan Karsh", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDQwOWQ2NmUtZThjZi00MGM0LTkzNDctMzcyMjcyOGI1OGRkXkEyXkFqcGdeQXVyMTA3MDk2NDg2._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "17-Jan-03", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "My Flesh and Blood", 0, 0, "movie", 1, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0342804.jpg", "tt0342804", "8.4", "1,563" },
                    { 526, 0, 0, "Dennis Bakke, Piers Lewis, Butch Mederos, Bill O'Reilly", 0, 0, "4 wins & 1 nomination.", 0, "38,593", 0, "USA, Georgia", 0, "Paul Devlin", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, Georgian", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjI1MDQ2MDg5Ml5BMl5BanBnXkFtZTgwMjc2NjM5ODE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "2-May-03", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Power Trip", 0, 0, "movie", 1, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0358647.jpg", "tt0358647", "7.5", "189" },
                    { 528, 0, 0, "N/A", 0, 0, "4 wins.", 0, "60,019", 0, "USA", 1, "Liz Garbus", 1, 0, 0, 0, 0, "Documentary, Crime", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE5OTM0OTY5NF5BMl5BanBnXkFtZTgwMDcxOTQ3ODE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "31-Oct-03", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Girlhood", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0368745.jpg", "tt0368745", "7.3", "401" },
                    { 529, 0, 0, "Frank Vincent, Vincent Pastore, Louis Vanaria, Christian Maelen", 0, 0, "N/A", 0, "null", 0, "USA", 1, "Danny Provenzano", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEzODA3MDcxMl5BMl5BanBnXkFtZTgwODgxNDk3NzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "N/A", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "This Thing of Ours", 0, 0, "movie", 0, 0, 0, "Ted A. Bohus, Danny Provenzano", 0, "data/Movie_Poster_Dataset/2003/tt0338497.jpg", "tt0338497", "5.4", "501" },
                    { 531, 0, 0, "Joanna Adler, Chris Barry, Walter Borden, Ray Brimicombe", 0, 0, "9 wins & 4 nominations.", 0, "35,518", 0, "Canada, USA", 0, "Thom Fitzgerald", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjMyNDkzMzI1OF5BMl5BanBnXkFtZTgwODcxODg5MjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Feb-04", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Event", 0, 0, "movie", 0, 0, 0, "Thom Fitzgerald, Steven Hillyer, Tim Marback", 0, "data/Movie_Poster_Dataset/2003/tt0314039.jpg", "tt0314039", "6.3", "915" },
                    { 532, 0, 0, "Robert Altman, John G. Avildsen, Warren Beatty, Linda Blair", 0, 0, "Nominated for 1 Primetime Emmy. Another 1 win & 1 nomination.", 0, "34,514", 0, "USA", 0, "Ted Demme, Richard LaGravenese", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2U1YzdhYWMtZWUzMi00OWI1LWFkM2ItNWVjM2YxMGQ2MmNhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Jan-03", "TRUE", 0, "138 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Decade Under the Influence", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0342275.jpg", "tt0342275", "7.6", "2,131" },
                    { 535, 0, 1, "Monica Calhoun, Lil' Kim, Stacey Dash, Marie Matiko", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Jean-Claude La Marre", 0, 1, 0, 0, 0, "Action, Drama, Western", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjU0Yzk2MzEtMjAzYy00MzY0LTg2YmItM2RkNzdkY2ZhN2JkXkEyXkFqcGdeQXVyNDg4NjY5OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Oct-03", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gang of Roses", 0, 0, "movie", 0, 0, 1, "Jean-Claude La Marre", 0, "data/Movie_Poster_Dataset/2003/tt0339091.jpg", "tt0339091", "2.2", "860" },
                    { 537, 0, 0, "Nicolas Duvauchelle, Grégoire Colin, Juliette Goudot, Jean-Philippe Écoffey", 0, 0, "N/A", 0, "null", 0, "France, Switzerland", 1, "Olias Barco", 0, 1, 0, 0, 0, "Crime, Drama, Sport", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTExMzU0ODcxNDheQTJeQWpwZ15BbWU4MDE1OTI4MzAy._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "2-Apr-03", "TRUE", 0, "110 min", 0, 0, 1, 0, 0, 0, 0, 0, "Snowboarder", 0, 0, "movie", 0, 0, 0, "Olias Barco (scenario), Julien Sax (scenario), Paolo Rota (scenario), Juliette Goudot (scenario collaborator)", 0, "data/Movie_Poster_Dataset/2003/tt0310164.jpg", "tt0310164", "3.5", "510" },
                    { 538, 0, 0, "André Dussollier, Michel Boujenah, Roland Giraud, Madeleine Besson", 0, 0, "N/A", 0, "6,212,170", 1, "France", 0, "Coline Serreau", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "French, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "5-Feb-03", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "18 ans après", 0, 0, "movie", 0, 0, 0, "Coline Serreau", 0, "data/Movie_Poster_Dataset/2003/tt0271337.jpg", "tt0271337", "4.6", "483" },
                    { 539, 0, 0, "Jason Gedrick, Marla Sokoloff, Lisa Edelstein, Sarah Carter", 0, 0, "2 nominations.", 0, "null", 0, "USA", 0, "Bobby Roth", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA5NzgxODE2NF5BMl5BanBnXkFtZTcwNTI1NTI0OQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "TV-14", 0, 0, "11-Aug-03", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Date with Darkness: The Trial and Capture of Andrew Luster", 0, 0, "movie", 0, 0, 0, "Christopher Canaan", 0, "data/Movie_Poster_Dataset/2003/tt0374600.jpg", "tt0374600", "5.8", "395" },
                    { 540, 0, 0, "John McNaughton, Harold Ramis, John Sayles, Forest Whitaker", 0, 0, "N/A", 0, "16,148", 0, "USA", 0, "Kevin Mukherji", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGIzNWYzN2YtMjcwYS00YjQ3LWI2NjMtOTNiYTUyYjE2MGNkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Apr-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Storytellers", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0212142.jpg", "tt0212142", "7.6", "42" },
                    { 543, 0, 1, "Mansai Nomura, Hideaki Itô, Kiichi Nakai, Kyoko Fukada", 0, 0, "1 nomination.", 0, "2,920,252", 0, "Japan", 0, "Yôjirô Takita", 0, 0, 0, 0, 1, "Action, Fantasy", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTRkMDRiYmEtNGM4YS00NzM3LWI4MTMtYzk1MmVjMjM3ODg1XkEyXkFqcGdeQXVyMjgyNjk3MzE@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "4-Oct-03", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Onmyoji 2", 0, 0, "movie", 0, 0, 0, "Itaru Era, Yôjirô Takita, Baku Yumemakura", 0, "data/Movie_Poster_Dataset/2003/tt0383543.jpg", "tt0383543", "6.3", "386" },
                    { 545, 0, 0, "Eric Bogosian, Aram Khachaturyan", 0, 0, "1 win & 1 nomination.", 1, "null", 0, "USA", 0, "Peter Rosen", 1, 0, 0, 0, 0, "Documentary, Biography, Music", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDUyZWU5N2UtOWFlMy00MTI0LTk0ZDYtMzFhNjljODBhZDA5XkEyXkFqcGdeQXVyNzA4ODc3ODU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "17-Oct-03", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "Khachaturian", 0, 0, "movie", 0, 0, 0, "Solomon Volkov, Bill van Horn", 0, "data/Movie_Poster_Dataset/2003/tt0396087.jpg", "tt0396087", "8.5", "36" },
                    { 547, 0, 0, "Lala Sloatman, Jeremy Sisto, Jenny Judelle, Klea Scott", 0, 0, "1 win.", 0, "null", 1, "USA", 0, "Tara Judelle", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5OTk4MTM3M15BMl5BanBnXkFtZTgwODcxNjg3MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Apr-03", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Manfast", 0, 0, "movie", 0, 0, 0, "Tara Judelle", 0, "data/Movie_Poster_Dataset/2003/tt0282718.jpg", "tt0282718", "3.6", "211" },
                    { 548, 0, 0, "Emmy Rossum, Steven Bauer, James Badge Dale, Thom Christopher", 0, 0, "N/A", 0, "8,058", 1, "USA", 0, "Alan Hruska", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "26", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk1NTc3NDc4MF5BMl5BanBnXkFtZTcwNjYwNDk0OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-May-03", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Nola", 0, 0, "movie", 0, 0, 0, "Alan Hruska", 0, "data/Movie_Poster_Dataset/2003/tt0317950.jpg", "tt0317950", "5.5", "331" },
                    { 549, 0, 0, "Cal Robertson, Andre Keuck, Serataren Adragna, Melissa Banks", 0, 0, "7 wins & 1 nomination.", 0, "7,221", 0, "USA", 0, "Ben Coccio", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGUyM2ZiZmUtMWY0OC00NTQ4LThkOGUtNjY2NjkzMDJiMWMwXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "23-Jan-04", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Zero Day", 0, 0, "movie", 1, 0, 0, "Ben Coccio, Christopher Coccio", 0, "data/Movie_Poster_Dataset/2003/tt0365960.jpg", "tt0365960", "7.4", "3,141" },
                    { 550, 0, 0, "Alicia Silverstone, Rachael Leigh Cook, Woody Harrelson, John Cleese", 0, 0, "N/A", 0, "null", 1, "USA", 1, "Gavin Grazer", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUyMjQ1MTY5OV5BMl5BanBnXkFtZTcwNzY5NjExMw@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-May-03", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Scorched", 0, 0, "movie", 0, 0, 0, "Joe Wein, Joe Wein (story), Max Wein (story)", 0, "data/Movie_Poster_Dataset/2003/tt0286947.jpg", "tt0286947", "6", "5,423" },
                    { 551, 0, 0, "Amy Blomquist, Don Hughes, Erik Engstrom, Charley King", 0, 0, "N/A", 0, "40,289", 1, "USA", 0, "Azita Zendel", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgzODgyNTQwOV5BMl5BanBnXkFtZTcwNzc0NTc0Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Oct-07", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Controlled Chaos", 0, 0, "movie", 0, 0, 0, "Azita Zendel", 0, "data/Movie_Poster_Dataset/2003/tt0349238.jpg", "tt0349238", "6.9", "34" },
                    { 552, 0, 0, "Liz Marks, Sarah Mueller, Marcus Berry, Mark Pauline", 0, 0, "3 wins & 1 nomination.", 0, "null", 0, "USA", 0, "Tiffany Shlain", 1, 0, 0, 0, 0, "Documentary, Short", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWM4NTY2NTMtZDZlZS00NTgyLWEzZDMtODE3ZGI1MzI3ZmU5XkEyXkFqcGdeQXVyNzI1NzMxNzM@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jan-03", "TRUE", 0, "14 min", 0, 1, 0, 0, 0, 0, 0, 0, "Life, Liberty & the Pursuit of Happiness", 0, 0, "movie", 0, 0, 0, "Xandra Castleton, Maya Draisin, Tiffany Shlain", 0, "data/Movie_Poster_Dataset/2003/tt0343978.jpg", "tt0343978", "7.6", "53" },
                    { 553, 0, 0, "Steve Parlavecchio, Arthur J. Nascarella, Stacie Mistysyn, Ralph Caputo", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Elia Zois", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "16", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmQ5MzFjYWMtMTMwNC00ZGU5LWI3YTQtYzhkMGExNGFlY2Q0XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Apr-03", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jersey Guy", 0, 0, "movie", 0, 0, 0, "Christ Zois, Elia Zois", 0, "data/Movie_Poster_Dataset/2003/tt0191211.jpg", "tt0191211", "4.7", "41" },
                    { 554, 0, 0, "Michael Blieden, Stephanie Courtney, Matt Price, Annabelle Gurwitch", 0, 0, "5 wins & 9 nominations.", 0, "null", 1, "USA", 0, "Bob Odenkirk", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5MjYyOTg4MF5BMl5BanBnXkFtZTcwNDc2MzQwMg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Dec-03", "TRUE", 1, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "Melvin Goes to Dinner", 0, 0, "movie", 0, 0, 0, "Michael Blieden (play), Michael Blieden (screenplay)", 0, "data/Movie_Poster_Dataset/2003/tt0323633.jpg", "tt0323633", "7.2", "1,924" },
                    { 555, 0, 0, "Nathan Smith Jones, Jen Hoskins, Eric Artell, Dan Merkley", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Nathan Smith Jones", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmIzYmY4MGItM2I4YS00OWZhLWFmMzQtYzI2MWY1MmM3NGU1XkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-Aug-03", "TRUE", 0, "77 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Work and the Story", 0, 0, "movie", 0, 0, 0, "Nathan Smith Jones, Dan Merkley", 0, "data/Movie_Poster_Dataset/2003/tt0339921.jpg", "tt0339921", "4.8", "101" },
                    { 556, 0, 0, "N/A", 0, 0, "2 nominations.", 0, "null", 0, "Australia", 0, "Klaus Toft", 0, 0, 0, 0, 0, "N/A", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYzNDc2MDc0N15BMl5BanBnXkFtZTgwOTcwMDQ5MTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "56 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Navigators: Baudin vs Flinders", 0, 0, "movie", 0, 0, 0, "Klaus Toft", 0, "data/Movie_Poster_Dataset/2003/tt0402398.jpg", "tt0402398", "5.6", "5" },
                    { 557, 0, 0, "Richard Anderson, Sonny Bono, John F. Butler, Hans Conried", 0, 0, "N/A", 0, "1,225", 0, "USA", 0, "Bret Wood", 1, 0, 0, 0, 0, "Documentary, History", 1, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzU1YWUzNjYtNmVhZi00ODUyLTg4M2ItMTFlMmU1Mzc5OTE5XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Jun-03", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hell's Highway: The True Story of Highway Safety Films", 0, 0, "movie", 0, 0, 0, "Bret Wood", 0, "data/Movie_Poster_Dataset/2003/tt0372321.jpg", "tt0372321", "7", "166" },
                    { 558, 0, 0, "Zoska Aleece, Nicole Areu, Randy Danner, Angelito Felix", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Dan Patton", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE5NDQ5OTE4Ml5BMl5BanBnXkFtZTcwOTE3NDIzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "20-Jun-03", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Wash Dry and Spin Out", 0, 0, "movie", 1, 0, 0, "Dan Patton", 0, "data/Movie_Poster_Dataset/2003/tt0302018.jpg", "tt0302018", "5.1", "22" },
                    { 560, 0, 0, "Alexei Arzamastsev, Natasha Borzilova, Andrei Missikhin, Sergei 'Spooky' Olkhovsky", 0, 0, "N/A", 0, "null", 0, "USA, Japan", 0, "Nina Gilden Seavey", 1, 0, 0, 0, 0, "Documentary, Music", 0, 0, "English", 0, "49", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUwOGFiM2QtOWMxYS00MjU2LThmZDMtZDM2MWMzNzllNjdhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "19-Feb-03", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Ballad of Bering Strait", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2003/tt0319029.jpg", "tt0319029", "7.6", "34" },
                    { 562, 0, 1, "Chris Pratt, Bryce Dallas Howard, Irrfan Khan, Vincent D'Onofrio", 1, 0, "3 wins & 48 nominations.", 0, "652,177,271", 0, "USA, Japan", 0, "Colin Trevorrow", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzQ5NGQwOTUtNWJlZi00ZTFiLWI0ZTEtOGU3MTA2ZGU5OWZiXkEyXkFqcGdeQXVyMTczNjQwOTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jun-15", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jurassic World", 0, 0, "movie", 0, 0, 0, "Rick Jaffa (screenplay), Amanda Silver (screenplay), Colin Trevorrow (screenplay), Derek Connolly (screenplay), Rick Jaffa (story), Amanda Silver (story), Michael Crichton (characters)", 0, "data/Movie_Poster_Dataset/2015/tt0369610.jpg", "tt0369610", "7.1", "380,404" },
                    { 563, 0, 1, "Robert Downey Jr., Chris Hemsworth, Mark Ruffalo, Chris Evans", 1, 0, "2 wins & 25 nominations.", 0, "458,991,599", 0, "USA", 0, "Joss Whedon", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE0NzgwODI4M15BMl5BanBnXkFtZTcwNjg3OTA0MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-May-15", "TRUE", 0, "141 min", 0, 0, 0, 0, 0, 0, 0, 0, "Avengers: Age of Ultron", 0, 0, "movie", 0, 0, 0, "Joss Whedon, Stan Lee (Marvel comics), Jack Kirby (Marvel comics)", 0, "data/Movie_Poster_Dataset/2015/tt2395427.jpg", "tt2395427", "7.5", "401,155" },
                    { 564, 0, 0, "Amy Poehler, Phyllis Smith, Richard Kind, Bill Hader", 1, 1, "Won 1 Oscar. Another 73 wins & 86 nominations.", 0, "356,454,367", 1, "USA", 0, "Pete Docter, Ronnie Del Carmen", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "94", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjAzODUwMjM1M15BMl5BanBnXkFtZTcwNjU2MjU2MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "19-Jun-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Inside Out", 0, 0, "movie", 0, 0, 0, "Pete Docter (original story by), Ronnie Del Carmen (original story by), Pete Docter (screenplay), Meg LeFauve (screenplay), Josh Cooley (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2096673.jpg", "tt2096673", "8.3", "287,471" },
                    { 565, 0, 1, "Vin Diesel, Paul Walker, Jason Statham, Michelle Rodriguez", 0, 0, "Nominated for 1 Golden Globe. Another 15 wins & 18 nominations.", 0, "350,034,110", 0, "USA, Japan, China", 1, "James Wan", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTg2OTY2ODg5OF5BMl5BanBnXkFtZTcwODM5MTYxOA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Apr-15", "TRUE", 0, "137 min", 0, 0, 0, 0, 0, 0, 0, 1, "Furious 7", 0, 0, "movie", 0, 0, 0, "Chris Morgan, Gary Scott Thompson (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2820852.jpg", "tt2820852", "7.3", "260,137" },
                    { 566, 0, 0, "Sandra Bullock, Jon Hamm, Michael Keaton, Allison Janney", 0, 1, "Nominated for 1 BAFTA Film Award. Another 13 nominations.", 0, "336,029,560", 1, "USA", 0, "Kyle Balda, Pierre Coffin", 0, 0, 0, 1, 0, "Animation, Comedy, Family", 0, 0, "English, Spanish", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOGUwYTU4NGEtNDM4MS00NDRjLTkwNmQtOTkwMWMyMjhmMjdlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "10-Jul-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Minions", 0, 0, "movie", 0, 0, 0, "Brian Lynch", 0, "data/Movie_Poster_Dataset/2015/tt2293640.jpg", "tt2293640", "6.5", "124,840" },
                    { 567, 0, 0, "Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth, Woody Harrelson", 1, 0, "9 nominations.", 0, "281,666,058", 0, "USA, Germany", 0, "Francis Lawrence", 0, 0, 0, 0, 0, "Adventure, Sci-Fi", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU3MDc2MjUwMV5BMl5BanBnXkFtZTcwNzQyMDAzMQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Nov-15", "TRUE", 0, "137 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hunger Games: Mockingjay - Part 2", 0, 0, "movie", 0, 0, 0, "Peter Craig (screenplay), Danny Strong (screenplay), Suzanne Collins (adaptation), Suzanne Collins (novel)", 0, "data/Movie_Poster_Dataset/2015/tt1951266.jpg", "tt1951266", "6.9", "97,247" },
                    { 568, 0, 0, "Matt Damon, Jessica Chastain, Kristen Wiig, Jeff Daniels", 1, 0, "Nominated for 7 Oscars. Another 31 wins & 161 nominations.", 0, "228,430,993", 0, "USA, UK", 0, "Ridley Scott", 0, 1, 0, 0, 0, "Adventure, Drama, Sci-Fi", 0, 0, "English, Mandarin", 0, "80", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGY1M2MwOTEtZDIyNi00YjNlLWExYmEtNzBjOGI3N2QzNTg5XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Oct-15", "TRUE", 0, "144 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Martian", 0, 0, "movie", 0, 0, 0, "Drew Goddard (screenplay), Andy Weir (book)", 0, "data/Movie_Poster_Dataset/2015/tt3659388.jpg", "tt3659388", "8.1", "383,169" },
                    { 569, 0, 1, "Daniel Craig, Christoph Waltz, Léa Seydoux, Ralph Fiennes", 1, 0, "Won 1 Oscar. Another 7 wins & 22 nominations.", 0, "200,074,175", 0, "UK, USA", 0, "Sam Mendes", 0, 0, 0, 0, 0, "Action, Adventure, Thriller", 0, 0, "English, Spanish, Italian, German, French", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "6-Nov-15", "TRUE", 0, "148 min", 0, 0, 0, 0, 0, 0, 0, 1, "Spectre", 0, 0, "movie", 0, 0, 0, "John Logan (screenplay), Neal Purvis (screenplay), Robert Wade (screenplay), Jez Butterworth (screenplay), John Logan (story), Neal Purvis (story), Robert Wade (story), Ian Fleming (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2379713.jpg", "tt2379713", "6.9", "247,144" },
                    { 570, 0, 1, "Tom Cruise, Jeremy Renner, Simon Pegg, Rebecca Ferguson", 1, 0, "2 wins & 12 nominations.", 0, "195,000,874", 0, "USA, China", 0, "Christopher McQuarrie", 0, 0, 0, 0, 0, "Action, Adventure, Thriller", 0, 0, "English, Swedish, German", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg5Mjk2NDMtZTk0Ny00YTQ0LWIzYWEtMWI5MGQ0Mjg1OTNkXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-Jul-15", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 1, "Mission: Impossible - Rogue Nation", 0, 0, "movie", 0, 0, 0, "Christopher McQuarrie (screenplay), Christopher McQuarrie (story), Drew Pearce (story), Bruce Geller (television series)", 0, "data/Movie_Poster_Dataset/2015/tt2381249.jpg", "tt2381249", "7.5", "207,337" },
                    { 571, 0, 0, "Anna Kendrick, Rebel Wilson, Hailee Steinfeld, Brittany Snow", 0, 0, "6 wins & 12 nominations.", 0, "183,436,380", 1, "USA", 0, "Elizabeth Banks", 0, 0, 0, 0, 0, "Comedy, Music", 0, 0, "English", 0, "63", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODBiNzYxNzYtMjkyMi00MjUyLWJkM2YtZjNkMDhhYmEwMTRiL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-May-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pitch Perfect 2", 0, 0, "movie", 0, 0, 0, "Kay Cannon, Mickey Rapkin (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2848292.jpg", "tt2848292", "6.5", "86,817" },
                    { 572, 0, 0, "Leonardo DiCaprio, Tom Hardy, Domhnall Gleeson, Will Poulter", 1, 0, "Won 3 Oscars. Another 66 wins & 150 nominations.", 0, "182,599,867", 0, "USA", 0, "Alejandro González Iñárritu", 0, 1, 0, 0, 0, "Adventure, Drama, Thriller", 0, 0, "English, Pawnee, French", 0, "76", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTIzNDUyMjA4MV5BMl5BanBnXkFtZTYwNDc4ODM3._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Jan-16", "TRUE", 0, "156 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Revenant", 0, 0, "movie", 0, 0, 0, "Mark L. Smith (screenplay), Alejandro González Iñárritu (screenplay), Michael Punke (based in part on the novel by)", 0, "data/Movie_Poster_Dataset/2015/tt1663202.jpg", "tt1663202", "8.2", "285,372" },
                    { 573, 0, 1, "Paul Rudd, Michael Douglas, Evangeline Lilly, Corey Stoll", 1, 0, "Nominated for 1 BAFTA Film Award. Another 1 win & 24 nominations.", 0, "180,191,634", 0, "USA", 0, "Peyton Reed", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Jul-15", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ant-Man", 0, 0, "movie", 0, 0, 0, "Edgar Wright (screenplay), Joe Cornish (screenplay), Adam McKay (screenplay), Paul Rudd (screenplay), Edgar Wright (story), Joe Cornish (story), Stan Lee (comic book), Larry Lieber (comic book), Jack Kirby (comic book)", 0, "data/Movie_Poster_Dataset/2015/tt0478970.jpg", "tt0478970", "7.4", "252,344" },
                    { 574, 0, 0, "Adam Sandler, Andy Samberg, Selena Gomez, Kevin James", 0, 1, "6 nominations.", 0, "169,692,572", 1, "USA", 0, "Genndy Tartakovsky", 0, 0, 0, 1, 0, "Animation, Comedy, Family", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMWQ2MjQ0OTctMWE1OC00NjZjLTk3ZDAtNTk3NTZiYWMxYTlmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Sep-15", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hotel Transylvania 2", 0, 0, "movie", 0, 0, 0, "Robert Smigel, Adam Sandler", 0, "data/Movie_Poster_Dataset/2015/tt2510894.jpg", "tt2510894", "6.8", "45,737" },
                    { 575, 0, 0, "Dakota Johnson, Jamie Dornan, Jennifer Ehle, Eloise Mumford", 0, 0, "Nominated for 1 Oscar. Another 7 wins & 16 nominations.", 0, "166,147,885", 0, "USA", 0, "Sam Taylor-Johnson", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmVmMGQ3NzEtM2FiNi00YThhLWFkZjYtM2Y0MjZjNGE4NzM0XkEyXkFqcGdeQXVyODc0OTEyNDU@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Feb-15", "TRUE", 1, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Fifty Shades of Grey", 0, 0, "movie", 0, 0, 0, "Kelly Marcel (screenplay), E.L. James (novel)", 0, "data/Movie_Poster_Dataset/2015/tt2322441.jpg", "tt2322441", "4.1", "212,611" },
                    { 576, 0, 0, "Antonio Banderas, Eric Bauza, Tim Conway, Eddie Deezen", 1, 1, "4 nominations.", 0, "162,495,848", 1, "USA", 0, "Paul Tibbitt, Mike Mitchell", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMGFkNjNmZWMtNDdiOS00ZWM3LWE1ZTMtZDU3MGQyMzIyNzZhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "6-Feb-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "The SpongeBob Movie: Sponge Out of Water", 0, 0, "movie", 0, 0, 0, "Glenn Berger (screenplay), Jonathan Aibel (screenplay), Stephen Hillenburg (story), Paul Tibbitt (story), Stephen Hillenburg (series \\\\", 0, "data/Movie_Poster_Dataset/2015/tt2279373.jpg", "tt2279373", "6", "32,349" },
                    { 577, 0, 0, "O'Shea Jackson Jr., Corey Hawkins, Jason Mitchell, Neil Brown Jr.", 0, 0, "Nominated for 1 Oscar. Another 19 wins & 33 nominations.", 1, "161,029,270", 0, "USA", 0, "F. Gary Gray", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjYzYWM4YTItZjJiMC00OTM5LTg3NDgtOGQ2Njk2ZWNhN2QwXkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Aug-15", "TRUE", 0, "147 min", 0, 0, 0, 0, 0, 0, 0, 0, "Straight Outta Compton", 0, 0, "movie", 0, 0, 0, "Jonathan Herman (screenplay), Andrea Berloff (screenplay), S. Leigh Savidge (story), Alan Wenkus (story), Andrea Berloff (story)", 0, "data/Movie_Poster_Dataset/2015/tt1398426.jpg", "tt1398426", "8", "96,338" },
                    { 578, 0, 1, "Dwayne Johnson, Carla Gugino, Alexandra Daddario, Ioan Gruffudd", 1, 0, "10 nominations.", 0, "155,181,732", 0, "USA", 0, "Brad Peyton", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2JkNGU0ZGMtZjVjNS00NjgyLWEyOWYtZmRmZGQyN2IxZjA2XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-May-15", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "San Andreas", 0, 0, "movie", 0, 0, 0, "Carlton Cuse (screenplay), Andre Fabrizio (story), Jeremy Passmore (story)", 0, "data/Movie_Poster_Dataset/2015/tt2126355.jpg", "tt2126355", "6.1", "134,083" },
                    { 579, 0, 1, "Tom Hardy, Charlize Theron, Nicholas Hoult, Hugh Keays-Byrne", 1, 0, "Won 6 Oscars. Another 176 wins & 184 nominations.", 0, "153,629,485", 0, "Australia, USA", 0, "George Miller", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English, Russian", 0, "90", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYxMDdlYjItMDVkYy00MjYzLThhMTYtYjIzZjZiODk1ZWRmXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-May-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mad Max: Fury Road", 0, 0, "movie", 0, 0, 0, "George Miller, Brendan McCarthy, Nick Lathouris", 0, "data/Movie_Poster_Dataset/2015/tt1392190.jpg", "tt1392190", "8.1", "482,416" },
                    { 580, 0, 0, "Will Ferrell, Mark Wahlberg, Linda Cardellini, Thomas Haden Church", 0, 0, "N/A", 0, "150,315,155", 1, "USA", 0, "Sean Anders", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ5NTI2NTI4NF5BMl5BanBnXkFtZTcwNjk2NDA2OQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Dec-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Daddy's Home", 0, 0, "movie", 0, 0, 0, "Brian Burns (screenplay), Sean Anders (screenplay), John Morris (screenplay), Brian Burns (story)", 0, "data/Movie_Poster_Dataset/2015/tt1528854.jpg", "tt1528854", "6.2", "29,643" },
                    { 582, 0, 0, "Trombone Shorty, Rebecca Bloom, Anastasia Bredikhina, Francesca Capaldi", 1, 1, "Nominated for 1 Golden Globe. Another 1 win & 42 nominations.", 0, "130,174,897", 1, "USA", 0, "Steve Martino", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzY1ZjMwMGEtYTY1ZS00ZDllLTk0ZmUtYzA3ZTA4NmYwNGNkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "6-Nov-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Peanuts Movie", 0, 0, "movie", 0, 0, 0, "Bryan Schulz, Craig Schulz, Cornelius Uliano, Charles M. Schulz (comic strip)", 0, "data/Movie_Poster_Dataset/2015/tt2452042.jpg", "tt2452042", "7.2", "22,213" },
                    { 584, 0, 0, "Jeffrey Wright, Frances McDormand, Maleah Nipay-Padilla, Ryan Teeple", 1, 1, "Nominated for 1 Golden Globe. Another 4 wins & 37 nominations.", 0, "123,070,338", 1, "USA", 0, "Peter Sohn", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYjBhZmViNTItMGExMy00MGNmLTkwZDItMDVlMTQ4ODVkYTMwXkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "25-Nov-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Good Dinosaur", 0, 0, "movie", 0, 0, 0, "Bob Peterson (original concept and development), Peter Sohn (story), Erik Benson (story), Meg LeFauve (story), Kelsey Mann (story), Bob Peterson (story), Meg LeFauve (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt1979388.jpg", "tt1979388", "6.8", "43,963" },
                    { 585, 0, 1, "Jude Law, Raad Rawi, Melissa McCarthy, Jessica Chaffin", 0, 0, "Nominated for 2 Golden Globes. Another 2 wins & 18 nominations.", 0, "110,822,419", 1, "USA", 1, "Paul Feig", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, French, Italian, German", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWM5ZDcxMTYtNTEyNS00MDRkLWI3YTItNThmMGExMWY4NDIwXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Jun-15", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spy", 0, 0, "movie", 0, 0, 0, "Paul Feig", 0, "data/Movie_Poster_Dataset/2015/tt3079380.jpg", "tt3079380", "7.1", "147,915" },
                    { 586, 0, 0, "Colin Quinn, Devin Fabry, Carla Oudin, Amy Schumer", 0, 0, "Nominated for 2 Golden Globes. Another 6 wins & 21 nominations.", 0, "110,008,260", 1, "USA, Japan", 0, "Judd Apatow", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2E2YWYxY2QtZmJmZi00MjJlLWFiYWItZTk5Y2IyMWQ1ZThhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Jul-15", "TRUE", 1, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Trainwreck", 0, 0, "movie", 0, 0, 0, "Amy Schumer", 0, "data/Movie_Poster_Dataset/2015/tt3152624.jpg", "tt3152624", "6.4", "80,101" },
                    { 587, 0, 0, "Michael B. Jordan, Sylvester Stallone, Tessa Thompson, Phylicia Rashad", 0, 0, "Nominated for 1 Oscar. Another 42 wins & 52 nominations.", 0, "109,712,885", 0, "USA", 0, "Ryan Coogler", 0, 1, 0, 0, 0, "Drama, Sport", 0, 0, "English, Spanish", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDg0MWNmNjktMGEwZC00ZDlmLWI1MTUtMDBmNjQzMWM2NjBjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Nov-15", "TRUE", 0, "133 min", 0, 0, 1, 0, 0, 0, 0, 0, "Creed", 0, 0, "movie", 0, 0, 0, "Ryan Coogler (screenplay), Aaron Covington (screenplay), Ryan Coogler (story), Sylvester Stallone (characters)", 0, "data/Movie_Poster_Dataset/2015/tt3076658.jpg", "tt3076658", "7.8", "116,166" },
                    { 588, 0, 1, "George Clooney, Hugh Laurie, Britt Robertson, Raffey Cassidy", 1, 0, "1 win & 11 nominations.", 0, "93,417,865", 0, "USA, Spain", 0, "Brad Bird", 0, 0, 0, 1, 0, "Action, Adventure, Family", 0, 0, "English, French, Japanese", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYTY4MTdjZDMtOTBiMC00MDEwLThhMjUtMjlhMjdlYTBmMzk3XkEyXkFqcGdeQXVyNjMwMjk0MTQ@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "22-May-15", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tomorrowland", 0, 0, "movie", 0, 0, 0, "Damon Lindelof (screenplay), Brad Bird (screenplay), Damon Lindelof (story), Brad Bird (story), Jeff Jensen (story)", 0, "data/Movie_Poster_Dataset/2015/tt1964418.jpg", "tt1964418", "6.5", "115,574" },
                    { 589, 0, 0, "Will Ferrell, Kevin Hart, Craig T. Nelson, Alison Brie", 0, 0, "N/A", 0, "90,353,764", 1, "USA", 1, "Etan Cohen", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDViNjFjOWMtZGZhMi00NmIyLThmYzktODA4MzJhZDZhMDc5XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Mar-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Get Hard", 0, 0, "movie", 0, 0, 0, "Jay Martel (screenplay), Ian Roberts (screenplay), Etan Cohen (screenplay), Adam McKay (story), Jay Martel (story), Ian Roberts (story)", 0, "data/Movie_Poster_Dataset/2015/tt2561572.jpg", "tt2561572", "6.1", "74,947" },
                    { 591, 0, 0, "Amy Poehler, Tina Fey, Maya Rudolph, Ike Barinholtz", 0, 0, "4 nominations.", 0, "87,028,670", 1, "USA", 0, "Jason Moore", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjg5OGU4OGYtNTZmNy00MjQ1LWIzYzgtMTllMGY2NzlkNzYwXkEyXkFqcGdeQXVyMTI3ODAyMzE2._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Dec-15", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sisters", 0, 0, "movie", 0, 0, 0, "Paula Pell", 0, "data/Movie_Poster_Dataset/2015/tt1850457.jpg", "tt1850457", "6.1", "27,624" },
                    { 592, 0, 0, "Jason Lee, Justin Long, Matthew Gray Gubler, Jesse McCartney", 1, 1, "1 win & 2 nominations.", 0, "85,710,063", 1, "USA", 0, "Walt Becker", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOTMyZGI4N2YtMzdkNi00MDZmLTg4NmItMzg0ODY5NjdhZjYwL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "18-Dec-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Alvin and the Chipmunks: The Road Chip", 0, 0, "movie", 0, 0, 0, "Ross Bagdasarian (characters), Janice Karman (characters), Randi Mayem Singer, Adam Sztykiel", 0, "data/Movie_Poster_Dataset/2015/tt2974918.jpg", "tt2974918", "4.4", "4,724" },
                    { 593, 0, 1, "Dylan O'Brien, Ki Hong Lee, Kaya Scodelario, Thomas Brodie-Sangster", 0, 0, "2 nominations.", 0, "81,687,587", 0, "USA", 0, "Wes Ball", 0, 0, 0, 0, 0, "Action, Sci-Fi, Thriller", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2I2N2Q1YmMtMzZkMC00Y2JjLWJmOWUtNjc2OTM2ZTk1MjUyXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Sep-15", "TRUE", 0, "132 min", 0, 0, 0, 0, 0, 0, 0, 1, "Maze Runner: The Scorch Trials", 0, 0, "movie", 0, 0, 0, "T.S. Nowlin (screenplay), James Dashner (novel)", 0, "data/Movie_Poster_Dataset/2015/tt4046784.jpg", "tt4046784", "6.4", "118,622" },
                    { 594, 0, 0, "Mark Wahlberg, Seth MacFarlane, Amanda Seyfried, Jessica Barth", 0, 0, "4 nominations.", 0, "81,257,500", 1, "USA", 0, "Seth MacFarlane", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDUxN2I5NDUtZjdlMC00NjlmLTg0OTQtNjk0NjAxZjFmZTUzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Jun-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ted 2", 0, 0, "movie", 0, 0, 0, "Seth MacFarlane, Alec Sulkin, Wellesley Wild", 0, "data/Movie_Poster_Dataset/2015/tt2637276.jpg", "tt2637276", "6.4", "103,061" },
                    { 595, 0, 0, "Jack Black, Dylan Minnette, Odeya Rush, Ryan Lee", 1, 0, "2 nominations.", 0, "80,021,740", 1, "USA, Australia", 0, "Rob Letterman", 0, 0, 0, 1, 0, "Adventure, Comedy, Family", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYjdkNzA4MzYtZThhOS00ZDgzLTlmMDItNmY1ZjI5YjkzZTE1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "16-Oct-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Goosebumps", 0, 0, "movie", 0, 0, 0, "Darren Lemke (screenplay), Scott Alexander (story), Larry Karaszewski (story), R.L. Stine (\\\\", 0, "data/Movie_Poster_Dataset/2015/tt1051904.jpg", "tt1051904", "6.4", "36,164" },
                    { 596, 0, 1, "Adam Sandler, Kevin James, Michelle Monaghan, Peter Dinklage", 0, 0, "1 win & 9 nominations.", 0, "78,747,585", 1, "USA, China, Canada", 0, "Chris Columbus", 0, 0, 0, 0, 0, "Action, Comedy, Sci-Fi", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWY3N2EyOWYtNDVhZi00MWRkLTg2OTUtODNkNDQ5ZTIwMGJkXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Jul-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pixels", 0, 0, "movie", 0, 0, 0, "Tim Herlihy (screenplay), Timothy Dowling (screenplay), Tim Herlihy (screen story), Patrick Jean (short film)", 0, "data/Movie_Poster_Dataset/2015/tt2120120.jpg", "tt2120120", "5.7", "77,919" },
                    { 597, 0, 0, "Robert De Niro, Anne Hathaway, Rene Russo, Anders Holm", 0, 0, "1 win & 4 nominations.", 0, "75,274,748", 1, "USA", 0, "Nancy Meyers", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTVjYWJmMWQtYWU4Ni00MWY3LWI2YmMtNTI5MDE0MWVmMmEzL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Sep-15", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Intern", 0, 0, "movie", 0, 0, 0, "Nancy Meyers", 0, "data/Movie_Poster_Dataset/2015/tt2361509.jpg", "tt2361509", "7.2", "98,627" },
                    { 598, 0, 0, "Mark Rylance, Domenick Lombardozzi, Victor Verhaeghe, Mark Fichera", 0, 0, "Won 1 Oscar. Another 24 wins & 84 nominations.", 0, "72,306,065", 0, "USA, Germany, India", 0, "Steven Spielberg", 0, 1, 0, 0, 0, "Drama, History, Thriller", 1, 0, "English, German, Russian", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWZiNWUwYjMtM2Y1Yi00MTZmLWEwYzctNjVmYWM0OTFlZDFhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Oct-15", "TRUE", 0, "142 min", 0, 0, 0, 0, 0, 0, 0, 1, "Bridge of Spies", 0, 0, "movie", 0, 0, 0, "Matt Charman, Ethan Coen, Joel Coen", 0, "data/Movie_Poster_Dataset/2015/tt3682448.jpg", "tt3682448", "7.6", "138,390" },
                    { 599, 0, 1, "Kevin James, Raini Rodriguez, Neal McDonough, Daniella Alonso", 0, 0, "9 nominations.", 0, "71,038,190", 1, "USA", 1, "Andy Fickman", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "13", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzIwM2IwYTItYmM4Zi00OWMzLTkwNjAtYWRmYWNmY2RhMDk0XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "17-Apr-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Paul Blart: Mall Cop 2", 0, 0, "movie", 0, 0, 0, "Kevin James, Nick Bakay, Kevin James (characters), Nick Bakay (characters)", 0, "data/Movie_Poster_Dataset/2015/tt3450650.jpg", "tt3450650", "4.4", "21,219" },
                    { 600, 0, 0, "Ryan Gosling, Rudy Eisenzopf, Casey Groves, Charlie Talbert", 0, 0, "Won 1 Oscar. Another 30 wins & 67 nominations.", 1, "70,235,322", 1, "USA", 0, "Adam McKay", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2MTIzMzg5Nl5BMl5BanBnXkFtZTgwOTc5NDI1MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Dec-15", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Big Short", 0, 0, "movie", 0, 0, 0, "Charles Randolph (screenplay), Adam McKay (screenplay), Michael Lewis (book)", 0, "data/Movie_Poster_Dataset/2015/tt1596363.jpg", "tt1596363", "7.9", "106,723" },
                    { 601, 0, 0, "Karen Abercrombie, Priscilla C. Shirer, T.C. Stallings, Tenae Downing", 0, 0, "N/A", 0, "67,790,117", 0, "USA", 0, "Alex Kendrick", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "26", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOWMyNjE0MzEtMzVjNy00NjIxLTg0ZjMtMWJhNGI1YmVjYTczL2ltYWdlXkEyXkFqcGdeQXVyNzc5MjA3OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "28-Aug-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "War Room", 0, 0, "movie", 0, 0, 0, "Alex Kendrick, Stephen Kendrick", 0, "data/Movie_Poster_Dataset/2015/tt3832914.jpg", "tt3832914", "6.3", "7,131" },
                    { 602, 0, 0, "Channing Tatum, Juan Piedrahita, Sharon Blackwood, Alison Faulk", 0, 0, "2 wins & 1 nomination.", 0, "66,009,973", 1, "USA", 0, "Gregory Jacobs", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "60", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTdlMDExOGUtN2I3MS00MjY5LWE1NTAtYzc3MzIxN2M3OWY1XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Jul-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Magic Mike XXL", 0, 0, "movie", 0, 0, 0, "Reid Carolin, Reid Carolin (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2268016.jpg", "tt2268016", "5.7", "34,337" },
                    { 603, 0, 0, "Olivia DeJonge, Ed Oxenbould, Deanna Dunagan, Peter McRobbie", 0, 0, "1 win & 9 nominations.", 0, "65,069,140", 0, "USA", 0, "M. Night Shyamalan", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzdmY2I3MmEtOGFiZi00MTg1LWIxY2QtNWUwM2NmNWNlY2U5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Sep-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Visit", 0, 0, "movie", 0, 0, 0, "M. Night Shyamalan (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3567288.jpg", "tt3567288", "6.2", "52,625" },
                    { 604, 0, 0, "Kevin Hart, Josh Gad, Affion Crockett, Kaley Cuoco", 0, 0, "2 wins & 3 nominations.", 0, "64,460,211", 1, "USA", 0, "Jeremy Garelick", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWE4N2JkNDUtZDU4MC00ZjNhLTlkMjYtOTNkMjZhMDAwMDMyXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Jan-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Wedding Ringer", 0, 0, "movie", 0, 0, 0, "Jeremy Garelick, Jay Lavender", 0, "data/Movie_Poster_Dataset/2015/tt0884732.jpg", "tt0884732", "6.7", "49,204" },
                    { 605, 0, 0, "Johnny Depp, Joel Edgerton, Benedict Cumberbatch, Dakota Johnson", 0, 0, "4 wins & 17 nominations.", 1, "62,563,543", 0, "USA, UK", 1, "Scott Cooper", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzc1YTIyNjctYzhlNy00ZmYzLWI2ZWQtMzk4MmQwYzA0NGQ1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Sep-15", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Black Mass", 0, 0, "movie", 0, 0, 0, "Mark Mallouk (screenplay), Jez Butterworth (screenplay), Dick Lehr (based on the book by), Gerard O'Neill (based on the book by)", 0, "data/Movie_Poster_Dataset/2015/tt1355683.jpg", "tt1355683", "7", "96,527" },
                    { 606, 0, 0, "Ed Helms, Christina Applegate, Skyler Gisondo, Steele Stebbins", 1, 0, "1 win & 2 nominations.", 0, "58,879,132", 1, "USA", 0, "John Francis Daley, Jonathan M. Goldstein", 0, 0, 0, 0, 0, "Adventure, Comedy", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWI2YWQxM2MtY2U4Yi00YjgzLTgwNzktN2ExNTgzNTIzMmUzXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Jul-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Vacation", 0, 0, "movie", 0, 0, 0, "Jonathan M. Goldstein, John Francis Daley, John Hughes (characters)", 0, "data/Movie_Poster_Dataset/2015/tt1524930.jpg", "tt1524930", "6.2", "55,490" },
                    { 607, 0, 0, "Sanaa Lathan, Michael Ealy, Morris Chestnut, L. Scott Caldwell", 0, 0, "2 wins & 1 nomination.", 0, "57,017,904", 0, "USA", 0, "David M. Rosenthal", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2IzM2I5NTQtMTIyMy00YWM2LWI1OGMtNjI0MWIyNDZkZGFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Sep-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Perfect Guy", 0, 0, "movie", 0, 0, 0, "Alan B. McElroy (story), Tyger Williams (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3862750.jpg", "tt3862750", "5.5", "5,078" },
                    { 608, 0, 0, "Jennifer Lawrence, Edgar Ramirez, Robert De Niro, Dascha Polanco", 0, 0, "Nominated for 1 Oscar. Another 4 wins & 18 nominations.", 1, "56,443,482", 1, "USA", 0, "David O. Russell", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English, Spanish, French", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDI2OTg2NDQtMzc0MC00MjRiLWI1NzAtMjY2ZDMwMmUyNzBiXkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Dec-15", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "Joy", 0, 0, "movie", 0, 0, 0, "David O. Russell (screenplay), Annie Mumolo (story), David O. Russell (story)", 0, "data/Movie_Poster_Dataset/2015/tt2446980.jpg", "tt2446980", "6.6", "49,874" },
                    { 609, 0, 1, "Miles Teller, Michael B. Jordan, Kate Mara, Jamie Bell", 1, 0, "7 wins & 3 nominations.", 0, "56,114,221", 0, "USA", 0, "Josh Trank", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzQ5NjJiYWQtYjAzMC00NGU0LWFlMDYtNGFiYjFlMWI1NWM0XkEyXkFqcGdeQXVyODQ0OTczOQ@@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Aug-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Fantastic Four", 0, 0, "movie", 0, 0, 0, "Jeremy Slater (screenplay), Simon Kinberg (screenplay), Josh Trank (screenplay), Stan Lee (Marvel comic book), Jack Kirby (Marvel comic book)", 0, "data/Movie_Poster_Dataset/2015/tt1502712.jpg", "tt1502712", "4.3", "97,024" },
                    { 610, 0, 0, "Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh, Walton Goggins", 0, 0, "Won 1 Oscar. Another 28 wins & 96 nominations.", 0, "54,020,527", 0, "USA", 1, "Quentin Tarantino", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Spanish", 0, "68", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjRkY2VhYzMtZWQyNS00OTY2LWE5NTAtYjlhNmQyYzE5MmUxXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Dec-15", "TRUE", 0, "187 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hateful Eight", 0, 0, "movie", 0, 0, 0, "Quentin Tarantino", 0, "data/Movie_Poster_Dataset/2015/tt3460252.jpg", "tt3460252", "7.9", "205,053" },
                    { 612, 0, 1, "Jake Gyllenhaal, Rachel McAdams, Forest Whitaker, Oona Laurence", 0, 0, "7 nominations.", 0, "52,418,902", 0, "USA", 0, "Antoine Fuqua", 0, 1, 0, 0, 0, "Action, Drama, Sport", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2M5Mzg3NjctZTlkNy00MTU0LWFlYTQtY2E2Y2M4NjNiNzllXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Jul-15", "TRUE", 0, "124 min", 0, 0, 1, 0, 0, 0, 0, 0, "Southpaw", 0, 0, "movie", 0, 0, 0, "Kurt Sutter", 0, "data/Movie_Poster_Dataset/2015/tt1798684.jpg", "tt1798684", "7.5", "132,121" },
                    { 613, 0, 0, "Dermot Mulroney, Stefanie Scott, Angus Sampson, Leigh Whannell", 0, 0, "1 win & 6 nominations.", 0, "52,200,504", 0, "Canada, USA", 0, "Leigh Whannell", 0, 0, 0, 0, 1, "Fantasy, Horror, Thriller", 0, 1, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmNhZmJhMmYtNjlkMC00MjhjLTk1NzMtMTNlMzYzNjZlMjNiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Jun-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Insidious: Chapter 3", 0, 0, "movie", 0, 0, 0, "Leigh Whannell, Leigh Whannell (characters)", 0, "data/Movie_Poster_Dataset/2015/tt3195644.jpg", "tt3195644", "6.1", "47,172" },
                    { 614, 0, 1, "Mila Kunis, Channing Tatum, Sean Bean, Eddie Redmayne", 1, 0, "2 wins & 14 nominations.", 0, "47,375,327", 0, "USA, Australia", 0, "Lana Wachowski, Lilly Wachowski", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English, Russian", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGUyYTZmOWItMDJhMi00N2IxLWIyNDMtNjUxM2ZiYmU5YWU1XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "6-Feb-15", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jupiter Ascending", 0, 0, "movie", 0, 0, 0, "Lilly Wachowski, Lana Wachowski", 0, "data/Movie_Poster_Dataset/2015/tt1617661.jpg", "tt1617661", "5.4", "132,233" },
                    { 615, 0, 1, "Emily Blunt, Benicio Del Toro, Josh Brolin, Victor Garber", 0, 0, "Nominated for 3 Oscars. Another 10 wins & 122 nominations.", 0, "46,875,468", 0, "USA", 1, "Denis Villeneuve", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Spanish", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzRmN2E1ZDUtZDc2ZC00ZmI3LTkwOTctNzE2ZDIzMGJiMTYzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Oct-15", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sicario", 0, 0, "movie", 0, 0, 0, "Taylor Sheridan", 0, "data/Movie_Poster_Dataset/2015/tt3397884.jpg", "tt3397884", "7.7", "161,525" },
                    { 616, 0, 1, "Henry Cavill, Armie Hammer, Alicia Vikander, Elizabeth Debicki", 1, 0, "4 wins & 2 nominations.", 0, "45,434,443", 1, "USA, UK", 0, "Guy Ritchie", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Russian, German, Italian", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkzNzYyMzA5N15BMl5BanBnXkFtZTgwODcwODQ3MDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Aug-15", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Man from U.N.C.L.E.", 0, 0, "movie", 0, 0, 0, "Guy Ritchie (screenplay), Lionel Wigram (screenplay), Jeff Kleeman (story), David C. Wilson (story), Guy Ritchie (story), Lionel Wigram (story), Sam Rolfe (television series)", 0, "data/Movie_Poster_Dataset/2015/tt1638355.jpg", "tt1638355", "7.3", "152,816" },
                    { 617, 0, 0, "Mark Ruffalo, Michael Keaton, Rachel McAdams, Liev Schreiber", 0, 0, "Won 2 Oscars. Another 106 wins & 121 nominations.", 1, "44,571,689", 0, "USA, Canada", 0, "Tom McCarthy", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "93", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjZhZTZkNWItZGE1My00MTRkLWI2ZDktMWZkZTIxZWYxOTgzXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Nov-15", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spotlight", 0, 0, "movie", 0, 0, 0, "Josh Singer, Tom McCarthy", 0, "data/Movie_Poster_Dataset/2015/tt1895587.jpg", "tt1895587", "8.2", "128,701" },
                    { 618, 0, 0, "Kevin Costner, Ramiro Rodriguez, Carlos Pratts, Johnny Ortiz", 0, 0, "3 wins & 2 nominations.", 1, "44,469,602", 0, "USA", 0, "Niki Caro", 0, 1, 0, 0, 0, "Biography, Drama, Sport", 0, 0, "English, Spanish", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTA0Y2UyMDUtZGZiOS00ZmVkLTg3NmItODQyNTY1ZjU1MWE4L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Feb-15", "TRUE", 0, "129 min", 0, 0, 1, 0, 0, 0, 0, 0, "McFarland, USA", 0, 0, "movie", 0, 0, 0, "Christopher Cleveland (screenplay), Bettina Gilois (screenplay), Grant Thompson (screenplay), Christopher Cleveland (story), Bettina Gilois (story)", 0, "data/Movie_Poster_Dataset/2015/tt2097298.jpg", "tt2097298", "7.4", "20,645" },
                    { 619, 0, 0, "Joseph Gordon-Levitt, Seth Rogen, Anthony Mackie, Jillian Bell", 0, 0, "1 nomination.", 0, "43,035,725", 1, "USA", 0, "Jonathan Levine", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTY0ZTA1ZjUtN2MyNi00ZGRmLWExYmMtOTkyNzI1NGQ2Y2RlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Nov-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Night Before", 0, 0, "movie", 0, 0, 0, "Jonathan Levine (screenplay), Kyle Hunter (screenplay), Ariel Shaffir (screenplay), Evan Goldberg (screenplay), Jonathan Levine (story)", 0, "data/Movie_Poster_Dataset/2015/tt3530002.jpg", "tt3530002", "6.6", "22,324" },
                    { 620, 0, 0, "Emjay Anthony, Adam Scott, Toni Collette, Stefania LaVie Owen", 0, 0, "1 win & 8 nominations.", 0, "42,592,530", 1, "USA, New Zealand", 0, "Michael Dougherty", 0, 0, 0, 0, 1, "Comedy, Fantasy, Horror", 0, 1, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjc4MTUxN2UtMmU1NC00MjQyLTk3YTYtZTQ0YzEzZDc0Njc0XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Dec-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Krampus", 0, 0, "movie", 0, 0, 0, "Todd Casey, Michael Dougherty, Zach Shields", 0, "data/Movie_Poster_Dataset/2015/tt3850590.jpg", "tt3850590", "6.5", "16,794" },
                    { 621, 0, 0, "Blake Lively, Michiel Huisman, Harrison Ford, Ellen Burstyn", 0, 0, "7 nominations.", 0, "42,478,175", 0, "USA, Canada", 0, "Lee Toland Krieger", 0, 1, 0, 0, 1, "Drama, Fantasy, Romance", 0, 0, "English, Portuguese, Italian", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDFlODBmZTYtMWU4MS00MzY4LWFmYzYtYzAzZmU1MGUzMDE5XkEyXkFqcGdeQXVyNTc1NDM0NDU@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Apr-15", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Age of Adaline", 0, 0, "movie", 0, 0, 0, "J. Mills Goodloe (screenplay), Salvador Paskowitz (screenplay), J. Mills Goodloe (screenplay), J. Mills Goodloe (story), Salvador Paskowitz (story)", 0, "data/Movie_Poster_Dataset/2015/tt1655441.jpg", "tt1655441", "7.2", "82,872" },
                    { 622, 0, 0, "Saoirse Ronan, Hugh Gormley, Brid Brennan, Maeve McGrath", 0, 0, "Nominated for 3 Oscars. Another 28 wins & 133 nominations.", 0, "38,153,369", 0, "Ireland, UK, Canada", 0, "John Crowley", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "87", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzY2NTA1MzUwN15BMl5BanBnXkFtZTgwOTc4NTU4MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Nov-15", "TRUE", 1, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Brooklyn", 0, 0, "movie", 0, 0, 0, "Nick Hornby (screenplay), Colm Tóibín (novel)", 0, "data/Movie_Poster_Dataset/2015/tt2381111.jpg", "tt2381111", "7.5", "52,864" },
                    { 623, 0, 0, "Britt Robertson, Scott Eastwood, Alan Alda, Jack Huston", 0, 0, "1 win & 4 nominations.", 0, "37,432,299", 0, "USA", 0, "George Tillman Jr.", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODcxYjUxZDgtYTQ5Zi00YmQ1LWJmZmItODZkOTYyNDhiNWM3XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Apr-15", "TRUE", 1, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Longest Ride", 0, 0, "movie", 0, 0, 0, "Nicholas Sparks (novel), Craig Bolotin (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2726560.jpg", "tt2726560", "7.1", "43,847" },
                    { 624, 0, 0, "Jennifer Lopez, Ryan Guzman, Ian Nelson, John Corbett", 0, 0, "1 win & 3 nominations.", 0, "35,385,560", 0, "USA", 0, "Rob Cohen", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "30", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWQ3YWJiMDEtMDBhNS00YjY1LTkzNmEtY2U4Njg4MjQ3YWE3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Jan-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Boy Next Door", 0, 0, "movie", 0, 0, 0, "Barbara Curry", 0, "data/Movie_Poster_Dataset/2015/tt3181822.jpg", "tt3181822", "4.6", "24,965" },
                    { 625, 0, 0, "Hugh Jackman, Levi Miller, Garrett Hedlund, Rooney Mara", 1, 0, "4 nominations.", 0, "34,964,818", 0, "USA, UK, Australia", 0, "Joe Wright", 0, 0, 0, 1, 1, "Adventure, Family, Fantasy", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzE1MzdjNmUtOWU5MS00OTgwLWIzYjYtYTYwYTM0NDkyOTU1XkEyXkFqcGdeQXVyMTY5Nzc4MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "9-Oct-15", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pan", 0, 0, "movie", 0, 0, 0, "Jason Fuchs, J.M. Barrie (characters)", 0, "data/Movie_Poster_Dataset/2015/tt3332064.jpg", "tt3332064", "5.9", "31,640" },
                    { 626, 0, 1, "Reese Witherspoon, Sofía Vergara, Matthew Del Negro, Michael Mosley", 0, 0, "4 nominations.", 0, "34,507,079", 1, "USA", 1, "Anne Fletcher", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, Spanish", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWIzZGUxZmItOThkMS00Y2QxLTg0MTYtMDdhMjRlNTNlYTI3L2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-May-15", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hot Pursuit", 0, 0, "movie", 0, 0, 0, "David Feeney, John Quaintance", 0, "data/Movie_Poster_Dataset/2015/tt2967224.jpg", "tt2967224", "5.1", "30,216" },
                    { 627, 0, 0, "Mae Whitman, Robbie Amell, Bella Thorne, Bianca A. Santos", 0, 0, "1 win & 7 nominations.", 0, "34,017,854", 1, "USA", 0, "Ari Sandel", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English, Spanish", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzkwNjk4ODgtYjRmMi00ODdhLWIyNjUtNWQyMjg2N2E2NjlhXkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Feb-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The DUFF", 0, 0, "movie", 0, 0, 0, "Josh A. Cagan (screenplay), Kody Keplinger (novel)", 0, "data/Movie_Poster_Dataset/2015/tt1666801.jpg", "tt1666801", "6.6", "45,821" },
                    { 628, 0, 0, "Helen Mirren, Ryan Reynolds, Daniel Brühl, Katie Holmes", 0, 0, "5 nominations.", 1, "33,305,037", 0, "UK", 0, "Simon Curtis", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English, German", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzg2YTFkNjgtM2ZkNS00MWVkLWIwMTEtZTgzMDM2MmUxNDE2XkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Apr-15", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Woman in Gold", 0, 0, "movie", 0, 0, 0, "Alexi Kaye Campbell, E. Randol Schoenberg (life story), Maria Altmann (life story)", 0, "data/Movie_Poster_Dataset/2015/tt2404425.jpg", "tt2404425", "7.3", "30,101" },
                    { 629, 0, 0, "Dev Patel, Maggie Smith, Danny Mahoney, David Strathairn", 0, 0, "1 nomination.", 0, "33,071,558", 1, "UK, USA", 0, "John Madden", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNjRkOGEwYTUtY2E5Yy00ODg4LTk2ZWItY2IyMzUxOGVhMTM1XkEyXkFqcGdeQXVyNDk0MDg4NDk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "6-Mar-15", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Second Best Exotic Marigold Hotel", 0, 0, "movie", 0, 0, 0, "John Madden (screen story), Ol Parker (screen story), Ol Parker (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2555736.jpg", "tt2555736", "6.6", "20,142" },
                    { 631, 0, 0, "Kevin Connolly, Adrian Grenier, Kevin Dillon, Jerry Ferrara", 0, 0, "N/A", 0, "32,361,416", 1, "USA", 0, "Doug Ellin", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTc1NGViOTMtNjZhNS00OGY2LWI4MmItOWQwNTY4MDMzNWI3L2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Jun-15", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Entourage", 0, 0, "movie", 0, 0, 0, "Doug Ellin (screenplay), Doug Ellin (story), Rob Weiss (story), Doug Ellin (based on characters created by)", 0, "data/Movie_Poster_Dataset/2015/tt1674771.jpg", "tt1674771", "6.7", "54,164" },
                    { 632, 0, 0, "Nat Wolff, Cara Delevingne, Austin Abrams, Justice Smith", 0, 0, "3 wins & 2 nominations.", 0, "31,990,064", 0, "USA", 0, "Jake Schreier", 0, 1, 0, 0, 0, "Drama, Mystery, Romance", 0, 0, "English", 0, "56", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjdiM2IyZmQtODJiYy00NDNkLTllYmItMmFjMDNiYTQyOGVkXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Jul-15", "TRUE", 1, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Paper Towns", 0, 0, "movie", 0, 0, 0, "John Green (book), Scott Neustadter (screenplay), Michael H. Weber (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3622592.jpg", "tt3622592", "6.4", "52,522" },
                    { 633, 0, 1, "Sharlto Copley, Dev Patel, Ninja, Yo-Landi Visser", 0, 0, "1 nomination.", 0, "31,569,268", 0, "USA, Mexico", 1, "Neill Blomkamp", 0, 0, 0, 0, 0, "Action, Crime, Sci-Fi", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk4NDQ0NjgyNF5BMl5BanBnXkFtZTgwMTE3NTkxMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Mar-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chappie", 0, 0, "movie", 0, 0, 0, "Neill Blomkamp, Terri Tatchell", 0, "data/Movie_Poster_Dataset/2015/tt1823672.jpg", "tt1823672", "6.9", "161,688" },
                    { 634, 0, 0, "Mia Wasikowska, Jessica Chastain, Tom Hiddleston, Charlie Hunnam", 0, 0, "1 win & 33 nominations.", 0, "31,056,945", 0, "USA, Canada", 0, "Guillermo del Toro", 0, 1, 0, 0, 1, "Drama, Fantasy, Horror", 0, 1, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjQ4ZDA4NGMtMTkwYi00NThiLThhZDUtZTEzNTAxOWYyY2E4XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Oct-15", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Crimson Peak", 0, 0, "movie", 0, 0, 0, "Guillermo del Toro, Matthew Robbins", 0, "data/Movie_Poster_Dataset/2015/tt2554274.jpg", "tt2554274", "6.6", "69,603" },
                    { 635, 0, 0, "Robert Redford, Nick Nolte, Emma Thompson, Mary Steenburgen", 1, 0, "1 nomination.", 1, "29,467,855", 1, "USA", 0, "Ken Kwapis", 0, 0, 0, 0, 0, "Adventure, Biography, Comedy", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDVmZTZkYjMtNmViZC00ODEzLTgwNDAtNmQ3OGQwOWY5YjFmXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Sep-15", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Walk in the Woods", 0, 0, "movie", 0, 0, 0, "Michael Arndt (screenplay), Bill Holderman (screenplay), Bill Bryson (book)", 0, "data/Movie_Poster_Dataset/2015/tt1178665.jpg", "tt1178665", "6.3", "11,039" },
                    { 636, 0, 0, "James Ransone, Shannyn Sossamon, Robert Daniel Sloan, Dartanian Sloan", 0, 0, "N/A", 0, "27,736,779", 0, "USA, UK", 0, "Ciarán Foy", 0, 0, 0, 0, 0, "Horror, Mystery, Thriller", 0, 1, "English", 0, "32", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjZjOTU3MTMtYTM5YS00YjZmLThmNmMtODcwOTM1NmRiMWM2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Aug-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Sinister 2", 0, 0, "movie", 0, 0, 0, "Scott Derrickson, C. Robert Cargill, Scott Derrickson (characters), C. Robert Cargill (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2752772.jpg", "tt2752772", "5.3", "20,003" },
                    { 637, 0, 1, "Vin Diesel, Rose Leslie, Elijah Wood, Ólafur Darri Ólafsson", 1, 0, "N/A", 0, "27,356,090", 0, "USA, China, Canada", 0, "Breck Eisner", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTJmNmQxNGItNDNlMC00MDU3LWFhNzMtZDQ2NDY0ZTVkNjE3XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-Oct-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Last Witch Hunter", 0, 0, "movie", 0, 0, 0, "Cory Goodman, Matt Sazama, Burk Sharpless", 0, "data/Movie_Poster_Dataset/2015/tt1618442.jpg", "tt1618442", "6", "47,371" },
                    { 638, 0, 1, "Owen Wilson, Lake Bell, Sterling Jerins, Claire Geare", 0, 0, "N/A", 0, "27,285,953", 0, "USA", 0, "John Erick Dowdle", 0, 0, 0, 0, 0, "Action, Thriller", 0, 0, "English, French, Thai, Khmer", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTY3YjYxZGQtMTM2YS00ZmYwLWFlM2QtOWFlMTU1NTAyZDQ2XkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Aug-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 1, "No Escape", 0, 0, "movie", 0, 0, 0, "John Erick Dowdle, Drew Dowdle", 0, "data/Movie_Poster_Dataset/2015/tt1781922.jpg", "tt1781922", "6.8", "41,519" },
                    { 639, 0, 0, "Meryl Streep, Rick Springfield, Rick Rosas, Joe Vitale", 0, 0, "3 nominations.", 0, "26,822,144", 1, "USA", 0, "Jonathan Demme", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "54", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjMyYjgyOTQtZDVlZS00NTQ0LWJiNDItNGRlZmM3Yzc0N2Y0XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Aug-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ricki and the Flash", 0, 0, "movie", 0, 0, 0, "Diablo Cody", 0, "data/Movie_Poster_Dataset/2015/tt3623726.jpg", "tt3623726", "6", "11,864" },
                    { 640, 0, 1, "Liam Neeson, Ed Harris, Joel Kinnaman, Boyd Holbrook", 0, 0, "N/A", 0, "26,442,251", 0, "USA", 1, "Jaume Collet-Serra", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAxYjEyMTctZTg3Ni00MGZmLWIxMmMtOGM2NTFiY2U3MmExXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Mar-15", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Run All Night", 0, 0, "movie", 0, 0, 0, "Brad Ingelsby", 0, "data/Movie_Poster_Dataset/2015/tt2199571.jpg", "tt2199571", "6.6", "70,675" },
                    { 641, 0, 0, "Steve Martin, Diane Keaton, John Goodman, Ed Helms", 0, 0, "1 nomination.", 0, "26,284,475", 1, "USA", 0, "Jessie Nelson", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTlkMmVmYjktYTc2NC00ZGZjLWEyOWUtMjc2MDMwMjQwOTA5XkEyXkFqcGdeQXVyNTI4MzE4MDU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Nov-15", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love the Coopers", 0, 0, "movie", 0, 0, 0, "Steven Rogers (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2279339.jpg", "tt2279339", "5.7", "6,897" },
                    { 642, 0, 0, "Mark Duplass, Olivia Wilde, Sarah Bolger, Evan Peters", 0, 0, "N/A", 0, "25,799,043", 0, "USA", 0, "David Gelb", 0, 0, 0, 0, 0, "Horror, Sci-Fi, Thriller", 0, 1, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmVhN2JlYjEtZWFkOS00YzE0LThiNDMtMGI3NDA1MTk2ZDQ2XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Feb-15", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Lazarus Effect", 0, 0, "movie", 0, 0, 0, "Luke Dawson, Jeremy Slater", 0, "data/Movie_Poster_Dataset/2015/tt2918436.jpg", "tt2918436", "5.2", "25,797" },
                    { 643, 0, 0, "Domhnall Gleeson, Corey Johnson, Oscar Isaac, Alicia Vikander", 0, 0, "Won 1 Oscar. Another 59 wins & 127 nominations.", 0, "25,440,971", 0, "UK", 0, "Alex Garland", 0, 1, 0, 0, 0, "Drama, Mystery, Sci-Fi", 0, 0, "English", 0, "78", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjcyYjg0M2ItMzMyZS00NmM1LTlhZDMtN2MxN2RhNWY4YTkwXkEyXkFqcGdeQXVyNjY1MTg4Mzc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Apr-15", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ex Machina", 0, 0, "movie", 0, 0, 0, "Alex Garland", 0, "data/Movie_Poster_Dataset/2015/tt0470752.jpg", "tt0470752", "7.7", "261,150" },
                    { 644, 0, 1, "Chris Hemsworth, Benjamin Walker, Cillian Murphy, Brendan Gleeson", 1, 0, "1 win & 2 nominations.", 1, "24,985,612", 0, "USA, Australia, Spain, UK, Canada", 0, "Ron Howard", 0, 0, 0, 0, 0, "Action, Adventure, Biography", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTBkMjMyN2UtNzVjNi00Y2ZiLTk2MDYtN2Y0MjgzYjAxNzE4XkEyXkFqcGdeQXVyNjkxOTM4ODY@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Dec-15", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "In the Heart of the Sea", 0, 0, "movie", 0, 0, 0, "Charles Leavitt (screenplay), Charles Leavitt (story), Rick Jaffa (story), Amanda Silver (story), Nathaniel Philbrick (book)", 0, "data/Movie_Poster_Dataset/2015/tt1390411.jpg", "tt1390411", "7", "46,422" },
                    { 645, 0, 0, "Reese Mishler, Pfeifer Brown, Ryan Shoos, Cassidy Gifford", 0, 0, "N/A", 0, "22,757,819", 0, "USA", 0, "Travis Cluff, Chris Lofing", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2YyZjQ0NTEtNzU5MS00NGZkLTg0MTEtYzJmMWY3MWRhZjM2XkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jul-15", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Gallows", 0, 0, "movie", 0, 0, 0, "Travis Cluff, Chris Lofing", 0, "data/Movie_Poster_Dataset/2015/tt2309260.jpg", "tt2309260", "4.3", "11,736" },
                    { 646, 0, 1, "Angelababy, Dan Bakkedahl, Charlene Beck, Michael Bornhütter", 0, 0, "N/A", 0, "22,464,430", 0, "USA, Germany, UK", 1, "Aleksander Bach", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDQzZmQ5MjItYmJlNy00MGI2LWExMDQtMjBiNjNmMzc5NTk1XkEyXkFqcGdeQXVyNjY1OTY4MTk@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Aug-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 1, "Hitman: Agent 47", 0, 0, "movie", 0, 0, 0, "Skip Woods (screenplay), Michael Finch (screenplay), Skip Woods (story)", 0, "data/Movie_Poster_Dataset/2015/tt2679042.jpg", "tt2679042", "5.8", "54,539" },
                    { 647, 0, 0, "Jonny Weston, Sofia Black-D'Elia, Sam Lerner, Allen Evangelista", 0, 0, "N/A", 0, "22,331,028", 0, "USA", 0, "Dean Israelite", 0, 0, 0, 0, 0, "Sci-Fi, Thriller", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzg2Mzg4YmUtNDdkNy00NWY1LWE3NmEtZWMwNGNlMzE5YzU3XkEyXkFqcGdeQXVyMjA5MTIzMjQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Jan-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "Project Almanac", 0, 0, "movie", 0, 0, 0, "Jason Pagan, Andrew Deutschman", 0, "data/Movie_Poster_Dataset/2015/tt2436386.jpg", "tt2436386", "6.4", "52,591" },
                    { 649, 0, 0, "Bradley Cooper, Emma Stone, Rachel McAdams, Bill Murray", 0, 0, "1 win & 6 nominations.", 0, "20,991,497", 1, "USA", 0, "Cameron Crowe", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmYwNWZlNzEtNjE4Zi00NzQ4LWI2YmUtOWZhNzZhZDYyNmVmXkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-May-15", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Aloha", 0, 0, "movie", 0, 0, 0, "Cameron Crowe", 0, "data/Movie_Poster_Dataset/2015/tt1243974.jpg", "tt1243974", "5.5", "34,947" },
                    { 650, 0, 0, "Justin Fletcher, John Sparkes, Omid Djalili, Richard Webber", 1, 1, "Nominated for 1 Oscar. Another 1 win & 47 nominations.", 0, "19,369,813", 1, "UK, France", 0, "Mark Burton, Richard Starzak", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "N/A", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BY2YxNjQxYWYtYzNkMi00YTgyLWIwZTMtYzgyYjZlZmYzZTA0XkEyXkFqcGdeQXVyMTA4NjE0NjEy._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "5-Aug-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shaun the Sheep Movie", 0, 0, "movie", 0, 0, 0, "Mark Burton, Richard Starzak, Nick Park (characters created by), Callum Blades", 0, "data/Movie_Poster_Dataset/2015/tt2872750.jpg", "tt2872750", "7.4", "21,440" },
                    { 651, 0, 0, "Chris J. Murray, Brit Shaw, Ivy George, Dan Gill", 0, 0, "1 nomination.", 0, "18,247,445", 0, "USA", 0, "Gregory Plotkin", 0, 0, 0, 0, 0, "Horror", 0, 1, "English, German", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA2Mzg2NDMzNl5BMl5BanBnXkFtZTgwMjcwODUzOTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Oct-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Paranormal Activity: The Ghost Dimension", 0, 0, "movie", 0, 0, 0, "Jason Pagan (screenplay), Andrew Deutschman (screenplay), Adam Robitel (screenplay), Gavin Heffernan (screenplay), Brantley Aufill (story), Jason Pagan (story), Andrew Deutschman (story), Oren Peli (based on the film \\\\", 0, "data/Movie_Poster_Dataset/2015/tt2473510.jpg", "tt2473510", "4.6", "12,671" },
                    { 652, 0, 0, "Michael Fassbender, Kate Winslet, Seth Rogen, Jeff Daniels", 0, 0, "Nominated for 2 Oscars. Another 18 wins & 101 nominations.", 1, "17,750,583", 0, "USA, UK", 0, "Danny Boyle", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjAzZjZiMmQtMDZmOC00NjVmLTkyNTItOGI2Mzg4NTBhZTA1XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Oct-15", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "Steve Jobs", 0, 0, "movie", 0, 0, 0, "Aaron Sorkin (screenplay), Walter Isaacson (book)", 0, "data/Movie_Poster_Dataset/2015/tt3565344.jpg", "tt3565344", "7.3", "75,114" },
                    { 653, 0, 0, "Ian McKellen, Laura Linney, Milo Parker, Hiroyuki Sanada", 0, 0, "14 nominations.", 0, "17,735,503", 0, "UK, USA", 0, "Bill Condon", 0, 1, 0, 0, 0, "Drama, Mystery", 0, 0, "English, Japanese, French", 0, "67", 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTYxMjk0NDg4Ml5BMl5BanBnXkFtZTgwODcyNjA5OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "24-Jul-15", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mr. Holmes", 0, 0, "movie", 0, 0, 0, "Mitch Cullin (novel), Jeffrey Hatcher (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3168230.jpg", "tt3168230", "7", "34,979" },
                    { 654, 0, 0, "Rakim Mayers, Blake Anderson, Bruce Beatty, De'aundre Bonds", 0, 0, "6 wins & 20 nominations.", 0, "17,474,107", 1, "USA", 1, "Rick Famuyiwa", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA0MzQzNjM1Ml5BMl5BanBnXkFtZTgwNjM5MjU5NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Jun-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dope", 0, 0, "movie", 0, 0, 0, "Rick Famuyiwa", 0, "data/Movie_Poster_Dataset/2015/tt3850214.jpg", "tt3850214", "7.3", "46,982" },
                    { 655, 0, 0, "Tina Fey", 0, 0, "1 nomination.", 0, "16,427,836", 0, "USA", 0, "Mark Linfield, Alastair Fothergill", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEwMzMxODIzOV5BMl5BanBnXkFtZTgwNzg3OTAzMDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "17-Apr-15", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monkey Kingdom", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3660770.jpg", "tt3660770", "7.3", "2,204" },
                    { 656, 0, 1, "Ed Skrein, Ray Stevenson, Loan Chabanol, Gabriella Wright", 0, 0, "N/A", 0, "16,027,866", 0, "France, China, Belgium", 1, "Camille Delamarre", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjQ0MTgyNjAxMV5BMl5BanBnXkFtZTgwNjUzMDkyODE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Sep-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Transporter Refueled", 0, 0, "movie", 0, 0, 0, "Adam Cooper, Bill Collage, Luc Besson, Luc Besson (characters), Robert Mark Kamen (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2938956.jpg", "tt2938956", "5.1", "22,523" },
                    { 657, 0, 0, "Brie Larson, Jacob Tremblay, Sean Bridgers, Wendy Crewson", 0, 0, "Won 1 Oscar. Another 79 wins & 124 nominations.", 0, "14,662,988", 0, "Ireland, Canada", 0, "Lenny Abrahamson", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "86", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA1MTc1NTg5NV5BMl5BanBnXkFtZTgwOTM2MDEzNzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Jan-16", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Room", 0, 0, "movie", 0, 0, 0, "Emma Donoghue (screenplay), Emma Donoghue (based on the novel by)", 0, "data/Movie_Poster_Dataset/2015/tt3170832.jpg", "tt3170832", "8.3", "98,027" },
                    { 658, 0, 1, "Jesse Eisenberg, Kristen Stewart, Topher Grace, Connie Britton", 0, 0, "N/A", 0, "14,434,604", 1, "USA, Switzerland", 0, "Nima Nourizadeh", 0, 0, 0, 0, 0, "Action, Comedy", 0, 0, "English, Mandarin", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2QzYTQyYzItMzAwYi00YjZlLThjNTUtNzMyMDdkYzJiNWM4XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Aug-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Ultra", 0, 0, "movie", 0, 0, 0, "Max Landis", 0, "data/Movie_Poster_Dataset/2015/tt3316948.jpg", "tt3316948", "6.1", "44,683" },
                    { 659, 0, 0, "Sean Astin, Nic Bishop, Caleb Castille, Sherri Shepherd", 0, 0, "1 nomination.", 0, "14,393,862", 0, "USA", 0, "Andrew Erwin, Jon Erwin", 0, 1, 0, 0, 0, "Drama, Sport", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTU3NjE2NjgwN15BMl5BanBnXkFtZTgwNDYzMzEwMzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "16-Oct-15", "TRUE", 0, "123 min", 0, 0, 1, 0, 0, 0, 0, 0, "Woodlawn", 0, 0, "movie", 0, 0, 0, "Jon Erwin, Quinton Peeples", 0, "data/Movie_Poster_Dataset/2015/tt4183692.jpg", "tt4183692", "6.5", "2,778" },
                    { 660, 0, 0, "Bradley Cooper, Sienna Miller, Daniel Brühl, Riccardo Scamarcio", 0, 0, "6 wins.", 0, "13,650,738", 1, "USA", 0, "John Wells", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, French", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU2OTcyOTE3MF5BMl5BanBnXkFtZTgwNTg5Mjc1MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Burnt", 0, 0, "movie", 0, 0, 0, "Steven Knight (screenplay), Michael Kalesniko (story)", 0, "data/Movie_Poster_Dataset/2015/tt2503944.jpg", "tt2503944", "6.6", "47,197" },
                    { 661, 0, 0, "Senyo Amoaku, Sean Astin, Brian Bosworth, Valerie Domínguez", 0, 0, "N/A", 0, "12,985,267", 0, "USA", 0, "Jon Gunn", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "22", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTcxNTgzNDg1N15BMl5BanBnXkFtZTgwNjg4MzI1MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Mar-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Do You Believe?", 0, 0, "movie", 0, 0, 0, "Chuck Konzelman, Cary Solomon", 0, "data/Movie_Poster_Dataset/2015/tt4056738.jpg", "tt4056738", "5.9", "4,514" },
                    { 662, 0, 0, "Cate Blanchett, Rooney Mara, Kyle Chandler, Jake Lacy", 0, 0, "Nominated for 6 Oscars. Another 57 wins & 202 nominations.", 0, "253,510", 0, "UK, USA", 0, "Todd Haynes", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "95", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjg5NmI3NmUtZDQ2Mi00ZTI0LWE0YzAtOGRhOWJmNDJkOWNkXkEyXkFqcGdeQXVyMzIzNDU1NTY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-Jan-16", "TRUE", 1, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Carol", 0, 0, "movie", 0, 0, 0, "Phyllis Nagy (screenplay), Patricia Highsmith (novel)", 0, "data/Movie_Poster_Dataset/2015/tt2402927.jpg", "tt2402927", "7.3", "47,504" },
                    { 663, 0, 0, "Aomi Muyock, Karl Glusman, Klara Kristin, Ugo Fox", 0, 0, "1 win & 1 nomination.", 0, "null", 0, "France, Belgium", 0, "Gaspar Noé", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, French", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUwMzc1NjIzMV5BMl5BanBnXkFtZTgwODUyMTIxMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "30-Oct-15", "TRUE", 1, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love", 0, 0, "movie", 0, 0, 0, "Gaspar Noé", 0, "data/Movie_Poster_Dataset/2015/tt3774694.jpg", "tt3774694", "6", "13,376" },
                    { 664, 0, 0, "Alan Cumming, Evan Rachel Wood, Elijah Kelley, Meredith Anne Bull", 0, 1, "1 nomination.", 0, "12,427,046", 0, "USA", 0, "Gary Rydstrom", 0, 0, 0, 1, 1, "Animation, Family, Fantasy", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYWNlODE1ZTEtOTQ5MS00N2QwLTllNjItZDQ2Y2UzMmU5YmI2XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG", 0, 0, "23-Jan-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Strange Magic", 0, 0, "movie", 0, 0, 0, "David Berenbaum (screenplay), Irene Mecchi (screenplay), Gary Rydstrom (screenplay), George Lucas (story)", 0, "data/Movie_Poster_Dataset/2015/tt4191054.jpg", "tt4191054", "5.7", "5,809" },
                    { 665, 0, 0, "Rob Corddry, Craig Robinson, Clark Duke, Adam Scott", 0, 0, "2 nominations.", 0, "12,282,677", 1, "USA", 0, "Steve Pink", 0, 0, 0, 0, 0, "Comedy, Sci-Fi", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDliOTIzNmUtOTllOC00NDU3LWFiNjYtMGM0NDc1YTMxNjYxXkEyXkFqcGdeQXVyNTM3NzExMDQ@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Feb-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hot Tub Time Machine 2", 0, 0, "movie", 0, 0, 0, "Josh Heald, Josh Heald (characters)", 0, "data/Movie_Poster_Dataset/2015/tt2637294.jpg", "tt2637294", "5.1", "26,112" },
                    { 666, 0, 1, "Ryan Reynolds, Natalie Martinez, Matthew Goode, Ben Kingsley", 0, 0, "N/A", 0, "12,276,810", 0, "USA", 0, "Tarsem Singh", 0, 0, 0, 0, 0, "Action, Mystery, Sci-Fi", 0, 0, "English", 0, "34", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA1ODUzMDA3NzFeQTJeQWpwZ15BbWU3MDgxMTYxNTk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Jul-15", "TRUE", 0, "117 min", 0, 0, 0, 0, 0, 0, 0, 0, "Self/less", 0, 0, "movie", 0, 0, 0, "David Pastor (screenplay), Àlex Pastor (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2140379.jpg", "tt2140379", "6.5", "50,343" },
                    { 667, 0, 0, "Carey Mulligan, Matthias Schoenaerts, Tilly Vosburgh, Mark Wingett", 0, 0, "4 nominations.", 0, "12,229,314", 0, "UK, USA", 0, "Thomas Vinterberg", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjQ5YWVmYmYtOWFiZC00NGMxLWEwODctZDM2MWI4YWViN2E5XkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-May-15", "TRUE", 1, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Far from the Madding Crowd", 0, 0, "movie", 0, 0, 0, "Thomas Hardy (novel), David Nicholls (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2935476.jpg", "tt2935476", "7.1", "25,263" },
                    { 668, 0, 0, "Antonio Banderas, Rodrigo Santoro, Juliette Binoche, James Brolin", 0, 0, "1 win & 1 nomination.", 1, "12,188,642", 0, "USA, Chile", 0, "Patricia Riggen", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English, Spanish", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU4NDg0MzkzNV5BMl5BanBnXkFtZTgwODA3Mzc1MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Nov-15", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "The 33", 0, 0, "movie", 0, 0, 0, "Mikko Alanne (screenplay), Craig Borten (screenplay), Michael Thomas (screenplay), Jose Rivera (screen story), Hector Tobar (book)", 0, "data/Movie_Poster_Dataset/2015/tt2006295.jpg", "tt2006295", "6.9", "14,517" },
                    { 669, 0, 0, "Alicia Vikander, Eddie Redmayne, Tusse Silberg, Adrian Schiller", 0, 0, "Won 1 Oscar. Another 25 wins & 64 nominations.", 1, "12,706,393", 0, "UK, USA, Belgium, Denmark, Germany", 0, "Tom Hooper", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English, French, German", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYzMDM4NzkxOV5BMl5BanBnXkFtZTgwNzM1Mzg2NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-Jan-16", "TRUE", 1, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Danish Girl", 0, 0, "movie", 0, 0, 0, "David Ebershoff (novel), Lucinda Coxon (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt0810819.jpg", "tt0810819", "7", "52,609" },
                    { 670, 0, 1, "Sean Penn, Jasmine Trinca, Javier Bardem, Ray Winstone", 0, 0, "N/A", 0, "10,640,645", 0, "USA, Spain, UK, France", 1, "Pierre Morel", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Spanish", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ4MzQ3NjA0N15BMl5BanBnXkFtZTgwODQyNjQ4MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Mar-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Gunman", 0, 0, "movie", 0, 0, 0, "Jean-Patrick Manchette (novel), Don MacPherson (screenplay), Pete Travis (screenplay), Sean Penn (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2515034.jpg", "tt2515034", "5.8", "26,041" },
                    { 671, 0, 0, "Vince Vaughn, Tom Wilkinson, Dave Franco, Sienna Miller", 0, 0, "N/A", 0, "10,214,013", 1, "USA", 0, "Ken Scott", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzllMWI1ZDQtMmFhNS00NzJkLThmMTMtNzFmMmMyYjU3ZGVjXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Mar-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Unfinished Business", 0, 0, "movie", 0, 0, 0, "Steve Conrad", 0, "data/Movie_Poster_Dataset/2015/tt2358925.jpg", "tt2358925", "5.4", "21,102" },
                    { 672, 0, 0, "Joseph Gordon-Levitt, Guillaume Baillargeon, Émilie Leclerc, Mark Trafford", 1, 0, "2 wins & 14 nominations.", 1, "10,137,502", 0, "USA", 0, "Robert Zemeckis", 0, 1, 0, 0, 0, "Adventure, Biography, Drama", 0, 0, "English, French", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzMwMTAwODczN15BMl5BanBnXkFtZTgwMDk2NDA4MTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "9-Oct-15", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Walk", 0, 0, "movie", 0, 0, 0, "Robert Zemeckis (screenplay), Christopher Browne (screenplay), Philippe Petit (book)", 0, "data/Movie_Poster_Dataset/2015/tt3488710.jpg", "tt3488710", "7.4", "63,408" },
                    { 673, 0, 0, "Maggie Smith, Jim Broadbent, Clare Hammond, George Fenton", 0, 0, "Nominated for 1 Golden Globe. Another 1 win & 3 nominations.", 1, "9,458,286", 1, "UK", 0, "Nicholas Hytner", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDc4MThhN2EtZjMzNC00ZDJmLThiZTgtNThlY2UxZWMzNjdkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Nov-15", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lady in the Van", 0, 0, "movie", 0, 0, 0, "Alan Bennett", 0, "data/Movie_Poster_Dataset/2015/tt3722070.jpg", "tt3722070", "6.8", "5,392" },
                    { 674, 0, 0, "Bruno Bichir, Carlos Espejel, Angélica Vale, Omar Chaparro", 0, 1, "N/A", 0, "9,069,010", 0, "Mexico", 0, "Gabriel Riva Palacio Alatriste, Rodolfo Riva-Palacio Alatriste", 0, 0, 0, 0, 0, "Animation", 0, 0, "Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzM2OGQ2NzUtNzlmYi00ZDg4LWExODgtMDVmOTU2Yzg2N2U5XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Sep-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Un gallo con muchos huevos", 0, 0, "movie", 0, 0, 0, "Marqus Bobesich (english adaptation), Andrzej Rattinger (Additional English adaptation writing by), Gabriel Riva Palacio Alatriste, Rodolfo Riva-Palacio Alatriste, Melanie Simka (english adaptation), Mychal Simka (english version), Jocelyn Wright (english adaptation)", 0, "data/Movie_Poster_Dataset/2015/tt4643580.jpg", "tt4643580", "6", "505" },
                    { 675, 0, 0, "Amy Winehouse, Lauren Gilbert, Juliette Ashby, Nick Shymansky", 0, 0, "Won 1 Oscar. Another 40 wins & 40 nominations.", 1, "8,412,034", 0, "UK, USA", 0, "Asif Kapadia", 1, 0, 0, 0, 0, "Documentary, Biography, Music", 0, 0, "English", 0, "85", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjRmNjc5MTYtYjc3My00ZjNiLTg4YjUtMTQ0ZTFkZmMxMDUzXkEyXkFqcGdeQXVyNDY5MTUyNjU@._V1_UY98_CR3,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Jul-15", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Amy", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt2870648.jpg", "tt2870648", "7.8", "25,490" },
                    { 676, 0, 0, "Salman Khan, Kareena Kapoor, Nawazuddin Siddiqui, Harshaali Malhotra", 0, 0, "N/A", 0, "7,655,452", 1, "India", 0, "Kabir Khan", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "Hindi, Urdu, Panjabi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTczNDk4NTQ0OV5BMl5BanBnXkFtZTcwNDAxMDgxNw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "17-Jul-15", "TRUE", 0, "163 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bajrangi Bhaijaan", 0, 0, "movie", 0, 0, 0, "Vijayendra Prasad (original story), Vijayendra Prasad (screenplay), Kabir Khan (screenplay), Parveez Sheikh (screenplay), Asad Hussain (screenplay), Kausar Munir (dialogue), Kabir Khan (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt3863552.jpg", "tt3863552", "8.2", "37,699" },
                    { 677, 0, 1, "Masako Nozawa, Ryô Horikawa, Hiromi Tsuru, Masaharu Satô", 1, 1, "1 nomination.", 0, "7,232,704", 0, "Japan", 0, "Tadayoshi Yamamuro", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODhiZWRhMjctNDUyMS00NmUwLTgwYmItMjJhOWNkZWQ3ZTQxXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "4-Aug-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dragon Ball Z: Resurrection 'F'", 0, 0, "movie", 0, 0, 0, "Jared Hedges (english adaptation), Akira Toriyama (manga), Akira Toriyama (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3819668.jpg", "tt3819668", "7.6", "11,925" },
                    { 678, 0, 1, "Chris Hemsworth, Leehom Wang, Wei Tang, Viola Davis", 0, 0, "1 nomination.", 0, "7,097,125", 0, "USA", 1, "Michael Mann", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Mandarin, Spanish", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgzMTkxNjAxNV5BMl5BanBnXkFtZTgwMDU3MDE0MjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Jan-15", "TRUE", 0, "133 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blackhat", 0, 0, "movie", 0, 0, 0, "Morgan Davis Foehl", 0, "data/Movie_Poster_Dataset/2015/tt2855042.jpg", "tt2855042", "5.4", "36,177" },
                    { 679, 0, 1, "Johnny Depp, Gwyneth Paltrow, Paul Bettany, Ewan McGregor", 0, 0, "4 nominations.", 0, "7,605,668", 1, "UK, USA", 0, "David Koepp", 0, 0, 0, 0, 0, "Action, Comedy, Mystery", 0, 0, "English", 0, "27", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA5MzkyMzIxNjJeQTJeQWpwZ15BbWU4MDU0MDk0OTUx._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Jan-15", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mortdecai", 0, 0, "movie", 0, 0, 0, "Eric Aronson (screenplay), Kyril Bonfiglioli (novel)", 0, "data/Movie_Poster_Dataset/2015/tt3045616.jpg", "tt3045616", "5.5", "43,407" },
                    { 680, 0, 0, "Blythe Danner, June Squibb, Rhea Perlman, Mary Kay Place", 0, 0, "7 nominations.", 0, "7,425,963", 1, "USA", 0, "Brett Haley", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQzMTg0NDA1M15BMl5BanBnXkFtZTgwODUzMTE0MjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-May-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "I'll See You in My Dreams", 0, 0, "movie", 0, 0, 0, "Marc Basch, Brett Haley", 0, "data/Movie_Poster_Dataset/2015/tt3236120.jpg", "tt3236120", "6.7", "3,811" },
                    { 681, 0, 0, "Thomas Mann, RJ Cyler, Olivia Cooke, Nick Offerman", 0, 0, "15 wins & 24 nominations.", 0, "6,743,776", 1, "USA", 0, "Alfonso Gomez-Rejon", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "74", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2ViOTU5MDQtZTRiZi00YjViLWFiY2ItOTRhNWYyN2ZiMzUyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jul-15", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Me and Earl and the Dying Girl", 0, 0, "movie", 0, 0, 0, "Jesse Andrews (novel), Jesse Andrews (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2582496.jpg", "tt2582496", "7.8", "63,167" },
                    { 682, 0, 1, "Prabhas, Rana Daggubati, Anushka Shetty, Tamannaah Bhatia", 1, 0, "6 nominations.", 0, "6,498,000", 0, "India", 0, "S.S. Rajamouli", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "Telugu, Tamil", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzU0NDY0NDEzNV5BMl5BanBnXkFtZTgwOTIxNDU1MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Jul-15", "TRUE", 0, "159 min", 0, 0, 0, 0, 0, 0, 0, 0, "Baahubali: The Beginning", 0, 0, "movie", 0, 0, 0, "Vijayendra Prasad (story), S.S. Rajamouli (screenplay), C.H. Vijay Kumar (telugu dialogue), Ajay Kumar (telugu dialogue), Madhan Karky (tamil dialogue), Manoj Muntashir (hindi dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt2631186.jpg", "tt2631186", "8.6", "58,933" },
                    { 683, 0, 0, "Priyanka Chopra, Deepika Padukone, Irrfan Khan, Ranveer Singh", 0, 0, "6 wins & 7 nominations.", 0, "6,557,047", 0, "India", 0, "Sanjay Leela Bhansali", 0, 1, 0, 0, 0, "Drama, History, Romance", 1, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2OTYyNzUxOF5BMl5BanBnXkFtZTcwMzUwMDY4Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 1, "158 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bajirao Mastani", 0, 0, "movie", 0, 0, 0, "Nagnath S. Inamdar (novel), Sanjay Leela Bhansali (additional writer), Prakash Kapadia", 0, "data/Movie_Poster_Dataset/2015/tt3735246.jpg", "tt3735246", "7.3", "14,276" },
                    { 684, 0, 0, "Ted Levine, Kevin James, Emily Watson, Michael Rapaport", 0, 0, "1 nomination.", 0, "6,420,319", 0, "Mexico, USA", 0, "Alejandro Monteverde", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English", 0, "30", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc2Mjc0MDg3MV5BMl5BanBnXkFtZTcwMjUzMDkxMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Apr-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Little Boy", 0, 0, "movie", 0, 1, 0, "Alejandro Monteverde, Pepe Portillo", 0, "data/Movie_Poster_Dataset/2015/tt1810683.jpg", "tt1810683", "7.4", "13,768" },
                    { 686, 0, 0, "Daniel Radcliffe, Jessica Brown Findlay, Bronson Webb, James McAvoy", 0, 0, "3 wins & 1 nomination.", 0, "5,773,519", 0, "USA", 0, "Paul McGuigan", 0, 1, 0, 0, 0, "Drama, Sci-Fi, Thriller", 0, 0, "English", 0, "36", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjYzOGE1MjUtODgyMy00ZDAxLTljYTgtNzk0Njg2YWQwMTZhXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Nov-15", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 1, "Victor Frankenstein", 0, 0, "movie", 0, 0, 0, "Max Landis (screenplay), Max Landis (screen story), Mary Shelley (novel)", 0, "data/Movie_Poster_Dataset/2015/tt1976009.jpg", "tt1976009", "6", "18,438" },
                    { 687, 0, 0, "Al Pacino, Annette Bening, Jennifer Garner, Bobby Cannavale", 0, 0, "Nominated for 1 Golden Globe. Another 1 win & 1 nomination.", 0, "5,348,317", 1, "USA", 0, "Dan Fogelman", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "58", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTNjM2Y2ZjgtMDc5NS00MDQ1LTgyNGYtYzYwMTAyNWQwYTMyXkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Apr-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Danny Collins", 0, 0, "movie", 0, 0, 0, "Dan Fogelman", 0, "data/Movie_Poster_Dataset/2015/tt1772288.jpg", "tt1772288", "7.1", "18,347" },
                    { 688, 0, 1, "Shah Rukh Khan, Kajol, Kriti Sanon, Varun Dhawan", 0, 0, "1 nomination.", 0, "4,830,637", 1, "India", 1, "Rohit Shetty", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "Indian Sign Language, Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM0ODk3MjM1MV5BMl5BanBnXkFtZTcwNzc1MDIwNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 0, "158 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dilwale", 0, 0, "movie", 0, 0, 0, "Yunus Sajawal (screenplay), Farhad (dialogue), Sajid (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt4535650.jpg", "tt4535650", "5.5", "18,608" },
                    { 689, 0, 0, "Hayden Christensen, Kate Bosworth, Hudson Meek, Bobby Batson", 0, 0, "N/A", 0, "4,700,361", 0, "USA", 0, "Michael Polish", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM4NzQ0OTYyOF5BMl5BanBnXkFtZTcwMDkyNjQyMg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Sep-15", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "90 Minutes in Heaven", 0, 0, "movie", 0, 0, 0, "Don Piper (book), Michael Polish (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4337690.jpg", "tt4337690", "4.6", "1,680" },
                    { 690, 0, 0, "Jonah Hill, James Franco, Felicity Jones, Maria Dizzia", 0, 0, "3 nominations.", 0, "4,715,819", 0, "USA", 1, "Rupert Goold", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Ibo", 0, "50", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTMzMTc3MjA5NF5BMl5BanBnXkFtZTcwOTk3MDE5MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Apr-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "True Story", 0, 0, "movie", 0, 0, 0, "Rupert Goold (screenplay), David Kajganich (screenplay), Michael Finkel (based on the book by)", 0, "data/Movie_Poster_Dataset/2015/tt2273657.jpg", "tt2273657", "6.3", "31,473" },
                    { 691, 0, 0, "Anne-Marie Duff, Grace Stottor, Geoff Bell, Carey Mulligan", 0, 0, "14 wins & 9 nominations.", 1, "4,693,356", 0, "UK", 0, "Sarah Gavron", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWUxZjJkMDktZmMxMS00Mzg3LTk4MDItN2IwODlmN2E0MTM0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Oct-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Suffragette", 0, 0, "movie", 0, 0, 0, "Abi Morgan", 0, "data/Movie_Poster_Dataset/2015/tt3077214.jpg", "tt3077214", "6.9", "13,771" },
                    { 692, 0, 1, "Salman Khan, Sonam Kapoor, Anupam Kher, Neil Nitin Mukesh", 0, 0, "N/A", 0, "4,328,805", 0, "India", 0, "Sooraj R. Barjatya", 0, 1, 0, 0, 0, "Action, Drama, Romance", 0, 0, "Hindi, Tamil", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "12-Nov-15", "TRUE", 1, "164 min", 0, 0, 0, 0, 0, 0, 0, 0, "Prem Ratan Dhan Payo", 0, 0, "movie", 0, 0, 0, "Sooraj R. Barjatya (story), Aash Karan Atal (dialogue), Sooraj R. Barjatya", 0, "data/Movie_Poster_Dataset/2015/tt3595298.jpg", "tt3595298", "5", "9,506" },
                    { 693, 0, 0, "Charlotte Rampling, Tom Courtenay, Geraldine James, Dolly Wells", 0, 0, "Nominated for 1 Oscar. Another 19 wins & 40 nominations.", 0, "4,250,507", 0, "UK", 0, "Andrew Haigh", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "94", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzgxMzYyNzAyOF5BMl5BanBnXkFtZTcwODY5MjY3MQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Dec-15", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "45 Years", 0, 0, "movie", 0, 0, 0, "David Constantine (short story 'In Another Country'), Andrew Haigh (adaptation)", 0, "data/Movie_Poster_Dataset/2015/tt3544082.jpg", "tt3544082", "7.1", "13,732" },
                    { 694, 0, 0, "Joaquin Phoenix, Emma Stone, Joe Stapleton, Nancy Carroll", 0, 0, "2 nominations.", 0, "4,027,764", 0, "USA", 0, "Woody Allen", 0, 1, 0, 0, 0, "Drama, Mystery", 0, 0, "English", 0, "53", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGRiYjE0YzItMzk3Zi00ZmYwLWJjNDktYTAwYjIwMjIxYzM3XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Aug-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Irrational Man", 0, 0, "movie", 0, 0, 0, "Woody Allen", 0, "data/Movie_Poster_Dataset/2015/tt3715320.jpg", "tt3715320", "6.7", "22,948" },
                    { 695, 0, 0, "David Thewlis, Jennifer Jason Leigh, Tom Noonan", 0, 1, "Nominated for 1 Oscar. Another 18 wins & 61 nominations.", 0, "3,442,820", 1, "USA", 0, "Duke Johnson, Charlie Kaufman", 0, 1, 0, 0, 0, "Animation, Comedy, Drama", 0, 0, "English, Italian, Japanese", 0, "88", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjY5ZjQyMjMtMmEwOC00Nzc2LTllYTItMmU2MzJjNTg1NjY0XkEyXkFqcGdeQXVyNjQ1MTMzMDQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Jan-16", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Anomalisa", 0, 0, "movie", 0, 0, 0, "Charlie Kaufman, Charlie Kaufman (play)", 0, "data/Movie_Poster_Dataset/2015/tt2401878.jpg", "tt2401878", "7.5", "15,639" },
                    { 696, 0, 1, "Tye Sheridan, Logan Miller, Joey Morgan, Sarah Dumont", 0, 0, "1 nomination.", 0, "3,635,292", 1, "USA", 0, "Christopher Landon", 0, 0, 0, 0, 0, "Action, Comedy, Horror", 0, 1, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjFmZGI2YTEtYmJhMS00YTE5LWJjNjAtNDI5OGY5ZDhmNTRlXkEyXkFqcGdeQXVyODAwMTU1MTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Scouts Guide to the Zombie Apocalypse", 0, 0, "movie", 0, 0, 0, "Carrie Lee Wilson (screenplay), Emi Mochizuki (screenplay), Christopher Landon (screenplay), Lona Williams (story), Carrie Lee Wilson (story), Emi Mochizuki (story)", 0, "data/Movie_Poster_Dataset/2015/tt1727776.jpg", "tt1727776", "6.3", "19,495" },
                    { 697, 0, 0, "Aislinn Derbez, Mauricio Ochmann, Aurora Papile, Luis Arrieta", 0, 0, "N/A", 0, "3,599,835", 1, "Mexico", 0, "Pedro Pablo Ibarra", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Feb-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "A la mala", 0, 0, "movie", 0, 0, 0, "Issa López, Ari Rosen", 0, "data/Movie_Poster_Dataset/2015/tt4357170.jpg", "tt4357170", "6.4", "1,227" },
                    { 698, 0, 0, "George Lopez, Marisa Tomei, Jamie Lee Curtis, Carlos PenaVega", 0, 0, "2 wins & 2 nominations.", 0, "3,610,933", 0, "USA", 0, "Sean McNamara", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg4ODkzMDQ3Nl5BMl5BanBnXkFtZTgwNTEwMTkxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Jun-15", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spare Parts", 0, 0, "movie", 0, 0, 0, "Joshua Davis (based on the Wired Magazine article \\\\", 0, "data/Movie_Poster_Dataset/2015/tt3233418.jpg", "tt3233418", "7.3", "6,757" },
                    { 699, 0, 0, "Zac Efron, Wes Bentley, Emily Ratajkowski, Jonny Weston", 0, 0, "N/A", 0, "3,590,010", 0, "UK, France, USA", 0, "Max Joseph", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English", 0, "46", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzhmNGMzMDMtZDM0Yi00MmVmLWExYjAtZDhjZjcxZDM0MzJhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Aug-15", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "We Are Your Friends", 0, 0, "movie", 0, 0, 0, "Max Joseph (screenplay), Meaghan Oppenheimer (screenplay), Richard Silverman (story)", 0, "data/Movie_Poster_Dataset/2015/tt3787590.jpg", "tt3787590", "6.1", "16,089" },
                    { 700, 0, 0, "Connor Long, Kevin Coubal, Alexander Mason, Nicole Carter Lyde", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Roderick E. Stevens", 0, 1, 0, 0, 0, "Short, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgzNTgzODU0NV5BMl5BanBnXkFtZTcwMjEyMjMzMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "N/A", 0, 1, 0, 0, 0, 0, 0, 0, "Learning to Drive", 0, 0, "movie", 0, 0, 0, "Roderick E. Stevens", 0, "data/Movie_Poster_Dataset/2015/tt4381862.jpg", "tt4381862", "N/A", "N/A" },
                    { 702, 0, 0, "Fernando Colunga, Eduardo Yáñez, Miguel Varoni, Jessica Lindsey", 0, 0, "N/A", 0, "3,058,367", 1, "USA, Dominican Republic", 0, "Joe Menendez", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English, Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzg4MDJhMDMtYmJiMS00ZDZmLThmZWUtYTMwZDM1YTc5MWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Oct-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ladrones", 0, 0, "movie", 0, 0, 0, "Jon Molerio", 0, "data/Movie_Poster_Dataset/2015/tt4296800.jpg", "tt4296800", "4.6", "149" },
                    { 703, 0, 0, "Bill Murray, Bruce Willis, Kate Hudson, Zooey Deschanel", 0, 0, "N/A", 0, "2,982,281", 1, "USA", 0, "Barry Levinson", 0, 0, 0, 0, 0, "Comedy, Music, War", 0, 0, "English", 0, "29", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjQ0NTY2ODY2M15BMl5BanBnXkFtZTgwMjE4MzkxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Oct-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rock the Kasbah", 0, 0, "movie", 0, 1, 0, "Mitch Glazer (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3164256.jpg", "tt3164256", "5.5", "3,525" },
                    { 704, 0, 0, "Jesse Eisenberg, Anna Chlumsky, Jason Segel, Joan Cusack", 0, 0, "3 wins & 15 nominations.", 0, "2,993,669", 0, "USA", 0, "James Ponsoldt", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2VlOTc4ZjctYjVlMS00NDYwLWEwZjctZmYzZmVkNGU5NjNjXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Nov-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "The End of the Tour", 0, 0, "movie", 0, 0, 0, "Donald Margulies (screenplay), David Lipsky (book)", 0, "data/Movie_Poster_Dataset/2015/tt3416744.jpg", "tt3416744", "7.4", "14,333" },
                    { 705, 0, 0, "The Retrosettes, Gabriella Belisario, Harvey Keitel, Alex Macqueen", 0, 0, "Nominated for 1 Oscar. Another 12 wins & 35 nominations.", 0, "2,698,509", 1, "Italy, France, UK, Switzerland", 0, "Paolo Sorrentino", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Spanish, Swiss German", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU4NTc5NjM5M15BMl5BanBnXkFtZTgwODEyMTE0MDE@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Dec-15", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "Youth", 0, 0, "movie", 0, 0, 0, "Paolo Sorrentino", 0, "data/Movie_Poster_Dataset/2015/tt3312830.jpg", "tt3312830", "7.4", "34,009" },
                    { 706, 0, 0, "Malala Yousafzai, Ziauddin Yousafzai, Toor Pekai Yousafzai, Khushal Yousafzai", 0, 0, "Nominated for 1 BAFTA Film Award. Another 4 wins & 11 nominations.", 0, "2,642,899", 0, "United Arab Emirates, USA", 0, "Davis Guggenheim", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA1NDQ3NTcyOTNeQTJeQWpwZ15BbWU3MDA0MzA4MzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Oct-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "He Named Me Malala", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3065132.jpg", "tt3065132", "6.7", "2,242" },
                    { 707, 0, 0, "Nick Cannon, Teyonah Parris, Wesley Snipes, Angela Bassett", 0, 0, "4 wins & 12 nominations.", 0, "2,647,377", 1, "USA", 1, "Spike Lee", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE1MjA0MDA3MV5BMl5BanBnXkFtZTcwOTU0MjMzMQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Dec-15", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chi-Raq", 0, 0, "movie", 0, 0, 0, "Kevin Willmott, Spike Lee, Aristophanes (play)", 0, "data/Movie_Poster_Dataset/2015/tt4594834.jpg", "tt4594834", "5.7", "4,498" },
                    { 708, 0, 0, "Cate Blanchett, Robert Redford, Topher Grace, Dennis Quaid", 0, 0, "1 win & 3 nominations.", 1, "2,541,554", 0, "Australia, USA", 0, "James Vanderbilt", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWY2ODRkZDYtMjllYi00Y2EyLWFhYjktMTQ5OGNkY2ViYmY2XkEyXkFqcGdeQXVyNjUxMDQ0MTg@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Truth", 0, 0, "movie", 0, 0, 0, "James Vanderbilt (screenplay), Mary Mapes (book)", 0, "data/Movie_Poster_Dataset/2015/tt3859076.jpg", "tt3859076", "6.8", "6,264" },
                    { 709, 0, 0, "Nat Baldwin, Juliet Brett, Andrea Chen, Michael Chernus", 0, 0, "1 win & 11 nominations.", 0, "2,461,121", 1, "USA, Brazil", 0, "Noah Baumbach", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWE2MDAwZjEtODEyOS00ZjYyLTgzNDUtYmNiY2VmNWRiMTQxXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Aug-15", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mistress America", 0, 0, "movie", 0, 0, 0, "Noah Baumbach, Greta Gerwig", 0, "data/Movie_Poster_Dataset/2015/tt2872462.jpg", "tt2872462", "6.8", "11,729" },
                    { 710, 0, 1, "Conrad Anker, Grace Chin, Jimmy Chin, Amee Hinkley", 1, 0, "4 wins & 11 nominations.", 0, "2,332,127", 0, "India, USA", 0, "Jimmy Chin, Elizabeth Chai Vasarhelyi", 1, 0, 0, 0, 0, "Documentary, Action, Adventure", 0, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIyOTU3MjUxOF5BMl5BanBnXkFtZTcwMTQ0NjYzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Aug-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Meru", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt2545428.jpg", "tt2545428", "7.7", "4,060" },
                    { 711, 0, 0, "Aaron Eckhart, Finn Wittrock, Rett Terrell, Michael Reilly Burke", 0, 0, "1 win.", 1, "2,246,000", 0, "USA", 0, "Angelo Pizzo", 0, 1, 0, 0, 0, "Biography, Drama, Sport", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzYwODUxNjkyMF5BMl5BanBnXkFtZTcwODUzNjQyMQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "13-Nov-15", "TRUE", 0, "118 min", 0, 0, 1, 0, 0, 0, 0, 0, "My All American", 0, 0, "movie", 0, 0, 0, "Angelo Pizzo, Jim Dent (book)", 0, "data/Movie_Poster_Dataset/2015/tt3719896.jpg", "tt3719896", "6.9", "1,222" },
                    { 712, 0, 0, "Aubrey Peeples, Stefanie Scott, Aurora Perrineau, Hayley Kiyoko", 1, 0, "1 nomination.", 0, "2,028,755", 0, "USA", 0, "Jon M. Chu", 0, 1, 0, 0, 1, "Adventure, Drama, Fantasy", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTk3OTM5Njg5M15BMl5BanBnXkFtZTYwMzA0ODI3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "23-Oct-15", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jem and the Holograms", 0, 0, "movie", 0, 0, 0, "Ryan Landels", 0, "data/Movie_Poster_Dataset/2015/tt3614530.jpg", "tt3614530", "3.9", "2,786" },
                    { 713, 0, 0, "Deepika Padukone, Ranbir Kapoor, Piyush Mishra, Javed Sheikh", 0, 0, "1 win.", 0, "1,980,235", 1, "India", 0, "Imtiaz Ali", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTNmZTgyMzAtMTUwZC00NjAwLTk4MjktODllYTY5YTUwN2YwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Nov-15", "TRUE", 1, "139 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tamasha", 0, 0, "movie", 0, 0, 0, "Imtiaz Ali", 0, "data/Movie_Poster_Dataset/2015/tt3148502.jpg", "tt3148502", "7.3", "10,298" },
                    { 716, 0, 0, "Paul Anderson, Tom Hardy, Christopher Eccleston, Joshua Hill", 0, 0, "3 wins & 10 nominations.", 1, "1,865,774", 0, "UK, France, USA", 1, "Brian Helgeland", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2YwNTQwM2ItZTA2Ni00NGY1LThjY2QtNzgyZTBhMTM0MWI4XkEyXkFqcGdeQXVyNzQxNDExNTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Nov-15", "TRUE", 0, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "Legend", 0, 0, "movie", 0, 0, 0, "Brian Helgeland, John Pearson (book)", 0, "data/Movie_Poster_Dataset/2015/tt3569230.jpg", "tt3569230", "7", "65,759" },
                    { 717, 0, 0, "Amitabh Bachchan, Deepika Padukone, Irrfan Khan, Moushumi Chatterjee", 0, 0, "4 wins & 2 nominations.", 0, "null", 1, "India", 0, "Shoojit Sircar", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "Hindi, Bengali", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGRiOTIwNTAtYWM2Yy00Yzc4LTkyZjEtNTM3NTIyZTNhMzg1XkEyXkFqcGdeQXVyODIyOTEyMzY@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "8-May-15", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Piku", 0, 0, "movie", 0, 0, 0, "Juhi Chaturvedi", 0, "data/Movie_Poster_Dataset/2015/tt3767372.jpg", "tt3767372", "7.6", "13,614" },
                    { 718, 0, 0, "Olivia Taylor Dudley, Alison Lohman, Kathleen Robertson, Michael Peña", 0, 0, "N/A", 0, "1,712,111", 0, "USA", 0, "Mark Neveldine", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English, Aramaic", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI1NDA4NTMyN15BMl5BanBnXkFtZTYwNTA2ODc5._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Jul-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Vatican Tapes", 0, 0, "movie", 0, 0, 0, "Chris Morgan (based on a story by), Christopher Borrelli (based on a story by), Christopher Borrelli (screenplay), Michael C. Martin (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt1524575.jpg", "tt1524575", "4.5", "6,060" },
                    { 719, 0, 0, "Géza Röhrig, Levente Molnár, Urs Rechn, Todd Charmont", 0, 0, "Won 1 Oscar. Another 45 wins & 37 nominations.", 0, "1,758,647", 0, "Hungary", 0, "László Nemes", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "Hungarian, Yiddish, German, Russian, Polish, French, Greek, Slovak", 0, "89", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDM0ZWRjZDgtZWI0MS00ZTIzLTg4MWYtZjU5MDEyMDU0ODBjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Dec-15", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 1, "Son of Saul", 0, 0, "movie", 0, 0, 0, "László Nemes, Clara Royer", 0, "data/Movie_Poster_Dataset/2015/tt3808342.jpg", "tt3808342", "7.9", "10,045" },
                    { 720, 0, 0, "Bel Powley, Willie, Kristen Wiig, Abby Wait", 0, 0, "13 wins & 31 nominations.", 0, "1,477,002", 0, "USA", 0, "Marielle Heller", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "87", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWM0ZjY5ZjctODNkZi00Nzk0LWE1ODUtNGM4ZDUyMzUwMGYwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Aug-15", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Diary of a Teenage Girl", 0, 0, "movie", 0, 0, 0, "Phoebe Gloeckner (novel), Marielle Heller (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3172532.jpg", "tt3172532", "6.9", "12,457" },
                    { 722, 0, 1, "Ju-Gang Bai, Xiaogang Feng, Shan Jiang, Yi Feng Li", 0, 0, "1 win & 5 nominations.", 0, "1,413,054", 0, "China", 0, "Hu Guan", 0, 1, 0, 0, 0, "Action, Drama", 0, 0, "Chinese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYThkMzgxNjEtMzFiOC00MTI0LWI5MDItNDVmYjA4NzY5MDQ2L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 0, "134 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mr. Six", 0, 0, "movie", 0, 0, 0, "Runnian Dong, Hu Guan", 0, "data/Movie_Poster_Dataset/2015/tt4701702.jpg", "tt4701702", "7.5", "1,165" },
                    { 723, 0, 1, "Anil Kapoor, Nana Patekar, Dimple Kapadia, John Abraham", 0, 0, "N/A", 0, "1,388,365", 1, "India, United Arab Emirates", 1, "Anees Bazmee", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDdhMzMxOTctNDMyNS00NTZmLTljNWEtNTc4MDBmZTYxY2NmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "4-Sep-15", "TRUE", 0, "152 min", 0, 0, 0, 0, 0, 0, 0, 0, "Welcome Back", 0, 0, "movie", 0, 0, 0, "Anees Bazmee (story), Rajeev Kaul (story), Rajeev Kaul (screenplay), Anees Bazmee (screenplay), Rajan Aggarwal (screenplay), Praful Parekh (screenplay), Raaj Shaandilyaa (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt3159708.jpg", "tt3159708", "4.3", "3,842" },
                    { 724, 0, 0, "Nathan Stevens, Jasen Wade, Caitlin E.J. Meyer, Mason D. Davis", 0, 0, "N/A", 0, "null", 0, "USA", 0, "T.C. Christensen", 0, 1, 0, 1, 0, "Drama, Family, History", 1, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTk2ZTMzMmUtZjUyNi00YzMyLWE3NTAtNDNjNzU3MGQ1YTFjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Jun-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Cokeville Miracle", 0, 0, "movie", 0, 0, 0, "T.C. Christensen", 0, "data/Movie_Poster_Dataset/2015/tt3877296.jpg", "tt3877296", "4.8", "1,147" },
                    { 726, 0, 0, "Zheng Xu, Wei Zhao, Bei-Er Bao, Singh Hartihan Bitto", 0, 0, "N/A", 0, "1,302,281", 1, "China, Hong Kong", 0, "Zheng Xu", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Mandarin, Cantonese, French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2Y5ZTU4YjctMDRmMC00MTg4LWE1M2MtMjk4MzVmOTE4YjkzXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "25-Sep-15", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lost in Hong Kong", 0, 0, "movie", 0, 0, 0, "Huan Shu", 0, "data/Movie_Poster_Dataset/2015/tt4242158.jpg", "tt4242158", "5.6", "679" },
                    { 727, 0, 0, "Bhagavan Angulo, Govinda Angulo, Jagadisa Angulo, Krsna Angulo", 0, 0, "7 wins & 13 nominations.", 1, "1,301,696", 0, "USA", 0, "Crystal Moselle", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzVmMTdjOTYtOTJkYS00ZTg2LWExNTgtNzA1N2Y0MDgwYWFhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jul-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Wolfpack", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt2415458.jpg", "tt2415458", "7.1", "6,325" },
                    { 728, 0, 0, "Allen Ai, Yuan Chang, Li-Chun Lee, Ping Li", 0, 0, "N/A", 0, "1,292,195", 1, "China", 0, "Da-Mo Peng, Fei Yan", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Chinese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODg0YjAzNDQtOGFkMi00Yzk2LTg1NzYtYTNjY2UwZTM2ZDdkL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Sep-15", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Goodbye Mr. Loser", 0, 0, "movie", 0, 0, 0, "Da-Mo Peng, Fei Yan", 0, "data/Movie_Poster_Dataset/2015/tt5061814.jpg", "tt5061814", "6.9", "758" },
                    { 730, 0, 1, "Angelababy, Kun Chen, Keith Collea, Alex Eckstorm", 0, 0, "1 nomination.", 0, "816,974", 0, "China", 0, "Wuershan", 0, 0, 0, 0, 0, "Action, Horror", 0, 1, "Chinese, Mandarin", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmIzMjE0M2YtNzliZi00YWNmLTgyNDItZDhjNWVhY2Q2ODk0XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mojin - The Lost Legend", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4276752.jpg", "tt4276752", "6.2", "1,260" },
                    { 731, 0, 1, "Andrew Cheney, John Rhys-Davies, Kara Killmer, Alan Madlane", 0, 0, "N/A", 0, "1,231,025", 0, "USA", 0, "Chad Burns", 0, 1, 0, 0, 0, "Action, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOGZhM2FhNTItODAzNi00YjA0LWEyN2UtNjJlYWQzYzU1MDg5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "6-Apr-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Beyond the Mask", 0, 0, "movie", 0, 0, 0, "Paul McCusker (screenplay), Stephen Kendrick (with), Brennan Smith (with), Aaron Burns (story), Chad Burns (story)", 0, "data/Movie_Poster_Dataset/2015/tt2433040.jpg", "tt2433040", "5.1", "1,464" },
                    { 732, 0, 0, "Xavier Atkins, Mark Lewis Jones, Tom Hardy, Joel Kinnaman", 0, 0, "1 nomination.", 0, "1,206,135", 0, "Czech Republic, UK, Romania, Russia, USA", 1, "Daniel Espinosa", 0, 0, 0, 0, 0, "Crime, Thriller", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Apr-15", "TRUE", 0, "137 min", 0, 0, 0, 0, 0, 0, 0, 1, "Child 44", 0, 0, "movie", 0, 0, 0, "Richard Price (screenplay), Tom Rob Smith (novel)", 0, "data/Movie_Poster_Dataset/2015/tt1014763.jpg", "tt1014763", "6.4", "36,204" },
                    { 733, 0, 1, "Jeong-min Hwang, Ah In Yoo, Hae-jin Yoo, Dal-su Oh", 0, 0, "1 win & 16 nominations.", 0, "1,048,332", 1, "South Korea", 1, "Seung-wan Ryoo", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODk4MzE5NjgtN2ZhOS00YTdkLTg0YzktMmE1MTkxZmMyMWI2L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Sep-15", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Veteran", 0, 0, "movie", 0, 0, 0, "Seung-wan Ryoo", 0, "data/Movie_Poster_Dataset/2015/tt4768764.jpg", "tt4768764", "7.3", "656" },
                    { 735, 0, 0, "Drew Barrymore, Toni Collette, Paddy Considine, Tyson Ritter", 0, 0, "N/A", 0, "1,162,653", 1, "UK", 0, "Catherine Hardwicke", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODI3ZTc5NjktOGMyOC00NjYzLTgwZDYtYmQ4NDc1MmJjMjRlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Sep-15", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Miss You Already", 0, 0, "movie", 0, 0, 0, "Morwenna Banks (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2245003.jpg", "tt2245003", "6.7", "4,792" },
                    { 736, 0, 0, "Adam Scott, Taylor Schilling, R.J. Hermes, Kyle Field", 0, 0, "1 win & 2 nominations.", 0, "1,100,000", 1, "USA", 0, "Patrick Brice", 0, 0, 0, 0, 0, "Comedy, Mystery", 0, 0, "English, French", 0, "65", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGVmMDNmYmEtNGQ2Mi00Y2ZhLThhZTYtYjE5YmQzMjZiZGMxXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Jun-15", "TRUE", 0, "79 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Overnight", 0, 0, "movie", 0, 0, 0, "Patrick Brice", 0, "data/Movie_Poster_Dataset/2015/tt3844362.jpg", "tt3844362", "6.2", "8,604" },
                    { 738, 0, 0, "Kevin Downes, David A.R. White, Stephen Baldwin, Candace Cameron Bure", 0, 0, "1 win.", 0, "986,472", 0, "USA", 0, "Carey Scott", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "20", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDYwZTU2MzktNWYxMS00NTYzLTgzOWEtMTRiYjc5NGY2Nzg1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jul-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Faith of Our Fathers", 0, 0, "movie", 0, 0, 0, "Kevin Downes, Carey Scott (screenwriter), Harold Uhl (screenplay), David A.R. White", 0, "data/Movie_Poster_Dataset/2015/tt1322393.jpg", "tt1322393", "2.9", "350" },
                    { 739, 0, 1, "Yûko Sanpei, Kokoro Kikuchi, Ryûichi Kijima, Junko Takeuchi", 1, 1, "N/A", 0, "null", 0, "Japan", 0, "Hiroyuki Yamashita", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTA5ZjdjNWUtZGUwNy00N2RhLWJiZmItYzFhYjU1NmYxNjY4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Aug-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Boruto: Naruto the Movie", 0, 0, "movie", 0, 0, 0, "Masashi Kishimoto (original author), Masashi Kishimoto (screenplay), Ukyo Kodachi (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4618398.jpg", "tt4618398", "8.5", "2,456" },
                    { 740, 0, 0, "Paul Newman, Kelsey Grammer, John Lithgow, Dick Cavett", 0, 0, "5 wins & 25 nominations.", 0, "891,997", 0, "USA", 0, "Robert Gordon, Morgan Neville", 1, 0, 0, 0, 0, "Documentary, History, News", 1, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2EyZDlhNjItODYzNi00Mzc3LWJjOWUtMTViODU5MTExZWMyL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Jul-15", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Best of Enemies", 0, 0, "movie", 0, 0, 0, "Robert Gordon, Morgan Neville", 0, "data/Movie_Poster_Dataset/2015/tt3518012.jpg", "tt3518012", "7.6", "2,659" },
                    { 741, 0, 0, "Günes Sensoy, Doga Zeynep Doguslu, Tugba Sunguroglu, Elit Iscan", 0, 0, "Nominated for 1 Oscar. Another 31 wins & 43 nominations.", 0, "828,077", 0, "France, Germany, Turkey, Qatar", 0, "Deniz Gamze Ergüven", 0, 1, 0, 0, 0, "Drama", 0, 0, "Turkish", 0, "83", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODRkYzA4MGItODE2MC00ZjkwLWI2NDEtYzU1NzFiZGU1YzA0XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Jun-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mustang", 0, 0, "movie", 0, 0, 0, "Deniz Gamze Ergüven (screenplay), Alice Winocour (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3966404.jpg", "tt3966404", "7.6", "10,009" },
                    { 742, 0, 0, "Alison Brie, Jason Sudeikis, Jordan Carlos, Margarita Levieva", 0, 0, "2 nominations.", 0, "814,775", 1, "USA", 0, "Leslye Headland", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODllYjM1ODItYjBmOC00MzkwLWJmM2YtMjMyZDU3MGJhNjc4L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "12-Aug-15", "TRUE", 1, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sleeping with Other People", 0, 0, "movie", 0, 0, 0, "Leslye Headland", 0, "data/Movie_Poster_Dataset/2015/tt3165612.jpg", "tt3165612", "6.5", "14,900" },
                    { 744, 0, 0, "Paris Warner, Lisa Clark, Hailey Smith, Clare Niederpruem", 0, 0, "N/A", 0, "597,031", 1, "USA", 0, "Maclain Nelson", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNDYwOThlMDAtYWUwMS00MjY5LTliMGUtZWFiYTA5MjYwZDAyXkEyXkFqcGdeQXVyNjY1NTQ0NDg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "14-Aug-15", "TRUE", 0, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Once I Was a Beehive", 0, 0, "movie", 0, 0, 0, "Maclain Nelson, Maclain Nelson", 0, "data/Movie_Poster_Dataset/2015/tt4002772.jpg", "tt4002772", "6.3", "273" },
                    { 745, 0, 1, "José Manuel 'El Doctor' Mireles", 0, 0, "Nominated for 1 Oscar. Another 12 wins & 29 nominations.", 0, "704,352", 0, "Mexico, USA", 0, "Matthew Heineman", 1, 1, 0, 0, 0, "Documentary, Action, Drama", 0, 0, "English, Spanish", 0, "76", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA3Y2I4NjAtMDQyZS00ZGJhLWEwMzgtODBiNzE5Zjc1Nzk1L2ltYWdlXkEyXkFqcGdeQXVyNTc2MDU0NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Jul-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cartel Land", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4126304.jpg", "tt4126304", "7.4", "7,644" },
                    { 746, 0, 0, "Kitana Kiki Rodriguez, Mya Taylor, Karren Karagulian, Mickey O'Hagan", 0, 0, "19 wins & 33 nominations.", 0, "701,837", 1, "USA", 0, "Sean Baker", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "85", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmFmOGZjYTItYjY1ZS00OWRiLTk0NDgtMjQ5MzBkYWE2YWE0XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jul-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tangerine", 0, 0, "movie", 0, 0, 0, "Sean Baker, Chris Bergoch", 0, "data/Movie_Poster_Dataset/2015/tt3824458.jpg", "tt3824458", "7.1", "10,023" },
                    { 747, 0, 0, "Jeong-min Hwang, Sung-ha Jo, In-kwon Kim, Mi-ran Ra", 0, 0, "N/A", 0, "696,717", 0, "South Korea", 0, "Seok-hoon Lee", 0, 1, 0, 0, 0, "Drama", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTczOTczNjE3Ml5BMl5BanBnXkFtZTgwODEzMzg5MTI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jan-16", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Himalayas", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4253360.jpg", "tt4253360", "5.8", "130" },
                    { 748, 0, 0, "Billy Crudup, Michael Angarano, Moises Arias, Nicholas Braun", 0, 0, "4 wins & 3 nominations.", 1, "643,557", 0, "USA", 0, "Kyle Patrick Alvarez", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTRiMWM3MGItNjAxZC00M2E3LThhODgtM2QwOGNmZGU4OWZhXkEyXkFqcGdeQXVyNjExODE1MDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Jul-15", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Stanford Prison Experiment", 0, 0, "movie", 0, 0, 0, "Tim Talbott, Philip Zimbardo (book)", 0, "data/Movie_Poster_Dataset/2015/tt0420293.jpg", "tt0420293", "6.9", "12,334" },
                    { 749, 0, 0, "Chen Chang, Qi Shu, Yun Zhou, Satoshi Tsumabuki", 0, 0, "Nominated for 1 BAFTA Film Award. Another 25 wins & 52 nominations.", 0, "613,556", 0, "Taiwan, China, Hong Kong, France", 0, "Hsiao-Hsien Hou", 0, 1, 0, 0, 0, "Drama", 0, 0, "Mandarin", 0, "80", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTIzZGU4ZWMtYmNjMy00NzU0LTljMGYtZmVkMDYwN2U2MzYwL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Aug-15", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Assassin", 0, 0, "movie", 0, 0, 0, "Cheng Ah (screenplay), T'ien-wen Chu (screenwriter), Hsiao-Hsien Hou (screenplay), Hai-Meng Hsieh (screenplay), Xing Pei (short story)", 0, "data/Movie_Poster_Dataset/2015/tt3508840.jpg", "tt3508840", "6.5", "7,483" },
                    { 750, 0, 1, "Sushant Singh Rajput, Anand Tiwari, Divya Menon, Swastika Mukherjee", 0, 0, "N/A", 0, "579,055", 0, "India", 0, "Dibakar Banerjee", 0, 0, 0, 0, 0, "Action, Mystery, Thriller", 0, 0, "Hindi", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGNmMjBmZWEtOWYwZC00NGIzLTg0YWItMzkzMWMwOTU4YTViXkEyXkFqcGdeQXVyNzc5MjA3OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "3-Apr-15", "TRUE", 0, "139 min", 0, 0, 0, 0, 0, 0, 0, 1, "Detective Byomkesh Bakshy!", 0, 0, "movie", 0, 0, 0, "Urmi Juvekar, Dibakar Banerjee, Saradindu Bandopaddhyay (based on the stories and characters created by)", 0, "data/Movie_Poster_Dataset/2015/tt3447364.jpg", "tt3447364", "7.8", "8,902" },
                    { 751, 0, 0, "Julianne Moore, Ellen Page, Michael Shannon, Steve Carell", 0, 0, "1 win & 5 nominations.", 1, "532,988", 0, "USA", 0, "Peter Sollett", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmE0ZGRiMDgtOTU0ZS00YWUwLTk5YWQtMzhiZGVhNzViMGZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Nov-15", "TRUE", 1, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Freeheld", 0, 0, "movie", 0, 0, 0, "Ron Nyswaner (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt1658801.jpg", "tt1658801", "6.5", "3,560" },
                    { 752, 0, 0, "Christopher Plummer, Dean Norris, Martin Landau, Jürgen Prochnow", 0, 0, "3 wins & 12 nominations.", 0, "311,938", 0, "Canada, Germany", 0, "Atom Egoyan", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English, German", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmRjNDI5NTgtOTIwMC00MzJhLWI4ZTYtMmU0ZTE3ZmRkZDNhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Dec-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 1, "Remember", 0, 0, "movie", 0, 0, 0, "Benjamin August", 0, "data/Movie_Poster_Dataset/2015/tt3704050.jpg", "tt3704050", "7.3", "2,631" },
                    { 753, 0, 0, "Brad Pitt, Angelina Jolie, Mélanie Laurent, Melvil Poupaud", 0, 0, "1 nomination.", 0, "531,009", 0, "USA, France", 0, "Angelina Jolie", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, French", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzY0ODQ3MTMxN15BMl5BanBnXkFtZTgwMDkwNTg4NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Dec-15", "TRUE", 1, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "By the Sea", 0, 0, "movie", 0, 0, 0, "Angelina Jolie", 0, "data/Movie_Poster_Dataset/2015/tt3707106.jpg", "tt3707106", "5.3", "5,210" },
                    { 754, 0, 1, "Akshay Kumar, Shruti Haasan, Sunil Grover, Kareena Kapoor", 0, 0, "N/A", 0, "null", 0, "India", 1, "Krish Jagarlamudi", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjI5NjEzMDYyMl5BMl5BanBnXkFtZTgwNjgwNTg4NjE@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-May-15", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gabbar is Back", 0, 0, "movie", 0, 0, 0, "A.R. Murugadoss (story), Rajat Arora (additional screenplay), Rajat Arora (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt2424988.jpg", "tt2424988", "7.3", "13,455" },
                    { 755, 0, 0, "Shahid Kapoor, Alia Bhatt, Pankaj Kapur, Sanjay Kapoor", 0, 0, "N/A", 0, "433,541", 1, "India", 0, "Vikas Bahl", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTc0ODM1Njk1NF5BMl5BanBnXkFtZTcwMDI5OTEyNw@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "22-Oct-15", "TRUE", 1, "144 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shaandaar", 0, 0, "movie", 0, 0, 0, "Vikas Bahl (story), Chaitally Parmar (story), Anvita Dutt (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4007558.jpg", "tt4007558", "3.6", "2,770" },
                    { 756, 0, 0, "Stu Richel", 0, 0, "3 wins & 5 nominations.", 0, "482,396", 0, "N/A", 0, "Stanley Nelson", 1, 0, 0, 0, 0, "Documentary", 0, 0, "N/A", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODhlNjA5MDEtZDVhNS00ZmM3LTg1YzAtZGRjNjhjNTAzNzVkXkEyXkFqcGdeQXVyNjUwMzI2NzU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "23-Oct-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Black Panthers: Vanguard of the Revolution", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4316236.jpg", "tt4316236", "7.2", "471" },
                    { 757, 0, 0, "Peggy Guggenheim, Marina Abramovic", 0, 0, "1 nomination.", 1, "498,428", 0, "USA, Italy, UK", 0, "Lisa Immordino Vreeland", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDQyMDVhZjItMGI0Mi00MDQ1LTk3NmQtZmRjZGQ5ZTQ2ZDU5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Dec-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Peggy Guggenheim: Art Addict", 0, 0, "movie", 0, 0, 0, "Bernadine Colish, Lisa Immordino Vreeland", 0, "data/Movie_Poster_Dataset/2015/tt3790720.jpg", "tt3790720", "7.3", "142" },
                    { 758, 0, 0, "Bob Belleville, Chrisann Brennan, Nolan Bushnell, Jason Chen", 0, 0, "N/A", 0, "494,461", 0, "USA", 0, "Alex Gibney", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTMxMGM5MjItNDJhNy00MWI2LWJlZWMtOWFhMjI5ZTQwMWM3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Sep-15", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Steve Jobs: The Man in the Machine", 0, 0, "movie", 0, 0, 0, "Alex Gibney", 0, "data/Movie_Poster_Dataset/2015/tt4425064.jpg", "tt4425064", "6.8", "3,239" },
                    { 759, 0, 0, "Kris Wu, Likun Wang, Jinglei Xu, Gordon Alexander", 0, 0, "1 win & 1 nomination.", 0, "null", 0, "China", 0, "Jinglei Xu", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Mandarin, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTFjNjU4OTktYzljMS00MmFlLWI3NGEtNjNhMTYwYzUyZDgyL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Feb-15", "TRUE", 1, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Somewhere Only We Know", 0, 0, "movie", 0, 0, 0, "Shuo Wang, Yun Wang, Jinglei Xu, Meng Zhao", 0, "data/Movie_Poster_Dataset/2015/tt4074958.jpg", "tt4074958", "5.4", "408" },
                    { 760, 0, 0, "Keke Palmer, Cory Hardrict, Romeo Miller, Eric D. Hill Jr.", 0, 0, "2 nominations.", 0, "444,044", 0, "USA", 0, "Jamal Hill", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2QwYmFmZTEtNzY2Mi00ZWMyLWEwY2YtMGIyNGZjMWExOWEyXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Apr-15", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Brotherly Love", 0, 0, "movie", 0, 0, 0, "Jamal Hill", 0, "data/Movie_Poster_Dataset/2015/tt3262990.jpg", "tt3262990", "7.3", "589" },
                    { 761, 0, 0, "Ivy Yi-Han Chen, Zuo Da, Yuanyuan Gao, Wu Jiang", 0, 0, "N/A", 0, "447,648", 1, "China", 0, "Jiang Liu", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "Mandarin", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWY3ODZlOGMtNzJmOS00ZTNjLWI3ZWEtZTJhZTk5NDZjYWRjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "2-Apr-15", "TRUE", 1, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Let's Get Married", 0, 0, "movie", 0, 0, 0, "Jiang Liu (screenplay), Hongwei Wang (screenplay), Yu Wang (screenplay), Nan Xu (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4572856.jpg", "tt4572856", "5.7", "85" },
                    { 762, 0, 0, "Ranbir Kapoor, Anushka Sharma, Karan Johar, Satyadeep Misra", 0, 0, "2 wins & 1 nomination.", 0, "null", 0, "India", 1, "Anurag Kashyap", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDA0NjZhZWUtNmI2NC00MmFjLTgwZDYtYzVjZmNhMDVmOTBkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-May-15", "TRUE", 0, "149 min", 0, 0, 0, 0, 0, 0, 0, 1, "Bombay Velvet", 0, 0, "movie", 0, 0, 0, "Vasan Bala, Anurag Kashyap, Gyan Prakash, Thani", 0, "data/Movie_Poster_Dataset/2015/tt2979920.jpg", "tt2979920", "5.8", "3,638" },
                    { 763, 0, 1, "Haruma Miura, Kiko Mizuhara, Kanata Hongô, Satomi Ishihara", 1, 0, "2 nominations.", 0, "258,794", 0, "Japan", 0, "Shinji Higuchi", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2ZmNDJiZTUtYjg5Zi00M2I3LTliZjAtNzQ4NTlkYTAzYTAxXkEyXkFqcGdeQXVyNTkyMDc0MjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "30-Sep-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Attack on Titan: Part 1", 0, 0, "movie", 0, 0, 0, "Hajime Isayama (manga), Yûsuke Watanabe (screenplay), Tomohiro Machiyama (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2072230.jpg", "tt2072230", "5.2", "7,404" },
                    { 764, 0, 0, "Peter Ascoli, Julian Bond, Stephanie Deutsch, Richard J. Powell", 0, 0, "1 nomination.", 1, "359,187", 0, "USA", 0, "Aviva Kempner", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODRlMjRkZGEtZWM2Zi00ZjYxLWE0MWUtMmM1YWM2NzZlOTE1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Aug-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rosenwald", 0, 0, "movie", 0, 0, 0, "Aviva Kempner", 0, "data/Movie_Poster_Dataset/2015/tt2514028.jpg", "tt2514028", "8.2", "48" },
                    { 766, 0, 0, "Michael Borne, Marlon Brando", 0, 0, "Nominated for 1 BAFTA Film Award. Another 4 wins & 16 nominations.", 1, "423,176", 0, "UK", 0, "Stevan Riley", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "87", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDRkOWQ5NGUtYTVmOS00ZjNhLWEwODgtOGI2MmUxNTBkMjU0XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "29-Jul-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Listen to Me Marlon", 0, 0, "movie", 0, 0, 0, "Stevan Riley, Peter Ettedgui (co writer)", 0, "data/Movie_Poster_Dataset/2015/tt4145178.jpg", "tt4145178", "8.2", "3,127" },
                    { 767, 0, 0, "Archie, Jason Berg, Heung-Heung Chin, Bob Currie", 0, 0, "4 wins & 9 nominations.", 0, "418,571", 0, "France, USA", 0, "Laurie Anderson", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "84", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTM5N2ZmZTMtNjlmOS00YzlkLTk3YjEtNTU1ZmQ5OTdhODZhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Mar-16", "TRUE", 0, "75 min", 0, 0, 0, 0, 0, 0, 0, 0, "Heart of a Dog", 0, 0, "movie", 0, 0, 0, "Laurie Anderson", 0, "data/Movie_Poster_Dataset/2015/tt4935446.jpg", "tt4935446", "7.2", "401" },
                    { 768, 0, 0, "Ben Masters, Jonny Fitzsimons, Thomas Glover, Ben Thamer", 0, 0, "1 win.", 0, "null", 0, "USA", 0, "Phillip Baribeau", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGI0NzI5YjAtNTg0MS00NDA2LWE5ZWItODRmOTAxOTAxYjg2L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Oct-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Unbranded", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3020666.jpg", "tt3020666", "7.6", "437" },
                    { 769, 0, 1, "Radhika Apte, Nawazuddin Siddiqui, Varun Dhawan, Yami Gautam", 0, 0, "N/A", 0, "370,843", 0, "India", 1, "Sriram Raghavan", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkxMjYyNzgwMl5BMl5BanBnXkFtZTgwMTE3MjYyMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Feb-15", "TRUE", 0, "128 min", 0, 0, 0, 0, 0, 0, 0, 0, "Badlapur", 0, 0, "movie", 0, 0, 0, "Arijit Biswas, Massimo Carlotto (novel), Sriram Raghavan, Pooja Ladha Surti (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt3678782.jpg", "tt3678782", "7.5", "11,068" },
                    { 770, 0, 0, "Andrea Pino, Annie Clark, Claire Potter, Melinda Manning", 0, 0, "Nominated for 1 Oscar. Another 5 wins & 18 nominations.", 0, "405,917", 0, "USA", 0, "Kirby Dick", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTUwMDA3MTYtZjhjMi00ODFmLTg5ZTAtYzgwN2NlODgzMmUwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jan-16", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hunting Ground", 0, 0, "movie", 0, 0, 0, "Kirby Dick", 0, "data/Movie_Poster_Dataset/2015/tt4185572.jpg", "tt4185572", "7.2", "2,357" },
                    { 771, 0, 1, "Henry Adofo, Michael Attram, Alphonse Menyo, Phillip Adekunle Michael", 0, 0, "3 nominations.", 0, "387,130", 0, "USA, Ghana", 0, "Garrett Batty", 0, 1, 0, 0, 0, "Action, Drama, Thriller", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTViNjlkYjgtMmE3Zi00ZGVkLTkyMjMtNzc3YzAwNzNiODQ1XkEyXkFqcGdeQXVyMjA0MzYwMDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Apr-15", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 1, "Freetown", 0, 0, "movie", 0, 0, 0, "Melissa Leilani Larson, Garrett Batty", 0, "data/Movie_Poster_Dataset/2015/tt3735554.jpg", "tt3735554", "4.6", "961" },
                    { 772, 0, 0, "Janis Joplin, Cat Power, Peter Albin, Sam Andrew", 0, 0, "N/A", 1, "400,824", 0, "USA", 0, "Amy Berg", 1, 0, 0, 0, 0, "Documentary, Biography, Music", 0, 0, "English", 0, "74", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2ODFlMDAtNzdhOC00ZDYzLWE3YTMtNDU4ZGFmZmJmYTczXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-Dec-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Janis: Little Girl Blue", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3707114.jpg", "tt3707114", "7.4", "554" },
                    { 773, 0, 0, "Regina Casé, Michel Joelsas, Camila Márdila, Karine Teles", 0, 0, "11 wins & 8 nominations.", 0, "375,723", 1, "Brazil", 0, "Anna Muylaert", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "Portuguese", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDM3YjNlYmMtOGY3NS00MmRjLWIyY2UtNDA0MWM3OTNlZTY2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Aug-15", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Second Mother", 0, 0, "movie", 0, 0, 0, "Anna Muylaert", 0, "data/Movie_Poster_Dataset/2015/tt3742378.jpg", "tt3742378", "8", "5,158" },
                    { 774, 0, 0, "Vivan Bhatena, Imran Khan, Suparna Marwah, Mithila Palkar", 0, 0, "N/A", 0, "364,932", 1, "India", 0, "Nikhil Advani", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjMyZmU4OGYtNjBiYS00YTIxLWJjMDUtZjczZmQwMTM4YjQxXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Sep-15", "TRUE", 1, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "Katti Batti", 0, 0, "movie", 0, 0, 0, "Nikhil Advani, Anshul Singhal", 0, "data/Movie_Poster_Dataset/2015/tt4467262.jpg", "tt4467262", "4.8", "1,795" },
                    { 776, 0, 0, "Mu-Yeol Kim, Ku Jin, Hyun-woo Lee, Chung-ah Lee", 0, 0, "4 nominations.", 0, "324,719", 0, "South Korea", 0, "Hak-sun Kim", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIxNDYxMTk2MF5BMl5BanBnXkFtZTgwMjQxNjU3MTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "17-Jul-15", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "Northern Limit Line", 0, 0, "movie", 0, 1, 0, "Soon-jo Choi (novel), Hak-sun Kim, Hak-sun Kim", 0, "data/Movie_Poster_Dataset/2015/tt4696222.jpg", "tt4696222", "6.5", "403" },
                    { 777, 0, 0, "Amitabh Bachchan, Dhanush, Akshara Haasan, Abhinaya", 0, 0, "N/A", 0, "241,720", 1, "India", 0, "R. Balki", 0, 1, 0, 0, 0, "Comedy, Drama, Thriller", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWQzYjBjZmQtZDFiOS00ZDQ1LWI4MDAtMDk1NGE1NDBhYjNhL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Feb-15", "TRUE", 0, "155 min", 0, 0, 0, 0, 0, 0, 0, 1, "Shamitabh", 0, 0, "movie", 0, 0, 0, "R. Balki", 0, "data/Movie_Poster_Dataset/2015/tt3836958.jpg", "tt3836958", "6.9", "4,828" },
                    { 778, 0, 0, "Miles Sloman, Jerry Sokolosky, Paul Hughes, Joseph Emms", 0, 0, "N/A", 0, "316,100", 0, "USA", 0, "Timothy A. Chey", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNzZlMThlYzktMDlmZC00YTI1LThlNzktZWU0MTY4ODc2ZWY4XkEyXkFqcGdeQXVyNTA1NjYyMDk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "13-Mar-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "David and Goliath", 0, 0, "movie", 0, 0, 0, "Timothy A. Chey", 0, "data/Movie_Poster_Dataset/2015/tt3962210.jpg", "tt3962210", "6.5", "957" },
                    { 779, 0, 1, "Haruma Miura, Hiroki Hasegawa, Kanata Hongô, Kiko Mizuhara", 0, 0, "N/A", 0, "null", 0, "Japan", 0, "Shinji Higuchi", 0, 1, 0, 0, 1, "Action, Drama, Fantasy", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjhhMDFlZDctYzg1Mi00ZmZiLTgyNTgtM2NkMjRkNzYwZmQ0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Oct-15", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Attack on Titan: Part 2", 0, 0, "movie", 0, 0, 0, "Hajime Isayama (manga), Tomohiro Machiyama (screenplay), Yûsuke Watanabe (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4294052.jpg", "tt4294052", "5", "1,226" },
                    { 780, 0, 0, "Anushka Sharma, Ravi Beniwal, Siddharth Bharadwaj, Neil Bhoopalam", 0, 0, "3 nominations.", 0, "null", 0, "India", 1, "Navdeep Singh", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "Hindi", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjZmMWE4NzgtZjc5OS00NTBmLThlY2MtM2MzNTA5NTZiNTFjXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Mar-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Nh10", 0, 0, "movie", 0, 0, 0, "Sudip Sharma", 0, "data/Movie_Poster_Dataset/2015/tt3742284.jpg", "tt3742284", "7.2", "7,053" },
                    { 781, 0, 0, "Lamman Rucker, Christian Keyes, Brely Evans, D.B. Woodside", 0, 0, "1 nomination.", 0, "289,575", 0, "USA", 0, "Trey Haley", 0, 0, 0, 0, 0, "Mystery", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDcxNjhiOTEtMzQ0YS00OTBhLTkxM2QtN2UyZDMzNzIzNWFlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Nov-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Man in 3B", 0, 0, "movie", 0, 0, 0, "Carl Weber", 0, "data/Movie_Poster_Dataset/2015/tt3384180.jpg", "tt3384180", "5.9", "47" },
                    { 782, 0, 0, "Mathieu Amalric, Wes Anderson, Olivier Assayas, Peter Bogdanovich", 0, 0, "1 win & 1 nomination.", 0, "304,899", 0, "France, USA", 0, "Kent Jones", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, French, Japanese", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTEyMzc0Mjk5MV5BMl5BanBnXkFtZTgwMjI2NDIwMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Dec-15", "TRUE", 0, "79 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hitchcock/Truffaut", 0, 0, "movie", 0, 0, 0, "Kent Jones, Serge Toubiana", 0, "data/Movie_Poster_Dataset/2015/tt3748512.jpg", "tt3748512", "7.4", "810" },
                    { 784, 0, 0, "Vivica A. Fox, Charles S. Dutton, Pooch Hall, David Banner", 0, 0, "N/A", 0, "146,040", 0, "USA", 1, "Arthur Muhammad", 0, 1, 0, 0, 0, "Crime, Drama, Sport", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTllNDU0ZTItYTYxMC00OTI4LThlNDAtZjNiNzdhMWZiYjNmXkEyXkFqcGdeQXVyNzY1NDgwNjQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Oct-15", "TRUE", 0, "110 min", 0, 0, 1, 0, 0, 0, 0, 0, "Carter High", 0, 0, "movie", 0, 0, 0, "Arthur Muhammad", 0, "data/Movie_Poster_Dataset/2015/tt3735398.jpg", "tt3735398", "8.1", "99" },
                    { 785, 0, 1, "Arjun Kapoor, Sonakshi Sinha, Manoj Bajpayee, Deepti Naval", 0, 0, "N/A", 0, "null", 0, "India", 0, "Amit Sharma", 0, 1, 0, 0, 0, "Action, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTgwZmIzMmYtZjE3Yy00NzgzLTgxNmUtNjlmZDlkMzlhOTJkXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Jan-15", "TRUE", 1, "157 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tevar", 0, 0, "movie", 0, 0, 0, "Gunasekhar, Shantanu Srivastava", 0, "data/Movie_Poster_Dataset/2015/tt3398048.jpg", "tt3398048", "4.1", "2,147" },
                    { 786, 0, 1, "Kodi Smit-McPhee, Michael Fassbender, Ben Mendelsohn, Aorere Paki", 0, 0, "4 wins & 11 nominations.", 0, "229,094", 0, "UK, New Zealand", 0, "John Maclean", 0, 0, 0, 0, 0, "Action, Mystery, Romance", 0, 0, "English, French", 0, "72", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQyNTAzOTI3NF5BMl5BanBnXkFtZTcwNTM0Mjg0Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Apr-15", "TRUE", 1, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Slow West", 0, 0, "movie", 0, 0, 0, "John Maclean", 0, "data/Movie_Poster_Dataset/2015/tt3205376.jpg", "tt3205376", "7", "23,698" },
                    { 787, 0, 0, "Sarah Gadon, Bel Powley, Emily Watson, Rupert Everett", 0, 0, "1 win & 1 nomination.", 0, "197,973", 1, "UK", 0, "Julian Jarrold", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTVmMTk2NjUtNjVjNC00OTcwLWE4OWEtNzA4Mjk1ZmIwNDExXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Dec-15", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Royal Night Out", 0, 0, "movie", 0, 0, 0, "Trevor De Silva, Kevin Hood", 0, "data/Movie_Poster_Dataset/2015/tt1837562.jpg", "tt1837562", "6.5", "3,101" },
                    { 788, 0, 0, "Sunny Singh Nijjar, Sonalli Sehgal, Kartik Aaryan, Nushrat Bharucha", 0, 0, "N/A", 0, "222,856", 1, "India", 0, "Luv Ranjan", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTViZmMwOGEtYzc4Yy00ZGQ1LWFkZDQtMDljNGZlMjAxMjhiXkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "16-Oct-15", "TRUE", 1, "137 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pyaar Ka Punchnama 2", 0, 0, "movie", 0, 0, 0, "Luv Ranjan (story), Rahul Mody (screenplay), Tarun Jain (screenplay), Luv Ranjan (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4430136.jpg", "tt4430136", "7.6", "7,196" },
                    { 789, 0, 0, "Robert Ri'chard, Vivica A. Fox, DeRay Davis, Michael Jai White", 0, 0, "N/A", 0, "212,223", 0, "USA", 0, "Jean-Claude La Marre", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGM0ZTU3NmItZmRmMy00YWNjLWEzMWItYzg3MzcwZmM5NjdiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-May-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chocolate City", 0, 0, "movie", 0, 0, 0, "Jean-Claude La Marre", 0, "data/Movie_Poster_Dataset/2015/tt3481000.jpg", "tt3481000", "3.9", "580" },
                    { 791, 0, 0, "Shaofeng Feng, Shawn Dou, Ankhnyam Ragchaa, Yin Zhusheng", 1, 0, "6 wins & 9 nominations.", 0, "null", 0, "China, France", 0, "Jean-Jacques Annaud", 0, 0, 0, 0, 0, "Adventure", 0, 0, "Mandarin, Mongolian", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmJkODczNjItNDI5Yy00MGI1LTkyOWItZDNmNjM4ZGI1ZDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Feb-15", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Wolf Totem", 0, 0, "movie", 0, 0, 0, "Jiang Rong (based on the novel by), Alain Godard (screenplay), Jean-Jacques Annaud (screenplay), Lu Wei (screenplay), John Collee (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2909116.jpg", "tt2909116", "6.6", "2,848" },
                    { 792, 0, 0, "Charlize Theron, Sterling Jerins, Nicholas Hoult, Christina Hendricks", 0, 0, "N/A", 0, "null", 0, "UK, France, USA", 0, "Gilles Paquet-Brenner", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English", 0, "39", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTM1ZjQ2YTktNDM2MS00NGY2LTkzNzItZTU4ODg1ODNkMWYxL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jun-15", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 1, "Dark Places", 0, 0, "movie", 0, 0, 0, "Gillian Flynn (novel), Gilles Paquet-Brenner (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2402101.jpg", "tt2402101", "6.2", "23,978" },
                    { 793, 0, 1, "John Arcilla, Mon Confiado, Arron Villaflor, Jeffrey Quizon", 0, 0, "3 wins & 13 nominations.", 0, "195,580", 0, "Philippines", 0, "Jerrold Tarog", 0, 0, 0, 0, 0, "Action, History", 1, 0, "Filipino, Tagalog, English, Spanish", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTM1MTRiNDctMTFiMC00NGM1LTkyMWQtNTY1M2JjZDczOWQ3XkEyXkFqcGdeQXVyMDI3OTIzOA@@._V1_UY98_CR3,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Heneral Luna", 0, 0, "movie", 0, 0, 0, "Henry Francia, E.A. Rocha, Jerrold Tarog", 0, "data/Movie_Poster_Dataset/2015/tt4944352.jpg", "tt4944352", "8", "1,043" },
                    { 794, 0, 0, "Arnold Schwarzenegger, Abigail Breslin, Joely Richardson, Douglas M. Griffin", 0, 0, "1 win & 2 nominations.", 0, "131,175", 0, "USA, Switzerland", 0, "Henry Hobson", 0, 1, 0, 0, 0, "Drama, Horror", 0, 1, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGQyNjBjNTUtNTM1OS00YzcyLWFhNTgtNTU0MDg3NzBlMDQzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-May-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Maggie", 0, 0, "movie", 0, 0, 0, "John Scott 3", 0, "data/Movie_Poster_Dataset/2015/tt1881002.jpg", "tt1881002", "5.6", "26,541" },
                    { 795, 0, 0, "Myung-min Kim, Yeon-hee Lee, Dal-su Oh", 0, 0, "N/A", 0, "185,367", 0, "South Korea", 0, "Kim Suk-Yoon", 0, 0, 0, 0, 0, "N/A", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzk5MDk2MjktY2I3NS00ODZkLTk3OTktY2Q3ZDE2MmQ2M2ZmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Feb-15", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "Detective K: Secret of the Lost Island", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4505170.jpg", "tt4505170", "6.3", "152" },
                    { 796, 0, 0, "Dong-won Kang, Yun-seok Kim, So-dam Park", 0, 0, "1 nomination.", 0, "158,334", 0, "South Korea", 1, "Jae-hyun Jang", 0, 0, 0, 0, 0, "Crime, Mystery, Thriller", 0, 0, "Korean", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzNiOGJhMDUtZjNjMC00YmE5LTk3NjQtNGM4ZjAzOGJjZmRlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "4-Dec-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Priests", 0, 0, "movie", 0, 0, 0, "Jae-hyun Jang", 0, "data/Movie_Poster_Dataset/2015/tt5049302.jpg", "tt5049302", "6.1", "167" },
                    { 798, 0, 0, "Paul Abbott, Mark Baxter, Steve Brookes, Rick Buckler", 0, 0, "1 nomination.", 0, "null", 0, "UK", 0, "Bob Smeaton", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODI3YzNiZTUtYjEyZS00ODkwLWE2ZDUtNGJmMTNiYTc4ZTM4XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "4-Sep-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Jam: About the Young Idea", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt5022418.jpg", "tt5022418", "7.8", "59" },
                    { 799, 0, 0, "Chuck D., Chris Cornell, Heidi Cotler, Rudy Danzinger", 0, 0, "N/A", 0, "166,872", 0, "USA, Japan", 0, "Colin Hanks", 1, 0, 0, 0, 0, "Documentary, History, Music", 1, 0, "English", 0, "73", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGU2YmU0MWMtMzg5My00ZmY2LTljMDItMTg2YTI5Y2U2OTE3XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "16-Oct-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "All Things Must Pass: The Rise and Fall of Tower Records", 0, 0, "movie", 0, 0, 0, "Steven Leckart", 0, "data/Movie_Poster_Dataset/2015/tt3272570.jpg", "tt3272570", "7.2", "541" },
                    { 800, 0, 0, "Teigan McCarty, Kristian Boulter, Julie-Anne Breen, Rob Sneddon", 0, 0, "N/A", 0, "null", 0, "Australia", 0, "Rhiannon Noon", 0, 0, 0, 0, 0, "Short, Sci-Fi", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2I1YWM4NTYtYjA0Ny00ZDEwLTg3NTgtNzBjMzZhZTk1YTA1XkEyXkFqcGdeQXVyMTY5Nzc4MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "31-Oct-15", "TRUE", 0, "N/A", 0, 1, 0, 0, 0, 0, 0, 0, "Out of Time Out of Mind", 0, 0, "movie", 0, 0, 0, "Rhiannon Noon", 0, "data/Movie_Poster_Dataset/2015/tt5233460.jpg", "tt5233460", "N/A", "N/A" },
                    { 801, 0, 0, "Kun Chen, Bingbing Li, Winston Chao, Zishan Yang", 0, 0, "1 nomination.", 0, "165,428", 0, "China, Hong Kong, USA", 0, "Peter Pau, Tianyu Zhao", 0, 0, 0, 0, 1, "Fantasy", 0, 0, "Mandarin", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGQ4NDUyNWQtZTEyOC00OTMzLWFhYjAtNDNmYmQ2MWQyMTRmXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "19-Feb-15", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Zhongkui: Snow Girl and the Dark Crystal", 0, 0, "movie", 0, 0, 0, "Junli Guo, Raymond Lei Jin, Huanhuan Zhang", 0, "data/Movie_Poster_Dataset/2015/tt3585004.jpg", "tt3585004", "5.3", "674" },
                    { 802, 0, 0, "Yun-seok Kim, Jung Woo, Hie-ae Kim, Hyo-ju Han", 0, 0, "2 nominations.", 0, "162,082", 0, "South Korea", 0, "Hyun-seok Kim", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjk3YzFjYTktOGY0ZS00Y2EwLTk2NTctYTI1Nzc2OWNiN2I4XkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Feb-15", "TRUE", 1, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "C'est Si Bon", 0, 0, "movie", 0, 0, 0, "Hyun-seok Kim", 0, "data/Movie_Poster_Dataset/2015/tt4430992.jpg", "tt4430992", "6.9", "130" },
                    { 803, 0, 0, "Qi Shu, Eddie Peng, Hong Pan, Shih-Chieh Chin", 0, 0, "N/A", 0, "null", 0, "China", 0, "Luo Luo", 0, 0, 0, 0, 0, "Romance", 0, 0, "Mandarin", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmVkOTRiYmItZjE4NS00MWNjLWE0ZmMtYzg5YzFjMjMyY2RkXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Nov-15", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Last Women Standing", 0, 0, "movie", 0, 0, 0, "Luo Luo", 0, "data/Movie_Poster_Dataset/2015/tt5257730.jpg", "tt5257730", "5.5", "71" },
                    { 804, 0, 0, "Portia Doubleday, Marc-André Grondin, Chris Noth, Lauren Holly", 0, 0, "N/A", 0, "160,165", 1, "Canada", 0, "Sean Garrity", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English, French, Italian", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTUzMzAzMzEzNV5BMl5BanBnXkFtZTgwOTg1NTAwMjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "24-Apr-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "After the Ball", 0, 0, "movie", 0, 0, 0, "Jason Sherman (screenplay), Kate Melville (screenplay), Jason Sherman (story)", 0, "data/Movie_Poster_Dataset/2015/tt3717016.jpg", "tt3717016", "6", "1,358" },
                    { 805, 0, 0, "Nick Swardson, Mila Kunis, Bob Odenkirk, T.J. Miller", 1, 1, "N/A", 0, "156,166", 1, "USA", 0, "Tom Gianas, Ross Shuman", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmYxZGU2NWYtNzQxZS00NmEyLWIzN2YtMDk5MWM0ODc5ZTE4XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Oct-15", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hell and Back", 0, 0, "movie", 0, 0, 0, "Tom Gianas, Zeb Wells, Hugh Sterbakov", 0, "data/Movie_Poster_Dataset/2015/tt2141773.jpg", "tt2141773", "5.3", "1,416" },
                    { 806, 0, 0, "John Palladino, Anthony Edwards, Jim Gaffigan, Peter Sarsgaard", 0, 0, "1 win & 3 nominations.", 1, "155,075", 0, "USA", 0, "Michael Almereyda", 0, 1, 0, 0, 0, "Biography, Drama, History", 1, 0, "English", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmMxZTU2ZDUtM2Y1MS00ZWFmLWJlN2UtNzI0OTJiOTYzMTk3XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Oct-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Experimenter", 0, 0, "movie", 0, 0, 0, "Michael Almereyda", 0, "data/Movie_Poster_Dataset/2015/tt3726704.jpg", "tt3726704", "6.6", "6,975" },
                    { 807, 0, 0, "Nick Carter, Howie Dorough, Brian Littrell, A.J. McLean", 0, 0, "N/A", 0, "null", 0, "UK, USA", 0, "Stephen Kijak", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ0Njc1MjM0OF5BMl5BanBnXkFtZTgwNTY2NTUyMjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Jan-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Backstreet Boys: Show 'Em What You're Made Of", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt2712154.jpg", "tt2712154", "7.9", "946" },
                    { 808, 0, 0, "Gero Camilo, Aisha Jambo, Gustavo Machado, Ney Matogrosso", 0, 0, "N/A", 0, "null", 1, "Brazil", 0, "Pedro Soffer Serrano", 0, 1, 0, 0, 0, "Short, Comedy, Drama", 0, 0, "Portuguese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU0OTc3ODk4Ml5BMl5BanBnXkFtZTgwMzM4NzI5NjM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "17 min", 0, 1, 0, 0, 0, 0, 0, 0, "Stories of Samba", 0, 0, "movie", 0, 0, 0, "Pedro Soffer Serrano", 0, "data/Movie_Poster_Dataset/2015/tt4830104.jpg", "tt4830104", "N/A", "N/A" },
                    { 810, 0, 0, "Kevin Bacon, James Freedson-Jackson, Hays Wellford, Camryn Manheim", 0, 0, "1 win & 4 nominations.", 0, "128,002", 0, "USA", 1, "Jon Watts", 0, 0, 0, 0, 0, "Crime, Thriller", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjRhYzk2NDAtYzA1Mi00MmNmLWE1ZjQtMDBhZmUyMTdjZjBiXkEyXkFqcGdeQXVyNjk1Njg5NTA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Aug-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 1, "Cop Car", 0, 0, "movie", 0, 0, 0, "Jon Watts, Christopher Ford", 0, "data/Movie_Poster_Dataset/2015/tt3813310.jpg", "tt3813310", "6.2", "17,483" },
                    { 811, 0, 0, "Pia Lindström, Roberto Rossellini, Isotta Rossellini, Isabella Rossellini", 0, 0, "2 wins & 1 nomination.", 1, "127,529", 0, "Sweden", 0, "Stig Björkman", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "Swedish, English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjk1Njk3YjctMmMyYS00Y2I4LThhMzktN2U0MTMyZTFlYWQ5XkEyXkFqcGdeQXVyODM2ODEzMDA@._V1_UY98_CR15,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Nov-15", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ingrid Bergman in Her Own Words", 0, 0, "movie", 0, 0, 0, "Stig Björkman, Dominika Daubenbüchel, Stina Gardell", 0, "data/Movie_Poster_Dataset/2015/tt4621016.jpg", "tt4621016", "7.3", "509" },
                    { 812, 0, 0, "Ben Mendelsohn, Yvonne Landry, Anthony Howard, Ryan Reynolds", 0, 0, "2 wins & 3 nominations.", 0, "129,747", 0, "USA", 0, "Anna Boden, Ryan Fleck", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUyMjU1OTUwM15BMl5BanBnXkFtZTgwMDg1NDQ2MjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Aug-15", "TRUE", 0, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mississippi Grind", 0, 0, "movie", 0, 0, 0, "Anna Boden, Ryan Fleck", 0, "data/Movie_Poster_Dataset/2015/tt2349144.jpg", "tt2349144", "6.4", "8,078" },
                    { 814, 0, 0, "Misty Copeland, Deirdre Kelly, Susan Fales-Hill, Leyla Fayyaz", 0, 0, "1 win & 1 nomination.", 0, "96,900", 0, "USA", 0, "Nelson George", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjUxMDQwNjcyNl5BMl5BanBnXkFtZTgwNzcwMzc0MTI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Oct-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Ballerina's Tale", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4504040.jpg", "tt4504040", "6.3", "286" },
                    { 815, 0, 0, "Chiwetel Ejiofor, Margot Robbie, Chris Pine", 0, 0, "3 nominations.", 0, "118,483", 0, "Iceland, Switzerland, New Zealand, USA", 0, "Craig Zobel", 0, 1, 0, 0, 0, "Drama, Sci-Fi, Thriller", 0, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjRlZmM0ODktY2RjNS00ZDdjLWJhZGYtNDljNWZkMGM5MTg0XkEyXkFqcGdeQXVyNjAwMjI5MDk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Aug-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 1, "Z for Zachariah", 0, 0, "movie", 0, 0, 0, "Nissar Modi (screenplay), Robert C. O'Brien (novel)", 0, "data/Movie_Poster_Dataset/2015/tt1598642.jpg", "tt1598642", "6", "14,037" },
                    { 816, 0, 0, "N/A", 0, 0, "1 win & 6 nominations.", 0, "45,896", 0, "USA", 0, "Frederick Wiseman", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, Spanish, Arabic, Hindi", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE0NDUyOTc2MV5BMl5BanBnXkFtZTgwODk2NzU3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "23-Mar-16", "TRUE", 0, "190 min", 0, 0, 0, 0, 0, 0, 0, 0, "In Jackson Heights", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4936064.jpg", "tt4936064", "7.8", "150" },
                    { 817, 0, 0, "Jake Johnson, Rosemarie DeWitt, Orlando Bloom, Brie Larson", 0, 0, "N/A", 0, "119,364", 0, "USA", 0, "Joe Swanberg", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjAwNDA5NzEwM15BMl5BanBnXkFtZTgwMTA1MDUyNDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Aug-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Digging for Fire", 0, 0, "movie", 0, 0, 0, "Jake Johnson, Joe Swanberg", 0, "data/Movie_Poster_Dataset/2015/tt3704416.jpg", "tt3704416", "6", "2,645" },
                    { 818, 0, 0, "Suzuko Mimori, Yurika Kubo, Pile, Riho Iida", 0, 1, "1 nomination.", 0, "null", 1, "Japan", 0, "Takahiko Kyogoku", 0, 0, 0, 0, 0, "Animation, Comedy, Music", 0, 0, "Japanese", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTlmYTJmMWEtNDRhNy00ODc1LTg2OTMtMjk2ODJhNTA4YTE1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Jun-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Love Live! The School Idol Movie", 0, 0, "movie", 0, 0, 0, "Jukki Hanada, Sakurako Kimino (original story)", 0, "data/Movie_Poster_Dataset/2015/tt3837248.jpg", "tt3837248", "7.9", "92" },
                    { 819, 0, 0, "Larry Clarke, Jonathan Klein, Adam Carolla, Jim O'Heir", 0, 0, "N/A", 0, "105,943", 1, "USA", 0, "Adam Carolla, Kevin Hench", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Mar-15", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Road Hard", 0, 0, "movie", 0, 0, 0, "Adam Carolla, Kevin Hench", 0, "data/Movie_Poster_Dataset/2015/tt3110770.jpg", "tt3110770", "6.1", "1,288" },
                    { 820, 0, 1, "Byung-hun Lee, Go-eun Kim, Do-yeon Jeon, Kyeong-yeong Lee", 0, 0, "N/A", 0, "109,972", 0, "South Korea", 0, "Heung-sik Park", 0, 1, 0, 0, 0, "Action, Drama, History", 1, 0, "Korean", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTM3ZTllNzItNTNmOS00NzJiLTg1MWMtMjMxNDc0NmJhODU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "28-Aug-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Memories of the Sword", 0, 0, "movie", 0, 0, 0, "Ah-reum Choi, Heung-sik Park", 0, "data/Movie_Poster_Dataset/2015/tt3054798.jpg", "tt3054798", "6.2", "576" },
                    { 821, 0, 0, "James Earl Jones, Rob Lowe, Gabrielle Union, Ernie Sabella", 1, 1, "N/A", 0, "null", 0, "N/A", 0, "Howy Parkins", 0, 0, 0, 1, 0, "Animation, Adventure, Family", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTVkMTFiZWItOTFkOC00YTc3LWFhYzQtZTg3NzAxZjJlNTAyXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "22-Nov-15", "TRUE", 0, "44 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lion Guard: Return of the Roar", 0, 0, "movie", 0, 0, 0, "Ford Riley", 0, "data/Movie_Poster_Dataset/2015/tt4938602.jpg", "tt4938602", "6.1", "604" },
                    { 822, 0, 0, "Hyo-ju Han, Seo Joon Park, Juri Ueno, Jin-wook Lee", 0, 0, "1 win & 4 nominations.", 0, "107,004", 0, "South Korea", 0, "Jong-Yeol Baek", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Korean, Japanese, Czech, English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTA1NzUzNjY4MV5BMl5BanBnXkFtZTgwNDU0MDI0NTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Sep-15", "TRUE", 1, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Beauty Inside", 0, 0, "movie", 0, 0, 0, "Seon-jeong Kim, Jeong-ye Park, Kyung-hee Noh (narration writer)", 0, "data/Movie_Poster_Dataset/2015/tt4273886.jpg", "tt4273886", "7.2", "900" },
                    { 823, 0, 0, "Guy Pearce, Cobie Smulders, Kevin Corrigan, Giovanni Ribisi", 0, 0, "5 nominations.", 0, "103,887", 1, "USA", 0, "Andrew Bujalski", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English, Japanese", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-May-15", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Results", 0, 0, "movie", 0, 0, 0, "Andrew Bujalski", 0, "data/Movie_Poster_Dataset/2015/tt3824412.jpg", "tt3824412", "5.5", "4,044" },
                    { 824, 0, 0, "Christopher Abbott, Cynthia Nixon, Scott Mescudi, Ron Livingston", 0, 0, "6 wins & 27 nominations.", 0, "94,464", 0, "USA", 0, "Josh Mond", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "83", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ5NTg5ODk4OV5BMl5BanBnXkFtZTgwODc4MTMzMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Nov-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "James White", 0, 0, "movie", 0, 0, 0, "Josh Mond", 0, "data/Movie_Poster_Dataset/2015/tt4288636.jpg", "tt4288636", "7.4", "764" },
                    { 825, 0, 0, "Maaya Sakamoto, Ken'ichirô Matsuda, Ikkyu Juku, Kazuya Nakai", 0, 1, "N/A", 0, "null", 0, "Japan", 0, "Kazuchika Kise, Kazuya Nomura", 0, 0, 0, 0, 0, "Animation, Sci-Fi", 0, 0, "Japanese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgwNTAwMjEzMF5BMl5BanBnXkFtZTcwNzMzODY4OA@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Nov-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ghost In The Shell: The New Movie", 0, 0, "movie", 0, 0, 0, "Masamune Shirow (manga), Tow Ubukata (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4337072.jpg", "tt4337072", "6.9", "1,014" },
                    { 826, 0, 0, "Simon Abkarian, Angela Sarafyan, Sam Page, Nikolai Kinski", 0, 0, "N/A", 0, "96,682", 0, "USA", 0, "Garin Hovannisian, Alec Mouhibian", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQzMzg2Nzg2MF5BMl5BanBnXkFtZTgwNjUzNzIzMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Apr-16", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "1915", 0, 0, "movie", 0, 0, 0, "Garin Hovannisian, Alec Mouhibian", 0, "data/Movie_Poster_Dataset/2015/tt3781762.jpg", "tt3781762", "4.4", "994" },
                    { 827, 0, 1, "Andy Lau, Ye Liu, Qianyuan Wang, Ruofu Wu", 0, 0, "2 nominations.", 0, "92,696", 0, "China", 1, "Sheng Ding", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "Mandarin, Chinese", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzA2NDkwODAwM15BMl5BanBnXkFtZTgwODk5MTgzMTE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Sep-15", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Saving Mr. Wu", 0, 0, "movie", 0, 0, 0, "Sheng Ding, Sheng Ding, Alex Jia (script advisor)", 0, "data/Movie_Poster_Dataset/2015/tt4819560.jpg", "tt4819560", "6.8", "875" },
                    { 828, 0, 0, "Margaret Clunie, Patrick Stewart, Gary Cole, Roxanne Cook", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Mitch Davis", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "24", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BOTc3NzAxMjg4M15BMl5BanBnXkFtZTcwMDc2ODQwNw@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG", 0, 0, "4-Dec-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Christmas Eve", 0, 0, "movie", 0, 0, 0, "Mitch Davis, Tyler McKellar", 0, "data/Movie_Poster_Dataset/2015/tt3703148.jpg", "tt3703148", "5.1", "995" },
                    { 829, 0, 0, "Elisabeth Moss, Katherine Waterston, Patrick Fugit, Kentucker Audley", 0, 0, "1 win & 3 nominations.", 0, "78,353", 0, "USA", 0, "Alex Ross Perry", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGQzODdlMDktNzU4ZC00N2M3LWFkYTAtYTM1NTE0ZWI5YTg4XkEyXkFqcGdeQXVyMTA1NTM1NDI2._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "26-Aug-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "Queen of Earth", 0, 0, "movie", 0, 0, 0, "Alex Ross Perry", 0, "data/Movie_Poster_Dataset/2015/tt3993894.jpg", "tt3993894", "6.6", "2,529" },
                    { 830, 0, 0, "Abraham Attah, Emmanuel Affadzi, Ricky Adelayitor, Andrew Adote", 0, 0, "Nominated for 1 Golden Globe. Another 24 wins & 46 nominations.", 0, "83,861", 0, "USA", 0, "Cary Joji Fukunaga", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzMxNTExOTkyMF5BMl5BanBnXkFtZTcwMzEyNDc0OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "16-Oct-15", "TRUE", 0, "137 min", 0, 0, 0, 0, 0, 0, 0, 0, "Beasts of No Nation", 0, 0, "movie", 0, 1, 0, "Cary Joji Fukunaga (screenplay), Uzodinma Iweala (based on the novel by)", 0, "data/Movie_Poster_Dataset/2015/tt1365050.jpg", "tt1365050", "7.8", "34,839" },
                    { 831, 0, 0, "Edsel Pete, Mia Sable, Chris Robinson, Ernest Tsosie III", 0, 0, "N/A", 0, "90,706", 0, "USA", 0, "Travis Holt Hamilton", 0, 0, 0, 0, 0, "Sci-Fi", 0, 0, "English, Navajo", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjg0OTM5OTQyNV5BMl5BanBnXkFtZTgwNDg5NDQ0NTE@._V1_UY98_CR2,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Jan-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "Legends from the Sky", 0, 0, "movie", 0, 0, 0, "Travis Holt Hamilton", 0, "data/Movie_Poster_Dataset/2015/tt3625220.jpg", "tt3625220", "6.9", "37" },
                    { 832, 0, 0, "Clint Eastwood, Lainie Kazan, Natalie Wood, Robert Wagner", 0, 0, "7 wins & 3 nominations.", 1, "null", 0, "USA", 0, "Jeffrey Schwarz", 1, 0, 0, 0, 0, "Documentary, Biography", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM3NzQzMDA5Ml5BMl5BanBnXkFtZTcwODA5NTcyNw@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "16-Oct-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tab Hunter Confidential", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt1533089.jpg", "tt1533089", "7.9", "519" },
                    { 833, 0, 0, "Sebastián Silva, Kristen Wiig, Tunde Adebimpe, Reg E. Cathey", 0, 0, "1 win & 1 nomination.", 0, "79,800", 0, "USA, Chile", 0, "Sebastián Silva", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Spanish", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM4NjY1MDQwMl5BMl5BanBnXkFtZTcwNTI3Njg3NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Nasty Baby", 0, 0, "movie", 0, 0, 0, "Sebastián Silva (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3121332.jpg", "tt3121332", "5.6", "1,251" },
                    { 835, 0, 0, "Teresa Clovicko, Audrey Copper, Katie Cotton, James Coyne", 0, 0, "3 wins & 1 nomination.", 1, "73,002", 0, "USA", 0, "Dana Nachman", 1, 0, 0, 1, 0, "Documentary, Biography, Family", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTg4MDk1ODExN15BMl5BanBnXkFtZTgwNzIyNjg3MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "26-Jun-15", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Batkid Begins", 0, 0, "movie", 0, 0, 0, "Kurt Kuenne, Dana Nachman", 0, "data/Movie_Poster_Dataset/2015/tt3884528.jpg", "tt3884528", "6.4", "1,035" },
                    { 836, 0, 1, "Jackie Chan, John Cusack, Adrien Brody, Si Won Choi", 1, 0, "2 wins & 1 nomination.", 0, "72,413", 0, "China, Hong Kong", 0, "Daniel Lee", 0, 1, 0, 0, 0, "Action, Adventure, Drama", 0, 0, "Mandarin, English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjE5MzYwMzYxMF5BMl5BanBnXkFtZTcwOTk4MTk0OQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Sep-15", "TRUE", 0, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dragon Blade", 0, 0, "movie", 0, 0, 0, "Daniel Lee", 0, "data/Movie_Poster_Dataset/2015/tt3672840.jpg", "tt3672840", "6.1", "10,144" },
                    { 838, 0, 0, "Nicholas Braun, Mackenzie Davis, Josh Fadem, Denis Leary", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Robbie Pickering", 0, 0, 0, 0, 0, "Comedy, Horror", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk2NzczOTgxNF5BMl5BanBnXkFtZTcwODQ5ODczOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Freaks of Nature", 0, 0, "movie", 0, 0, 0, "Oren Uziel (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt1817771.jpg", "tt1817771", "5.8", "3,583" },
                    { 840, 0, 1, "Munro Chambers, Laurence Leboeuf, Michael Ironside, Edwin Wright", 1, 0, "9 wins & 4 nominations.", 0, "50,000", 1, "Canada, USA, New Zealand", 0, "François Simard, Anouk Whissell, Yoann-Karl Whissell", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYwMzMzMDI0NF5BMl5BanBnXkFtZTgwNDQ3NjI3NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "28-Aug-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Turbo Kid", 0, 0, "movie", 1, 0, 0, "François Simard, Anouk Whissell, Yoann-Karl Whissell", 0, "data/Movie_Poster_Dataset/2015/tt3672742.jpg", "tt3672742", "6.7", "13,990" },
                    { 841, 0, 0, "Jemaine Clement, Regina Hall, Jessica Williams, Stephanie Allynne", 0, 0, "3 nominations.", 0, "null", 1, "USA", 0, "James C. Strouse", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGUyZDUxZjEtMmIzMC00MzlmLTg4MGItZWJmMzBhZjE0Mjc1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Aug-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "People Places Things", 0, 0, "movie", 0, 0, 0, "James C. Strouse", 0, "data/Movie_Poster_Dataset/2015/tt4104022.jpg", "tt4104022", "6.9", "4,028" },
                    { 844, 0, 0, "Colette Kenny Mckenna, Krystle Fitch, Anastasia Blue, Tanya Erin Paoli", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Phil Stevens", 0, 0, 0, 0, 0, "Horror, Mystery, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg5OTMxNzk4Nl5BMl5BanBnXkFtZTcwOTk1MjAwNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Feb-15", "TRUE", 0, "79 min", 0, 0, 0, 0, 0, 0, 0, 1, "Flowers", 0, 0, "movie", 0, 0, 0, "Phil Stevens", 0, "data/Movie_Poster_Dataset/2015/tt4248930.jpg", "tt4248930", "5.4", "103" },
                    { 845, 0, 0, "Silvia Bottini, Fan Liao, Yan Su, Wei Tang", 0, 0, "N/A", 0, "55,239", 1, "China", 0, "Hao Zhang", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "Mandarin, Italian, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGQwZjg5YmYtY2VkNC00NzliLTljYTctNzI5NmU3MjE2ODQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "24-Jul-15", "TRUE", 1, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Only You", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4819544.jpg", "tt4819544", "5.3", "66" },
                    { 846, 0, 0, "Josh Charles, Skylar Gaertner, Shayne Coleman, Sarah Silverman", 0, 0, "1 win & 5 nominations.", 0, "57,678", 0, "USA", 0, "Adam Salky", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWZiNjE2OWItMTkwNy00ZWQzLWI0NTgtMWE0NjNiYTljN2Q1XkEyXkFqcGdeQXVyNzAwMjYxMzA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Nov-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "I Smile Back", 0, 0, "movie", 0, 0, 0, "Paige Dylan, Paige Dylan, Amy Koppelman, Amy Koppelman", 0, "data/Movie_Poster_Dataset/2015/tt3640682.jpg", "tt3640682", "6.1", "2,534" },
                    { 847, 0, 0, "Gregg Turkington, Annabella Lwin, Tye Sheridan, John C. Reilly", 0, 0, "1 win & 2 nominations.", 0, "44,242", 0, "USA", 0, "Rick Alverson", 0, 1, 0, 0, 0, "Drama", 0, 0, "English, Spanish", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM2MTI5NzA3MF5BMl5BanBnXkFtZTcwODExNTc0OA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Nov-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Entertainment", 0, 0, "movie", 0, 0, 0, "Rick Alverson, Rick Alverson, Tim Heidecker, Gregg Turkington, Gregg Turkington", 0, "data/Movie_Poster_Dataset/2015/tt3343784.jpg", "tt3343784", "5.8", "1,176" },
                    { 848, 0, 0, "Zijian Dong, Jiaqi Li, Honglei Sun, Sen Wang", 0, 0, "N/A", 0, "null", 1, "China", 0, "Yang Xiao", 0, 0, 0, 0, 0, "Comedy", 0, 0, "Mandarin", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzljNjY3MDYtYzc0Ni00YjU0LWIyNDUtNTE0ZDRiMGExMjZlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "19-Jun-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Ark of Mr Chow", 0, 0, "movie", 0, 0, 0, "Xiao Yang, Ji Zhang", 0, "data/Movie_Poster_Dataset/2015/tt4727756.jpg", "tt4727756", "5.7", "76" },
                    { 850, 0, 0, "Holly Valance, Vincent Pastore, Corinna Harney, Lanette Fugit", 0, 0, "1 win & 1 nomination.", 0, "null", 0, "USA", 1, "Ousa Khun", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTk5MjM4OTU1OV5BMl5BanBnXkFtZTcwODkzNDIzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Oct-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Red Herring", 0, 0, "movie", 0, 0, 0, "Joshua A. Cohen (character conception), Joshua A. Cohen, Russell Grin (character conception)", 0, "data/Movie_Poster_Dataset/2015/tt1460646.jpg", "tt1460646", "3.1", "200" },
                    { 851, 0, 0, "Miroslav Karel, Drago Lazetich, Emilie Ohana", 0, 0, "N/A", 0, "null", 1, "China, Czech Republic, Slovakia", 0, "Andrej Iliev", 0, 1, 0, 0, 0, "Short, Comedy, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2OTE1Mjk0N15BMl5BanBnXkFtZTcwODE3MDAwNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-Jun-15", "TRUE", 0, "21 min", 0, 1, 0, 0, 0, 0, 0, 0, "Shanghai Story", 0, 0, "movie", 0, 0, 0, "Andrej Iliev (story), Andrej Iliev", 0, "data/Movie_Poster_Dataset/2015/tt4781992.jpg", "tt4781992", "7.5", "115" },
                    { 852, 0, 0, "Sushil Pandey, Tanmay Bhat, Gurmeet Choudhary, Amyra Dastur", 0, 0, "N/A", 0, "30,097", 0, "India", 0, "Vikram Bhatt", 0, 0, 0, 0, 0, "Sci-Fi, Thriller", 0, 0, "Hindi", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTc3YmM3N2QtODZkMC00ZDE5LThjMTQtYTljN2Y1YTYwYWJkXkEyXkFqcGdeQXVyODEzNjM5OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "17-Apr-15", "TRUE", 0, "133 min", 0, 0, 0, 0, 0, 0, 0, 1, "Mr. X", 0, 0, "movie", 0, 0, 0, "Vikram Bhatt (story), Shagufta Rafique (dialogue)", 0, "data/Movie_Poster_Dataset/2015/tt3848938.jpg", "tt3848938", "3.7", "1,125" },
                    { 854, 0, 0, "Thomas Curry, Michael French, Daniel E. Gray, Emma Jordan", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Chris Widdop", 0, 0, 0, 0, 0, "Short, Horror", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTY4NTU2NTU4NF5BMl5BanBnXkFtZTcwNjE0OTc5MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "17-Aug-15", "TRUE", 0, "15 min", 0, 1, 0, 0, 0, 0, 0, 0, "Breathe", 0, 0, "movie", 0, 0, 0, "Chris Widdop", 0, "data/Movie_Poster_Dataset/2015/tt5503970.jpg", "tt5503970", "N/A", "N/A" },
                    { 855, 0, 0, "Patricio Guzmán, Raúl Zurita", 0, 0, "10 wins & 7 nominations.", 0, "null", 0, "France, Spain, Chile, Switzerland", 0, "Patricio Guzmán", 1, 0, 0, 0, 0, "Documentary", 0, 0, "Spanish", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDliMTMxOWEtODM3Yi00N2QwLTg4YTAtNTE5YzBlNTA2NjhlXkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-Oct-15", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Pearl Button", 0, 0, "movie", 0, 0, 0, "Patricio Guzmán (concept)", 0, "data/Movie_Poster_Dataset/2015/tt4377864.jpg", "tt4377864", "7.5", "604" },
                    { 858, 0, 0, "Niklas Frank, Philippe Sands, Horst von Wächter", 0, 0, "1 win & 2 nominations.", 0, "38,987", 0, "UK", 0, "David Evans", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTA1Mzg3NjIxNV5BMl5BanBnXkFtZTcwNzU2NTc5MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Nov-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "What Our Fathers Did: A Nazi Legacy", 0, 0, "movie", 0, 0, 0, "Philippe Sands", 0, "data/Movie_Poster_Dataset/2015/tt4668808.jpg", "tt4668808", "6.3", "149" },
                    { 859, 0, 0, "Sam Brower, Nick Cave, Andrew Chatwin, Lori Chatwin", 0, 0, "1 nomination.", 1, "13,532", 0, "USA", 0, "Amy Berg", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "English", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU2NjQ1Nzc4MF5BMl5BanBnXkFtZTcwNTM0NDk1Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Sep-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Prophet's Prey", 0, 0, "movie", 0, 0, 0, "Amy Berg", 0, "data/Movie_Poster_Dataset/2015/tt4188202.jpg", "tt4188202", "7.3", "594" },
                    { 862, 0, 0, "Keanu Reeves, Lorenza Izzo, Ana de Armas, Aaron Burns", 0, 0, "N/A", 0, "34,004", 0, "Chile, USA", 1, "Eli Roth", 0, 0, 0, 0, 0, "Crime, Horror, Thriller", 0, 1, "English, Spanish", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzA4ZGM1NjYtMjcxYS00MTdiLWJmNzEtMTUzODY0NDQ0YzUzXkEyXkFqcGdeQXVyMzYwMjQ3OTI@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Oct-15", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 1, "Knock Knock", 0, 0, "movie", 0, 0, 0, "Eli Roth, Nicolás López, Guillermo Amoedo", 0, "data/Movie_Poster_Dataset/2015/tt3605418.jpg", "tt3605418", "4.9", "37,906" },
                    { 863, 0, 0, "N/A", 0, 0, "7 wins & 7 nominations.", 0, "36,010", 0, "USA", 0, "Michael Beach Nichols, Christopher K. Walker", 1, 0, 0, 0, 0, "Documentary, Thriller", 0, 0, "English", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDNlNjEzMzQtZDM0MS00YzhiLTk0MGUtYTdmNDZiZGVjNTk0L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-Dec-15", "TRUE", 0, "85 min", 0, 0, 0, 0, 0, 0, 0, 1, "Welcome to Leith", 0, 0, "movie", 0, 0, 0, "Michael Beach Nichols, Christopher K. Walker", 0, "data/Movie_Poster_Dataset/2015/tt3962848.jpg", "tt3962848", "7.1", "475" },
                    { 864, 0, 1, "Louis Koo, Shawn Yue, Liya Tong, Hsiao-chuan Chang", 0, 0, "1 nomination.", 0, "null", 0, "Hong Kong", 1, "Ringo Lam", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "Cantonese", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmE3OWZhZDYtOTBjMi00NDIwLTg1NWMtMjg0NjJmZWM4MjliL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "31-Jul-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 1, "Wild City", 0, 0, "movie", 0, 0, 0, "Ringo Lam", 0, "data/Movie_Poster_Dataset/2015/tt3801934.jpg", "tt3801934", "5.7", "422" },
                    { 865, 0, 0, "Roy Dupuis, Clara Furey, Louis Negin, Udo Kier", 0, 0, "4 wins & 7 nominations.", 0, "34,043", 1, "Canada", 0, "Guy Maddin, Evan Johnson", 0, 0, 0, 0, 0, "Comedy, Mystery", 0, 0, "English", 0, "83", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Dec-15", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Forbidden Room", 0, 0, "movie", 0, 0, 0, "Guy Maddin, Evan Johnson, Robert Kotyk, John Ashbery (additional writer), Kim Morgan (additional writer), Kim Morgan (story)", 0, "data/Movie_Poster_Dataset/2015/tt3066630.jpg", "tt3066630", "6.7", "935" },
                    { 866, 0, 0, "Sam Rockwell, Amy Ryan, Will Forte, Danny McBride", 1, 0, "N/A", 0, "null", 1, "USA", 0, "Jared Hess", 0, 1, 0, 0, 0, "Adventure, Comedy, Drama", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIxODEyOTQ5Ml5BMl5BanBnXkFtZTcwNjE3NzI5Mw@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Dec-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Don Verdean", 0, 0, "movie", 0, 0, 0, "Jared Hess, Jerusha Hess", 0, "data/Movie_Poster_Dataset/2015/tt3534282.jpg", "tt3534282", "5.3", "1,825" },
                    { 867, 0, 1, "Beau Martin Williams, Matt Funke, Trai Byers, Michael Masini", 0, 0, "N/A", 1, "128,782", 0, "USA", 1, "Theo Avgerinos", 0, 0, 0, 0, 0, "Action, Biography, Crime", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjM1NTkxNjkzMl5BMl5BanBnXkFtZTgwNDgwMDAxMzE@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Jan-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Americons", 0, 0, "movie", 0, 0, 0, "Beau Martin Williams (writer,  co-creator), Matt Funke (creator)", 0, "data/Movie_Poster_Dataset/2015/tt2293060.jpg", "tt2293060", "7.1", "55" },
                    { 868, 0, 0, "Siegfried Peters, Stephen Michael Joseph, Nicole Bosworth, Estrella Cristina", 0, 0, "3 nominations.", 0, "null", 0, "USA", 0, "Rodney Ascher", 1, 0, 0, 0, 0, "Documentary, Horror", 0, 1, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2UwNDc5NmEtNjVjZS00OTI5LWE5YjctMWM3ZjBiZGYwMGI2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "5-Jun-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Nightmare", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3317522.jpg", "tt3317522", "5.9", "3,167" },
                    { 869, 0, 0, "Jason Schwartzman, Stephen Root, Jimmy Gonzales, Olympia Dukakis", 0, 0, "1 win & 4 nominations.", 0, "null", 1, "USA", 0, "Bob Byington", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjczMWI1YWMtYTZjOS00ZDc5LWE2MWItMTY3ZGUxNzFkNjJmL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Apr-16", "TRUE", 0, "76 min", 0, 0, 0, 0, 0, 0, 0, 0, "7 Chinese Brothers", 0, 0, "movie", 0, 0, 0, "Bob Byington", 0, "data/Movie_Poster_Dataset/2015/tt3488184.jpg", "tt3488184", "5.7", "777" },
                    { 871, 0, 0, "Maud Arnold, Chloe Arnold, Jason Samuels Smith, Sarah Reich", 0, 0, "N/A", 0, "21,312", 0, "USA", 0, "Dean Hargrove", 1, 0, 0, 0, 0, "Documentary, History, Music", 1, 0, "English, French, Japanese, Hindi, Mandarin, Portuguese, Zulu", 0, "60", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQyODczNjU3NF5BMl5BanBnXkFtZTcwNjQ0NDIzMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "10-Jul-15", "TRUE", 0, "72 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tap World", 0, 0, "movie", 0, 0, 0, "Dean Hargrove", 0, "data/Movie_Poster_Dataset/2015/tt4669204.jpg", "tt4669204", "7.4", "29" },
                    { 872, 0, 0, "William 'Dub' Lawrence", 0, 0, "6 wins & 4 nominations.", 0, "26,632", 0, "USA", 0, "Brad Barber, Scott Christopherson", 1, 0, 0, 0, 0, "Documentary, News", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTEzOTYwMTcxN15BMl5BanBnXkFtZTcwNTgyNjI1MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Apr-15", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Peace Officer", 0, 0, "movie", 0, 0, 0, "Brad Barber, Scott Christopherson, David Lawrence, Renny McCauley", 0, "data/Movie_Poster_Dataset/2015/tt4079142.jpg", "tt4079142", "7.7", "195" },
                    { 873, 0, 0, "N/A", 0, 0, "3 nominations.", 1, "25,947", 0, "Senegal, USA", 0, "Samba Gadjigo, Jason Silverman", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "English, French", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAxNDYxMjg0MjNeQTJeQWpwZ15BbWU3MDcyNTk2OTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "23-Jan-15", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sembene!", 0, 0, "movie", 0, 0, 0, "Samba Gadjigo, Jason Silverman", 0, "data/Movie_Poster_Dataset/2015/tt4344782.jpg", "tt4344782", "7.6", "36" },
                    { 875, 0, 0, "Cobie Smulders, Anders Holm, Gail Bean, Elizabeth McGovern", 0, 0, "1 nomination.", 0, "null", 1, "USA", 0, "Kris Swanberg", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODFlNTI0ZWQtOTcxNC00OTc0LTkwZDUtMmNkM2I1ZWFlYzZkXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UY98_CR2,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Jul-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Unexpected", 0, 0, "movie", 0, 0, 0, "Megan Mercier, Kris Swanberg", 0, "data/Movie_Poster_Dataset/2015/tt4145304.jpg", "tt4145304", "5.7", "1,984" },
                    { 877, 0, 0, "Geun-hyeong Park, Yeo-jeong Yoon, Jin-woong Jo, Ji-min Han", 0, 0, "N/A", 0, "null", 0, "South Korea", 0, "Je-kyu Kang", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5NTAzNTc1NF5BMl5BanBnXkFtZTYwNDY4MDc3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Apr-15", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Salut d'Amour", 0, 0, "movie", 0, 0, 0, "Sang-Hyeon Lee (screenplay), Je-kyu Kang (screenplay), Eun-jin Pang (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4695462.jpg", "tt4695462", "7.6", "69" },
                    { 878, 0, 0, "Adam Pally, Sarah Burns, Megan Neuringer, Reid Scott", 0, 0, "N/A", 0, "21,080", 1, "USA", 0, "Don Argott, Sheena M. Joyce", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODE0NTcxNTQzNF5BMl5BanBnXkFtZTcwMzczOTIzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "19-Aug-15", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Slow Learners", 0, 0, "movie", 0, 0, 0, "Heather Maidat (screenplay), Heather Maidat (story), Peter C. Swords (story)", 0, "data/Movie_Poster_Dataset/2015/tt2537390.jpg", "tt2537390", "5.9", "1,564" },
                    { 879, 0, 0, "Ashley Bratcher, Joseph Gray, Rusty Martin Sr., Cory Assink", 0, 0, "2 nominations.", 0, "null", 0, "USA", 0, "Paul Munger", 0, 0, 0, 0, 0, "Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTk1OTA1MjIyNV5BMl5BanBnXkFtZTcwODQxMTkyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "4-Aug-15", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Princess Cut", 0, 0, "movie", 0, 0, 0, "Paul Munger, Sheilah Munger", 0, "data/Movie_Poster_Dataset/2015/tt3175798.jpg", "tt3175798", "5.6", "49" },
                    { 880, 0, 0, "Rene Redzepi", 0, 0, "N/A", 0, "19,554", 0, "UK", 0, "Pierre Deschamps", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English, Danish, Spanish, Albanian, Swedish, French", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjZiOTNlMzYtZWYwZS00YWJjLTk5NDgtODkwNjRhMDI0MjhjXkEyXkFqcGdeQXVyMjgyNjk3MzE@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Noma My Perfect Storm", 0, 0, "movie", 0, 0, 0, "Pierre Deschamps", 0, "data/Movie_Poster_Dataset/2015/tt4610372.jpg", "tt4610372", "6.2", "53" },
                    { 881, 0, 0, "Khalid Abour, Mo Abour, Joni Barnes, Ken Barnes", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Daryl Wein", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTIyMDFmMmItMWQzYy00MjBiLTg2M2UtM2JiNDRhOWE4NjBhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jun-15", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 1, "Consumed", 0, 0, "movie", 0, 0, 0, "Zoe Lister-Jones, Zoe Lister-Jones, Daryl Wein, Daryl Wein", 0, "data/Movie_Poster_Dataset/2015/tt3760966.jpg", "tt3760966", "2.8", "298" },
                    { 882, 0, 0, "Bobby Cannavale, Freddie Prinze Jr., Whoopi Goldberg, Sam Rockwell", 0, 0, "1 nomination.", 0, "5,300", 1, "USA", 0, "Kevin Pollak", 1, 0, 0, 0, 0, "Documentary, Comedy", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjk1NzBlY2YtNjJmNi00YTVmLWI2OTgtNDUxNDE5NjUzZmE0XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Apr-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Misery Loves Comedy", 0, 0, "movie", 0, 0, 0, "Kevin Pollak, Kevin Pollak, John Vorhaus, John Vorhaus", 0, "data/Movie_Poster_Dataset/2015/tt3132632.jpg", "tt3132632", "6.2", "656" },
                    { 884, 0, 0, "Kent Moran, Michael Clarke Duncan, S. Epatha Merkerson, Justin Hartley", 0, 0, "4 wins & 1 nomination.", 0, "19,003", 0, "USA", 0, "Kent Moran", 0, 1, 0, 0, 0, "Drama, Sport", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQxNDQwNjQzOV5BMl5BanBnXkFtZTcwNTQxNDYyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Sep-15", "TRUE", 0, "95 min", 0, 0, 1, 0, 0, 0, 0, 0, "The Challenger", 0, 0, "movie", 0, 0, 0, "Kent Moran", 0, "data/Movie_Poster_Dataset/2015/tt1974382.jpg", "tt1974382", "5.7", "545" },
                    { 885, 0, 0, "Juan Gabriel Vásquez, Jon Lee Anderson, Xavi Ayén, Carmen Balcells", 0, 0, "1 nomination.", 1, "11,574", 0, "Spain, UK, Colombia, France, USA", 0, "Justin Webster", 1, 0, 0, 0, 0, "Documentary, Biography, History", 1, 0, "Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI2NDI5ODk4N15BMl5BanBnXkFtZTYwMTI3NTE3._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Mar-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gabo: The Creation of Gabriel Garcia Marquez", 0, 0, "movie", 0, 0, 0, "Kate Horne, Justin Webster", 0, "data/Movie_Poster_Dataset/2015/tt4568106.jpg", "tt4568106", "7.5", "26" },
                    { 886, 0, 0, "Koudous Seihon, Alassane Sy, Paolo Sciarretta, Vincenzina Siciliano", 0, 0, "10 wins & 10 nominations.", 0, "5,846", 0, "Italy, France, USA, Germany, Qatar", 0, "Jonas Carpignano", 0, 1, 0, 0, 0, "Drama", 0, 0, "French, Italian, English, Arabic", 0, "77", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI1NDMyMjExOF5BMl5BanBnXkFtZTcwOTc4MjQzMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Nov-15", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mediterranea", 0, 0, "movie", 0, 0, 0, "Jonas Carpignano", 0, "data/Movie_Poster_Dataset/2015/tt3486542.jpg", "tt3486542", "6.7", "441" },
                    { 888, 0, 0, "Nicole Kidman, Joseph Fiennes, Hugo Weaving, Lisa Flanagan", 0, 0, "6 nominations.", 0, "null", 0, "Australia, Ireland", 0, "Kim Farrant", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODFlMmEwMDgtYjhmZi00ZTE5LTk2NWQtMWE1Y2M0NjkzOGYxXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Jul-15", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 1, "Strangerland", 0, 0, "movie", 0, 0, 0, "Michael Kinirons, Fiona Seres (story), Fiona Seres", 0, "data/Movie_Poster_Dataset/2015/tt2325977.jpg", "tt2325977", "5.2", "5,087" },
                    { 889, 0, 1, "Bruce Willis, Kellan Lutz, Gina Carano, D.B. Sweeney", 0, 0, "N/A", 0, "null", 0, "Canada", 0, "Steven C. Miller", 0, 0, 0, 0, 0, "Action, Thriller", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzQxNjM5NzkxNV5BMl5BanBnXkFtZTcwMzg5NDMwMg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Dec-15", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 1, "Extraction", 0, 0, "movie", 0, 0, 0, "Max Adams, Umair Aleem", 0, "data/Movie_Poster_Dataset/2015/tt4382872.jpg", "tt4382872", "3.9", "3,111" },
                    { 891, 0, 0, "Stacey Arwen Raab", 0, 0, "3 nominations.", 0, "12,700", 0, "Canada, USA", 0, "Avi Lewis", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzkyNzQ1Mzc0NV5BMl5BanBnXkFtZTcwODg3MzUzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Nov-15", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "This Changes Everything", 0, 0, "movie", 0, 0, 0, "Naomi Klein", 0, "data/Movie_Poster_Dataset/2015/tt1870548.jpg", "tt1870548", "6.5", "213" },
                    { 892, 0, 0, "Will Roth, Yogi Roth", 1, 0, "N/A", 0, "null", 0, "USA, Portugal, Spain", 0, "Yogi Roth", 1, 0, 0, 1, 0, "Documentary, Adventure, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI2NzU1NTc1NF5BMl5BanBnXkFtZTcwOTQ1MjAwMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "76 min", 0, 0, 0, 0, 0, 0, 0, 0, "Life in a Walk", 0, 0, "movie", 0, 0, 0, "Jonathan James", 0, "data/Movie_Poster_Dataset/2015/tt4425148.jpg", "tt4425148", "9.6", "8" },
                    { 893, 0, 0, "Ron Finley", 0, 0, "1 win.", 0, "null", 0, "USA", 0, "Delila Vallot", 1, 1, 0, 1, 0, "Documentary, Drama, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI0MTg4NzI3M15BMl5BanBnXkFtZTcwOTE0MTUyMQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Jun-15", "TRUE", 0, "80 min", 0, 0, 0, 0, 0, 0, 0, 0, "Can You Dig This", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4422656.jpg", "tt4422656", "9.1", "15" },
                    { 895, 0, 0, "Caroline Barry, Christopher Lambert, Kelly LeBrock, Julia Chantrey", 0, 0, "N/A", 0, "14,616", 0, "USA", 0, "Timothy Hines", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGY1YmUzN2MtNDQ3NC00Nzc4LWI5M2EtYzUwMGQ4NWM4NjE1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "11-Nov-15", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "10 Days in a Madhouse", 0, 0, "movie", 0, 0, 0, "Timothy Hines", 0, "data/Movie_Poster_Dataset/2015/tt3453052.jpg", "tt3453052", "8", "267" },
                    { 896, 0, 0, "Joseph Mawle, Bojana Novakovic, Michael McElhatton, Michael Smiley", 0, 0, "10 wins & 3 nominations.", 0, "8,967", 0, "UK, USA, Ireland", 0, "Corin Hardy", 0, 0, 0, 0, 0, "Horror", 0, 1, "N/A", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzEyNzc0NjctZjJiZC00MWI1LWJlOTMtYWZkZDAzNzQ0ZDNkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "5-Nov-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Hallow", 0, 0, "movie", 0, 0, 0, "Corin Hardy (screenplay), Felipe Marino (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt2474976.jpg", "tt2474976", "5.7", "5,032" },
                    { 897, 0, 0, "Christopher Giles, Sadey Wild, Scott Lawson, Aazan Manji", 1, 0, "N/A", 0, "null", 0, "Canada", 0, "Janie Fontaine", 0, 0, 0, 0, 0, "Short, Adventure", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjIwZWU0ZDItNzBlNS00MDIwLWFlZjctZTJjODdjZWYxNzczL2ltYWdlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "8 min", 0, 1, 0, 0, 0, 0, 0, 0, "City Boys: Backcountry Adventures", 0, 0, "movie", 0, 0, 0, "Stella Constance", 0, "data/Movie_Poster_Dataset/2015/tt2904688.jpg", "tt2904688", "N/A", "N/A" },
                    { 899, 0, 1, "Yayan Ruhian, Rirî Furankî, Hayato Ichihara, Tetsu Watanabe", 0, 0, "N/A", 0, "null", 1, "Japan, France", 0, "Takashi Miike", 0, 0, 0, 0, 0, "Action, Comedy, Horror", 0, 1, "Japanese, English", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWMwMzQxZjQtODM1YS00YmFiLTk1YjQtNzNiYWY1MDE4NTdiXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Oct-15", "TRUE", 0, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "Yakuza Apocalypse", 0, 0, "movie", 0, 0, 0, "Yoshitaka Yamaguchi (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3675748.jpg", "tt3675748", "5.6", "1,364" },
                    { 900, 0, 0, "Lucy McBath, Rob Schenck", 0, 0, "2 wins & 1 nomination.", 0, "null", 0, "USA", 0, "Abigail Disney, Kathleen Hughes", 1, 0, 0, 0, 0, "Documentary, News", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjcxMmQ0MmItYTkzYy00MmUyLTlhOTQtMmJmNjE3MDMwYjdlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Oct-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Armor of Light", 0, 0, "movie", 0, 0, 0, "Abigail Disney", 0, "data/Movie_Poster_Dataset/2015/tt4506722.jpg", "tt4506722", "6.4", "40" },
                    { 901, 0, 0, "Miguel Gomes, Carloto Cotta, Maria Rueff, Adriano Luz", 0, 0, "6 wins & 13 nominations.", 0, "12,017", 0, "Portugal, France, Germany, Switzerland", 0, "Miguel Gomes", 0, 1, 0, 0, 0, "Drama", 0, 0, "Portuguese, English, French, German, Mandarin", 0, "80", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNThiMDc1YjUtYmE3Zi00MTM1LTkzM2MtNjdlNzQ4ZDlmYjRmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "24-Jun-15", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Arabian Nights: Volume 1 - The Restless One", 0, 0, "movie", 0, 0, 0, "Telmo Churro, Miguel Gomes, Mariana Ricardo", 0, "data/Movie_Poster_Dataset/2015/tt3284178.jpg", "tt3284178", "7.3", "846" },
                    { 902, 0, 1, "Hyuk Jang, Ha-kyun Shin, HaNeul Kim, Kang Ha-Neul", 0, 0, "N/A", 0, "6,316", 0, "South Korea", 0, "Sang-hoon Ahn", 0, 1, 0, 0, 0, "Action, Drama, Romance", 0, 0, "Korean", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGY3NWYwNzctNWU5Yi00ZjljLTgyNDgtZjNhZjRlNjc0ZTU1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "5-Mar-15", "TRUE", 1, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Empire of Lust", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3544326.jpg", "tt3544326", "6.7", "91" },
                    { 904, 0, 0, "Robert Hands, Evan Bendall, Michaela Prchalová, Dolya Gavanski", 0, 0, "1 nomination.", 0, "null", 0, "UK", 0, "Ruth Platt", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGY5NWUyNDUtZWJhZi00ZjMxLWFmMjMtYmJhZjVkZGZhNWQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "29-Feb-16", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Lesson", 0, 0, "movie", 0, 0, 0, "Ruth Platt, Ruth Platt", 0, "data/Movie_Poster_Dataset/2015/tt4078160.jpg", "tt4078160", "4.6", "210" },
                    { 905, 0, 0, "Beck, Jackson Browne, Cold Cave, Ólafur Eliasson", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Doug Aitken", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzVmYzVkMmUtOGRhMi00MTNmLThlMmUtZTljYjlkMjNkMjJkXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "25-Jan-15", "TRUE", 0, "71 min", 0, 0, 0, 0, 0, 0, 0, 0, "Station to Station", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4382618.jpg", "tt4382618", "6.5", "88" },
                    { 907, 0, 0, "N/A", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Jem Cohen", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTIyNThlMjMtMzUyMi00YmEyLTljMmYtMWRhN2Q3ZTllZjA4XkEyXkFqcGdeQXVyMzM4MjM0Nzg@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "31-Jul-15", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Counting", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4462082.jpg", "tt4462082", "5.8", "53" },
                    { 908, 0, 0, "Emily VanCamp, Michael Nyqvist, Ana Mulvoy-Ten, Talia Balsam", 0, 0, "1 nomination.", 0, "5,249", 0, "USA", 0, "Marya Cohn", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "68", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjZkOTdmMWItOTkyNy00MDdjLTlhNTQtYzU3MzdhZjA0ZDEyXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "11-Dec-15", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Girl in the Book", 0, 0, "movie", 0, 0, 0, "Marya Cohn", 0, "data/Movie_Poster_Dataset/2015/tt2980554.jpg", "tt2980554", "6.1", "1,353" },
                    { 909, 0, 0, "Rachel McAdams, James Franco, Peter Stormare, Charlotte Gainsbourg", 0, 0, "1 nomination.", 0, "null", 0, "Germany, Canada, France, Sweden, Norway", 0, "Wim Wenders", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDYwYzlhOTAtNDAwMC00ZTBhLWI4M2QtMTA1NmJhYTdiNTkxXkEyXkFqcGdeQXVyNTM0NTU5Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NOT RATED", 0, 0, "2-Apr-15", "TRUE", 0, "118 min", 0, 0, 0, 0, 0, 0, 0, 0, "Every Thing Will Be Fine", 0, 0, "movie", 0, 0, 0, "Bjørn Olaf Johannessen", 0, "data/Movie_Poster_Dataset/2015/tt1707380.jpg", "tt1707380", "5.5", "3,071" },
                    { 910, 0, 0, "Zephyr Benson, Aaron Costa Ganis, Jon McCormick, Mike Steinmetz", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Zephyr Benson", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOGE0ZWI0YzAtY2NkZi00YjkyLWIzYWEtNTJmMzJjODllNjdjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Mar-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Straight Outta Tompkins", 0, 0, "movie", 0, 0, 0, "Zephyr Benson", 0, "data/Movie_Poster_Dataset/2015/tt2815720.jpg", "tt2815720", "5.7", "185" },
                    { 911, 0, 0, "Reid Warner, Darrin Bragg, Ben Rovner, Jelena Nik", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Oren Peli", 0, 0, 0, 0, 0, "Horror, Sci-Fi, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTA5MzQ3MzI1NV5BMl5BanBnXkFtZTgwNTcxNTYxMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "15-May-15", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 1, "Area 51", 0, 0, "movie", 0, 0, 0, "Christopher Denham, Oren Peli", 0, "data/Movie_Poster_Dataset/2015/tt1519461.jpg", "tt1519461", "4.2", "7,274" },
                    { 913, 0, 0, "Andrew Agner-Nichols, Catie Carlton, Danny Dobyns, Adrian Fernandez", 0, 0, "1 win & 4 nominations.", 0, "null", 0, "USA", 0, "André Joseph, Anna Snead", 0, 1, 0, 0, 0, "Short, Drama, Mystery", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2FlNzE0ZmUtMmVkZS00MWQ3LWE4OWQtYjQwZjdhNzRmNWE2XkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Aug-15", "TRUE", 0, "21 min", 0, 1, 0, 0, 0, 0, 0, 0, "The Dinner", 0, 0, "movie", 0, 0, 0, "André Joseph, Anna Snead", 0, "data/Movie_Poster_Dataset/2015/tt4265396.jpg", "tt4265396", "N/A", "N/A" },
                    { 914, 0, 0, "N/A", 0, 0, "N/A", 0, "4,914", 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, "N/A", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDZkMTUxYWEtMDY5NS00ZTA5LTg3MTItNTlkZWE1YWRjYjMwL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jun-15", "TRUE", 0, "72 min", 0, 0, 0, 0, 0, 0, 0, 0, "Antarctic Edge", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4836406.jpg", "tt4836406", "N/A", "N/A" },
                    { 915, 0, 0, "Tilda Swinton", 0, 0, "2 nominations.", 0, "null", 0, "Austria, Germany, UK", 0, "Manu Luksch, Martin Reinhart, Thomas Tode", 1, 0, 0, 0, 0, "Documentary, History, News", 1, 0, "English", 0, "62", 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE2OTc3OTk2M15BMl5BanBnXkFtZTgwMjg2NjIyMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-May-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dreams Rewired", 0, 0, "movie", 0, 0, 0, "Manu Luksch, Mukul Patel, Martin Reinhart, Thomas Tode", 0, "data/Movie_Poster_Dataset/2015/tt4414694.jpg", "tt4414694", "7", "40" },
                    { 916, 0, 0, "Steve McQueen, Chad McQueen, John Sturges, Neile Adams", 0, 0, "1 nomination.", 0, "4,079", 0, "USA, UK", 0, "Gabriel Clarke, John McKenna", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjA2MTA1MjUtYmUyNy00NGZiLTk2NTAtMDk3N2M3YmMwOTc1XkEyXkFqcGdeQXVyMjA0MzYwMDY@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "13-Nov-15", "TRUE", 0, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Steve McQueen: The Man & Le Mans", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3504604.jpg", "tt3504604", "7.4", "169" },
                    { 917, 0, 0, "Dani Rovira, Michelle Jenner, Carme Calvell, Javier Balas", 1, 1, "3 wins & 2 nominations.", 0, "null", 1, "Spain", 0, "Enrique Gato", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "Spanish, Catalan, English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYmUxY2MyOTQtYjRlMi00ZWEwLTkzODctZDMxNDcyNTFhYjNjXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG", 0, 0, "28-Aug-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Capture the Flag", 0, 0, "movie", 0, 0, 0, "Patxi Amezcua (Argumento), Jordi Gasull, Neil Landau, Javier López Barreira", 0, "data/Movie_Poster_Dataset/2015/tt3896100.jpg", "tt3896100", "5.8", "822" },
                    { 918, 0, 0, "Crista Alfaiate, Chico Chapas, Luísa Cruz, Pedro Caldas", 0, 0, "4 wins & 8 nominations.", 0, "6,197", 0, "Portugal, France, Germany, Switzerland", 0, "Miguel Gomes", 0, 1, 0, 0, 0, "Drama", 0, 0, "Portuguese, English, French, German, Mandarin", 0, "81", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWMxZTgzMWEtMTU0Zi00NDc5LWFkZjctMzUxNDIyNzZiMmNjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "29-Jul-15", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 0, "Arabian Nights: Volume 2 - The Desolate One", 0, 0, "movie", 0, 0, 0, "Telmo Churro, Miguel Gomes, Mariana Ricardo", 0, "data/Movie_Poster_Dataset/2015/tt4692234.jpg", "tt4692234", "7.4", "534" },
                    { 919, 0, 0, "Terrance Zdunich, Paul Sorvino, Adam Pascal, Marc Senter", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Darren Lynn Bousman", 0, 0, 0, 0, 0, "Horror, Musical", 0, 1, "English", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWFjYmZmZGQtYzg4YS00ZGE5LTgwYzAtZmQwZjQ2NDliMGVmXkEyXkFqcGdeQXVyNTUyMzE4Mzg@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Aug-15", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Alleluia! The Devil's Carnival", 0, 0, "movie", 0, 0, 0, "Terrance Zdunich", 0, "data/Movie_Poster_Dataset/2015/tt3892618.jpg", "tt3892618", "7.7", "161" },
                    { 920, 0, 1, "Jaime King, Samuel L. Jackson, Madeleine Stack, Eva G. Cooper", 1, 0, "N/A", 0, "null", 1, "USA", 0, "Kyle Newman", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjFkOWM5NDUtODYwOS00ZDg0LWFkZGUtYzBkYzNjZjU3ODE3XkEyXkFqcGdeQXVyNzQzNzQxNzI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Apr-15", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Barely Lethal", 0, 0, "movie", 0, 0, 0, "John D'Arco", 0, "data/Movie_Poster_Dataset/2015/tt1731701.jpg", "tt1731701", "5.3", "9,778" },
                    { 921, 0, 0, "Selma Blair, Drea de Matteo, Mary Lynn Rajskub, Adrian Grenier", 0, 0, "N/A", 0, "5,236", 1, "USA", 0, "Ally Walker", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzMzMDZkYWEtODIzNS00YjI3LTkxNTktOWEyZGM3ZWI2MWM4XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Oct-15", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sex, Death and Bowling", 0, 0, "movie", 0, 0, 0, "Ally Walker (story), Ally Walker, Ally Walker", 0, "data/Movie_Poster_Dataset/2015/tt3250032.jpg", "tt3250032", "5.3", "59" },
                    { 923, 0, 0, "Chris Baker-Brian, Florence Banda, Ibrahim Bangura, Isaac Balla Bangura", 0, 0, "N/A", 0, "5,677", 0, "USA, UK, Malawi, Sierra Leone", 0, "Adam Friedman, Iain Kennedy", 1, 0, 0, 0, 0, "Documentary, History, News", 1, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQzMzcxMzUyMl5BMl5BanBnXkFtZTgwNDI1MjgxMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "2-Oct-15", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shout Gladi Gladi", 0, 0, "movie", 0, 0, 0, "Iain Kennedy", 0, "data/Movie_Poster_Dataset/2015/tt4109204.jpg", "tt4109204", "5.4", "20" },
                    { 924, 0, 0, "Paul Ashton, Ahmed Bharoocha, Gia Carides, Leonel Claude", 0, 0, "1 win & 1 nomination.", 0, "null", 1, "USA", 0, "Paul Ashton", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTM2NWI2OGYtYWNhMi00ZTlmLTg2ZTAtMmI5NWRjODA5YTE1XkEyXkFqcGdeQXVyODE2OTYwNTg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Dec-15", "TRUE", 1, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "This Isn't Funny", 0, 0, "movie", 0, 0, 0, "Paul Ashton, Paul Ashton, Katie Page, Katie Page", 0, "data/Movie_Poster_Dataset/2015/tt3334212.jpg", "tt3334212", "6.7", "194" },
                    { 925, 0, 0, "Fanny Ardant, Marina Hands, Eric Elmosnino, Laurent Stocker", 0, 0, "N/A", 0, "null", 1, "France", 0, "Jérôme Cornuau", 0, 0, 0, 0, 0, "Comedy", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2U5OWM5NWQtZDYwZS00NmI3LTk4NDktNzcwZjYzNmEzYWU1XkEyXkFqcGdeQXVyNjMwMjk0MTQ@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Jan-15", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "Chic!", 0, 0, "movie", 0, 0, 0, "Jean-Paul Bathany (scenario)", 0, "data/Movie_Poster_Dataset/2015/tt3592176.jpg", "tt3592176", "5.4", "115" },
                    { 927, 0, 0, "Katrina Law, Lochlyn Munro, Victoria Pratt, Nick E. Tarabay", 0, 0, "N/A", 0, "4,344", 0, "USA", 1, "T.J. Scott", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDQzMGE5ODYtZDdiNC00MzZjLTg2NjAtZTk0ODlkYmY4MTQzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "20-Oct-15", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Death Valley", 0, 0, "movie", 0, 0, 0, "Brad MacPherson, Brad MacPherson, T.J. Scott", 0, "data/Movie_Poster_Dataset/2015/tt2788512.jpg", "tt2788512", "3.8", "257" },
                    { 930, 0, 0, "Brian Crawford, Deanna Reed Foster, Amy Frazzini, Danny Glenn", 0, 0, "N/A", 0, "4,418", 1, "USA", 0, "Josh Wolff", 0, 1, 0, 0, 0, "Short, Comedy, Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjM4NWRhYTQtYTJlNC00ZmMyLWEzNTAtZDA2MjJjYTQ5ZTVmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "18 min", 0, 1, 0, 0, 0, 0, 0, 0, "Guidance", 0, 0, "movie", 0, 0, 0, "Josh Wolff", 0, "data/Movie_Poster_Dataset/2015/tt4846028.jpg", "tt4846028", "N/A", "N/A" },
                    { 931, 0, 0, "Katherine Heigl, Tom Wilkinson, Linda Emond, Grace Gummer", 0, 0, "N/A", 0, "2,254", 1, "USA", 0, "Mary Agnes Donoghue", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmVhNWIzOTMtYmVlZC00ZDVmLWIyODEtODEzOTAxYjAwMzVlXkEyXkFqcGdeQXVyMzIwNDY4NDI@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-Jul-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jenny's Wedding", 0, 0, "movie", 0, 0, 0, "Mary Agnes Donoghue (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt3289712.jpg", "tt3289712", "5.5", "3,996" },
                    { 932, 0, 0, "Mickey Rourke, Nat Wolff, Emma Roberts, Sarah Silverman", 0, 0, "1 nomination.", 0, "4,631", 1, "USA", 0, "Tony McNamara", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzE1Njk0NmItNDhlMC00ZmFlLWI4ZTUtYTY4ZjgzNjkyMTU1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Sep-15", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ashby", 0, 0, "movie", 0, 0, 0, "Tony McNamara", 0, "data/Movie_Poster_Dataset/2015/tt3774466.jpg", "tt3774466", "6.4", "6,126" },
                    { 933, 0, 0, "Crista Alfaiate, Bernardo Alves, Chico Chapas, Carloto Cotta", 0, 0, "4 wins & 8 nominations.", 0, "4,290", 0, "Portugal, France, Germany, Switzerland", 0, "Miguel Gomes", 0, 1, 0, 0, 0, "Drama", 0, 0, "Portuguese, English, French, German, Mandarin", 0, "80", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZWY0ODc2NDktYmYxNS00MGZiLTk5YjktZjgwZWFhNDQ0MzNhXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "26-Aug-15", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Arabian Nights: Volume 3 - The Enchanted One", 0, 0, "movie", 0, 0, 0, "Telmo Churro, Miguel Gomes, Mariana Ricardo", 0, "data/Movie_Poster_Dataset/2015/tt4692242.jpg", "tt4692242", "6.7", "383" },
                    { 934, 0, 0, "Julija Steponaityte, Aiste Dirziute, Jurate Sodyte, Martynas Budraitis", 0, 0, "8 wins & 7 nominations.", 0, "3,275", 0, "Lithuania, France, Netherlands", 0, "Alante Kavaite", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "Lithuanian", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDE0MWE1ZTMtOWFkMS00YjdiLTkwZTItMDljYjY3MjM0NTk5XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "29-Jul-15", "TRUE", 1, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Summer of Sangaile", 0, 0, "movie", 0, 0, 0, "Alante Kavaite", 0, "data/Movie_Poster_Dataset/2015/tt2994832.jpg", "tt2994832", "6.7", "860" },
                    { 935, 0, 0, "Jay R. Ferguson, Jessica Szohr, Jerry Ferrara, Robert Davi", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Fabrizio Conte", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2Y0NWRkNWItZWEwNi00MDNlLWJmZDYtNTkwYzI5Nzg4MjVjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Nov-15", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Club Life", 0, 0, "movie", 0, 0, 0, "Danny A. Abeckaser, Ryan O'Nan, Ryan Vallan", 0, "data/Movie_Poster_Dataset/2015/tt3038734.jpg", "tt3038734", "4.8", "335" },
                    { 936, 0, 0, "Melanie Griffith, Jane Lynch, William Baldwin, Stephen Baldwin", 0, 1, "N/A", 0, "null", 0, "USA", 0, "Yoon-suk Choi", 0, 0, 0, 0, 0, "Animation", 0, 0, "N/A", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDkzOTFmMTUtMmI2OS00MDE4LTg5YTUtODMwNDMzNmI5OGYwL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "9-Jun-15", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Back to the Jurassic", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt4693418.jpg", "tt4693418", "5", "211" },
                    { 938, 0, 0, "N/A", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Darren Doane", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDNiYmRkNDYtOWU1NC00NmMxLWFkNmUtMGI5NTJjOTJmYTM5XkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "5-Nov-15", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Free Speech Apocalypse", 0, 0, "movie", 0, 0, 0, "Cheston Hervey", 0, "data/Movie_Poster_Dataset/2015/tt5105784.jpg", "tt5105784", "7.7", "56" },
                    { 939, 0, 0, "Alexandra Neary, Herman Johansen, Stephanie Snow, Victor Chi", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Matthew McGregor", 0, 1, 0, 0, 0, "Short, Drama, Horror", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjVkYmFkZWQtZmNjYy00NmFhLTliMWYtNThlOTUxNjg5ODdhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR4,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "N/A", "TRUE", 0, "14 min", 0, 1, 0, 0, 0, 0, 0, 0, "In the Basement", 0, 0, "movie", 0, 0, 0, "Matthew McGregor (story), Matthew McGregor", 0, "data/Movie_Poster_Dataset/2015/tt4094590.jpg", "tt4094590", "N/A", "N/A" },
                    { 940, 0, 0, "Rossif Sutherland, Paul Gross, Allan Hawco, Clark Johnson", 0, 0, "9 nominations.", 0, "1,430", 0, "Canada", 0, "Paul Gross", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTYzN2MxODMtMDBhOC00Y2M0LTgzMTItMzQ4NDIyYWIwMDEzL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Oct-15", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hyena Road", 0, 0, "movie", 0, 1, 0, "Paul Gross", 0, "data/Movie_Poster_Dataset/2015/tt4034452.jpg", "tt4034452", "6.5", "1,760" },
                    { 941, 0, 0, "Robert Fontaine, Michael Brainard, Grant Boyd, Michael Derek", 0, 0, "N/A", 0, "3,330", 0, "USA", 1, "Robert Fontaine", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English, Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmRlZDQ1MmUtMzE2Yi00YTkxLTk1MGMtYmIyYWQwODcxYzRlXkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Oct-15", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Mi America", 0, 0, "movie", 0, 0, 0, "Robert Fontaine", 0, "data/Movie_Poster_Dataset/2015/tt2460506.jpg", "tt2460506", "7.9", "19" },
                    { 942, 0, 0, "Deshawn Brown, Niquana Clark, Michael Dew, Gabrielle Garcia", 0, 0, "6 wins & 3 nominations.", 0, "null", 0, "USA", 0, "Juan Carlos Pineiro Escoriaza", 0, 1, 0, 0, 0, "Drama, Musical", 0, 0, "English", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWQ1ZWE0MTQtMmEwOS00YjA3LTgyZTAtNjY5ODEyZTJjNDI2XkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "15-May-15", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Know How", 0, 0, "movie", 0, 0, 0, "Deshawn Brown, Niquana Clark, Michael Dew, Gabrielle Garcia, Gilbert Howard, Claribelle Pagan, Juan Carlos Pineiro Escoriaza, Ebonee Simpson", 0, "data/Movie_Poster_Dataset/2015/tt2089721.jpg", "tt2089721", "7", "39" },
                    { 943, 0, 0, "Nick P. Ross, J.R. Ramirez, Christian Cooke, Bethany Dwyer", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Nick Weiss", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgxMDMxMTctNDY0Zi00ZmNlLWFlYmQtODA2YjY4MDk4MjU1XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "22-May-15", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Drunk Wedding", 0, 0, "movie", 0, 0, 0, "Anthony Weiss, Nick Weiss", 0, "data/Movie_Poster_Dataset/2015/tt1950135.jpg", "tt1950135", "4.3", "374" },
                    { 944, 0, 0, "Samaire Armstrong, Anna Biani, Matt Cohen, Kyan DuBois", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Natalie Bible'", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "N/A", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY2Njk3MTAzM15BMl5BanBnXkFtZTgwMTY5Mzk4NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "28-Aug-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "Windsor Drive", 0, 0, "movie", 0, 0, 0, "T.R. Gough, Tommy O'Reilly", 0, "data/Movie_Poster_Dataset/2015/tt2311428.jpg", "tt2311428", "3.3", "161" },
                    { 945, 0, 0, "Janusz Gajos, Maja Ostaszewska, Justyna Suwala, Ewa Dalkowska", 0, 0, "6 wins & 4 nominations.", 0, "2,457", 1, "Poland", 0, "Malgorzata Szumowska", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "Polish, Spanish", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDhiOTM2OTctODk3Ny00NWI4LThhZDgtNGQ4NjRiYjFkZGQzXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "6-Mar-15", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Body", 0, 0, "movie", 0, 0, 0, "Michal Englert (screenplay), Malgorzata Szumowska (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4358230.jpg", "tt4358230", "6.6", "725" },
                    { 946, 0, 1, "Sherri Eakin, Jeremy Sande, Jeremy Ivy, Corlandos Scott", 0, 0, "N/A", 0, "1,668", 0, "USA", 0, "Terron R. Parsons", 0, 0, 0, 0, 0, "Action, Horror, Thriller", 0, 1, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDcwMTYzMjctN2M2Yy00ZDcxLWJhNTEtMGNhYzEwYzc2NDE4XkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Mar-16", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 1, "Hayride 2", 0, 0, "movie", 0, 0, 0, "Terron R. Parsons", 0, "data/Movie_Poster_Dataset/2015/tt2924352.jpg", "tt2924352", "2.9", "453" },
                    { 947, 0, 0, "Mischa Barton, Dave Bautista, Andy Dick, Eric Roberts", 0, 0, "N/A", 0, "null", 1, "USA, UK", 1, "Martin Owen", 0, 0, 0, 0, 1, "Comedy, Crime, Fantasy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjE3ODY5OWEtZmE0Mi00MjUxLTg5MmUtZmFkMzM1N2VjMmU5XkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "26-Jun-15", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "L.A. Slasher", 0, 0, "movie", 0, 0, 0, "Martin Owen, Abigail Wright, Elizabeth Morris, Tim Burke, Sean Decker (additional writing)", 0, "data/Movie_Poster_Dataset/2015/tt2735292.jpg", "tt2735292", "3.6", "376" },
                    { 948, 0, 0, "Freya Mavor, Benjamin Biolay, Elio Germano, Stacy Martin", 0, 0, "N/A", 0, "2,033", 0, "France, Belgium", 0, "Joann Sfar", 0, 0, 0, 0, 0, "Thriller", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTk0NDU4YmItOTk0ZS00ODc2LTkwNGItNWI5MDJkNTJiYWMxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "18-Dec-15", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Lady in the Car with Glasses and a Gun", 0, 0, "movie", 0, 0, 0, "Patrick Godeau (screenplay), Sébastien Japrisot (novel), Gilles Marchand (screenplay)", 0, "data/Movie_Poster_Dataset/2015/tt4159182.jpg", "tt4159182", "5.5", "831" },
                    { 949, 0, 0, "Angela Sarafyan, Jaime Zevallos, Sean Nateghi, Daniel C.", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Jaime Zevallos", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmQwNzczZDItNmI0OS00MjRmLTliYWItZWIyMjk1MTU4ZTQ4L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Jul-15", "TRUE", 1, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Me You and Five Bucks", 0, 0, "movie", 0, 0, 0, "Jaime Zevallos", 0, "data/Movie_Poster_Dataset/2015/tt2265431.jpg", "tt2265431", "5.4", "9" },
                    { 950, 0, 0, "N/A", 0, 0, "N/A", 0, "1,903", 0, "USA", 0, "David T. Friendly, Mick Partridge", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjEyZTdhNDMtMWFkMS00ZmRjLWEyNmEtZDU3MWFkNDEzMDYwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "7-Aug-15", "TRUE", 0, "73 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sneakerheadz", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2015/tt3240784.jpg", "tt3240784", "7.2", "45" },
                    { 952, 0, 0, "Dorothy Tristan, Trish Basinger, Ed Ernstes, Elizabeth Stenholt", 0, 0, "N/A", 0, "1,711", 0, "USA", 0, "John D. Hancock", 0, 1, 0, 0, 0, "Drama, Music", 0, 0, "English", 0, "N/A", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzExOTczNTgtN2Q1Yy00MmI1LWE0NjgtNmIwMzdmZGNlODU1XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Aug-15", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Looking Glass", 0, 0, "movie", 0, 0, 0, "Dorothy Tristan, Dorothy Tristan", 0, "data/Movie_Poster_Dataset/2015/tt2912776.jpg", "tt2912776", "7.2", "9" },
                    { 953, 0, 0, "Matt Levett, Maya Stange, Jack Matthews, Harry Cook", 0, 0, "8 wins & 3 nominations.", 0, "1,631", 0, "Australia", 0, "Dean Francis", 0, 1, 0, 0, 0, "Drama, Sport", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2E1YWRlNzAtYzAwYy00MDg5LTlmYTUtYjdlZDI0NzFkNjNlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjQ2MjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "4-Mar-15", "TRUE", 0, "93 min", 0, 0, 1, 0, 0, 0, 0, 0, "Drown", 0, 0, "movie", 1, 0, 0, "Stephen Davis, Dean Francis, Stephen Davis (play)", 0, "data/Movie_Poster_Dataset/2015/tt2241750.jpg", "tt2241750", "5.7", "547" },
                    { 957, 0, 0, "Richard Harris, Maggie Smith, Robbie Coltrane, Saunders Triplets", 1, 0, "Nominated for 3 Oscars. Another 16 wins & 60 nominations.", 0, "317,557,891", 0, "UK, USA", 0, "Chris Columbus", 0, 0, 0, 1, 1, "Adventure, Family, Fantasy", 0, 0, "English", 0, "64", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTUxMjEzMzI2MV5BMl5BanBnXkFtZTgwNTU3ODAxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "16-Nov-01", "TRUE", 0, "152 min", 0, 0, 0, 0, 0, 0, 0, 0, "Harry Potter and the Sorcerer's Stone", 0, 0, "movie", 0, 0, 0, "J.K. Rowling (novel), Steve Kloves (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0241527.jpg", "tt0241527", "7.5", "427,890" },
                    { 958, 0, 0, "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", 1, 0, "Won 4 Oscars. Another 108 wins & 121 nominations.", 0, "36,116,967", 0, "New Zealand, USA", 0, "Peter Jackson", 0, 1, 0, 0, 1, "Adventure, Drama, Fantasy", 0, 0, "English, Sindarin", 0, "92", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGUwMjM0MTEtOGY2NS00MjJmLWEyMDAtYmNkMWJjOWJlNGM0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Dec-01", "TRUE", 0, "178 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Lord of the Rings: The Fellowship of the Ring", 0, 0, "movie", 0, 0, 0, "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0120737.jpg", "tt0120737", "8.8", "1,201,277" },
                    { 959, 0, 0, "Mike Myers, Eddie Murphy, Cameron Diaz, John Lithgow", 1, 1, "Won 1 Oscar. Another 36 wins & 59 nominations.", 0, "267,652,016", 1, "USA", 0, "Andrew Adamson, Vicky Jenson", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "84", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTU5MzMwMzAzM15BMl5BanBnXkFtZTcwNjYyMjA0Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "18-May-01", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shrek", 0, 0, "movie", 0, 0, 0, "William Steig (book), Ted Elliott, Terry Rossio, Joe Stillman, Roger S.H. Schulman, Cody Cameron (additional dialogue), Chris Miller (additional dialogue), Conrad Vernon (additional dialogue)", 0, "data/Movie_Poster_Dataset/2001/tt0126029.jpg", "tt0126029", "7.9", "448,396" },
                    { 960, 0, 0, "John Goodman, Billy Crystal, Mary Gibbs, Steve Buscemi", 1, 1, "Won 1 Oscar. Another 13 wins & 38 nominations.", 0, "289,907,418", 1, "USA", 0, "Pete Docter, David Silverman, Lee Unkrich", 0, 0, 0, 0, 0, "Animation, Adventure, Comedy", 0, 0, "English", 0, "78", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzcyYWE5YmQtNDE1Yi00ZjlmLWFlZTAtMzRjODBiYjM3OTA3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "2-Nov-01", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monsters, Inc.", 0, 0, "movie", 0, 0, 0, "Pete Docter (original story by), Jill Culton (original story by), Jeff Pidgeon (original story by), Ralph Eggleston (original story by), Andrew Stanton (screenplay), Daniel Gerson (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0198781.jpg", "tt0198781", "8.1", "555,364" },
                    { 961, 0, 1, "Jackie Chan, Chris Tucker, John Lone, Ziyi Zhang", 0, 0, "10 wins & 22 nominations.", 0, "8,601,812", 1, "USA, Hong Kong", 1, "Brett Ratner", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, Mandarin, Cantonese", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODBmOWU2YWMtZGUzZi00YzRhLWJjNDAtYTUwNWVkNDcyZmU5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "3-Aug-01", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rush Hour 2", 0, 0, "movie", 0, 0, 0, "Ross LaManna (characters), Jeff Nathanson", 0, "data/Movie_Poster_Dataset/2001/tt0266915.jpg", "tt0266915", "6.6", "155,532" },
                    { 962, 0, 1, "Brendan Fraser, Rachel Weisz, John Hannah, Arnold Vosloo", 1, 0, "4 wins & 16 nominations.", 0, "202,007,640", 0, "USA", 0, "Stephen Sommers", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English, Arabic", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWU3MDFkYWQtMWQ5YS00YTcwLThmNDItODY4OWE2ZTdhZmIwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-May-01", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Mummy Returns", 0, 0, "movie", 0, 0, 0, "Stephen Sommers", 0, "data/Movie_Poster_Dataset/2001/tt0209163.jpg", "tt0209163", "6.3", "241,380" },
                    { 963, 0, 1, "Ben Affleck, Josh Hartnett, Kate Beckinsale, William Lee Scott", 0, 0, "Won 1 Oscar. Another 10 wins & 48 nominations.", 0, "198,539,855", 0, "USA", 0, "Michael Bay", 0, 1, 0, 0, 0, "Action, Drama, History", 1, 0, "English, Japanese, French", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjA3YjdhMWEtYjc2Ni00YzVlLWI0MTUtMGZmNTJjNmU0Yzk2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-May-01", "TRUE", 0, "183 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pearl Harbor", 0, 0, "movie", 0, 0, 0, "Randall Wallace", 0, "data/Movie_Poster_Dataset/2001/tt0213149.jpg", "tt0213149", "6", "246,291" },
                    { 964, 0, 0, "George Clooney, Cecelia Ann Birt, Paul L. Nolan, Carol Florence", 0, 0, "4 wins & 20 nominations.", 0, "183,405,771", 0, "USA", 1, "Steven Soderbergh", 0, 0, 0, 0, 0, "Crime, Thriller", 0, 0, "English, Italian, Cantonese", 0, "74", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzYyNjg3OTctNzA2ZS00NjkzLWE4MmYtZDAzZWQ0NzkyMTJhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Dec-01", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 1, "Ocean's Eleven", 0, 0, "movie", 0, 0, 0, "George Clayton Johnson, Jack Golden Russell, Harry Brown, Charles Lederer, Ted Griffin (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0240772.jpg", "tt0240772", "7.8", "388,933" },
                    { 965, 0, 1, "Sam Neill, William H. Macy, Téa Leoni, Alessandro Nivola", 1, 0, "5 wins & 11 nominations.", 0, "181,166,115", 0, "USA", 0, "Joe Johnston", 0, 0, 0, 0, 0, "Action, Adventure, Sci-Fi", 0, 0, "English, Spanish", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzk1OGU2NmMtNTdhZC00NjdlLWE5YTMtZTQ0MGExZTQzOGQyXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "18-Jul-01", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jurassic Park III", 0, 0, "movie", 0, 0, 0, "Michael Crichton (characters), Peter Buchman, Alexander Payne, Jim Taylor", 0, "data/Movie_Poster_Dataset/2001/tt0163025.jpg", "tt0163025", "5.9", "209,797" },
                    { 966, 0, 0, "Russell Crowe, Ed Harris, Jennifer Connelly, Christopher Plummer", 0, 0, "Won 4 Oscars. Another 32 wins & 63 nominations.", 1, "170,708,996", 0, "USA", 0, "Ron Howard", 0, 1, 0, 0, 0, "Biography, Drama", 0, 0, "English", 0, "72", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmVhMDQ1YWUtYjgxOS00NzYyLWI0ZGItNTg3ZjM0MmQ4NmIwXkEyXkFqcGdeQXVyMjQzMzQzODY@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "4-Jan-02", "TRUE", 0, "135 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Beautiful Mind", 0, 0, "movie", 0, 0, 0, "Akiva Goldsman, Sylvia Nasar (book)", 0, "data/Movie_Poster_Dataset/2001/tt0268978.jpg", "tt0268978", "8.2", "587,831" },
                    { 967, 0, 0, "Anthony Hopkins, Julianne Moore, Gary Oldman, Ray Liotta", 0, 0, "7 wins & 15 nominations.", 0, "165,091,464", 0, "USA, UK", 1, "Ridley Scott", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, Italian, Japanese", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYxMDk1NTA5NF5BMl5BanBnXkFtZTcwNDkzNzA2NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Feb-01", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 1, "Hannibal", 0, 0, "movie", 0, 0, 0, "Thomas Harris (novel), David Mamet (screenplay), Steven Zaillian (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0212985.jpg", "tt0212985", "6.8", "204,463" },
                    { 968, 0, 0, "Jason Biggs, Shannon Elizabeth, Alyson Hannigan, Chris Klein", 0, 0, "8 wins & 4 nominations.", 0, "102,247,810", 1, "USA", 0, "J.B. Rogers", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE1NDY0NDk3Ml5BMl5BanBnXkFtZTcwMTAzMTM3NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "10-Aug-01", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Pie 2", 0, 0, "movie", 0, 0, 0, "Adam Herz (characters), David H. Steinberg (story), Adam Herz (story), Adam Herz (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0252866.jpg", "tt0252866", "6.4", "195,120" },
                    { 969, 0, 1, "Paul Walker, Vin Diesel, Michelle Rodriguez, Jordana Brewster", 0, 0, "9 wins & 12 nominations.", 0, "799,647", 0, "USA, Germany", 1, "Rob Cohen", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGZmMWE1MDYtNzAyNC00MDMzLTgzZjQtNTQ5NjYzN2E4MzkzXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "22-Jun-01", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Fast and the Furious", 0, 0, "movie", 0, 0, 0, "Ken Li (magazine article \\\\", 0, "data/Movie_Poster_Dataset/2001/tt0232500.jpg", "tt0232500", "6.7", "263,045" },
                    { 970, 0, 1, "Angelina Jolie, Jon Voight, Iain Glen, Noah Taylor", 1, 0, "3 wins & 15 nominations.", 0, "2,355,719", 0, "USA, UK, Japan, Germany", 0, "Simon West", 0, 0, 0, 0, 1, "Action, Adventure, Fantasy", 0, 0, "English", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTU4ZTI0NzAtYzMwNi00YmMxLThmZWItNTY5NzgyMDAwYWVhXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "15-Jun-01", "TRUE", 0, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lara Croft: Tomb Raider", 0, 0, "movie", 0, 0, 0, "Sara B. Cooper (story), Mike Werb (story), Michael Colleary (story), Simon West (adaptation), Patrick Massett (screenplay), John Zinman (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0146316.jpg", "tt0146316", "5.7", "152,910" },
                    { 971, 0, 0, "Eddie Murphy, Kristen Wilson, Raven-Symoné, Kyla Pratt", 0, 0, "2 wins & 6 nominations.", 0, "112,950,721", 1, "USA", 0, "Steve Carr", 0, 0, 0, 1, 1, "Comedy, Family, Fantasy", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNGZiMTkyNzQtMDdmZi00ZDNkLWE4YTAtZGNlNTIzYzQyMGM2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "22-Jun-01", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Dr. Dolittle 2", 0, 0, "movie", 0, 0, 0, "Hugh Lofting (Doctor Dolittle stories), Larry Levin", 0, "data/Movie_Poster_Dataset/2001/tt0240462.jpg", "tt0240462", "4.6", "33,042" },
                    { 972, 0, 1, "Antonio Banderas, Carla Gugino, Alexa PenaVega, Daryl Sabara", 1, 0, "2 wins & 10 nominations.", 0, "112,692,062", 1, "USA", 0, "Robert Rodriguez", 0, 0, 0, 0, 0, "Action, Adventure, Comedy", 0, 0, "English, Spanish", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZjBhYzU3NWItOWZjMy00NjI5LWFmYmItZmIyOWFlMDIxMWNiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "30-Mar-01", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Spy Kids", 0, 0, "movie", 0, 0, 0, "Robert Rodriguez", 0, "data/Movie_Poster_Dataset/2001/tt0227538.jpg", "tt0227538", "5.4", "81,544" },
                    { 973, 0, 0, "Josh Hartnett, Ewan McGregor, Tom Sizemore, Eric Bana", 0, 0, "Won 2 Oscars. Another 7 wins & 37 nominations.", 0, "976,530", 0, "USA, UK", 0, "Ridley Scott", 0, 1, 0, 0, 0, "Drama, History, War", 1, 0, "English, Somali", 0, "74", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTZhY2E3NmItMGIwNi00OTA2LThkYmEtODFiZTM0NGI0ZWU5XkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jan-02", "TRUE", 0, "144 min", 0, 0, 0, 0, 0, 0, 0, 0, "Black Hawk Down", 0, 0, "movie", 0, 1, 0, "Mark Bowden (book), Ken Nolan (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0265086.jpg", "tt0265086", "7.7", "284,766" },
                    { 974, 0, 0, "Julie Andrews, Anne Hathaway, Hector Elizondo, Heather Matarazzo", 0, 0, "2 wins & 11 nominations.", 0, "null", 1, "USA", 0, "Garry Marshall", 0, 0, 0, 1, 0, "Comedy, Family, Romance", 0, 0, "English, Dutch, Italian", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzdhMTM2YTItOWU2YS00MTM0LTgyNDYtMDM1OWM3NzkzNTM2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "3-Aug-01", "TRUE", 1, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Princess Diaries", 0, 0, "movie", 0, 0, 0, "Meg Cabot (novel), Gina Wendkos (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0247638.jpg", "tt0247638", "6.2", "89,263" },
                    { 975, 0, 0, "Tom Cruise, Penélope Cruz, Cameron Diaz, Kurt Russell", 0, 0, "Nominated for 1 Oscar. Another 4 wins & 31 nominations.", 0, "100,614,858", 0, "USA, Spain", 0, "Cameron Crowe", 0, 0, 0, 0, 1, "Fantasy, Mystery, Romance", 0, 0, "English, Spanish", 0, "45", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGE3ZWZiNzktMDIyOC00ZmVhLThjZTktZjQ5NjI4NGVhMDBlXkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Dec-01", "TRUE", 1, "136 min", 0, 0, 0, 0, 0, 0, 0, 0, "Vanilla Sky", 0, 0, "movie", 0, 0, 0, "Alejandro Amenábar (film \\\\", 0, "data/Movie_Poster_Dataset/2001/tt0259711.jpg", "tt0259711", "6.9", "202,750" },
                    { 976, 0, 0, "Nicole Kidman, Fionnula Flanagan, Christopher Eccleston, Alakina Mann", 0, 0, "Nominated for 1 Golden Globe. Another 28 wins & 50 nominations.", 0, "61,291,152", 0, "USA, Spain, France, Italy", 0, "Alejandro Amenábar", 0, 0, 0, 0, 1, "Fantasy, Horror, Thriller", 0, 1, "English, French", 0, "74", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDVhNzQxZDEtMzcyZC00ZDg1LWFkZDctOWYxZTY0ZmYzYjc2XkEyXkFqcGdeQXVyMjA0MDQ0Mjc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Aug-01", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Others", 0, 0, "movie", 0, 0, 0, "Alejandro Amenábar", 0, "data/Movie_Poster_Dataset/2001/tt0230600.jpg", "tt0230600", "7.6", "261,169" },
                    { 977, 0, 0, "Reese Witherspoon, Luke Wilson, Selma Blair, Matthew Davis", 0, 0, "Nominated for 2 Golden Globes. Another 6 wins & 10 nominations.", 0, "953,084", 1, "USA", 0, "Robert Luketic", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "59", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2Y1ZTI0NzktYzU3MS00YmE1LThkY2EtMDc0NGYxNTNlZDA5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "13-Jul-01", "TRUE", 1, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Legally Blonde", 0, 0, "movie", 0, 0, 0, "Amanda Brown (novel), Karen McCullah (screenplay), Kirsten Smith (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0250494.jpg", "tt0250494", "6.2", "125,894" },
                    { 978, 0, 0, "Julia Roberts, Billy Crystal, Catherine Zeta-Jones, John Cusack", 0, 0, "1 win.", 0, "1,803,711", 1, "USA", 0, "Joe Roth", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjNkNGJjYWEtM2IyNi00ZjM5LWFlYjYtYjQ4NTU5MGFlMTI2XkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "20-Jul-01", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "America's Sweethearts", 0, 0, "movie", 0, 0, 0, "Billy Crystal, Peter Tolan", 0, "data/Movie_Poster_Dataset/2001/tt0265029.jpg", "tt0265029", "5.7", "46,910" },
                    { 979, 0, 1, "Jeff Goldblum, Elizabeth Perkins, Alexander Pollock, Miriam Margolyes", 0, 0, "2 wins & 3 nominations.", 0, "null", 1, "USA, Australia", 0, "Lawrence Guterman", 0, 0, 0, 1, 0, "Action, Comedy, Family", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTRjOTA1NzctNzFmMy00ZjcwLWExYjgtYWQyZDM5ZWY1Y2JlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "4-Jul-01", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Cats & Dogs", 0, 0, "movie", 0, 0, 0, "John Requa, Glenn Ficarra", 0, "data/Movie_Poster_Dataset/2001/tt0239395.jpg", "tt0239395", "5.2", "44,716" },
                    { 980, 0, 0, "Julia Stiles, Sean Patrick Thomas, Kerry Washington, Fredro Starr", 0, 0, "6 wins & 7 nominations.", 0, "2,153,586", 0, "USA", 0, "Thomas Carter", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English", 0, "53", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTU5ZThjNzAtNjc4NC00OTViLWIxYTYtODFmMTk5Y2NjZjZiL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jan-01", "TRUE", 1, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Save the Last Dance", 0, 0, "movie", 0, 0, 0, "Duane Adler (story), Duane Adler (screenplay), Cheryl Edwards (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0206275.jpg", "tt0206275", "6.1", "46,694" },
                    { 981, 0, 1, "Michael J. Fox, Corey Burton, James Garner, Claudia Christian", 1, 1, "1 win & 16 nominations.", 0, "37,312", 0, "USA", 0, "Gary Trousdale, Kirk Wise", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "English, French, Spanish", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BYzdlYmQ3MWMtMDY3My00MzVmLTg0YmMtYjRlZDUzNjBlMmE0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "15-Jun-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Atlantis: The Lost Empire", 0, 0, "movie", 0, 0, 0, "Tab Murphy (screenplay), Kirk Wise (story), Gary Trousdale (story), Joss Whedon (story), Bryce Zabel (story), Jackie Zabel (story), Tab Murphy (story), David Reynolds (additional screenplay material)", 0, "data/Movie_Poster_Dataset/2001/tt0230011.jpg", "tt0230011", "6.8", "69,204" },
                    { 982, 0, 1, "Megan Cavanaugh, Mark DeCarlo, Debi Derryberry, Jeffrey Garcia", 1, 1, "Nominated for 1 Oscar. Another 5 nominations.", 0, "null", 0, "USA", 0, "John A. Davis", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTQ2MzE0OTU3NV5BMl5BanBnXkFtZTcwNjQxNTgzNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "21-Dec-01", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jimmy Neutron: Boy Genius", 0, 0, "movie", 0, 0, 0, "John A. Davis (story), Steve Oedekerk (story), John A. Davis (screenplay), David N. Weiss (screenplay), J. David Stem (screenplay), Steve Oedekerk (screenplay), Dan Schneider (contributing writer)", 0, "data/Movie_Poster_Dataset/2001/tt0268397.jpg", "tt0268397", "6", "23,213" },
                    { 983, 0, 0, "Haley Joel Osment, Frances O'Connor, Sam Robards, Jake Thomas", 1, 0, "Nominated for 2 Oscars. Another 16 wins & 64 nominations.", 0, "39,192,703", 0, "USA", 0, "Steven Spielberg", 0, 1, 0, 0, 0, "Adventure, Drama, Sci-Fi", 0, 0, "English", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAxNDA1ODc5MDleQTJeQWpwZ15BbWU4MDg2MDA4OTEx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-Jun-01", "TRUE", 0, "146 min", 0, 0, 0, 0, 0, 0, 0, 0, "A.I. Artificial Intelligence", 0, 0, "movie", 0, 0, 0, "Brian Aldiss (short story \\\\", 0, "data/Movie_Poster_Dataset/2001/tt0212720.jpg", "tt0212720", "7.1", "232,857" },
                    { 984, 0, 1, "Denzel Washington, Ethan Hawke, Scott Glenn, Tom Berenger", 0, 0, "Won 1 Oscar. Another 14 wins & 22 nominations.", 0, "null", 0, "USA, Australia", 1, "Antoine Fuqua", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Russian, Spanish, Korean", 0, "70", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWNlMTJmMWUtYjk0MC00M2U4LWI1ODItZDgxNDZiODFmNjc5XkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Oct-01", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "Training Day", 0, 0, "movie", 0, 0, 0, "David Ayer", 0, "data/Movie_Poster_Dataset/2001/tt0139654.jpg", "tt0139654", "7.7", "296,734" },
                    { 985, 0, 0, "Morgan Freeman, Monica Potter, Michael Wincott, Dylan Baker", 0, 0, "1 win & 1 nomination.", 0, "1,155,221", 0, "USA, Germany, Canada", 0, "Lee Tamahori", 0, 0, 0, 0, 0, "Thriller", 0, 0, "English, Russian", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjM3ZTAzZDYtZmFjZS00YmQ1LWJlOWEtN2I4MDRmYzY5YmRlL2ltYWdlXkEyXkFqcGdeQXVyMjgyNjk3MzE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Apr-01", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 1, "Along Came a Spider", 0, 0, "movie", 0, 0, 0, "James Patterson (novel), Marc Moss (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0164334.jpg", "tt0164334", "6.3", "57,613" },
                    { 986, 0, 0, "Renée Zellweger, Gemma Jones, Celia Imrie, James Faulkner", 0, 0, "Nominated for 1 Oscar. Another 8 wins & 29 nominations.", 0, "149,761,366", 1, "UK, France, USA, Ireland", 0, "Sharon Maguire", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzYyNzU0MTM1OF5BMl5BanBnXkFtZTcwMzE1ODE1NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Apr-01", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bridget Jones's Diary", 0, 0, "movie", 0, 0, 0, "Helen Fielding (novel), Helen Fielding (screenplay), Andrew Davies (screenplay), Richard Curtis (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0243155.jpg", "tt0243155", "6.7", "165,728" },
                    { 987, 0, 0, "Antony Acker, Mark Barrett, Richard Bellos, Suzanne Bianqui", 0, 0, "2 wins & 3 nominations.", 0, "43,957,551", 1, "USA, Canada", 0, "Keenen Ivory Wayans", 0, 0, 0, 0, 1, "Comedy, Fantasy", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzBiMWRhNzQtMjZhZS00NzFmLWE5YWMtOWY4NzIxMjYzZTEyXkEyXkFqcGdeQXVyMzg2MzE2OTE@._V1_UY98_CR3,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Jul-01", "TRUE", 0, "83 min", 0, 0, 0, 0, 0, 0, 0, 0, "Scary Movie 2", 0, 0, "movie", 0, 0, 0, "Shawn Wayans (characters), Marlon Wayans (characters), Buddy Johnson (characters), Phil Beauman (characters), Jason Friedberg (characters), Aaron Seltzer (characters), Shawn Wayans, Marlon Wayans, Alyson Fouse, Greg Grabianski, Dave Polsky, Michael Anthony Snowden, Craig Wayans", 0, "data/Movie_Poster_Dataset/2001/tt0257106.jpg", "tt0257106", "5.2", "115,985" },
                    { 988, 0, 0, "Robert De Niro, Edward Norton, Marlon Brando, Angela Bassett", 0, 0, "1 win & 1 nomination.", 0, "1,649,345", 0, "USA, Germany", 1, "Frank Oz", 0, 1, 0, 0, 0, "Crime, Drama, Thriller", 0, 0, "English, French", 0, "71", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTExYjM3MDYtMzg4MC00MjU4LTljZjAtYzdlMTFmYTJmYTE4XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "13-Jul-01", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Score", 0, 0, "movie", 0, 0, 0, "Daniel E. Taylor (story), Kario Salem (story), Kario Salem (screenplay), Lem Dobbs (screenplay), Scott Marshall Smith (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0227445.jpg", "tt0227445", "6.8", "99,972" },
                    { 989, 0, 0, "Gwyneth Paltrow, Jack Black, Jason Alexander, Joe Viterelli", 0, 0, "3 nominations.", 0, "70,836,296", 1, "USA, Germany", 0, "Bobby Farrelly, Peter Farrelly", 0, 1, 0, 0, 1, "Comedy, Drama, Fantasy", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg2ODcxOTU1OV5BMl5BanBnXkFtZTgwNzA3ODI1MDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Nov-01", "TRUE", 0, "114 min", 0, 0, 0, 0, 0, 0, 0, 0, "Shallow Hal", 0, 0, "movie", 0, 0, 0, "Sean Moynihan, Peter Farrelly, Bobby Farrelly", 0, "data/Movie_Poster_Dataset/2001/tt0256380.jpg", "tt0256380", "5.9", "107,315" },
                    { 990, 0, 1, "John Travolta, Hugh Jackman, Halle Berry, Don Cheadle", 0, 0, "5 wins & 8 nominations.", 0, "30,393,888", 0, "USA, Australia", 1, "Dominic Sena", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, German", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTVlM2JmOGQtNWEwYy00NDQzLWIyZmEtOGZhMzgxZGRjZDA0XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Jun-01", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 1, "Swordfish", 0, 0, "movie", 0, 0, 0, "Skip Woods", 0, "data/Movie_Poster_Dataset/2001/tt0244244.jpg", "tt0244244", "6.5", "152,673" },
                    { 991, 0, 0, "Brad Pitt, Julia Roberts, James Gandolfini, J.K. Simmons", 1, 0, "3 wins & 1 nomination.", 0, "2,940,996", 1, "USA", 1, "Gore Verbinski", 0, 0, 0, 0, 0, "Adventure, Comedy, Crime", 0, 0, "English, Spanish", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmFlNTA1NWItODQxNC00YjFmLWE3ZWYtMzg3YTkwYmMxMjY2XkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Mar-01", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Mexican", 0, 0, "movie", 0, 0, 0, "J.H. Wyman", 0, "data/Movie_Poster_Dataset/2001/tt0236493.jpg", "tt0236493", "6.1", "85,634" },
                    { 992, 0, 0, "Chris Rock, Regina King, Chazz Palminteri, Eugene Levy", 0, 0, "3 nominations.", 0, "null", 1, "USA, Australia, Germany, Canada", 0, "Chris Weitz, Paul Weitz", 0, 0, 0, 0, 1, "Comedy, Fantasy", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMWM1ZDhlM2MtNDNmMi00MDk4LTg5MjgtODE4ODk1MjYxOTIwXkEyXkFqcGdeQXVyNjc0MzMzNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Feb-01", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Down to Earth", 0, 0, "movie", 0, 0, 0, "Elaine May, Warren Beatty, Chris Rock (screenplay), Lance Crouther (screenplay), Ali LeRoi (screenplay), Louis C.K. (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0231775.jpg", "tt0231775", "5.4", "18,751" },
                    { 993, 0, 1, "Robert Redford, Brad Pitt, Catherine McCormack, Stephen Dillane", 0, 0, "3 nominations.", 0, "982,874", 0, "Germany, USA, Japan, France", 1, "Tony Scott", 0, 0, 0, 0, 0, "Action, Crime, Thriller", 0, 0, "English, German, Arabic, French, Cantonese", 0, "63", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU5NTBmYTAtOTgyYi00NGM0LWE0ODctZjNiYWM5MmIxYzE4XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Nov-01", "TRUE", 0, "126 min", 0, 0, 0, 0, 0, 0, 0, 1, "Spy Game", 0, 0, "movie", 0, 0, 0, "Michael Frost Beckner (story), Michael Frost Beckner (screenplay), David Arata (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0266987.jpg", "tt0266987", "7", "118,440" },
                    { 994, 0, 0, "Jennifer Lopez, Matthew McConaughey, Bridgette Wilson-Sampras, Justin Chambers", 0, 0, "1 win & 4 nominations.", 0, "null", 1, "Germany, USA", 0, "Adam Shankman", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, Italian", 0, "33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzM3YjE2NGMtODY3Zi00NTY0LWE4Y2EtMTE5YzNmM2U1NTg2XkEyXkFqcGdeQXVyMTY5Nzc4MDY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Jan-01", "TRUE", 1, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Wedding Planner", 0, 0, "movie", 0, 0, 0, "Pamela Falk, Michael Ellis", 0, "data/Movie_Poster_Dataset/2001/tt0209475.jpg", "tt0209475", "5.2", "59,508" },
                    { 995, 0, 1, "Owen Wilson, Gene Hackman, Gabriel Macht, Charles Malik Whitfield", 0, 0, "1 win & 2 nominations.", 0, "59,068,786", 0, "USA", 0, "John Moore", 0, 1, 0, 0, 0, "Action, War, Drama", 0, 0, "English, Serbo-Croatian, Spanish, Czech", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWUxMzViZTUtNTYxNy00YjY4LWJmMjYtMzNlOThjNjhiZmZkXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Nov-01", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Behind Enemy Lines", 0, 0, "movie", 0, 1, 0, "Jim Thomas (story), John Thomas (story), David Veloz (screenplay), Zak Penn (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0159273.jpg", "tt0159273", "6.4", "84,872" },
                    { 996, 0, 0, "Will Smith, Jamie Foxx, Jon Voight, Mario Van Peebles", 0, 0, "Nominated for 2 Oscars. Another 10 wins & 25 nominations.", 1, "646,787", 0, "USA", 0, "Michael Mann", 0, 1, 0, 0, 0, "Biography, Drama, Sport", 0, 0, "English, French", 0, "65", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjAxMTI1Njk3OF5BMl5BanBnXkFtZTgwNjkzODk4NTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "25-Dec-01", "TRUE", 0, "157 min", 0, 0, 1, 0, 0, 0, 0, 0, "Ali", 0, 0, "movie", 0, 0, 0, "Gregory Allen Howard (story), Stephen J. Rivele (screenplay), Christopher Wilkinson (screenplay), Eric Roth (screenplay), Michael Mann (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0248667.jpg", "tt0248667", "6.8", "76,241" },
                    { 997, 0, 0, "Rob Schneider, Colleen Haskell, John C. McGinley, Edward Asner", 0, 0, "5 nominations.", 0, "null", 1, "USA", 0, "Luke Greenfield", 0, 0, 0, 0, 0, "Comedy, Sci-Fi", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjllMmE0Y2YtYWIwZi00OWY1LWJhNWItYzM2MmNiYmFiZmRmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jun-01", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Animal", 0, 0, "movie", 0, 0, 0, "Tom Brady (story), Tom Brady (screenplay), Rob Schneider (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0255798.jpg", "tt0255798", "4.8", "46,370" },
                    { 998, 0, 0, "Nicole Kidman, Ewan McGregor, John Leguizamo, Jim Broadbent", 0, 0, "Won 2 Oscars. Another 81 wins & 127 nominations.", 0, "57,386,369", 0, "USA, Australia", 0, "Baz Luhrmann", 0, 1, 0, 0, 0, "Drama, Musical, Romance", 0, 0, "English, French, Spanish", 0, "66", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODQ0M2Y5M2QtZGIwMC00MzJjLThlMzYtNmE3ZTMzZTYzOGEwXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jun-01", "TRUE", 1, "127 min", 0, 0, 0, 0, 0, 0, 0, 0, "Moulin Rouge!", 0, 0, "movie", 0, 0, 0, "Baz Luhrmann, Craig Pearce", 0, "data/Movie_Poster_Dataset/2001/tt0203009.jpg", "tt0203009", "7.6", "219,541" },
                    { 999, 0, 0, "Breckin Meyer, Jenica Bergere, Cuba Gooding Jr., Carrie Diamond", 1, 0, "1 nomination.", 0, "1,320,394", 1, "Canada, USA", 0, "Jerry Zucker", 0, 0, 0, 0, 0, "Adventure, Comedy", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIwOTA3NDI3MF5BMl5BanBnXkFtZTgwNzIzMzA5NTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Aug-01", "TRUE", 0, "112 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rat Race", 0, 0, "movie", 0, 0, 0, "Andy Breckman", 0, "data/Movie_Poster_Dataset/2001/tt0250687.jpg", "tt0250687", "6.4", "91,828" },
                    { 1000, 0, 1, "Heath Ledger, Rufus Sewell, Shannyn Sossamon, Paul Bettany", 1, 0, "4 wins & 10 nominations.", 0, "1,525,952", 0, "USA", 0, "Brian Helgeland", 0, 0, 0, 0, 0, "Action, Adventure, Romance", 0, 0, "English", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-May-01", "TRUE", 1, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "A Knight's Tale", 0, 0, "movie", 0, 0, 0, "Brian Helgeland", 0, "data/Movie_Poster_Dataset/2001/tt0183790.jpg", "tt0183790", "6.9", "133,473" },
                    { 1001, 0, 0, "Michael Douglas, Sean Bean, Brittany Murphy, Skye McCole Bartusiak", 0, 0, "1 nomination.", 0, "null", 0, "USA, Australia, Switzerland, Canada", 1, "Gary Fleder", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Italian, Chinese", 0, "38", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzk2NmU3NmEtMTVhNS00NzJhLWE1M2ItMThjZjI5NWM3YmFmXkEyXkFqcGdeQXVyMjA1MzUyODk@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "28-Sep-01", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "Don't Say a Word", 0, 0, "movie", 0, 0, 0, "Andrew Klavan (novel), Anthony Peckham (screenplay), Patrick Smith Kelly (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0260866.jpg", "tt0260866", "6.3", "39,504" },
                    { 1002, 0, 0, "Johnny Depp, Penélope Cruz, Franka Potente, Rachel Griffiths", 0, 0, "1 win & 6 nominations.", 1, "8,844,782", 0, "USA", 1, "Ted Demme", 0, 1, 0, 0, 0, "Biography, Crime, Drama", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjg4ZmY1MmItMjFjOS00ZTg2LWJjNDYtNDM2YmM2NzhiNmZhXkEyXkFqcGdeQXVyNTAzMTY4MDA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Apr-01", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "Blow", 0, 0, "movie", 0, 0, 0, "Bruce Porter (book), David McKenna (screenplay), Nick Cassavetes (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0221027.jpg", "tt0221027", "7.6", "193,159" },
                    { 1003, 0, 0, "Gene Hackman, Anjelica Huston, Ben Stiller, Gwyneth Paltrow", 0, 0, "Nominated for 1 Oscar. Another 10 wins & 45 nominations.", 0, "52,353,636", 1, "USA", 0, "Wes Anderson", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, Italian", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmM4YzA5NjUtZGEyOS00YzllLWJmM2UtZjhhNmJhM2E1NjUxXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-Jan-02", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Royal Tenenbaums", 0, 0, "movie", 0, 0, 0, "Wes Anderson, Owen Wilson", 0, "data/Movie_Poster_Dataset/2001/tt0265666.jpg", "tt0265666", "7.6", "203,191" },
                    { 1004, 0, 1, "Steven Seagal, DMX, Isaiah Washington, Anthony Anderson", 0, 0, "2 nominations.", 0, "null", 1, "USA, Australia", 1, "Andrzej Bartkowiak", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjQ2NDU3NDE0M15BMl5BanBnXkFtZTgwMjA3OTg0MDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Mar-01", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Exit Wounds", 0, 0, "movie", 0, 0, 0, "Ed Horowitz (screenplay), Richard D'Ovidio (screenplay), John Westermann (novel)", 0, "data/Movie_Poster_Dataset/2001/tt0242445.jpg", "tt0242445", "5.5", "27,030" },
                    { 1005, 0, 0, "Jude Law, Ed Harris, Rachel Weisz, Joseph Fiennes", 0, 0, "3 nominations.", 0, "51,396,781", 0, "USA, France, Germany, UK, Ireland", 0, "Jean-Jacques Annaud", 0, 1, 0, 0, 0, "Drama, History, War", 1, 0, "English, German, Russian", 0, "53", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOWVmZGQ0MGYtMDI1Yy00MDkxLWJiYjQtMmZjZmQ0NDFmMDRhXkEyXkFqcGdeQXVyNjg3MDMxNzU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Mar-01", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 0, "Enemy at the Gates", 0, 0, "movie", 0, 1, 0, "Jean-Jacques Annaud, Alain Godard", 0, "data/Movie_Poster_Dataset/2001/tt0215750.jpg", "tt0215750", "7.6", "182,725" },
                    { 1006, 0, 0, "Kevin Spacey, Jeff Bridges, Mary McCormack, Alfre Woodard", 0, 0, "3 nominations.", 0, "626,381", 0, "USA, Germany", 0, "Iain Softley", 0, 1, 0, 0, 0, "Drama, Sci-Fi", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTc5NzQzNjk2NF5BMl5BanBnXkFtZTgwODU0MjI5NjE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Oct-01", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "K-PAX", 0, 0, "movie", 0, 0, 0, "Gene Brewer (novel), Charles Leavitt (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0272152.jpg", "tt0272152", "7.4", "144,456" },
                    { 1007, 0, 0, "John Cusack, Kate Beckinsale, Jeremy Piven, Bridget Moynahan", 0, 0, "3 nominations.", 0, "633,868", 1, "USA", 0, "Peter Chelsom", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English, French", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkwODUzODA0OV5BMl5BanBnXkFtZTgwMTA3ODkxNzE@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "5-Oct-01", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Serendipity", 0, 0, "movie", 0, 0, 0, "Marc Klein", 0, "data/Movie_Poster_Dataset/2001/tt0240890.jpg", "tt0240890", "6.9", "83,256" },
                    { 1008, 0, 0, "John Travolta, James Lashly, Rebecca Tilney, Debra Mooney", 0, 0, "1 win & 3 nominations.", 0, "203,338", 0, "USA", 1, "Harold Becker", 0, 0, 0, 0, 0, "Crime, Mystery, Thriller", 0, 0, "English", 0, "29", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjM0NTc0NzItM2FlYS00YzEwLWE0YmUtNTA2ZWIzODc2OTgxXkEyXkFqcGdeQXVyNTgwNzIyNzg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Nov-01", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 1, "Domestic Disturbance", 0, 0, "movie", 0, 0, 0, "Lewis Colick (story), William S. Comanor (story), Gary Drucker (story), Lewis Colick (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0249478.jpg", "tt0249478", "5.5", "21,005" },
                    { 1009, 0, 0, "Ben Stiller, Owen Wilson, Christine Taylor, Will Ferrell", 0, 0, "1 win & 9 nominations.", 0, "381,063", 1, "Germany, USA", 0, "Ben Stiller", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjM3MjQ1MzkxNl5BMl5BanBnXkFtZTgwODk1ODgyMjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Sep-01", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Zoolander", 0, 0, "movie", 0, 0, 0, "Drake Sather (character Derek Zoolander), Ben Stiller (character Derek Zoolander), Drake Sather (story), Ben Stiller (story), Drake Sather (screenplay), Ben Stiller (screenplay), John Hamburg (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0196229.jpg", "tt0196229", "6.6", "193,289" },
                    { 1010, 0, 1, "Jet Li, Carla Gugino, Delroy Lindo, Jason Statham", 0, 0, "4 nominations.", 0, "null", 0, "USA", 0, "James Wong", 0, 0, 0, 0, 0, "Action, Sci-Fi, Thriller", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWFlOWI3YTMtYTk3NS00YWQ2LTlmYTMtZjk0ZDk4Y2NjODI0XkEyXkFqcGdeQXVyNTQxNTQ4Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Nov-01", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 1, "The One", 0, 0, "movie", 0, 0, 0, "Glen Morgan, James Wong", 0, "data/Movie_Poster_Dataset/2001/tt0267804.jpg", "tt0267804", "5.9", "76,298" },
                    { 1011, 0, 0, "Bruce Willis, Billy Bob Thornton, Cate Blanchett, Troy Garity", 0, 0, "Nominated for 2 Golden Globes. Another 4 wins & 5 nominations.", 0, "41,523,271", 1, "USA", 1, "Barry Levinson", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "60", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjIxOTI0MjU5NV5BMl5BanBnXkFtZTgwNzM4OTk4NTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Oct-01", "TRUE", 0, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bandits", 0, 0, "movie", 0, 0, 0, "Harley Peyton", 0, "data/Movie_Poster_Dataset/2001/tt0219965.jpg", "tt0219965", "6.6", "56,086" },
                    { 1012, 0, 0, "Maggie Smith, Michael Gambon, Kristin Scott Thomas, Camilla Rutherford", 0, 0, "Won 1 Oscar. Another 31 wins & 73 nominations.", 0, "178,641", 0, "UK, USA, Italy", 0, "Robert Altman", 0, 1, 0, 0, 0, "Drama, Mystery", 0, 0, "English", 0, "90", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTEzNzY0OTg0NTdeQTJeQWpwZ15BbWU4MDU3OTg3MjUz._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jan-02", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gosford Park", 0, 0, "movie", 0, 0, 0, "Julian Fellowes, Robert Altman (based upon an idea by), Bob Balaban (based upon an idea by)", 0, "data/Movie_Poster_Dataset/2001/tt0280707.jpg", "tt0280707", "7.3", "64,074" },
                    { 1013, 0, 0, "Sigourney Weaver, Jennifer Love Hewitt, Ray Liotta, Jason Lee", 0, 0, "4 nominations.", 0, "706,240", 1, "USA", 1, "David Mirkin", 0, 0, 0, 0, 0, "Comedy, Crime, Romance", 0, 0, "English, Russian", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-Mar-01", "TRUE", 1, "123 min", 0, 0, 0, 0, 0, 0, 0, 0, "Heartbreakers", 0, 0, "movie", 0, 0, 0, "Robert Dunn, Paul Guay, Stephen Mazur", 0, "data/Movie_Poster_Dataset/2001/tt0125022.jpg", "tt0125022", "6.2", "43,556" },
                    { 1014, 0, 0, "Sean Penn, Michelle Pfeiffer, Dakota Fanning, Dianne Wiest", 0, 0, "Nominated for 1 Oscar. Another 8 wins & 10 nominations.", 0, "null", 0, "USA", 0, "Jessie Nelson", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "28", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA5NjM3NTk1M15BMl5BanBnXkFtZTgwMzg1MzU2NjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "25-Jan-02", "TRUE", 0, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "I Am Sam", 0, 0, "movie", 0, 0, 0, "Kristine Johnson, Jessie Nelson", 0, "data/Movie_Poster_Dataset/2001/tt0277027.jpg", "tt0277027", "7.6", "119,214" },
                    { 1016, 0, 0, "David Duchovny, Julianne Moore, Orlando Jones, Seann William Scott", 0, 0, "1 nomination.", 0, "38,311,134", 1, "USA", 0, "Ivan Reitman", 0, 0, 0, 0, 0, "Comedy, Sci-Fi", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmZkYjQzY2QtNjdkNC00YjkzLTk5NjUtY2MyNDNiYTBhN2M2XkEyXkFqcGdeQXVyMjMwNDgzNjc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "8-Jun-01", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Evolution", 0, 0, "movie", 0, 0, 0, "Don Jakoby (story), David Diamond (screenplay), David Weissman (screenplay), Don Jakoby (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0251075.jpg", "tt0251075", "6", "100,561" },
                    { 1017, 0, 0, "Chyler Leigh, Chris Evans, Jaime Pressly, Eric Christian Olsen", 0, 0, "5 nominations.", 0, "null", 1, "USA", 0, "Joel Gallen", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTYxZjQ2YTktNmVkMC00ZTY4LThkZmItMDc4MTJiYjVhZjM0L2ltYWdlXkEyXkFqcGdeQXVyMjgyNjk3MzE@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Dec-01", "TRUE", 0, "89 min", 0, 0, 0, 0, 0, 0, 0, 0, "Not Another Teen Movie", 0, 0, "movie", 0, 0, 0, "Mike Bender, Adam Jay Epstein, Andrew Jacobson, Phil Beauman, Buddy Johnson", 0, "data/Movie_Poster_Dataset/2001/tt0277371.jpg", "tt0277371", "5.7", "78,416" },
                    { 1018, 0, 0, "Gina Philips, Justin Long, Jonathan Breck, Patricia Belcher", 0, 0, "3 wins & 6 nominations.", 0, "513,292", 0, "Germany, USA", 0, "Victor Salva", 0, 0, 0, 0, 0, "Horror", 0, 1, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg4NDA1OTA5NF5BMl5BanBnXkFtZTgwMDQ2MDM5ODE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Aug-01", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jeepers Creepers", 0, 0, "movie", 0, 0, 0, "Victor Salva", 0, "data/Movie_Poster_Dataset/2001/tt0263488.jpg", "tt0263488", "6.1", "83,602" },
                    { 1019, 0, 1, "Jet Li, Bridget Fonda, Tchéky Karyo, Max Ryan", 0, 0, "N/A", 0, "null", 0, "France", 1, "Chris Nahon", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, French, Mandarin", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA5ODgyNzcxMV5BMl5BanBnXkFtZTgwMzkzOTYzMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "6-Jul-01", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kiss of the Dragon", 0, 0, "movie", 0, 0, 0, "Jet Li (story), Luc Besson (screenplay), Robert Mark Kamen (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0271027.jpg", "tt0271027", "6.6", "52,234" },
                    { 1020, 0, 0, "Rickey D'Shon Collins, Jason Davis, Ashley Johnson, Andrew Lawrence", 0, 1, "N/A", 0, "null", 1, "USA", 0, "Chuck Sheetz", 0, 0, 0, 1, 0, "Animation, Family, Comedy", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgwODk3NDc1N15BMl5BanBnXkFtZTgwNTc1NjQwMjE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "G", 0, 0, "16-Feb-01", "TRUE", 0, "82 min", 0, 0, 0, 0, 0, 0, 0, 0, "Recess: School's Out", 0, 0, "movie", 0, 0, 0, "Paul Germain (television series Recess), Joe Ansolabehere (television series Recess), Paul Germain (story), Joe Ansolabehere (story), Jonathan Greenberg (story), Jonathan Greenberg (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0265632.jpg", "tt0265632", "6.5", "6,464" },
                    { 1021, 0, 0, "Tom Wilkinson, Sissy Spacek, Nick Stahl, Marisa Tomei", 0, 0, "Nominated for 5 Oscars. Another 38 wins & 69 nominations.", 0, "35,918,429", 0, "USA", 1, "Todd Field", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English, Serbo-Croatian", 0, "86", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGMxZjFkN2EtMDRiMS00ZTBjLWI0M2MtZWUyYjFhZGViZDJlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Feb-02", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "In the Bedroom", 0, 0, "movie", 0, 0, 0, "Robert Festinger (screenplay), Todd Field (screenplay), Andre Dubus (story)", 0, "data/Movie_Poster_Dataset/2001/tt0247425.jpg", "tt0247425", "7.5", "31,919" },
                    { 1022, 0, 0, "Martin Lawrence, Marsha Thomason, Tom Wilkinson, Vincent Regan", 1, 0, "2 nominations.", 0, "14,895", 1, "USA", 0, "Gil Junger", 0, 0, 0, 0, 1, "Adventure, Comedy, Fantasy", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZGIxODNjM2YtZjA5Mi00MjA5LTk2YjItODE0OWI5NThjNTBmXkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Nov-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Black Knight", 0, 0, "movie", 0, 0, 0, "Darryl Quarles, Peter Gaulke, Gerry Swallow", 0, "data/Movie_Poster_Dataset/2001/tt0265087.jpg", "tt0265087", "4.8", "29,839" },
                    { 1023, 0, 1, "David Arquette, Michael Clarke Duncan, Leslie Bibb, Joe Viterelli", 0, 0, "1 nomination.", 0, "null", 1, "USA, Australia", 1, "John Whitesell", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, American Sign Language", 0, "24", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMjMxNjU0ODU5Ml5BMl5BanBnXkFtZTcwNjI4MzAyOA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "2-Mar-01", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "See Spot Run", 0, 0, "movie", 0, 0, 0, "George Gallo (screenplay), Gregory Poirier (screenplay), Dan Baron (screenplay), Chris Faber (screenplay), Andrew Deane (story), Michael Alexander Miller (story), George Gallo (story), Stuart Gibbs (adaptation), Craig Titley (adaptation)", 0, "data/Movie_Poster_Dataset/2001/tt0250720.jpg", "tt0250720", "5.4", "7,253" },
                    { 1024, 0, 0, "Audrey Tautou, Mathieu Kassovitz, Rufus, Lorella Cravotta", 0, 0, "Nominated for 5 Oscars. Another 56 wins & 60 nominations.", 0, "33,201,661", 1, "France, Germany", 0, "Jean-Pierre Jeunet", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "French, Russian", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZDY3ZGI0ZDAtMThlNy00MzAxLTg4YjAtNjkwYTkxNmQ4MjdlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Feb-02", "TRUE", 1, "122 min", 0, 0, 0, 0, 0, 0, 0, 0, "Amélie", 0, 0, "movie", 0, 0, 0, "Guillaume Laurant (scenario), Jean-Pierre Jeunet (scenario), Guillaume Laurant (dialogue)", 0, "data/Movie_Poster_Dataset/2001/tt0211915.jpg", "tt0211915", "8.4", "515,697" },
                    { 1025, 0, 1, "Sylvester Stallone, Burt Reynolds, Kip Pardue, Stacy Edwards", 0, 0, "1 win & 7 nominations.", 0, "640,223", 0, "USA, Canada, Australia", 0, "Renny Harlin", 0, 1, 0, 0, 0, "Action, Drama, Sport", 0, 0, "English, German, Spanish", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmE5ZmE3OGItNTdlNC00YmMxLWEzNjctYzAwOGQ5ODg0OTI0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "27-Apr-01", "TRUE", 0, "116 min", 0, 0, 1, 0, 0, 0, 0, 0, "Driven", 0, 0, "movie", 0, 0, 0, "Jan Skrentny (story), Neal Tabachnick (story), Sylvester Stallone (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0132245.jpg", "tt0132245", "4.5", "33,919" },
                    { 1026, 0, 0, "Martin Lawrence, Danny DeVito, John Leguizamo, Glenne Headly", 0, 0, "N/A", 0, "null", 1, "USA", 1, "Sam Weisman", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English, American Sign Language", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODhkZDIzNjgtOTA5ZS00MmMzLWFkNjYtM2Y2MzFjN2FkNjAzL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Jun-01", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "What's the Worst That Could Happen?", 0, 0, "movie", 0, 0, 0, "Donald E. Westlake (novel), Matthew Chapman (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0161083.jpg", "tt0161083", "5.5", "12,103" },
                    { 1027, 0, 1, "Ming-Na Wen, Alec Baldwin, Ving Rhames, Steve Buscemi", 1, 1, "1 win & 9 nominations.", 0, "1,448,087", 0, "USA, Japan", 0, "Hironobu Sakaguchi, Motonori Sakakibara", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDY2OTE5MzE0Nl5BMl5BanBnXkFtZTcwNDAyOTc2NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Jul-01", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "Final Fantasy: The Spirits Within", 0, 0, "movie", 0, 0, 0, "Hironobu Sakaguchi (story), Al Reinert, Jeff Vintar, Jack Fletcher (additional dialogue), Ramin Mebdy (Farsi adaptation), B.L. Jurgens (story)", 0, "data/Movie_Poster_Dataset/2001/tt0173840.jpg", "tt0173840", "6.4", "70,971" },
                    { 1028, 0, 0, "Johnny Depp, Heather Graham, Ian Holm, Robbie Coltrane", 0, 0, "9 nominations.", 0, "1,812,396", 0, "USA", 0, "Albert Hughes, Allen Hughes", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "54", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY3NjY0MTQ0Nl5BMl5BanBnXkFtZTcwMzQ2MTc0Mw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Oct-01", "TRUE", 0, "122 min", 0, 0, 0, 0, 0, 0, 0, 1, "From Hell", 0, 0, "movie", 0, 0, 0, "Alan Moore (graphic novel), Eddie Campbell (graphic novel), Terry Hayes (screenplay), Rafael Yglesias (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0120681.jpg", "tt0120681", "6.8", "121,913" },
                    { 1029, 0, 0, "Billy Bob Thornton, Halle Berry, Taylor Simpson, Gabrielle Witcher", 0, 0, "Won 1 Oscar. Another 14 wins & 22 nominations.", 0, "null", 0, "USA", 0, "Marc Forster", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "69", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjg3ODQyNTIyN15BMl5BanBnXkFtZTcwMjUzNzM5NQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Mar-02", "TRUE", 1, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monster's Ball", 0, 0, "movie", 0, 0, 0, "Milo Addica, Will Rokos", 0, "data/Movie_Poster_Dataset/2001/tt0285742.jpg", "tt0285742", "7.1", "70,538" },
                    { 1030, 0, 0, "Method Man, Redman, Obba Babatundé, Mike Epps", 0, 0, "N/A", 0, "31,155,435", 1, "USA", 0, "Jesse Dylan", 0, 0, 0, 0, 1, "Comedy, Fantasy", 0, 0, "English", 0, "29", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTMzNzEzMDYxM15BMl5BanBnXkFtZTcwMTc0NTMxMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Dec-01", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "How High", 0, 0, "movie", 0, 0, 0, "Dustin Lee Abraham", 0, "data/Movie_Poster_Dataset/2001/tt0278488.jpg", "tt0278488", "6.2", "41,309" },
                    { 1031, 0, 0, "Drew Barrymore, Steve Zahn, Adam Garcia, Brittany Murphy", 0, 0, "2 wins & 2 nominations.", 1, "null", 1, "USA", 0, "Penny Marshall", 0, 1, 0, 0, 0, "Biography, Comedy, Drama", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjI2ODE4ODAtMDA3MS00ODNkLTg4N2EtOGU0YjZmNGY4NjZlXkEyXkFqcGdeQXVyMTY5MDE5NA@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "19-Oct-01", "TRUE", 0, "132 min", 0, 0, 0, 0, 0, 0, 0, 0, "Riding in Cars with Boys", 0, 0, "movie", 0, 0, 0, "Beverly D'Onofrio (book), Morgan Ward (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0200027.jpg", "tt0200027", "6.4", "22,009" },
                    { 1032, 0, 0, "Jason Mewes, Kevin Smith, Ben Affleck, Jeff Anderson", 0, 0, "1 win & 2 nominations.", 0, "89,005", 1, "USA", 0, "Kevin Smith", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "51", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjAxOTU3Mzc1M15BMl5BanBnXkFtZTcwMzk1ODUzNg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Aug-01", "TRUE", 0, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Jay and Silent Bob Strike Back", 0, 0, "movie", 0, 0, 0, "Kevin Smith (characters), Kevin Smith", 0, "data/Movie_Poster_Dataset/2001/tt0261392.jpg", "tt0261392", "6.9", "126,063" },
                    { 1033, 0, 1, "Orlando Jones, Eddie Griffin, Gary Grubbs, Daniel Roebuck", 0, 0, "N/A", 0, "20,218", 1, "USA", 1, "George Gallo", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English, Spanish", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmFmNjY5NDYtZjlhNi00YjQ5LTgzNzctNWRiNWUzNmIyNjc4XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jan-01", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Double Take", 0, 0, "movie", 0, 0, 0, "Graham Greene (story), Guy Elmes, Denis Freeman, George Gallo (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0238948.jpg", "tt0238948", "5.3", "5,327" },
                    { 1034, 0, 0, "Tyrese Gibson, Taraji P. Henson, Omar Gooding, Tamara LaSeon Bass", 0, 0, "1 win & 14 nominations.", 0, "null", 1, "USA", 1, "John Singleton", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English", 0, "55", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU5MDg0NTQ1N15BMl5BanBnXkFtZTcwMjA4Mjg3Mg@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Jun-01", "TRUE", 0, "130 min", 0, 0, 0, 0, 0, 0, 0, 0, "Baby Boy", 0, 0, "movie", 0, 0, 0, "John Singleton", 0, "data/Movie_Poster_Dataset/2001/tt0255819.jpg", "tt0255819", "6.4", "9,265" },
                    { 1035, 0, 0, "Jim Carrey, Bob Balaban, Jeffrey DeMunn, Hal Holbrook", 0, 0, "2 wins & 2 nominations.", 0, "27,796,042", 0, "USA, Australia", 0, "Frank Darabont", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzc0ZmUyZjAtZThkMi00ZDY5LTg5YjctYmUwM2FiYjMyMDI5XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Dec-01", "TRUE", 1, "152 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Majestic", 0, 0, "movie", 0, 0, 0, "Michael Sloane", 0, "data/Movie_Poster_Dataset/2001/tt0268995.jpg", "tt0268995", "6.9", "44,344" },
                    { 1036, 0, 0, "Morris Chestnut, D.L. Hughley, Bill Bellamy, Shemar Moore", 0, 0, "1 win & 8 nominations.", 0, "null", 1, "USA", 0, "Gary Hardwick", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English, French", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTg0NjEwNjUxM15BMl5BanBnXkFtZTcwMzk0MjQ5Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Mar-01", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Brothers", 0, 0, "movie", 0, 0, 0, "Gary Hardwick", 0, "data/Movie_Poster_Dataset/2001/tt0250274.jpg", "tt0250274", "6.3", "3,093" },
                    { 1037, 0, 0, "Ashley Judd, Greg Kinnear, Hugh Jackman, Marisa Tomei", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Tony Goldwyn", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "32", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEzOTE3ODM3OF5BMl5BanBnXkFtZTcwMzYyODI4Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "30-Mar-01", "TRUE", 1, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "Someone Like You...", 0, 0, "movie", 0, 0, 0, "Laura Zigman (novel), Elizabeth Chandler (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0244970.jpg", "tt0244970", "6.1", "19,199" },
                    { 1038, 0, 0, "David Spade, Brittany Daniel, Dennis Miller, Adam Beach", 1, 0, "1 nomination.", 0, "27,087,695", 1, "USA", 0, "Dennie Gordon", 0, 1, 0, 0, 0, "Adventure, Comedy, Drama", 0, 0, "English", 0, "20", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTIzNTg3NzkzNV5BMl5BanBnXkFtZTcwNzMwMjU2MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Apr-01", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Joe Dirt", 0, 0, "movie", 0, 0, 0, "David Spade, Fred Wolf", 0, "data/Movie_Poster_Dataset/2001/tt0245686.jpg", "tt0245686", "5.9", "40,702" },
                    { 1039, 0, 1, "Catherine Deneuve, Mena Suvari, Stephen Rea, Tim Roth", 1, 0, "N/A", 0, "null", 0, "Germany, Luxembourg, UK, USA", 0, "Peter Hyams", 0, 0, 0, 0, 0, "Action, Adventure, Romance", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTU0NzY0MTY5OF5BMl5BanBnXkFtZTcwODY3MDEwMg@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Sep-01", "TRUE", 1, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Musketeer", 0, 0, "movie", 0, 0, 0, "Alexandre Dumas père (novels), Gene Quintano (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0246544.jpg", "tt0246544", "4.7", "12,716" },
                    { 1040, 0, 0, "Paul Hogan, Linda Kozlowski, Jere Burns, Jonathan Banks", 1, 0, "2 nominations.", 0, "null", 1, "Australia, USA", 1, "Simon Wincer", 0, 0, 0, 0, 0, "Adventure, Comedy, Crime", 0, 0, "English", 0, "37", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTcwMzU0OTY3NF5BMl5BanBnXkFtZTYwNzkwNjg2._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "20-Apr-01", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Crocodile Dundee in Los Angeles", 0, 0, "movie", 0, 0, 0, "Paul Hogan (characters), Matt Berry, Eric Abrams", 0, "data/Movie_Poster_Dataset/2001/tt0231402.jpg", "tt0231402", "4.8", "19,281" },
                    { 1041, 0, 0, "Penélope Cruz, John Hurt, Christian Bale, Irene Papas", 0, 0, "3 nominations.", 0, "25,528,495", 0, "UK, France, USA", 0, "John Madden", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English, Greek, German, Italian", 0, "36", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "17-Aug-01", "TRUE", 1, "131 min", 0, 0, 0, 0, 0, 0, 0, 0, "Captain Corelli's Mandolin", 0, 0, "movie", 0, 0, 0, "Shawn Slovo (screenplay), Louis de Bernières (novel)", 0, "data/Movie_Poster_Dataset/2001/tt0238112.jpg", "tt0238112", "5.9", "27,700" },
                    { 1042, 0, 0, "Keanu Reeves, Charlize Theron, Jason Isaacs, Greg Germann", 0, 0, "3 nominations.", 0, "6,068,804", 0, "USA", 0, "Pat O'Connor", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjEzMjEzNTIzOF5BMl5BanBnXkFtZTcwMTg2MjAyMw@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "16-Feb-01", "TRUE", 1, "119 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sweet November", 0, 0, "movie", 0, 0, 0, "Herman Raucher, Paul Yurick (story), Kurt Voelker (story), Kurt Voelker (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0230838.jpg", "tt0230838", "6.7", "68,621" },
                    { 1043, 0, 1, "Robert De Niro, Edward Burns, Kelsey Grammer, Avery Brooks", 0, 0, "1 nomination.", 0, "null", 0, "USA, Germany", 1, "John Herzfeld", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English, Czech, Russian, Greek, Afrikaans", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjc4MjA2ZDgtOGY3YS00NDYzLTlmNTEtYWMxMzcwZjgzYWNjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Mar-01", "TRUE", 0, "120 min", 0, 0, 0, 0, 0, 0, 0, 0, "15 Minutes", 0, 0, "movie", 0, 0, 0, "John Herzfeld", 0, "data/Movie_Poster_Dataset/2001/tt0179626.jpg", "tt0179626", "6.1", "41,876" },
                    { 1044, 0, 0, "Anthony Hopkins, Anton Yelchin, Hope Davis, Mika Boorem", 0, 0, "2 wins & 8 nominations.", 0, "null", 0, "USA, Australia", 0, "Scott Hicks", 0, 1, 0, 0, 0, "Drama, Mystery", 0, 0, "English", 0, "55", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmM2NDNiNGItMTRhMi00ZDA2LTgzOWMtZTE2ZjFhMDQ2M2U5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "28-Sep-01", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hearts in Atlantis", 0, 0, "movie", 0, 0, 0, "Stephen King (book), William Goldman (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0252501.jpg", "tt0252501", "6.9", "29,660" },
                    { 1045, 0, 0, "Jennifer Lopez, Jim Caviezel, Jeremy Sisto, Terrence Howard", 0, 0, "1 win & 4 nominations.", 0, "661,749", 0, "USA", 0, "Luis Mandoki", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "39", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BOTBmZDZkNWYtODIzYi00N2Y4LWFjMmMtNmM1OGYyNGVhYzUzXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-May-01", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Angel Eyes", 0, 0, "movie", 0, 0, 0, "Gerald Di Pego", 0, "data/Movie_Poster_Dataset/2001/tt0225071.jpg", "tt0225071", "5.6", "19,382" },
                    { 1046, 0, 0, "Chris Kattan, Vinessa Shaw, Peter Falk, Peter Berg", 0, 0, "1 nomination.", 0, "23,978,402", 1, "USA", 1, "Rob Pritts", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English, Vietnamese, Spanish, Thai", 0, "20", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTI5MjA2Mzk2M15BMl5BanBnXkFtZTcwODY1MDUzMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Oct-01", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Corky Romano", 0, 0, "movie", 0, 0, 0, "David Garrett, Jason Ward", 0, "data/Movie_Poster_Dataset/2001/tt0250310.jpg", "tt0250310", "4.6", "10,838" },
                    { 1047, 0, 1, "Gene Hackman, Danny DeVito, Delroy Lindo, Sam Rockwell", 0, 0, "N/A", 0, "47,239", 0, "Canada, USA", 1, "David Mamet", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2VkMzZlZDAtNTkzNS00MDIzLWFmOTctMWQwZjQ1OWJiYzQ1XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Nov-01", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Heist", 0, 0, "movie", 0, 0, 0, "David Mamet", 0, "data/Movie_Poster_Dataset/2001/tt0252503.jpg", "tt0252503", "6.5", "27,671" },
                    { 1048, 0, 0, "LL Cool J, Jada Pinkett Smith, Vivica A. Fox, Loretta Devine", 0, 0, "6 nominations.", 0, "23,247,539", 1, "USA", 0, "Doug McHenry", 0, 1, 0, 1, 0, "Comedy, Drama, Family", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTI5Mzk1MDc2M15BMl5BanBnXkFtZTcwMjIzMDA0MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "11-Apr-01", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kingdom Come", 0, 0, "movie", 0, 0, 0, "David Dean Bottrell (play), Jessie Jones (play), David Dean Bottrell (screenplay), Jessie Jones (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0246002.jpg", "tt0246002", "5.6", "1,751" },
                    { 1049, 0, 0, "Tim Allen, Julie Bowen, Kelly Lynch, Greg Germann", 0, 0, "1 nomination.", 0, "22,770,864", 1, "USA", 0, "John Pasquin", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNzU3NDg4NTAyNV5BMl5BanBnXkFtZTcwOTg2ODg1Mg@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "21-Dec-01", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Joe Somebody", 0, 0, "movie", 0, 0, 0, "John Scott Shepherd", 0, "data/Movie_Poster_Dataset/2001/tt0279889.jpg", "tt0279889", "5.5", "8,259" },
                    { 1050, 0, 0, "Vivica A. Fox, Morris Chestnut, Anthony Anderson, Gabrielle Union", 0, 0, "7 nominations.", 0, "22,235,901", 1, "USA", 0, "Mark Brown", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWMxYTZlOTUtZDExMi00YzZmLTkwYTMtZmM2MmRjZmQ3OGY4XkEyXkFqcGdeQXVyMTAwMzUyMzUy._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Sep-01", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Two Can Play That Game", 0, 0, "movie", 0, 0, 0, "Mark Brown", 0, "data/Movie_Poster_Dataset/2001/tt0269341.jpg", "tt0269341", "6.1", "4,251" },
                    { 1051, 0, 0, "Steve Zahn, Paul Walker, Leelee Sobieski, Jessica Bowman", 0, 0, "3 nominations.", 0, "null", 0, "USA", 0, "John Dahl", 0, 0, 0, 0, 0, "Mystery, Thriller", 0, 0, "English", 0, "75", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjRjOTMwMDEtNTY4NS00OWRjLWI4ZWItZDgwYmZhMzlkYzgxXkEyXkFqcGdeQXVyODIxOTg5MTc@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "5-Oct-01", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 1, "Joy Ride", 0, 0, "movie", 0, 0, 0, "Clay Tarver, J.J. Abrams", 0, "data/Movie_Poster_Dataset/2001/tt0206314.jpg", "tt0206314", "6.6", "52,259" },
                    { 1052, 0, 0, "Denise Richards, David Boreanaz, Marley Shelton, Jessica Capshaw", 0, 0, "1 win.", 0, "null", 0, "USA", 0, "Jamie Blanks", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BY2IzNGNiODgtOWYzOS00OTI0LTgxZTUtOTA5OTQ5YmI3NGUzXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "2-Feb-01", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 1, "Valentine", 0, 0, "movie", 0, 0, 0, "Tom Savage (novel), Donna Powers (screenplay), Wayne Powers (screenplay), Gretchen J. Berg (screenplay), Aaron Harberts (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0242998.jpg", "tt0242998", "4.7", "20,093" },
                    { 1053, 0, 0, "Freddie Prinze Jr., Jessica Biel, Fred Ward, Matthew Lillard", 0, 0, "N/A", 0, "19,693,891", 1, "USA", 0, "Michael Tollin", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTYzZWE3MDAtZjZkMi00MzhlLTlhZDUtNmI2Zjg3OWVlZWI0XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Aug-01", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Summer Catch", 0, 0, "movie", 0, 0, 0, "Kevin Falls (story), Kevin Falls (screenplay), John Gatins (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0234829.jpg", "tt0234829", "4.9", "12,753" },
                    { 1054, 0, 0, "Patricia Clarkson, Beau Daniels, Benicio Del Toro, Dale Dickey", 0, 0, "1 win & 6 nominations.", 0, "null", 0, "USA", 1, "Sean Penn", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "71", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzQ2ZTBhNmEtZDBmYi00ODU0LTgzZmQtNmMxM2M4NzM1ZjE4XkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Jan-01", "TRUE", 0, "124 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Pledge", 0, 0, "movie", 0, 0, 0, "Friedrich Dürrenmatt (book), Jerzy Kromolowski (screenplay), Mary Olson-Kromolowski (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0237572.jpg", "tt0237572", "6.8", "41,822" },
                    { 1055, 0, 0, "Steve Zahn, Jack Black, Jason Biggs, Amanda Peet", 0, 0, "N/A", 0, "872,059", 1, "USA, Australia", 1, "Dennis Dugan", 0, 0, 0, 0, 0, "Comedy, Crime, Romance", 0, 0, "English, Thai", 0, "22", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA0MjIyOTI3MF5BMl5BanBnXkFtZTcwODM5NTY5MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Feb-01", "TRUE", 1, "90 min", 0, 0, 0, 0, 0, 0, 0, 0, "Saving Silverman", 0, 0, "movie", 0, 0, 0, "Hank Nelken, Greg DePaul", 0, "data/Movie_Poster_Dataset/2001/tt0239948.jpg", "tt0239948", "5.9", "32,707" },
                    { 1056, 0, 1, "Robert Redford, James Gandolfini, Mark Ruffalo, Steve Burton", 0, 0, "1 win & 3 nominations.", 0, "286,201", 0, "USA", 0, "Rod Lurie", 0, 1, 0, 0, 0, "Action, Drama, Thriller", 0, 0, "English", 0, "43", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTgxMjQ4NzE5OF5BMl5BanBnXkFtZTcwNzkwOTkyMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Oct-01", "TRUE", 0, "131 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Last Castle", 0, 0, "movie", 0, 0, 0, "David Scarpa (story), David Scarpa (screenplay), Graham Yost (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0272020.jpg", "tt0272020", "6.9", "55,476" },
                    { 1057, 0, 0, "Leelee Sobieski, Diane Lane, Stellan Skarsgård, Bruce Dern", 0, 0, "3 nominations.", 0, "17,951,431", 0, "USA", 1, "Daniel Sackheim", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English, Spanish", 0, "34", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjIwOGJhY2QtMTA5Yi00MDhlLWE5OTgtYmIzZDNlM2UwZjMyXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "14-Sep-01", "TRUE", 0, "106 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Glass House", 0, 0, "movie", 0, 0, 0, "Wesley Strick", 0, "data/Movie_Poster_Dataset/2001/tt0221218.jpg", "tt0221218", "5.8", "24,911" },
                    { 1058, 0, 0, "Alex D. Linz, Larry Miller, Jamie Kennedy, Zena Grey", 0, 0, "1 win & 1 nomination.", 0, "17,292,381", 1, "USA", 1, "Tim Hill", 0, 0, 0, 1, 0, "Comedy, Crime, Family", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BZWI4ZTgwMzktNjk3Yy00OTlhLTg3YTAtMTA1MWVlMWJiOTRiXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "5-Oct-01", "TRUE", 0, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Max Keeble's Big Move", 0, 0, "movie", 0, 0, 0, "David L. Watts (story), Jonathan Bernstein (story), Mark Blackwell (story), James Greer (story), Jonathan Bernstein (screenplay), Mark Blackwell (screenplay), James Greer (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0273799.jpg", "tt0273799", "5.3", "5,653" },
                    { 1059, 0, 0, "Mark Wahlberg, Jennifer Aniston, Dominic West, Jason Bonham", 0, 0, "1 nomination.", 0, "null", 1, "USA", 0, "Stephen Herek", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English", 0, "54", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTUzNDgyMzg3Ml5BMl5BanBnXkFtZTcwMzIxNTAwMQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Sep-01", "TRUE", 0, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "Rock Star", 0, 0, "movie", 0, 0, 0, "John Stockwell", 0, "data/Movie_Poster_Dataset/2001/tt0202470.jpg", "tt0202470", "6.2", "33,825" },
                    { 1060, 0, 0, "Kirsten Dunst, Jay Hernandez, Bruce Davison, Herman Osorio", 0, 0, "5 nominations.", 0, "null", 0, "USA", 0, "John Stockwell", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "61", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjA4MjI2OTM5N15BMl5BanBnXkFtZTcwNDA1NjUzMw@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-Jun-01", "TRUE", 1, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Crazy/Beautiful", 0, 0, "movie", 0, 0, 0, "Phil Hay, Matt Manfredi", 0, "data/Movie_Poster_Dataset/2001/tt0250224.jpg", "tt0250224", "6.5", "21,091" },
                    { 1061, 0, 0, "Antonio Banderas, Angelina Jolie, Thomas Jane, Jack Thompson", 0, 0, "1 nomination.", 0, "614,343", 0, "France, USA", 0, "Michael Cristofer", 0, 1, 0, 0, 0, "Drama, Mystery, Romance", 0, 0, "English, German, Japanese, Latin, Spanish", 0, "33", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmNlNDVjMWUtZDZjNS00YTBmLWE3NGUtNDcxMzE0YTQ2ODMxXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "3-Aug-01", "TRUE", 1, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "Original Sin", 0, 0, "movie", 0, 0, 0, "Cornell Woolrich (novel), Michael Cristofer (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0218922.jpg", "tt0218922", "6", "43,898" },
                    { 1062, 0, 1, "Kurt Russell, Kevin Costner, Courteney Cox, Christian Slater", 0, 0, "8 nominations.", 0, "15,738,632", 1, "USA", 1, "Demian Lichtenstein", 0, 0, 0, 0, 0, "Action, Comedy, Crime", 0, 0, "English", 0, "21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTMxNzYzNzUzMV5BMl5BanBnXkFtZTYwNjcwMjE3._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Feb-01", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "3000 Miles to Graceland", 0, 0, "movie", 0, 0, 0, "Richard Recco, Demian Lichtenstein", 0, "data/Movie_Poster_Dataset/2001/tt0233142.jpg", "tt0233142", "5.9", "37,459" },
                    { 1063, 0, 0, "Kevin Kline, Kristin Scott Thomas, Hayden Christensen, Jena Malone", 0, 0, "Nominated for 1 Golden Globe. Another 2 wins & 8 nominations.", 0, "15,561,627", 0, "USA", 0, "Irwin Winkler", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmE0YjdlYTktMTU4Ni00Mjk2LWI3NWMtM2RjNmFiOTk4YjYxL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "9-Nov-01", "TRUE", 0, "125 min", 0, 0, 0, 0, 0, 0, 0, 0, "Life as a House", 0, 0, "movie", 0, 0, 0, "Mark Andrus", 0, "data/Movie_Poster_Dataset/2001/tt0264796.jpg", "tt0264796", "7.5", "38,690" },
                    { 1064, 0, 0, "Rachael Leigh Cook, Rosario Dawson, Tara Reid, Gabriel Mann", 0, 0, "5 nominations.", 0, "null", 1, "Canada, USA", 0, "Harry Elfont, Deborah Kaplan", 0, 0, 0, 0, 0, "Comedy, Music", 0, 0, "English", 0, "47", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODNiZmY2MWUtMjFhMy00ZmM2LTg2MjYtNWY1OTY5NGU2MjdjL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "11-Apr-01", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "Josie and the Pussycats", 0, 0, "movie", 0, 0, 0, "Deborah Kaplan, Harry Elfont, Richard Goldwater (characters), Dan DeCarlo (characters), John L. Goldwater (characters)", 0, "data/Movie_Poster_Dataset/2001/tt0236348.jpg", "tt0236348", "5.3", "18,670" },
                    { 1065, 0, 0, "Tom Green, Rip Torn, Marisa Coughlan, Eddie Kaye Thomas", 0, 0, "7 wins & 5 nominations.", 0, "14,249,005", 1, "USA", 0, "Tom Green", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "13", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTFkM2ViMmQtZmI5NS00MjQ2LWEyN2EtMTI1ZmNlZDU3MTZjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "20-Apr-01", "TRUE", 0, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Freddy Got Fingered", 0, 0, "movie", 0, 0, 0, "Tom Green, Derek Harvie", 0, "data/Movie_Poster_Dataset/2001/tt0240515.jpg", "tt0240515", "4.5", "39,027" },
                    { 1066, 0, 0, "Flex Alexander, A.J. Cook, David Denman, Caroline Dhavernas", 0, 0, "N/A", 0, "13,903,262", 1, "USA", 0, "Brendan Malloy, Emmett Malloy", 0, 0, 0, 0, 0, "Comedy, Sport", 0, 0, "English", 0, "22", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMDc2MGYwYzAtNzE2Yi00YmU3LTkxMDUtODk2YjhiNDM5NDIyXkEyXkFqcGdeQXVyMTEwNDU1MzEy._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Nov-01", "TRUE", 0, "89 min", 0, 0, 1, 0, 0, 0, 0, 0, "Out Cold", 0, 0, "movie", 0, 0, 0, "Jon Zack", 0, "data/Movie_Poster_Dataset/2001/tt0253798.jpg", "tt0253798", "6.3", "14,485" },
                    { 1067, 0, 0, "Pierce Brosnan, Geoffrey Rush, Jamie Lee Curtis, Leonor Varela", 0, 0, "1 nomination.", 0, "13,491,653", 0, "USA, Ireland", 0, "John Boorman", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English, Spanish", 0, "66", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYmUzODQ5MGItZTZlNy00MDBhLWIxMmItMjg4Y2QyNDFlMWQ2XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "4-May-01", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Tailor of Panama", 0, 0, "movie", 0, 0, 0, "John le Carré (novel), Andrew Davies (screenplay), John le Carré (screenplay), John Boorman (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0236784.jpg", "tt0236784", "6.1", "23,299" },
                    { 1068, 0, 1, "Chris Rock, Laurence Fishburne, David Hyde Pierce, Brandy Norwood", 1, 1, "1 win & 7 nominations.", 0, "13,596,911", 0, "USA", 0, "Bobby Farrelly, Peter Farrelly", 0, 0, 0, 0, 0, "Animation, Action, Adventure", 0, 0, "English", 0, "57", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BNDhjMzc3ZTgtY2Y4MC00Y2U3LWFiMDctZGM3MmM4N2YzNDQ5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "10-Aug-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Osmosis Jones", 0, 0, "movie", 0, 0, 0, "Marc Hyman", 0, "data/Movie_Poster_Dataset/2001/tt0181739.jpg", "tt0181739", "6.2", "24,846" },
                    { 1069, 0, 0, "Jerry O'Connell, Shannon Elizabeth, Jake Busey, Horatio Sanz", 0, 0, "N/A", 0, "13,558,739", 1, "USA", 0, "Gregory Poirier", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "15", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Mar-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tomcats", 0, 0, "movie", 0, 0, 0, "Gregory Poirier", 0, "data/Movie_Poster_Dataset/2001/tt0246989.jpg", "tt0246989", "5.3", "15,247" },
                    { 1070, 0, 1, "Colin Farrell, Scott Caan, Ali Larter, Gabriel Macht", 0, 0, "7 nominations.", 0, "13,264,986", 0, "USA", 0, "Les Mayfield", 0, 0, 0, 0, 0, "Action, Western", 0, 0, "English", 0, "25", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTAxMDE4Mzc3ODNeQTJeQWpwZ15BbWU4MDY2Mjg4MDcx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "17-Aug-01", "TRUE", 0, "94 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Outlaws", 0, 0, "movie", 0, 0, 1, "Roderick Taylor (story), Roderick Taylor (screenplay), John Rogers (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0244000.jpg", "tt0244000", "6", "11,932" },
                    { 1071, 0, 0, "Marla Sokoloff, Marley Shelton, Melissa George, Mena Suvari", 0, 0, "N/A", 0, "13,276,953", 1, "USA", 1, "Francine McDougall", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English", 0, "48", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjg5ZDkzZWEtZDQ2ZC00Y2ViLThhMzYtMmIxZDYzYTY2Y2Y2XkEyXkFqcGdeQXVyODAwMTU1MTE@._V1_UY98_CR1,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "26-Jan-01", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sugar & Spice", 0, 0, "movie", 0, 0, 0, "Mandy Nelson", 0, "data/Movie_Poster_Dataset/2001/tt0186589.jpg", "tt0186589", "5.6", "11,350" },
                    { 1072, 0, 0, "Kirsten Dunst, Ben Foster, Melissa Sagemiller, Sisqó", 0, 0, "1 nomination.", 0, "null", 1, "USA", 0, "Tommy O'Haver", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "52", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWFlY2E3ODQtZWNiNi00ZGU4LTkzNWEtZTQ2ZTViMWRhYjIzL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Mar-01", "TRUE", 1, "87 min", 0, 0, 0, 0, 0, 0, 0, 0, "Get Over It", 0, 0, "movie", 0, 0, 0, "R. Lee Fleming Jr.", 0, "data/Movie_Poster_Dataset/2001/tt0192071.jpg", "tt0192071", "5.8", "15,387" },
                    { 1073, 0, 0, "Kevin Spacey, Julianne Moore, Judi Dench, Cate Blanchett", 0, 0, "Nominated for 2 Golden Globes. Another 2 wins & 10 nominations.", 0, "166,081", 0, "USA", 0, "Lasse Hallström", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "47", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTI3YzZjZjEtMDdjOC00OWVjLTk0YmYtYzI2MGMwZjFiMzBlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-Jan-02", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Shipping News", 0, 0, "movie", 0, 0, 0, "Annie Proulx (based on the novel by), Robert Nelson Jacobs (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0120824.jpg", "tt0120824", "6.8", "28,069" },
                    { 1074, 0, 1, "Ryan Phillippe, Rachael Leigh Cook, Claire Forlani, Tim Robbins", 0, 0, "2 wins & 3 nominations.", 0, "null", 0, "USA", 1, "Peter Howitt", 0, 1, 0, 0, 0, "Action, Crime, Drama", 0, 0, "English", 0, "31", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTA3OTYxMzg0MDFeQTJeQWpwZ15BbWU4MDY1MjY0MTEx._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "12-Jan-01", "TRUE", 0, "109 min", 0, 0, 0, 0, 0, 0, 0, 0, "Antitrust", 0, 0, "movie", 0, 0, 0, "Howard Franklin", 0, "data/Movie_Poster_Dataset/2001/tt0218817.jpg", "tt0218817", "6.1", "25,221" },
                    { 1075, 0, 0, "Monica Potter, Freddie Prinze Jr., Shalom Harlow, Ivana Milicevic", 0, 0, "N/A", 0, "10,397,365", 1, "USA", 0, "Mark Waters", 0, 0, 0, 0, 0, "Comedy, Mystery, Romance", 0, 0, "English, Russian", 0, "27", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTM2ZGJmNjQtN2UyOS00NjcxLWFjMDktMDE2NzMyNTZlZTBiXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Feb-01", "TRUE", 1, "86 min", 0, 0, 0, 0, 0, 0, 0, 0, "Head Over Heels", 0, 0, "movie", 0, 0, 0, "John J. Strauss (story), Ed Decter (story), David Kidd (story), Ron Burch (story), Ron Burch (screenplay), David Kidd (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0192111.jpg", "tt0192111", "5.3", "11,476" },
                    { 1076, 0, 0, "Anthony Albano, Dr. Dre, Tic, Lamont Bentley", 0, 0, "N/A", 0, "null", 1, "USA", 0, "DJ Pooh", 0, 0, 0, 0, 0, "Comedy", 0, 0, "English", 0, "18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMmU5ZjFmYjQtYmNjZC00Yjk4LWI1ZTQtZDJiMjM0YjQyNDU0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Nov-01", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Wash", 0, 0, "movie", 0, 0, 0, "DJ Pooh", 0, "data/Movie_Poster_Dataset/2001/tt0290332.jpg", "tt0290332", "4.6", "5,488" },
                    { 1077, 0, 0, "Tilda Swinton, Goran Visnjic, Jonathan Tucker, Peter Donat", 0, 0, "Nominated for 1 Golden Globe. Another 4 wins & 18 nominations.", 0, "null", 0, "USA", 1, "Scott McGehee, David Siegel", 0, 1, 0, 0, 0, "Crime, Drama, Mystery", 0, 0, "English", 0, "78", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjEzMTM2NjAtNWFmZC00MTVlLTgyMmQtMGQyNTFjZDk5N2NmXkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Aug-01", "TRUE", 0, "101 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Deep End", 0, 0, "movie", 0, 0, 0, "Elisabeth Sanxay Holding (novel), Scott McGehee, David Siegel", 0, "data/Movie_Poster_Dataset/2001/tt0250323.jpg", "tt0250323", "6.7", "9,595" },
                    { 1078, 0, 0, "John Tormey, John Schuck, Woody Allen, Elizabeth Berkley", 0, 0, "1 win.", 0, "7,585,551", 1, "USA, Germany", 1, "Woody Allen", 0, 0, 0, 0, 0, "Comedy, Crime, Mystery", 0, 0, "English", 0, "52", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODkxNGQ1NWYtNzg0Ny00Yjg3LThmZTItMjE2YjhmZTQ0ODY5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Aug-01", "TRUE", 0, "103 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Curse of the Jade Scorpion", 0, 0, "movie", 0, 0, 0, "Woody Allen", 0, "data/Movie_Poster_Dataset/2001/tt0256524.jpg", "tt0256524", "6.8", "31,115" },
                    { 1079, 0, 0, "Billy Bob Thornton, Frances McDormand, Michael Badalucco, James Gandolfini", 0, 0, "Nominated for 1 Oscar. Another 24 wins & 41 nominations.", 0, "7,494,849", 0, "USA, UK", 1, "Joel Coen, Ethan Coen", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English, Italian, French", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjA2ZDY3ZjYtZmNiMC00MDU5LTgxMWEtNzk1YmI3NzdkMTU0XkEyXkFqcGdeQXVyNjQyMjcwNDM@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Nov-01", "TRUE", 0, "116 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Man Who Wasn't There", 0, 0, "movie", 0, 0, 0, "Joel Coen, Ethan Coen", 0, "data/Movie_Poster_Dataset/2001/tt0243133.jpg", "tt0243133", "7.6", "84,157" },
                    { 1080, 0, 0, "Snoop Dogg, Pam Grier, Michael T. Weiss, Clifton Powell", 0, 0, "1 nomination.", 0, "7,307,756", 0, "USA", 1, "Ernest R. Dickerson", 0, 0, 0, 0, 0, "Crime, Horror", 0, 1, "English, French, Spanish", 0, "42", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTkyNTAzZDYtNWUzYi00ODVjLTliZjYtNjc2YzJmODZhNTg3XkEyXkFqcGdeQXVyNjUxMDQ0MTg@._V1_UY98_CR6,0,67,98_AL_.jpg", 1, "R", 0, 0, "24-Oct-01", "TRUE", 0, "96 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bones", 0, 0, "movie", 0, 0, 0, "Adam Simon, Tim Metcalfe", 0, "data/Movie_Poster_Dataset/2001/tt0166110.jpg", "tt0166110", "4", "5,502" },
                    { 1081, 0, 0, "Kerr Smith, Brendan Fehr, Izabella Miko, Johnathon Schaech", 0, 0, "N/A", 0, "6,755,271", 0, "USA", 0, "J.S. Cardone", 0, 0, 0, 0, 0, "Horror, Thriller", 0, 1, "English", 0, "35", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGExOGExM2UtNWM5ZS00OWEzLTllNzYtM2NlMTJlYjBlZTJkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Apr-01", "TRUE", 0, "90 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Forsaken", 0, 0, "movie", 0, 0, 0, "J.S. Cardone", 0, "data/Movie_Poster_Dataset/2001/tt0245120.jpg", "tt0245120", "5.3", "7,195" },
                    { 1082, 0, 0, "Naomi Watts, Jeanne Bates, Dan Birnbaum, Laura Harring", 0, 0, "Nominated for 1 Oscar. Another 46 wins & 53 nominations.", 0, "7,219,578", 0, "France, USA", 0, "David Lynch", 0, 1, 0, 0, 0, "Drama, Mystery, Thriller", 0, 0, "English, Spanish", 0, "81", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzk1MmI4NzAtOGRiNS00YjY1LTllNmEtZDhiZDM4MjU2NTMxXkEyXkFqcGdeQXVyNjc3MjQzNTI@._V1_UY98_CR1,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Oct-01", "TRUE", 0, "147 min", 0, 0, 0, 0, 0, 0, 0, 1, "Mulholland Drive", 0, 0, "movie", 0, 0, 0, "David Lynch", 0, "data/Movie_Poster_Dataset/2001/tt0166924.jpg", "tt0166924", "8", "228,268" },
                    { 1083, 0, 0, "Warren Beatty, Nastassja Kinski, Diane Keaton, Goldie Hawn", 0, 0, "1 win & 2 nominations.", 0, "6,712,451", 1, "USA", 0, "Peter Chelsom", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYWUxOWY4NDctMDFmMS00ZTQwLWExMGEtODg0ZWNhOTE5NzZmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Apr-01", "TRUE", 1, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Town & Country", 0, 0, "movie", 0, 0, 0, "Michael Laughlin, Buck Henry", 0, "data/Movie_Poster_Dataset/2001/tt0141907.jpg", "tt0141907", "4.4", "4,039" },
                    { 1084, 0, 0, "Matt Dillon, Mary Jo Smith, Michael Douglas, Paul Reiser", 0, 0, "N/A", 0, "null", 1, "USA", 1, "Harald Zwart", 0, 0, 0, 0, 0, "Comedy, Crime", 0, 0, "English, Spanish", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNzk1MjU3MDQyMl5BMl5BanBnXkFtZTcwNjc1OTM2MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "27-Apr-01", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "One Night at McCool's", 0, 0, "movie", 0, 0, 0, "Stan Seidel", 0, "data/Movie_Poster_Dataset/2001/tt0203755.jpg", "tt0203755", "6.1", "25,718" },
                    { 1085, 0, 0, "Thora Birch, Scarlett Johansson, Steve Buscemi, Brad Renfro", 0, 0, "Nominated for 1 Oscar. Another 28 wins & 56 nominations.", 0, "6,200,756", 1, "USA, UK, Germany", 0, "Terry Zwigoff", 0, 1, 0, 0, 0, "Comedy, Drama", 0, 0, "English", 0, "88", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjI0ZWFiMmQtMjRlZi00ZmFhLWI4NmYtMjQ5YmY0MzIyMzRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Sep-01", "TRUE", 0, "111 min", 0, 0, 0, 0, 0, 0, 0, 0, "Ghost World", 0, 0, "movie", 0, 0, 0, "Daniel Clowes (comic book), Daniel Clowes, Terry Zwigoff", 0, "data/Movie_Poster_Dataset/2001/tt0162346.jpg", "tt0162346", "7.4", "93,706" },
                    { 1086, 0, 0, "Kate Winslet, Hugh Bonneville, Judi Dench, Jim Broadbent", 0, 0, "Won 1 Oscar. Another 13 wins & 30 nominations.", 1, "1,292,119", 0, "UK, USA", 0, "Richard Eyre", 0, 1, 0, 0, 0, "Biography, Drama, Romance", 0, 0, "English", 0, "76", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTJlZmQ1OTAtODQzZi00NGIzLWI1MmEtZGE4NjFlOWRhODIyXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Mar-02", "TRUE", 1, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Iris", 0, 0, "movie", 0, 0, 0, "John Bayley (books), Richard Eyre (screenplay), Charles Wood (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0280778.jpg", "tt0280778", "7.1", "14,536" },
                    { 1087, 0, 0, "Chris Klein, Heather Graham, Orlando Jones, Sally Field", 0, 0, "1 nomination.", 0, "null", 1, "USA", 0, "J.B. Rogers", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNmRiZDZkN2EtNWI5ZS00ZDg3LTgyNDItMWI5NjVlNmE5ODJiXkEyXkFqcGdeQXVyMjQwMjk0NjI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "23-Mar-01", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Say It Isn't So", 0, 0, "movie", 0, 0, 0, "Peter Gaulke, Gerry Swallow", 0, "data/Movie_Poster_Dataset/2001/tt0239949.jpg", "tt0239949", "4.9", "11,117" },
                    { 1088, 0, 0, "Brendan Fraser, Bridget Fonda, John Turturro, Chris Kattan", 0, 1, "2 nominations.", 0, "5,409,517", 1, "USA", 0, "Henry Selick", 0, 0, 0, 0, 1, "Animation, Comedy, Fantasy", 0, 0, "English", 0, "40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjEzYjJmNzgtNDkwNy00MTQ4LTlmMWMtNzA4YjE2NjI0ZDg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "23-Feb-01", "TRUE", 0, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Monkeybone", 0, 0, "movie", 0, 0, 0, "Kaja Blackley (graphic novel \\\\", 0, "data/Movie_Poster_Dataset/2001/tt0166276.jpg", "tt0166276", "4.7", "13,975" },
                    { 1089, 0, 0, "Jon Favreau, Vince Vaughn, Joe Goossen, Famke Janssen", 0, 0, "1 nomination.", 0, "5,308,707", 1, "USA", 1, "Jon Favreau", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English, French", 0, "62", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNTliYTI1YTctMTE0Mi00NDM0LThjZDgtYmY3NGNiODBjZjAwXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Aug-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Made", 0, 0, "movie", 0, 0, 0, "Jon Favreau", 0, "data/Movie_Poster_Dataset/2001/tt0227005.jpg", "tt0227005", "6.4", "14,856" },
                    { 1090, 0, 0, "Jake Gyllenhaal, Swoosie Kurtz, Marley Shelton, Danny Trejo", 1, 0, "N/A", 0, "5,002,310", 1, "USA", 0, "Blair Hayes", 0, 0, 0, 0, 0, "Adventure, Comedy, Romance", 0, 0, "English", 0, "41", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjcxMzM3OWMtNmM3Yy00YzBkLTkxMmQtMDk4MmM3Y2Y4MDliL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "24-Aug-01", "TRUE", 1, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Bubble Boy", 0, 0, "movie", 0, 0, 0, "Cinco Paul, Ken Daurio", 0, "data/Movie_Poster_Dataset/2001/tt0258470.jpg", "tt0258470", "5.6", "24,942" },
                    { 1091, 0, 0, "Jean Reno, Christina Applegate, Christian Clavier, Matt Ross", 0, 0, "N/A", 0, "null", 1, "France, USA", 0, "Jean-Marie Poiré", 0, 0, 0, 0, 1, "Comedy, Fantasy, Sci-Fi", 0, 0, "English, French", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTM5MDY5MDQyOV5BMl5BanBnXkFtZTgwMzM3NzMxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "6-Apr-01", "TRUE", 0, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "Just Visiting", 0, 0, "movie", 0, 0, 0, "Jean-Marie Poiré, Christian Clavier, Christian Clavier (screenplay), Jean-Marie Poiré (screenplay), John Hughes (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0189192.jpg", "tt0189192", "5.8", "14,718" },
                    { 1092, 0, 0, "Christopher Gorham, Anne Hathaway, Joe Folau, Nathaniel Lees", 1, 0, "1 win.", 1, "4,720,371", 0, "USA", 0, "Mitch Davis", 0, 1, 0, 0, 0, "Adventure, Biography, Drama", 0, 0, "English, Tonga", 0, "38", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMTQxNDYzMTg1M15BMl5BanBnXkFtZTgwNzk4MDgxMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "12-Apr-02", "TRUE", 0, "113 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Other Side of Heaven", 0, 0, "movie", 0, 0, 0, "Mitch Davis, John H. Groberg (book)", 0, "data/Movie_Poster_Dataset/2001/tt0250371.jpg", "tt0250371", "6.5", "3,135" },
                    { 1093, 0, 0, "Anthony LaPaglia, Geoffrey Rush, Barbara Hershey, Kerry Armstrong", 0, 0, "36 wins & 22 nominations.", 0, "null", 0, "Australia, Germany", 0, "Ray Lawrence", 0, 1, 0, 0, 0, "Drama, Mystery", 0, 0, "English", 0, "84", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5NjI2MjQxMl5BMl5BanBnXkFtZTgwMDA2MzM2NzE@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "8-Mar-02", "TRUE", 0, "121 min", 0, 0, 0, 0, 0, 0, 0, 0, "Lantana", 0, 0, "movie", 0, 0, 0, "Andrew Bovell (play), Andrew Bovell (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0259393.jpg", "tt0259393", "7.4", "16,268" },
                    { 1094, 0, 0, "Jacqueline Obradors, Tamara Mello, Judy Herrera, Nikolai Kinski", 0, 0, "2 wins & 7 nominations.", 0, "4,447,014", 1, "USA", 0, "Maria Ripoll", 0, 1, 0, 0, 0, "Comedy, Romance, Drama", 0, 0, "English, Spanish", 0, "58", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNjg5ZDM0MTEtYTZmNC00NDJiLWI5MTktYzk4N2QxY2IxZTc2L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY98_CR3,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "31-Aug-01", "TRUE", 1, "102 min", 0, 0, 0, 0, 0, 0, 0, 0, "Tortilla Soup", 0, 0, "movie", 0, 0, 0, "Hui-Ling Wang (earlier screenplay), Ang Lee (earlier screenplay), James Schamus (earlier screenplay), Ramón Menéndez (screenplay), Tom Musca (screenplay), Vera Blasi (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0255653.jpg", "tt0255653", "6.5", "3,445" },
                    { 1095, 0, 0, "Lance Bass, Joey Fatone, Emmanuelle Chriqui, GQ", 0, 0, "2 nominations.", 0, "4,356,743", 1, "USA", 0, "Eric Bross", 0, 0, 0, 1, 0, "Comedy, Family, Romance", 0, 0, "English", 0, "34", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, "https://m.media-amazon.com/images/M/MV5BMzFkM2YwOTQtYzk2Mi00N2VlLWE3NTItN2YwNDg1YmY0ZDNmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG", 0, 0, "26-Oct-01", "TRUE", 1, "85 min", 0, 0, 0, 0, 0, 0, 0, 0, "On the Line", 0, 0, "movie", 0, 0, 0, "Eric Aronson, Paul B. Stanton", 0, "data/Movie_Poster_Dataset/2001/tt0279286.jpg", "tt0279286", "4.1", "3,618" },
                    { 1096, 0, 0, "Mariah Carey, Max Beesley, Da Brat, Tia Texada", 0, 0, "1 win & 8 nominations.", 0, "4,273,372", 0, "USA", 0, "Vondie Curtis-Hall", 0, 1, 0, 0, 0, "Drama, Music, Romance", 0, 0, "English", 0, "14", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWFlYWY2YjYtNjdhNi00MzVlLTg2MTMtMWExNzg4NmM5NmEzXkEyXkFqcGdeQXVyMDk5Mzc5MQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "21-Sep-01", "TRUE", 1, "104 min", 0, 0, 0, 0, 0, 0, 0, 0, "Glitter", 0, 0, "movie", 0, 0, 0, "Cheryl L. West (story), Kate Lanier (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0118589.jpg", "tt0118589", "2.1", "19,180" },
                    { 1097, 0, 0, "Alan Cumming, Jennifer Jason Leigh, Otis, Steven Freedman", 0, 0, "2 wins & 5 nominations.", 0, "4,013,506", 1, "USA", 0, "Alan Cumming, Jennifer Jason Leigh", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "56", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjE0ODEwNjM2NF5BMl5BanBnXkFtZTcwMjU2Mzg3NA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "29-Jun-01", "TRUE", 1, "115 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Anniversary Party", 0, 0, "movie", 0, 0, 0, "Jennifer Jason Leigh, Alan Cumming", 0, "data/Movie_Poster_Dataset/2001/tt0254099.jpg", "tt0254099", "6.4", "7,352" },
                    { 1098, 0, 0, "Marc Messier, Rémy Girard, Patrick Huard, Serge Thériault", 0, 0, "2 wins & 3 nominations.", 0, "995,000", 1, "Canada", 0, "Louis Saia", 0, 1, 0, 0, 0, "Comedy, Drama, Sport", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2JlZTBhYTEtZDE3OC00NTA3LTk5NTQtNjg5M2RjODllM2M0XkEyXkFqcGdeQXVyNjk1Njg5NTA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "30-Nov-01", "TRUE", 0, "124 min", 0, 0, 1, 0, 0, 0, 0, 0, "Les Boys III", 0, 0, "movie", 0, 0, 0, "René Brisebois, François Camirand, Louis Saia", 0, "data/Movie_Poster_Dataset/2001/tt0186895.jpg", "tt0186895", "5.8", "851" },
                    { 1099, 0, 0, "Lance Crouther, J.B. Smoove, Jennifer Coolidge, Reg E. Cathey", 1, 0, "N/A", 0, "3,293,258", 1, "USA", 0, "Louis C.K.", 0, 0, 0, 0, 0, "Comedy, Musical, Adventure", 0, 0, "English", 0, "31", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODk1ZWM4ZjItMjFhZi00MDMxLTgxNmYtODFhNWZlZTkwM2UwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "29-Jun-01", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Pootie Tang", 0, 0, "movie", 0, 0, 0, "Louis C.K.", 0, "data/Movie_Poster_Dataset/2001/tt0258038.jpg", "tt0258038", "5.1", "11,195" },
                    { 1100, 0, 0, "Melissa Sagemiller, Wes Bentley, Casey Affleck, Eliza Dushku", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Stephen Carpenter", 0, 1, 0, 0, 0, "Drama, Horror, Mystery", 0, 1, "English", 0, "20", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2I1ZWNkYjEtYWY3ZS00MmMwLWI5OTEtNWNkZjNiYjIwNzY0XkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "7-Sep-01", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 0, "Soul Survivors", 0, 0, "movie", 0, 0, 0, "Stephen Carpenter", 0, "data/Movie_Poster_Dataset/2001/tt0218619.jpg", "tt0218619", "3.9", "7,209" },
                    { 1101, 0, 0, "John Cameron Mitchell, Miriam Shor, Stephen Trask, Theodore Liscinski", 0, 0, "Nominated for 1 Golden Globe. Another 28 wins & 32 nominations.", 0, "3,029,081", 1, "USA", 0, "John Cameron Mitchell", 0, 1, 0, 0, 0, "Comedy, Drama, Music", 0, 0, "English, German", 0, "85", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTllNWNlZjctMWQwMS00ZDc3LTg5ZjMtNzhmNzhjMmVhYTFlXkEyXkFqcGdeQXVyNTc1NTQxODI@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "31-Aug-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Hedwig and the Angry Inch", 0, 0, "movie", 0, 0, 0, "John Cameron Mitchell (book), Stephen Trask (book), John Cameron Mitchell (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0248845.jpg", "tt0248845", "7.8", "25,863" },
                    { 1102, 0, 0, "Amitabh Bachchan, Jaya Bhaduri, Shah Rukh Khan, Kajol", 0, 0, "22 wins & 43 nominations.", 0, "null", 0, "India", 0, "Karan Johar", 0, 1, 0, 0, 0, "Drama, Musical, Romance", 0, 0, "Hindi, English, Urdu", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZmI5YzM1MjItMzFmNy00NGFkLThlMDUtZjZmYTZkM2QxMjU3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "14-Dec-01", "TRUE", 1, "210 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kabhi Khushi Kabhie Gham...", 0, 0, "movie", 0, 0, 0, "Karan Johar, Sheena Parikh (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0248126.jpg", "tt0248126", "7.5", "27,927" },
                    { 1103, 0, 0, "Trevor Jack Brooks, Lorelei Linklater, Wiley Wiggins, Glover Gill", 0, 1, "5 wins & 20 nominations.", 0, "2,892,011", 0, "USA", 0, "Richard Linklater", 0, 1, 0, 0, 1, "Animation, Drama, Fantasy", 0, 0, "English", 0, "82", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNWQ4MGZlZmYtZjY0MS00N2JhLWE0NmMtOTMwMTk4NDQ4NjE2XkEyXkFqcGdeQXVyNTI4MjkwNjA@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "16-Nov-01", "TRUE", 0, "99 min", 0, 0, 0, 0, 0, 0, 0, 0, "Waking Life", 0, 0, "movie", 0, 0, 0, "Richard Linklater", 0, "data/Movie_Poster_Dataset/2001/tt0243017.jpg", "tt0243017", "7.8", "47,445" },
                    { 1104, 0, 0, "Penny Balfour, Edward Burns, Michael Leydon Campbell, Nadia Dajani", 0, 0, "N/A", 0, "2,402,459", 1, "USA", 0, "Edward Burns", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "49", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BN2VlNjNhZWQtMTY2OC00Y2E1LWJkNGUtMDU4M2ViNzliMGYwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "30-Nov-01", "TRUE", 1, "108 min", 0, 0, 0, 0, 0, 0, 0, 0, "Sidewalks of New York", 0, 0, "movie", 0, 0, 0, "Edward Burns", 0, "data/Movie_Poster_Dataset/2001/tt0239986.jpg", "tt0239986", "6.5", "5,656" },
                    { 1105, 0, 0, "Jaime Gomez, Seidy Lopez, Zach Galligan, Troy Winbush", 0, 0, "N/A", 0, "2,334,720", 0, "USA", 0, "Vincent Jay Miller", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTU2MWRiMTMtYzAzZi00NGYzLTlkMDEtNWQ3MzZlNTJlNzZkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "18-May-01", "TRUE", 1, "93 min", 0, 0, 0, 0, 0, 0, 0, 0, "Gabriela", 0, 0, "movie", 0, 0, 0, "Vincent Jay Miller", 0, "data/Movie_Poster_Dataset/2001/tt0189541.jpg", "tt0189541", "6.9", "1,398" },
                    { 1106, 0, 0, "Jeff Daniels, Harve Presnell, Joey Albright, Wayne David Parker", 0, 0, "N/A", 0, "null", 1, "USA", 0, "Jeff Daniels", 0, 0, 0, 0, 1, "Comedy, Fantasy", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMGQ0OGM5YjItYzYyMi00NmVmLWI3ODMtMTY2NGRkZmI5MWU2XkEyXkFqcGdeQXVyMzI0NDc4ODY@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "9-Feb-01", "TRUE", 0, "91 min", 0, 0, 0, 0, 0, 0, 0, 0, "Escanaba in da Moonlight", 0, 0, "movie", 0, 0, 0, "Jeff Daniels (play), Jeff Daniels (story), Guy Sanville (story), Jeff Daniels", 0, "data/Movie_Poster_Dataset/2001/tt0180679.jpg", "tt0180679", "6.5", "1,455" },
                    { 1107, 0, 0, "Richard Meese, Andrew Martin, Steve De Forest, Cynthia Downey", 0, 0, "N/A", 0, "null", 0, "USA", 0, "Rocky Costanzo", 0, 1, 0, 0, 0, "Drama", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDQ3MzNjMDItZjE0ZS00ZTYxLTgxNTAtM2I4YjZjNWFjYjJlL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "13-Nov-07", "TRUE", 0, "110 min", 0, 0, 0, 0, 0, 0, 0, 0, "Return to Innocence", 0, 0, "movie", 1, 0, 0, "Gary M. Frazier", 0, "data/Movie_Poster_Dataset/2001/tt0288192.jpg", "tt0288192", "7.3", "763" },
                    { 1108, 0, 0, "Chelcie Ross, Steve Martin, Laura Dern, Lynne Thigpen", 0, 0, "N/A", 0, "2,025,238", 1, "USA", 1, "David Atkins", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "English, French", 0, "45", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzZiODUwNzktNzBiZi00MDc4LThkMGMtZmE3MTE0M2E1MTM3L2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "14-Dec-01", "TRUE", 0, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "Novocaine", 0, 0, "movie", 0, 0, 0, "Paul Felopulos (story), David Atkins (story), David Atkins (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0234354.jpg", "tt0234354", "5.8", "9,436" },
                    { 1109, 0, 1, "Carman, Michael Nouri, Patricia Manterola, Jeremy Williams", 0, 0, "N/A", 0, "1,743,863", 0, "USA", 0, "Lee Stanley", 0, 1, 0, 0, 0, "Action, Drama, Sport", 0, 0, "English", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNDU1MjQ0YWMtMWQ2MS00NTdmLTg1MGItNDA5NTNkNTRhOTIyXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "2-Mar-01", "TRUE", 0, "82 min", 0, 0, 1, 0, 0, 0, 0, 0, "Carman: The Champion", 0, 0, "movie", 0, 0, 0, "Carman (story), Lee Stanley, Carman, Tony Cinciripini, Tadd Callies", 0, "data/Movie_Poster_Dataset/2001/tt0262462.jpg", "tt0262462", "5.8", "762" },
                    { 1110, 0, 0, "Ike Ogut, Nelofer Pazira, Hassan Tantai, Sadou Teymouri", 0, 0, "3 wins & 6 nominations.", 1, "21,122", 0, "Iran, France", 0, "Mohsen Makhmalbaf", 0, 1, 0, 0, 0, "Biography, Drama, War", 0, 0, "Persian, English, Pushto, Polish", 0, "76", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjM1NjE5NjQxN15BMl5BanBnXkFtZTgwMjYzMzQxMDE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Feb-02", "TRUE", 0, "81 min", 0, 0, 0, 0, 0, 0, 0, 0, "Kandahar", 0, 0, "movie", 0, 1, 0, "Mohsen Makhmalbaf", 0, "data/Movie_Poster_Dataset/2001/tt0283431.jpg", "tt0283431", "6.8", "5,569" },
                    { 1111, 0, 0, "Kaleil Isaza Tuzman, Tom Herman, Kenneth Austin, Tricia Burke", 0, 0, "10 wins & 6 nominations.", 0, "1,280,975", 0, "USA", 0, "Chris Hegedus, Jehane Noujaim", 1, 0, 0, 0, 0, "Documentary", 0, 0, "English", 0, "75", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYzZhODNiOWYtMmNkNS00OTFhLTkzYzktYTQ4ZmNmZWMyN2ZiL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "1-Jun-01", "TRUE", 0, "107 min", 0, 0, 0, 0, 0, 0, 0, 0, "Startup.com", 0, 0, "movie", 0, 0, 0, "N/A", 0, "data/Movie_Poster_Dataset/2001/tt0256408.jpg", "tt0256408", "7.1", "2,961" },
                    { 1112, 0, 0, "François Morency, Geneviève Brouillette, Pierrette Robitaille, Jacques Girard", 0, 0, "1 win & 2 nominations.", 0, "null", 1, "Canada", 0, "Émile Gaudreault", 0, 0, 0, 0, 0, "Comedy", 0, 0, "French", 0, "N/A", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYjRmY2VjN2ItMzBmYy00YTRjLWFiMTgtNGZhNWJjMjk3YjZjXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "1-Jun-01", "TRUE", 0, "92 min", 0, 0, 0, 0, 0, 0, 0, 0, "Nuit de noces", 0, 0, "movie", 0, 0, 0, "Marc Brunet, Émile Gaudreault", 0, "data/Movie_Poster_Dataset/2001/tt0275560.jpg", "tt0275560", "6.2", "367" },
                    { 1113, 0, 0, "Paul Dano, Bruce Altman, Billy Kay, James Costa", 0, 0, "20 wins & 18 nominations.", 0, "1,141,829", 0, "USA", 1, "Michael Cuesta", 0, 1, 0, 0, 0, "Crime, Drama", 0, 0, "English", 0, "73", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMzAyNDUwYzUtN2NlMC00ODliLWExMjgtMGMzNmYzZmUwYTg1XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "NC-17", 0, 0, "29-Nov-02", "TRUE", 0, "97 min", 0, 0, 0, 0, 0, 0, 0, 0, "L.I.E.", 0, 0, "movie", 0, 0, 0, "Stephen M. Ryder, Michael Cuesta, Gerald Cuesta", 0, "data/Movie_Poster_Dataset/2001/tt0242587.jpg", "tt0242587", "7.2", "8,381" },
                    { 1114, 0, 0, "Shane Edelman, Peter Sarsgaard, Molly Parker, Karry Brown", 0, 0, "1 nomination.", 0, "1,096,037", 0, "USA", 0, "Wayne Wang", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English", 0, "44", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMjAwMTExODExNl5BMl5BanBnXkFtZTgwMjM2MDgyMTE@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "18-May-01", "TRUE", 1, "88 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Center of the World", 0, 0, "movie", 1, 0, 0, "Wayne Wang (story), Miranda July (story), Paul Auster (story), Siri Hustvedt (story), Ellen Benjamin Wong (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0240402.jpg", "tt0240402", "5.9", "3,966" },
                    { 1116, 0, 0, "Stockard Channing, Julia Stiles, Frederick Weller, Mary Testa", 0, 0, "4 wins & 6 nominations.", 0, "1,028,337", 0, "USA", 0, "Patrick Stettner", 0, 1, 0, 0, 0, "Drama, Thriller", 0, 0, "English", 0, "67", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BYTE4YWU0NjAtMjNiYi00MTNiLTgwYzctZjk0YjY5NGVhNWQwXkEyXkFqcGdeQXVyMTY5Nzc4MDY@._V1_UY98_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "21-Dec-01", "TRUE", 0, "84 min", 0, 0, 0, 0, 0, 0, 0, 1, "The Business of Strangers", 0, 0, "movie", 0, 0, 0, "Patrick Stettner", 0, "data/Movie_Poster_Dataset/2001/tt0270259.jpg", "tt0270259", "6.4", "3,392" },
                    { 1117, 0, 0, "Scott Baio, John Seitz, Kim Martin, Zachary Mott", 0, 0, "5 wins.", 0, "null", 0, "USA", 0, "Melissa Martin", 0, 1, 0, 0, 0, "Drama, Romance", 0, 0, "English, Italian", 0, "54", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZjQyMGUwNzAtNTc2MC00Y2FjLThlM2ItZGRjNzM0OWVmZGYyXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "1-Feb-01", "TRUE", 1, "105 min", 0, 0, 0, 0, 0, 0, 0, 0, "The Bread, My Sweet", 0, 0, "movie", 0, 0, 0, "Melissa Martin", 0, "data/Movie_Poster_Dataset/2001/tt0281680.jpg", "tt0281680", "6.8", "763" },
                    { 1118, 0, 0, "Dan Bucatinsky, Richard Ruccolo, Sasha Alexander, Adam Goldberg", 0, 0, "N/A", 0, "1,006,969", 1, "USA", 0, "Julie Davis", 0, 0, 0, 0, 0, "Comedy, Romance", 0, 0, "English", 0, "46", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BNGEwMTRmZTQtMDY4Ni00MTliLTk5ZmMtOWMxYWMyMTllMDg0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "7-Mar-02", "TRUE", 1, "95 min", 0, 0, 0, 0, 0, 0, 0, 0, "All Over the Guy", 0, 0, "movie", 0, 0, 0, "Dan Bucatinsky", 0, "data/Movie_Poster_Dataset/2001/tt0250202.jpg", "tt0250202", "6.6", "3,829" },
                    { 1119, 0, 0, "Branko Djuric, Rene Bitorajac, Filip Sovagovic, Georges Siatidis", 0, 0, "Won 1 Oscar. Another 27 wins & 20 nominations.", 0, "1,059,830", 0, "Bosnia and Herzegovina, France, Slovenia, Italy, UK, Belgium", 0, "Danis Tanovic", 0, 1, 0, 0, 0, "Drama, War", 0, 0, "Bosnian, French, English, Serbian", 0, "84", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BODk3YjdjZTItOGVhYi00Mjc2LTgzMDAtMThmYTVkNTBlMWVkXkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_UX67_CR0,0,67,98_AL_.jpg", 1, "R", 0, 0, "19-Sep-01", "TRUE", 0, "98 min", 0, 0, 0, 0, 0, 0, 0, 0, "No Man's Land", 0, 0, "movie", 0, 1, 0, "Danis Tanovic", 0, "data/Movie_Poster_Dataset/2001/tt0283509.jpg", "tt0283509", "8", "37,171" },
                    { 1120, 0, 0, "Jackie Shroff, Hrithik Roshan, Kareena Kapoor, Amrish Puri", 0, 0, "1 nomination.", 0, "null", 0, "India", 0, "Subhash Ghai", 0, 1, 0, 0, 0, "Musical, Drama, Romance", 0, 0, "Hindi", 0, "N/A", 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BM2U3YzkxNGMtYWE0YS00ODk0LTk1ZGEtNjk3ZTE0MTk4MzJjXkEyXkFqcGdeQXVyNDk0MDg4NDk@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "N/A", 0, 0, "27-Jun-01", "TRUE", 1, "171 min", 0, 0, 0, 0, 0, 0, 0, 0, "Yaadein...", 0, 0, "movie", 0, 0, 0, "Subhash Ghai (dialogue), Subhash Ghai (screenplay), Amrik Gill (dialogue), Aatish Kapadia (screenplay), Anuradha Tiwari (screenplay)", 0, "data/Movie_Poster_Dataset/2001/tt0248617.jpg", "tt0248617", "4.4", "2,396" },
                    { 1121, 0, 0, "Deep Katdare, Purva Bedi, Ronobir Lahiri, Rizwan Manji", 0, 0, "N/A", 0, "null", 1, "USA, India", 0, "Piyush Dinker Pandya", 0, 1, 0, 0, 0, "Comedy, Drama, Romance", 0, 0, "English", 0, "50", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BZTBmMjUyMjItYTM4ZS00MjAwLWEyOGYtYjMyZTUxN2I3OTMxXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "UNRATED", 0, 0, "27-Sep-02", "TRUE", 1, "100 min", 0, 0, 0, 0, 0, 0, 0, 0, "American Desi", 0, 0, "movie", 1, 0, 0, "Piyush Dinker Pandya", 0, "data/Movie_Poster_Dataset/2001/tt0203289.jpg", "tt0203289", "6.7", "1,483" },
                    { 1122, 0, 0, "Jeanne Balibar, Marianne Basler, Hélène de Fougerolles, Catherine Rouvel", 0, 0, "3 wins & 3 nominations.", 0, "907,323", 1, "France, Italy, Germany", 1, "Jacques Rivette", 0, 1, 0, 0, 0, "Comedy, Crime, Drama", 0, 0, "French, Italian", 0, "79", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "https://m.media-amazon.com/images/M/MV5BMTY5ODAzMTcwOF5BMl5BanBnXkFtZTcwMzYxNDYyNA@@._V1_UX67_CR0,0,67,98_AL_.jpg", 0, "PG-13", 0, 0, "10-Oct-01", "TRUE", 0, "154 min", 0, 0, 0, 0, 0, 0, 0, 0, "Va Savoir (Who Knows?)", 0, 0, "movie", 0, 0, 0, "Pascal Bonitzer (scenario), Christine Laurent (scenario), Jacques Rivette (scenario), Pascal Bonitzer (dialogue), Christine Laurent (dialogue)", 0, "data/Movie_Poster_Dataset/2001/tt0242994.jpg", "tt0242994", "7", "2,016" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "LMmCWpbT0WnO0HWpNWpt5IHEkauAKZHPkdj++Cr4vOU=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "TempPassword" },
                values: new object[] { "LMmCWpbT0WnO0HWpNWpt5IHEkauAKZHPkdj++Cr4vOU=", "LMmCWpbT0WnO0HWpNWpt5IHEkauAKZHPkdj++Cr4vOU=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "MovieCatalog",
                keyColumn: "MovieId",
                keyValue: 1122);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "TempPassword" },
                values: new object[] { "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=", "/msrEh2aisw4YMZxo0VI42yG8wpYt5Xeq19Xs6zhJ/0=" });
        }
    }
}
