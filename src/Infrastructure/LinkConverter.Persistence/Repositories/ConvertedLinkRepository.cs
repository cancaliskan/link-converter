using LinkConverter.Application.Interfaces;
using LinkConverter.Domain.Entities;
using LinkConverter.Persistence.Context;

namespace LinkConverter.Persistence.Repositories
{
    public class ConvertedLinkRepository : GenericRepository<ConvertedLink>, IConvertedLinkRepository
    {
        public ConvertedLinkRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}