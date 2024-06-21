using BloggingSystem.Commands;
using BloggingSystem.Handlers;
using BloggingSystem.Models;
using BloggingSystem.Repositories;
using FluentAssertions;
using Xunit;

namespace BloggingSystem.UnitTest
{
    public class CreateBlogCommandHandlerTests
    {
        private readonly ApplicationDbContext _context;
        private readonly CreateBlogCommandHandler _handler;

        public CreateBlogCommandHandlerTests()
        {
            _context = ApplicationBloggingContextFactory.Create();
            var unitOfWork = new UnitOfWork(_context);
            _handler = new CreateBlogCommandHandler(unitOfWork);
        }

        [Fact]
        public async Task Handle_Should_Add_Blog()
        {
            var command = new CreateBlogCommand { Name = "Test Blog", Url = "http://testblog.com" };
            var result = await _handler.Handle(command, CancellationToken.None);

            var savedBlog = _context.Blogs.Find(result.Id);
            savedBlog.Should().NotBeNull();
            savedBlog.Name.Should().Be("Test Blog");
        }
    }
}
