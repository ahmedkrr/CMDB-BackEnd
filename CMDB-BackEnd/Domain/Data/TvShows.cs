namespace CMDB_BackEnd.Domain.Data
{
    public class TvShows
    {
        public int Tvshow_Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Release_Date { get; private set; }
        public string OverView { get; private set; }
        public string Poster_Url { get; private set; }
        public double Average_Rating { get; private set; }
        public MediaType MediaType { get; private set; }
        public int MediaTypeId { get; private set; }
        public ICollection<TvShow_Actors> TvShow_Actors { get; private set; }
        public ICollection<TvShow_Directors> TvShow_Directors { get; private set; }
        public ICollection<TvShow_Genres> TvShow_Genres { get; private set; }
    }
}
