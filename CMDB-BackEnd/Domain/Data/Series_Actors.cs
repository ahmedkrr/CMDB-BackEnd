namespace CMDB_BackEnd.Domain.Data
{
    public class Series_Actors
    {
        public int Id { get; set; }
        public Actors Actors { get; private set; }
        public int Actors_Id { get; private set; }
        public Series Series { get; private set; }
        public int Series_Id { get; private set; }

    }
}
