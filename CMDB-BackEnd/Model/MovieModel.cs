namespace CMDB_BackEnd.Model
{
    public class MovieModel
    {
    }
    public class CreateMovieRequest
    {
        public required string Title { get;  set; }
        public DateTime Release_Date { get;  set; }
        public required string OverView { get;  set; }
        public double Runtime { get; set; }
        public string? Poster_Url { get;  set; }
        public double Average_Rating { get; set; }
        public int MediaTypeId { get; set; }
        public required List<int> Movie_Actors_Id { get; set; }
        public required List<int> Movie_Direcotr_Id { get; set; }
        public required List<int> Movie_Genre_Id { get; set; }
    }

    public class GetAllMovieRequest
    {
        public int Movie_Id { get; set; }
        public required string Title { get; set; }
        public required string Release_Date { get; set; }
        public required string OverView { get; set; }
        public double Runtime { get; set; }
        public string? Poster_Url { get; set; }
        public double Average_Rating { get; set; }
        public string? MediaTypes { get; set; }
        public List<GetMovieDirector>? MovieDirectors { get; set; }
        public List<GetMovieActors>? Movie_Actors { get; set; }
        public List<GetMovieGenre>? MovieGenres { get; set; }
    }

    public class GetMovieDirector
    {
        public string? Directors_Name { get; set; }
    }
    public class GetMovieActors
    {
        public string?  Actor_Name { get; set; }
    }
    public class GetMovieGenre
    {
        public string? Movie_genre { get; set; }
    }
}
