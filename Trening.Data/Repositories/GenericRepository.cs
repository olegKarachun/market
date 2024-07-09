
using Microsoft.EntityFrameworkCore;
using Trening.Data;
using Trening.DB;
using Trening.Models.Interfaces;
using Trening.Repositories.Interfaces;

namespace Trening.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IEntity //не менять
    {

        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _entity;
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entity = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _entity.Find(id);
            if (entity != null)
            {
                _entity.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            return _entity.ToList();
        }

        public T GetById(int id)
        {
            return _entity.Find(id);
        }

        public void Update(T entity)
        {
            var updatingEntity = entity;
            _entity.Update(updatingEntity);
            _dbContext.SaveChanges();
        }
    }
}
