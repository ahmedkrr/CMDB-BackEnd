namespace CMDB_BackEnd.Domain.Data
{
    public class Series_Directors
    {
        public int Id { get; set; }
        public Directors  Directors { get; private set; }
        public int  Directors_Id{ get; private set; }
        public Series Series { get; private set; }
        public int Series_Id { get; private set; }
        public Series_Directors() { }
        public Series_Directors(int directors_Id, int series_Id)
        {
            Directors_Id= directors_Id;
            Series_Id= series_Id;
        }
    }
}
