using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Description).HasMaxLength(1000);


            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.CreatedUser).HasMaxLength(1000);

            builder.Property(x => x.ModifiedUser).HasMaxLength(1000);


            builder.ToTable("Roles");
        }
    }
}
