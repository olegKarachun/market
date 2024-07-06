namespace Trening.Services.Interfaces
{
    public interface IGenericService<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void Update(T entity);
        public void Delete(int id);
    }
}
