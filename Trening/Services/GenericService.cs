﻿using Trening.Repositories.Interfaces;
using Trening.Services.Interfaces;

namespace Trening.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
