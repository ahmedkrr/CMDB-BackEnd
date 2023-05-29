namespace CMDB_BackEnd.Model
{
    public class CreateMovieModel
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
}
