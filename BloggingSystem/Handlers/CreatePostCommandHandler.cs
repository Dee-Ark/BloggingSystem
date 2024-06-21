using BloggingSystem.Commands;
using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Handlers
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreatePostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post
            {
                Title = request.Title,
                Content = request.Content,
                DatePublished = request.DatePublished,
                BlogId = request.BlogId,
                Id = request.AuthorId
            };
            _unitOfWork.Posts.Add(post);
            _unitOfWork.Complete();
            return Task.FromResult(post);
        }
    }
}
