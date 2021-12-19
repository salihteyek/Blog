using Blog.Core.Repositories;
using Blog.Data.Repositories.Base;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
