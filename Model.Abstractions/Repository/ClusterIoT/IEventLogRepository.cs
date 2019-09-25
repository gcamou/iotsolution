using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Abstractions.Repository.ClusterIoT
{
    using Model.Abstractions.Entities;
    public interface IEventLogRepository : IBaseRepository<EventLog>
    {
    }
}