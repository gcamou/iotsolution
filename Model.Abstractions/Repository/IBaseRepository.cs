using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Abstractions.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable 
    where TEntity : class
    {
        void Add(TEntity entity);
        Task<TEntity> GetById(Object id);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity entity);
    }
}