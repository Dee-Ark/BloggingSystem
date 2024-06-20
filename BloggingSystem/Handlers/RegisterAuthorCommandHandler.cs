using BloggingSystem.Commands;
using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Handlers
{
    public class RegisterAuthorCommandHandler : IRequestHandler<RegisterAuthorCommand, Author>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegisterAuthorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<Author> Handle(RegisterAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = new Author { Name = request.Name, Email = request.Email };
            _unitOfWork.Authors.Add(author);
            _unitOfWork.Complete();
            return Task.FromResult(author);
        }
    }
}
