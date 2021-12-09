using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Text;

namespace Blog.Data.Seeds
{
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { 
                    Id = 1,
                    FullName = "Salih Teyek",
                    Email = "salihteyek@hotmail.com",
                    PasswordHash = Encoding.ASCII.GetBytes("e10adc3949ba59abbe56e057f20f883e"),
                    UserName = "salihteyek",
                    ImagePateh="",
                    Description = "",
                    IsActive = true, 
                    RoleId = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedUser = "system",
                    ModifiedUser = "system"
                }
            );
        }
    }
}
