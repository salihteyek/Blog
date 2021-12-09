using Blog.Core.Data.Repositories;
using Blog.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Blog.Core.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        Task CommitAsync();

        void Commit();
    }
}
