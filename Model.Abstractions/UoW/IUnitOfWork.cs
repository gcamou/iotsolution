using System;
using System.Threading.Tasks;

namespace Model.Abstractions.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}