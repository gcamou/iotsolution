
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    using Core.Abstractions.Biz;
    using Core.Abstractions.Extensions;
    using Core.Abstractions.Services;
    using Model.Abstractions.Entities;
    using Model.Abstractions.Repository.ClusterIoT;
    using Model.Abstractions.UoW;

    public class MeassureService : IMeassureService
    {
        private readonly IMeassureRepository _meassureRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MeassureService(IMeassureRepository meassureRepository, IUnitOfWork unitOfWork)
        {
            _meassureRepository = meassureRepository;
            _unitOfWork = unitOfWork;
        }

        public Task AddAsync(MeassureBiz meassureBiz)
        {
            var entity = meassureBiz.ToEntity<MeassureBiz, Meassure>();
            _meassureRepository.Add(entity);

            _unitOfWork.Commit();

            return Task.CompletedTask;
        }

        public Task<IEnumerable<MeassureBiz>> GetAll()
        {

            var list = _meassureRepository.GetAll();
            return list.ToBizAsync<Meassure, MeassureBiz>();
        }

        public Task<MeassureBiz> GetByIdAsync(object id)
        {
            return _meassureRepository.GetById(id).ToBizAsync<Meassure, MeassureBiz>();
        }
    }
}