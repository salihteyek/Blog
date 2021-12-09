using Blog.Core.Repositories;
using Blog.Domain.Models;
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
