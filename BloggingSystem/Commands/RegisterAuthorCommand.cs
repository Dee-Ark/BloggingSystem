using BloggingSystem.Models;
using MediatR;

namespace BloggingSystem.Commands
{
    public class RegisterAuthorCommand : IRequest<Author>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
