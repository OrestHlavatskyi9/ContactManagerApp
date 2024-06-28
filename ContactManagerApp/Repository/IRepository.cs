namespace ContactManagerApp.Repository
{
    public interface IRepository<T, R> where T : class
    {
        Task<R> CreateAsync(T entity);

        Task<R> UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<List<T>> GetAllAsync();

        Task<T> GetAsync(R id);
    }
}
