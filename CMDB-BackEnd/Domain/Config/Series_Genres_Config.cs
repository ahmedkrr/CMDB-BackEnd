using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Series_Genres_Config : IEntityTypeConfiguration<Series_Genres>
    {
        public void Configure(EntityTypeBuilder<Series_Genres> b)
        {
           
            b.HasOne(c => c.Series).WithMany(c => c.Series_Genres).HasForeignKey(c => c.Series_Id);
            b.HasOne(c => c.Genres).WithMany(c => c.Series_Genres).HasForeignKey(c => c.Genres_Id);
        }
    }
}
