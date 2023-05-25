namespace CMDB_BackEnd.Domain.Data
{
    public class TvShow_Genres
    {
        public int Id { get; set; }
        public Genres Genres { get; private set; }
        public int Genres_Id { get; private set; }
        public TvShows TvShows { get; private set; }
        public int Tvshow_Id { get; private set; }
    }
}
