using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Abstractions.Repository.ClusterIoT
{
    using Model.Abstractions.Entities;
    public interface IMeassureRepository
    {
        void Add(Meassure entity);
        Task<Meassure> GetById(Object id);
        Task<IEnumerable<Meassure>> GetAll();
    }
}