using MongoDB.Driver;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model.Repository.ClosterIoT
{
    using Model.Abstractions.Context;
    using Model.Abstractions.Entities;
    using Model.Abstractions.Repository.ClusterIoT;
    public class EventLogRepository : IEventLogRepository
    {
        protected readonly IMongoContext _mongoContext;
        protected readonly IMongoCollection<EventLog> DbSet;
        public EventLogRepository(IMongoContext mongoContext)
        {
            _mongoContext = mongoContext;
            DbSet = _mongoContext.GetCollection<EventLog>(typeof(EventLog).Name);
        }

        public virtual void Add(EventLog obj)
        {
            _mongoContext.AddCommand(() => DbSet.InsertOneAsync(obj));
        }

        public virtual async Task<EventLog> GetById(Object id)
        {
            var data = await DbSet.FindAsync(Builders<EventLog>.Filter.Eq("CodeId", id));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<EventLog>> GetAll()
        {
            var all = await DbSet.FindAsync(Builders<EventLog>.Filter.Empty);
            return all.ToList();
        }
        public void Dispose()
        {
            _mongoContext?.Dispose();
        }
    }
}