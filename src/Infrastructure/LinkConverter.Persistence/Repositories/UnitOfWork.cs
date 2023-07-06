using System.Threading.Tasks;
using LinkConverter.Application.Interfaces;
using LinkConverter.Application.Interfaces.Repositories;
using LinkConverter.Persistence.Context;

namespace LinkConverter.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ConvertedLinks = new ConvertedLinkRepository(_context);
        }

        public IConvertedLinkRepository ConvertedLinks { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}