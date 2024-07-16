namespace Trening.BLL.Services
{
    public interface IGenericService<T> where T : IBusinessEntity //dont change
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void Update(T entity);
        public void Delete(int id);
    }
}
