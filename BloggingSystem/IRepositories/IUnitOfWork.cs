namespace BloggingSystem.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository Blogs { get; }
        IPostRepository Posts { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
