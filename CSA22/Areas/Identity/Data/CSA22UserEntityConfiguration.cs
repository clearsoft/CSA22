using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSA22.Areas.Identity.Data
{
    internal class CSA22UserEntityConfiguration : IEntityTypeConfiguration<CSA22User>
    {
        public void Configure(EntityTypeBuilder<CSA22User> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);
        }
    }
}