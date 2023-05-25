using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class TvShow_Genres_Config : IEntityTypeConfiguration<TvShow_Genres>
    {
        public void Configure(EntityTypeBuilder<TvShow_Genres> b)
        {
          
            b.HasOne(c => c.TvShows).WithMany(c => c.TvShow_Genres).HasForeignKey(c => c.Tvshow_Id);
            b.HasOne(c => c.Genres).WithMany(c => c.TvShow_Genres).HasForeignKey(c => c.Genres_Id);
        }
    }
}
