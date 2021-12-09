using Blog.Core.Repositories;
using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
