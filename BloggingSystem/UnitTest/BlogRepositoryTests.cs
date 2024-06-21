using BloggingSystem.Models;
using BloggingSystem.Repositories;
using FluentAssertions;
using Xunit;

namespace BloggingSystem.UnitTest
{
    public class BlogRepositoryTests
    {
        private readonly ApplicationDbContext _context;
        private readonly BlogRepository _repository;

        public BlogRepositoryTests()
        {
            _context = ApplicationBloggingContextFactory.Create();
            _repository = new BlogRepository(_context);
        }

        [Fact]
        public void Add_Should_Add_Blog()
        {
            var blog = new Blog { Name = "Test Blog", Url = "http://testblog.com" };
            _repository.Add(blog);
            _context.SaveChanges();

            var savedBlog = _context.Blogs.Find(blog.Id);
            savedBlog.Should().NotBeNull();
            savedBlog.Name.Should().Be("Test Blog");
        }
    }
}
