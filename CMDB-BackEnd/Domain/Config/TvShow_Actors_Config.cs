using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class TvShow_Actors_Config : IEntityTypeConfiguration<TvShow_Actors>
    {
        public void Configure(EntityTypeBuilder<TvShow_Actors> b)
        {
           
            b.HasOne(c => c.TvShows).WithMany(c => c.TvShow_Actors).HasForeignKey(c => c.Tvshow_Id);
            b.HasOne(c => c.Actors).WithMany(c => c.TvShow_Actors).HasForeignKey(c => c.Actors_Id);
        }
    }
}
