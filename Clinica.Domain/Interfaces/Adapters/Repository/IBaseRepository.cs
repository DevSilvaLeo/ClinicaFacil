﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Interfaces.Adapters.Repository
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable
        where TEntity : class
        where TKey : struct
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> GetAll();
        TEntity GetById(TKey key);
    }
}
