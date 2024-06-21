using BloggingSystem.IRepositories;
using BloggingSystem.Models;

namespace BloggingSystem.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext context) : base(context) { }
    }
}
