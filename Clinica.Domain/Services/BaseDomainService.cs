using Clinica.Domain.Interfaces.Adapters.Repository;
using Clinica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Services
{
    public class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        private readonly IBaseRepository<TEntity, TKey> _repository;

        public BaseDomainService(IBaseRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public void Create(TEntity obj)
        {
            _repository.Create(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(TKey key)
        {
            return _repository.GetById(key);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
