namespace CMDB_BackEnd.Domain.Data
{
    public class Directors
    {
        public int Directors_Id { get; private set; }
        public string Directors_Name { get; private set; }
        public ICollection<Movie_Directors>? Movie_Directors { get; private set; }
        public ICollection<Series_Directors>? Series_Directors { get; private set; }
        public ICollection<TvShow_Directors>? TvShow_Directors { get; private set; }


        public Directors(string Directors_Name)
        {
            this.Directors_Name = Directors_Name;
        }


    }
}
