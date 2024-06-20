using BloggingSystem.IRepositories;
using BloggingSystem.Models;

namespace BloggingSystem.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context) : base(context) { }
    }
}
