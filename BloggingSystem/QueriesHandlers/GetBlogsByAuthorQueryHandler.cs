using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using BloggingSystem.Queries;
using MediatR;

namespace BloggingSystem.QueriesHandlers
{
    public class GetBlogsByAuthorQueryHandler : IRequestHandler<GetBlogsByAuthorQuery, IEnumerable<Blog>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogsByAuthorQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<Blog>> Handle(GetBlogsByAuthorQuery request, CancellationToken cancellationToken)
        {
            var blogs = _unitOfWork.Blogs.GetAll().Where(b => b.Posts.Any(p => p.Id == request.AuthorId));
            return Task.FromResult(blogs);
        }
    }
}
