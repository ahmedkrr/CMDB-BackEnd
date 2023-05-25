using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Series_Directors_Config : IEntityTypeConfiguration<Series_Directors>
    {
        public void Configure(EntityTypeBuilder<Series_Directors> b)
        {
            b.HasOne(p => p.Series).WithMany(p => p.Series_Directors).HasForeignKey(p => p.Series_Id);
            b.HasOne(p => p.Directors).WithMany(p => p.Series_Directors).HasForeignKey(p => p.Directors_Id);

        }
    }
}
