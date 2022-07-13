namespace BackEndAssignment.Interfaces.Repositories
{
    public interface IBaseRepositoryAsync<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Entities { get; }

        Task<TEntity> GetByIdAsync(int id);

        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    

    }
}
