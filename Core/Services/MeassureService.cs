
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

    public class MeassureService : BaseService<Meassure, MeassureBiz, MeassureBiz, MeassureBiz>, IMeassureService
    {
        public MeassureService(IMeassureRepository meassureRepository, IUnitOfWork unitOfWork)
        : base(meassureRepository, unitOfWork)
        {
        }
    }
}