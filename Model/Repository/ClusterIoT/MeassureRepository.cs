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
    public class MeassureRepository : BaseRepository<Meassure>, IMeassureRepository
    {
        public MeassureRepository(IMongoContext mongoContext)
        : base(mongoContext)
        {
        }
    }
}
