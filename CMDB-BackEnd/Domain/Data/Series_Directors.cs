namespace CMDB_BackEnd.Domain.Data
{
    public class Series_Directors
    {
        public int Id { get; set; }
        public Directors  Directors { get; private set; }
        public int  Directors_Id{ get; private set; }
        public Series Series { get; private set; }
        public int Series_Id { get; private set; }
    }
}
