namespace Trening.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void Update(T entity);
        public void Delete(int id);
        public void Add(T entity);

    }
}
