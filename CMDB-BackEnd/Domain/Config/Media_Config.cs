using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Media_Config : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> b)
        {
            b.HasKey(c => c.Media_TypeId);
            b.Property(c => c.Media_Type_Name).HasMaxLength(50).IsRequired(true);
            b.HasIndex(c => c.Media_Type_Name).IsUnique(true);
        }
    }
}
