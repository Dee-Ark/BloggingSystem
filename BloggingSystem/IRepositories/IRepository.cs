namespace BloggingSystem.IRepositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
