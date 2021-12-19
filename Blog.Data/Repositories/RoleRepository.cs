using Blog.Core.Repositories;
using Blog.Data.Repositories.Base;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
