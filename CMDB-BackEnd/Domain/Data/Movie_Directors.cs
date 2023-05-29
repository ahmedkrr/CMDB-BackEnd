using System.IO;

namespace CMDB_BackEnd.Domain.Data
{
    public class Movie_Directors
    {
        public int Id { get; set; }
        public Directors Directors { get; private set; }
        public int Directors_Id { get; private set; }
        public Movie Movies { get; private set; }
        public int Movies_Id { get; private set; }

        public Movie_Directors()
        {

        }
        public Movie_Directors(int directors_Id, int movies_Id)
        {
            Directors_Id = directors_Id;
            Movies_Id = movies_Id;
        }
    }
}
