using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Commands
{
    public class CreateBlogCommand : IRequest<Blog>
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
