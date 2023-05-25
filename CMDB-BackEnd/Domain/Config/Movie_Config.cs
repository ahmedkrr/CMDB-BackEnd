using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Movie_Config : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> b)
        {
            b.HasKey(c => c.Movie_Id);
            b.Property(c => c.Title).HasMaxLength(50).IsRequired(true);
            b.HasIndex(c => c.Title).IsUnique(true);

            b.Property(c => c.OverView).HasMaxLength(800).IsRequired(true);
            b.Property(c => c.Release_Date).IsRequired(true);
            b.Property(c => c.Runtime).IsRequired(true);

            b.HasOne(c => c.MediaType).WithOne(c => c.Movie).HasForeignKey<Movie>(c => c.MediaTypeId);



        }
    }
}
