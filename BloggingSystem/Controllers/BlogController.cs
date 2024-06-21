using BloggingSystem.Commands;
using BloggingSystem.IRepositories;
using BloggingSystem.Models;
using BloggingSystem.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddBlog")]
        public async Task<IActionResult> AddBlog(CreateBlogCommand command)
        {
            var blog = await _mediator.Send(command);
            return Ok(blog);
        }

        [HttpPost("AddPost")]
        public async Task<IActionResult> AddPost(CreatePostCommand command)
        {
            var post = await _mediator.Send(command);
            return Ok(post);
        }

        [HttpPost("RegisterAuthor")]
        public async Task<IActionResult> RegisterAuthor(RegisterAuthorCommand command)
        {
            var author = await _mediator.Send(command);
            return Ok(author);
        }

        [HttpGet("GetPostsByBlog/{blogId}")]
        public async Task<IActionResult> GetPostsByBlog(int blogId)
        {
            var query = new GetBlogPostsQuery { BlogId = blogId };
            var posts = await _mediator.Send(query);
            return Ok(posts);
        }

        [HttpGet("GetBlogsByAuthor/{authorId}")]
        public async Task<IActionResult> GetBlogsByAuthor(int authorId)
        {
            var query = new GetBlogsByAuthorQuery { AuthorId = authorId };
            var blogs = await _mediator.Send(query);
            return Ok(blogs);
        }
    }
}
