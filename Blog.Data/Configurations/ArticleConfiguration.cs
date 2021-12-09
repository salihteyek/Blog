using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(1000);
            
            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(1000);

            builder.Property(x => x.Date).IsRequired().HasDefaultValue(DateTime.Now);


            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.CreatedUser).HasMaxLength(1000);

            builder.Property(x => x.ModifiedUser).HasMaxLength(1000);


            builder.HasOne<Category>(x => x.Category).WithMany(c => c.Articles).HasForeignKey(f => f.CategoryId);

            builder.HasOne<User>(x => x.User).WithMany(c => c.Articles).HasForeignKey(f => f.UserId);

            builder.ToTable("Articles");
        }
    }
}
