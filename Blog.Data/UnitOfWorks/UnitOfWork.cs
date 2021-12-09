using Blog.Core.Data.Repositories;
using Blog.Core.Repositories;
using Blog.Core.UnitOfWorks;
using Blog.Data.Repositories;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _context;

        private ArticleRepository _articleRepository;
        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;

        public UnitOfWork(BlogDbContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _articleRepository = _articleRepository ?? new ArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository = _commentRepository ?? new CommentRepository(_context);

        public IRoleRepository Roles => _roleRepository = _roleRepository ?? new RoleRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
