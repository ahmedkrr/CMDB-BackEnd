namespace CMDB_BackEnd.Domain.Data
{
    public class TvShow_Directors
    {
        public int Id { get; set; }
        public Directors Directors { get; set; }
        public int Directors_Id { get; private set; }
        public TvShows TvShows { get; private set; }
        public int Tvshow_Id { get; private set; }
    }
}
