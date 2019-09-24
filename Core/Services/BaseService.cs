using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    using Core.Abstractions.Biz;
    using Core.Abstractions.Extensions;
    using Core.Abstractions.Services;
    using Model.Abstractions.Repository;
    using Model.Abstractions.UoW;

    public abstract class BaseService<TEntity, TEntityBiz, TEntityCreateBiz, TEntityUpdateBiz> : IBaseService<TEntity, TEntityBiz, TEntityCreateBiz, TEntityUpdateBiz>
    where TEntity : class, new()
    where TEntityBiz : IBiz
    where TEntityCreateBiz : IBiz
    where TEntityUpdateBiz : IBiz
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BaseService(IBaseRepository<TEntity> baseRepository, IUnitOfWork unitOfWork)
        {
            _baseRepository = baseRepository;
            _unitOfWork = unitOfWork;
        }
        public virtual Task AddAsync(TEntityCreateBiz entityCreateBiz)
        {
            var entity = entityCreateBiz.ToEntity<TEntityCreateBiz, TEntity>();
            _baseRepository.Add(entity);

            return Task.CompletedTask;
        }

        public virtual Task<IEnumerable<TEntityBiz>> GetAll()
        {
            var list = _baseRepository.GetAll();
            return list.ToBizAsync<TEntity, TEntityBiz>();
        }

        public virtual Task<TEntityBiz> GetByIdAsync(Object id)
        {
            return _baseRepository.GetById(id).ToBizAsync<TEntity, TEntityBiz>();
        }

        public virtual Task UpdateAsync(TEntityUpdateBiz entityUpdateBiz)
        {
            var entity = entityUpdateBiz.ToEntity<TEntityUpdateBiz, TEntity>();
            _baseRepository.Add(entity);

            return Task.CompletedTask;
        }
    }
}