namespace CMDB_BackEnd.Domain.Data
{
    public class Series_Genres
    {
        public int Id { get; set; }
        public Genres Genres { get; private set; }
        public int Genres_Id { get; private set; }
        public Series Series { get; private set; }
        public int Series_Id { get; private set; }
    }
}
