namespace BackEndAssignment.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        public IEnumerable<T> Get();

        public T Get(int id);

        public T Add(T entity);
        public T Update(T entity);
        public T Delete(int id);
    }
}
