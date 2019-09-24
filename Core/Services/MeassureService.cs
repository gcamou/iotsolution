namespace Core.Services
{
    using Core.Abstractions.Biz;
    using Core.Abstractions.Services;
    using Model.Abstractions.Entities;
    using Model.Abstractions.Repository;
    using Model.Abstractions.UoW;

    public class MeassureService : BaseService<Meassure, MeassureBiz, MeassureBiz, MeassureBiz>, IMeassureService
    {
        private readonly IBaseRepository<Meassure> _baseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MeassureService(IBaseRepository<Meassure> baseRepository, IUnitOfWork unitOfWork)
        : base(baseRepository, unitOfWork)
        {
            _baseRepository = baseRepository;
            _unitOfWork = unitOfWork;
        }
    }
}