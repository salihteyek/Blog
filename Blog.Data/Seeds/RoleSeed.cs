using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Seeds
{
    internal class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role 
                { 
                    Id = 1, 
                    Name = "Admin", 
                    Description="Admin tüm yetkilere sahiptir.", 
                    IsActive = true, 
                    IsDeleted = false,
                    CreatedUser = "System",
                    CreatedDate = DateTime.Now,
                    ModifiedUser = "System",
                    ModifiedDate = DateTime.Now,
                }
            );
        }
    }
}
