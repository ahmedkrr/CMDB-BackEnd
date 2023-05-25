using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class TvShow_Directors_Config : IEntityTypeConfiguration<TvShow_Directors>
    {
        public void Configure(EntityTypeBuilder<TvShow_Directors> b)
        {
            
            b.HasOne(p => p.TvShows).WithMany(p => p.TvShow_Directors).HasForeignKey(p => p.Tvshow_Id);
            b.HasOne(p => p.Directors).WithMany(p => p.TvShow_Directors).HasForeignKey(p => p.Directors_Id);

        }
    }
}
