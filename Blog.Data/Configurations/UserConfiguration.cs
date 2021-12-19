using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);

            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("bytea");

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(100);

            builder.Property(x => x.ImagePateh).HasMaxLength(1000);

            builder.Property(x => x.Description).HasMaxLength(10000);


            builder.Property(x => x.Description).HasMaxLength(1000);

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.CreatedUser).HasMaxLength(1000);

            builder.Property(x => x.ModifiedUser).HasMaxLength(1000);


            builder.HasOne<Role>(x => x.Role).WithMany(u => u.Users).HasForeignKey(f => f.RoleId);


            builder.ToTable("Users");
        }
    }
}
