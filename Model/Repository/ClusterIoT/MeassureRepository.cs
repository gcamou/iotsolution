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
    public class MeassureRepository : IMeassureRepository
    {
        protected readonly IMongoContext _mongoContext;
        protected readonly IMongoCollection<Meassure> DbSet;
        public MeassureRepository(IMongoContext mongoContext)
        {
            _mongoContext = mongoContext;
            DbSet = _mongoContext.GetCollection<Meassure>(typeof(Meassure).Name);
        }

        public virtual void Add(Meassure obj)
        {
            _mongoContext.AddCommand(() => DbSet.InsertOneAsync(obj));
        }

        public virtual async Task<Meassure> GetById(Object id)
        {
            var data = await DbSet.FindAsync(Builders<Meassure>.Filter.Eq("_id", id));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<Meassure>> GetAll()
        {
            var all = await DbSet.FindAsync(Builders<Meassure>.Filter.Empty);
            return all.ToList();
        }
        public void Dispose()
        {
            _mongoContext?.Dispose();
        }
    }
}
