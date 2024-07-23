using AutoMapper;
using Market.BLL.Models.Base;
using Market.DAL.Models.Base;
using Market.DAL.Repository.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.BLL.Service.Base
{
    public abstract class GenericService<TBusiness, TBusinessId, TEntity, TEntityId>
        where TBusiness : BusinessEntity<TBusinessId>
        where TEntity : Entity<TEntityId>
    {
        protected readonly Repository<TEntity, TEntityId> repository;
        protected readonly IMapper mapper;

        protected GenericService(Repository<TEntity, TEntityId> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task Add(TBusiness businessEntity)
        {
            var entity = mapper.Map<TEntity>(businessEntity);
            await repository.Add(entity);
        }

        public async Task Delete(TBusinessId id)
        {
            var entity = await repository.GetById(MapToEntityId(id));
            if (entity != null)
            {
                await repository.Delete(entity);
            }
        }

        public async Task Update(TBusiness businessEntity)
        {
            var entity = mapper.Map<TEntity>(businessEntity);
            await repository.Update(entity);
        }

        public async Task<List<TBusiness>> GetAll()
        {
            var entities = await repository.Get();
            return mapper.Map<List<TBusiness>>(entities);
        }

        public async Task<TBusiness> GetById(TBusinessId id)
        {
            var entity = await repository.GetById(MapToEntityId(id));
            return mapper.Map<TBusiness>(entity);
        }

        protected abstract TEntityId MapToEntityId(TBusinessId businessId);
    }
}
