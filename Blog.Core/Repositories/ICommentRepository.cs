using Blog.Core.Data.Repositories;
using Blog.Domain.Models;

namespace Blog.Core.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
    }
}
