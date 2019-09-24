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

    public class EventLogService : IEventLogService
    {
        private readonly IEventLogRepository _eventLogRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EventLogService(IEventLogRepository eventLogRepository, IUnitOfWork unitOfWork)
        {
            _eventLogRepository = eventLogRepository;
            _unitOfWork = unitOfWork;
        }

        public Task AddAsync(EventLogBiz eventLogBiz)
        {
            var entity = eventLogBiz.ToEntity<EventLogBiz, EventLog>();
            
            _eventLogRepository.Add(entity);
            
            _unitOfWork.Commit();

            return Task.CompletedTask;
        }

        public Task<IEnumerable<EventLogBiz>> GetAll()
        {

            var list = _eventLogRepository.GetAll();
            return list.ToBizAsync<EventLog, EventLogBiz>();
        }

        public Task<EventLogBiz> GetByIdAsync(object id)
        {
            return _eventLogRepository.GetById(id).ToBizAsync<EventLog, EventLogBiz>();
        }
    }
}