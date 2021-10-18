using Adapters.SqlServer.Contexts;
using Clinica.Domain.Interfaces.Adapters.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.SqlServer.Repositories
{
    public abstract class BaseRepository<TEntity, Tkey> : IBaseRepository<TEntity, Tkey>
        where TEntity : class
        where Tkey : struct
    {
        private readonly SqlServerContext _context;

        protected BaseRepository(SqlServerContext context)
        {
            _context = context;
        }

        public void Create(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Tkey key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
