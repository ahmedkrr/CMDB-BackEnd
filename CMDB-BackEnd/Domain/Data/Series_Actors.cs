namespace CMDB_BackEnd.Domain.Data
{
    public class Series_Actors
    {
        public int Id { get; set; }
        public Actors Actors { get; private set; }
        public int Actors_Id { get; private set; }
        public Series Series { get; private set; }
        public int Series_Id { get; private set; }

        public Series_Actors() { }

        public Series_Actors(int actors_Id, int series_Id)
        {
            Actors_Id = actors_Id;
            Series_Id = series_Id;
        }
    }
    

}
