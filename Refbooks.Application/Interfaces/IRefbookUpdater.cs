namespace Refbooks.Application.Interfaces
{
    public interface IRefbookUpdater
    {
        public Task<IEnumerable<string>> UpdateRefbooksAsync(IEnumerable<string> refbooks);
    }
}
