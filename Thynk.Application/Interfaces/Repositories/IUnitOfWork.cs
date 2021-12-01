using System;
using System.Threading.Tasks;

namespace Thynk.Covid19Pcr.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : class;
        Task<int> CommitAsync();
        void RollBack();
    }
}
