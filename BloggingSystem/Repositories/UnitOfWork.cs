using BloggingSystem.IRepositories;
using BloggingSystem.Models;

namespace BloggingSystem.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Blogs = new BlogRepository(_context);
            Posts = new PostRepository(_context);
            Authors = new AuthorRepository(_context);
        }
        public IBlogRepository Blogs { get; }
        public IPostRepository Posts { get; }
        public IAuthorRepository Authors { get; }
        public int Complete() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();
    }
}
