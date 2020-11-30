using QuickBy.Dominio.Contracts;
using System;
using System.Collections.Generic;

namespace QuickBy.Repositorio
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    { 
        public BaseRepository()
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
