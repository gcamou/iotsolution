using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    using Core.Abstractions.Biz;
    public interface IMeassureService
    {
        Task AddAsync(MeassureBiz meassureBiz);
        Task<MeassureBiz> GetByIdAsync(Object id);
        Task<IEnumerable<MeassureBiz>> GetAll();
    }
}