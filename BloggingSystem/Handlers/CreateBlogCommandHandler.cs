using BloggingSystem.Commands;
using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Handlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Blog>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateBlogCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<Blog> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = new Blog { Name = request.Name, Url = request.Url };
            _unitOfWork.Blogs.Add(blog);
            _unitOfWork.Complete();
            return Task.FromResult(blog);
        }
    }
}
