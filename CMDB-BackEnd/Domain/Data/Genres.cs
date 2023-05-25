namespace CMDB_BackEnd.Domain.Data
{
    public class Genres
    {
        public int Genre_Id { get; private set; }  
        public string Genre_Name { get; private set; }
        public ICollection<Movie_Genres> Movie_Genres { get; private set; }
        public ICollection<Series_Genres> Series_Genres { get; private set; }
        public ICollection<TvShow_Genres> TvShow_Genres { get; private set; }

        public Genres(string genre_Name)
        {
            Genre_Name = genre_Name;    
        }
    }
}
