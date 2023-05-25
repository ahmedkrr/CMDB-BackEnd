namespace CMDB_BackEnd.Domain.Data
{
    public class Movie_Genres
    {
        public int Id { get; set; }
        public Genres Genres { get; private set; }     
        public int Genres_Id{ get; private set; }
        public Movie Movie { get; private set; }
        public int Movie_Id { get; private set; }
    }
}
