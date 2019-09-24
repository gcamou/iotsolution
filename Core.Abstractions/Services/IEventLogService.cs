using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    using Core.Abstractions.Biz;
    public interface IEventLogService
    {
        Task AddAsync(EventLogBiz eventLogBiz);
        Task<EventLogBiz> GetByIdAsync(Object id);
        Task<IEnumerable<EventLogBiz>> GetAll();
    }
}