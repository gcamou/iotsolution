using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    using Core.Abstractions.Biz;
    public interface IBaseService<TEntity, TEntityBiz, TEntityCreateBiz, TEntityUpdateBiz>
    where TEntity : class, new()
    where TEntityBiz : IBiz
    where TEntityCreateBiz : IBiz
    where TEntityUpdateBiz : IBiz
    {
        Task AddAsync(TEntityCreateBiz entityCreate);
        Task UpdateAsync(TEntityUpdateBiz entityUpdate);
        Task<TEntityBiz> GetByIdAsync(Object id);
        Task<IEnumerable<TEntityBiz>> GetAll();
    }
}