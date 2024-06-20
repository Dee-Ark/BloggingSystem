using BloggingSystem.IRepositories;
using BloggingSystem.Models;

namespace BloggingSystem.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context) { }
    }
}
