using BloggingSystem.IRepositories;
using BloggingSystem.Models;

namespace BloggingSystem.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(T entity) => _context.Set<T>().Add(entity);
        public void Remove(T entity) => _context.Set<T>().Remove(entity);
        public T Get(int id) => _context.Set<T>().Find(id);
        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
        
    }
}
