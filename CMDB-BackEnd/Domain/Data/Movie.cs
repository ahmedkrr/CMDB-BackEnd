namespace CMDB_BackEnd.Domain.Data
{
    public class Movie
    {
        public int Movie_Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Release_Date { get; private set; }
        public string OverView { get; private set; }
        public double Runtime { get; set; }
        public string Poster_Url { get; private set; }
        public double Average_Rating { get; private set; }
        public MediaType MediaType { get; private set; }
        public int MediaTypeId { get; private set; }
        public ICollection<Movie_Genres> Movie_Genres { get; private set; }
        public ICollection<Movie_Actors> Movie_Actors { get; private set; }
        public ICollection<Movie_Directors> Movie_Directors { get; private set; }

        public Movie()
        {

        }

        public Movie(string title, DateTime release_Date, string overView, double runtime, string poster_Url, double average_Rating, int mediaTypeId)
        {
            Title = title;
            Release_Date = release_Date;
            OverView = overView;
            Runtime = runtime;
            Poster_Url = poster_Url;
            Average_Rating = average_Rating;
            MediaTypeId = mediaTypeId;
        }   
    }
}
