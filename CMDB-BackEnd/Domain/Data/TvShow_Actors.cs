namespace CMDB_BackEnd.Domain.Data
{
    public class TvShow_Actors
    {
        public int Id { get; set; }
        public Actors Actors { get; set; }
        public int Actors_Id { get; private set; }
        public TvShows TvShows { get; private set; }
        public int Tvshow_Id { get; private set; }
    }
}
