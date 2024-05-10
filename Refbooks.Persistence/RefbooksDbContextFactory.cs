using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;

namespace Refbooks.Persistence
{
    public class RefbooksDbContextFactory<TContext> : IRefbooksDbContextFactory
        where TContext : DbContext, IRefbooksDbContext
    {
        private readonly IDbContextFactory<TContext> _dbFactory;

        public RefbooksDbContextFactory(IDbContextFactory<TContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }
        

        public async Task<IRefbooksDbContext> CreateDbContextAsync(CancellationToken cancellationToken)
        {
            return await _dbFactory.CreateDbContextAsync(cancellationToken);
        }

       
    }
}
