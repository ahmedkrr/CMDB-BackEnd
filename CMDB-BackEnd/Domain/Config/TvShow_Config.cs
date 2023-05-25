using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class TvShow_Config : IEntityTypeConfiguration<TvShows>
    {
        public void Configure(EntityTypeBuilder<TvShows> b)
        {
            b.HasKey(c => c.Tvshow_Id);
            b.Property(c => c.Title).HasMaxLength(50).IsRequired(true);
            b.HasIndex(c => c.Title).IsUnique(true);

            b.Property(c => c.OverView).HasMaxLength(800).IsRequired(true);
            b.Property(c => c.Release_Date).IsRequired(true);

            b.HasOne(c => c.MediaType).WithOne(c => c.TvShows).HasForeignKey<TvShows>(c => c.MediaTypeId);
        }
    }
}
