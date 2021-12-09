using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Configurations
{
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Text).IsRequired().HasMaxLength(1000);


            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.CreatedUser).HasMaxLength(1000);

            builder.Property(x => x.ModifiedUser).HasMaxLength(1000);


            builder.HasOne<Article>(x => x.Article).WithMany(c => c.Comments).HasForeignKey(f => f.ArticleId);

            builder.ToTable("Comments");
        }
    }
}
