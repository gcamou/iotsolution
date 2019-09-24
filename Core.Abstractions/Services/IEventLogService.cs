namespace Core.Abstractions.Services
{
    using Core.Abstractions.Biz;
    using Model.Abstractions.Entities;
    public interface IEventLogService : IBaseService<EventLog, EventLogBiz, EventLogBiz, EventLogBiz>
    {
    }
}