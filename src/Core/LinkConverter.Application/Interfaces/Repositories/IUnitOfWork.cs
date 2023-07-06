using System;
using System.Threading.Tasks;

namespace LinkConverter.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IConvertedLinkRepository ConvertedLinks { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}