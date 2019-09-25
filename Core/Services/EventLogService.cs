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

    public class EventLogService : BaseService<EventLog, EventLogBiz, EventLogBiz, EventLogBiz>, IEventLogService
    {
        public EventLogService(IEventLogRepository eventLogRepository, IUnitOfWork unitOfWork)
        : base(eventLogRepository, unitOfWork)
        {
        }
    }
}