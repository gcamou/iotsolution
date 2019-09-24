namespace Core.Abstractions.Services
{
    using Core.Abstractions.Biz;
    using Model.Abstractions.Entities;
    public interface IMeassureService : IBaseService<Meassure, MeassureBiz, MeassureBiz, MeassureBiz>
    {
    }
}