using Market.DAL.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.DAL.Repository.Base
{
    public abstract class Repository<TEntity, TEntityId>
        where TEntity : Entity<TEntityId>
    {
        protected readonly AppDbContext context;

        protected Repository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Add(TEntity entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> Get()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetById(TEntityId id)
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
