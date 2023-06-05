namespace CMDB_BackEnd.Model
{
    public class SeriesModel
    {
    }

    public class CreateSeriesRequest
    {
        public required string Title { get; set; }
        public DateTime Release_Date { get; set; }
        public required string OverView { get; set; }
        public double Runtime { get; set; }
        public string? Poster_Url { get; set; }
        public double Average_Rating { get; set; }
        public int MediaTypeId { get; set; }
        public required List<int> Series_Actors_Id { get; set; }
        public required List<int> Series_Directors_Id { get; set; }
        public required List<int> Series_Genres_Id { get; set; }
    }
    public class GetAllSeriesRequest
    {
        public int Series_Id { get; set; }
        public required string Title { get; set; }
        public required string Release_Date { get; set; }
        public required string OverView { get; set; }
        public string? Poster_Url { get; set; }
        public double Average_Rating { get; set; }
        public string? MediaTypes { get; set; }
        public List<GetSeriesDirector>? SeriesDirectors { get; set; }
        public List<GetSeriesActors>? Series_Actors { get; set; }
        public List<GetSeriesGenre>? SeriesGenres { get; set; }
    }

    public class GetSeriesDirector
    {
        public string? Directors_Name { get; set; }
    }
    public class GetSeriesActors
    {
        public string? Actor_Name { get; set; }
    }
    public class GetSeriesGenre
    {
        public string? Series_genre { get; set; }
    }


}
