namespace Core.Services
{
    using Core.Abstractions.Biz;
    using Core.Abstractions.Services;
    using Model.Abstractions.Entities;
    using Model.Abstractions.Repository;
    using Model.Abstractions.UoW;

    public class EventLogService : BaseService<EventLog, EventLogBiz, EventLogBiz, EventLogBiz>, IEventLogService
    {
        private readonly IBaseRepository<EventLog> _baseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EventLogService(IBaseRepository<EventLog> baseRepository, IUnitOfWork unitOfWork)
        :base(baseRepository, unitOfWork)
        {
            _baseRepository = baseRepository;
            _unitOfWork = unitOfWork;
        }
    }
}