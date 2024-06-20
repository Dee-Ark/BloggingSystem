using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using BloggingSystem.Queries;
using MediatR;

namespace BloggingSystem.QueriesHandlers
{
    public class GetBlogPostsQueryHandler : IRequestHandler<GetBlogPostsQuery, IEnumerable<Post>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBlogPostsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<Post>> Handle(GetBlogPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = _unitOfWork.Posts.GetAll().Where(p => p.BlogId == request.BlogId);
            return Task.FromResult(posts);
        }
    }
}
