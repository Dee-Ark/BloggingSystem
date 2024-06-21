using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Queries
{
    public class GetBlogsByAuthorQuery : IRequest<IEnumerable<Blog>>
    {
        public int AuthorId { get; set; }
    }
}
