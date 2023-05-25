using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain
{
    public class Actors_Config : IEntityTypeConfiguration<Actors>
    {
        public void Configure(EntityTypeBuilder<Actors> b)
        {
            b.HasKey(c => c.Actors_Id);
            b.Property(p => p.Actors_Name).HasMaxLength(100).IsRequired(true);
            b.HasIndex(p => p.Actors_Name).IsUnique(true);

            b.Property(p => p.Date_of_Birdth).IsRequired(true);
            b.Property(p => p.Biography).HasMaxLength(800).IsRequired(true);
        }
    }
}
