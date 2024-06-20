using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Queries
{
    public class GetBlogPostsQuery : IRequest<IEnumerable<Post>>
    {
        public int BlogId { get; set; }
    }
}
