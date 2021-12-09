using Blog.Core.Data.Repositories;
using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
