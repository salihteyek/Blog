using Blog.Core.Repositories;
using Blog.Data.Repositories.Base;
using Blog.Models;
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
