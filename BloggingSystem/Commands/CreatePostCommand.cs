using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Commands
{
    public class CreatePostCommand : IRequest<Post>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
    }
}
