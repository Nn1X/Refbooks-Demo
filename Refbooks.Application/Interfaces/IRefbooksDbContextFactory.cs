namespace Refbooks.Application.Interfaces
{
    public interface IRefbooksDbContextFactory
    {
        public Task<IRefbooksDbContext> CreateDbContextAsync(CancellationToken cancellationToken);
        
    }
}
