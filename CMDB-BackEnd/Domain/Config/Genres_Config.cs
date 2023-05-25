using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Genres_Config : IEntityTypeConfiguration<Genres>
    {
        public void Configure(EntityTypeBuilder<Genres> b)
        {
            b.HasKey(c => c.Genre_Id);
            b.Property(p => p.Genre_Name).HasMaxLength(50).IsRequired(true);
                b.HasIndex(p => p.Genre_Name);


        }
    }
}
