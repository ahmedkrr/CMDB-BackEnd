namespace CMDB_BackEnd.Domain.Data
{
    public class Actors
    {
        public int Actors_Id { get; private set; }
        public  string Actors_Name { get; private set; } 
        public DateTime Date_of_Birdth { get; private set; }
        public string Biography { get; private set; }
        public string Profile_Pic { get; private set; }
        public ICollection<Movie_Actors> Movie_Actors { get; private set; }
        public ICollection<Series_Actors> Series_Actors { get; private set; }
        public ICollection<TvShow_Actors> TvShow_Actors { get; private set; }

        public Actors(string actors_Name, DateTime date_of_Birdth, string biography, string profile_Pic)
        {
            Actors_Name = actors_Name;
            Date_of_Birdth = date_of_Birdth;
            Biography = biography;
            Profile_Pic = profile_Pic;
        }

    }
}
