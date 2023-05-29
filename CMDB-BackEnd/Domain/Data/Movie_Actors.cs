namespace CMDB_BackEnd.Domain.Data
{
    public class Movie_Actors
    {
        public int Id { get; set; }
        public Actors Actors { get; set; } 
        public int Actors_Id { get; private set; }
        public Movie Movies { get; private set; }
        public int Movies_Id { get; private set; }

        public Movie_Actors()
        {

        }
        public Movie_Actors( int actors_Id, int movies_Id)
        {
            Actors_Id = actors_Id;
            Movies_Id = movies_Id;
        }   
    }
}
