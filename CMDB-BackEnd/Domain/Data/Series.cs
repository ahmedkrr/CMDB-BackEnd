namespace CMDB_BackEnd.Domain.Data
{
    public class Series
    {
        public int Series_Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Release_Date { get; private set; }
        public string OverView { get; private set; }
        public string Poster_Url { get; private set; }
        public double Average_Rating { get; private set; }
        public MediaType MediaType { get; private set; }
        public int MediaTypeId { get; private set; }
        public ICollection<Series_Actors> Series_Actors { get; private set; }
        public ICollection<Series_Directors> Series_Directors { get; private set; }
        public ICollection<Series_Genres> Series_Genres { get; private set; }

        public Series() { }
        public Series(string title, DateTime release_Date, string overView, string poster_Url, double average_Rating, int mediaTypeId)
        {
            Title = title;
            Release_Date = release_Date;
            OverView = overView;
            Poster_Url = poster_Url;
            Average_Rating = average_Rating;
            MediaTypeId = mediaTypeId;
        }
    }
}