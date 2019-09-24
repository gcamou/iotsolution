namespace Model.Repository.ClosterIoT
{
    using Model.Abstractions.Context;
    using Model.Abstractions.Entities;
    using Model.Abstractions.Repository.ClusterIoT;
    public class EventLogRepository : BaseRepository<EventLog>, IEventLogRepository
    {
        public EventLogRepository(IMongoContext mongoContext) : base(mongoContext)
        {
        }
    }
}