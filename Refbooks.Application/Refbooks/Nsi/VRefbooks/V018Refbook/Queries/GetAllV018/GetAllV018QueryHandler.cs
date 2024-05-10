
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetAllV018
{
    public class GetAllV018QueryHandler : IRequestHandler<GetAllV018Query, V018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllV018QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V018[]> Handle(GetAllV018Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.V018.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(V018));
                }

                return result;
            }
        }
    }
}
