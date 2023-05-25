using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Series_Actors_Config : IEntityTypeConfiguration<Series_Actors>
    {
        public void Configure(EntityTypeBuilder<Series_Actors> b)
        {
            
            b.HasOne(c => c.Series).WithMany(c => c.Series_Actors).HasForeignKey(c => c.Series_Id);
            b.HasOne(c => c.Actors).WithMany(c => c.Series_Actors).HasForeignKey(c => c.Actors_Id);
        }
    }
}
