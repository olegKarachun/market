using Trening.Models.Interfaces;

namespace Trening.Repositories
{
    public interface IGenericRepository<T> where T : IEntity //не менять
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void Update(T entity);
        public void Delete(int id);
        public void Add(T entity);

    }
}
