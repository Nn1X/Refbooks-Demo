
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R013Refbook.Queries.GetAllR013
{
    public class GetAllR013QueryHandler : IRequestHandler<GetAllR013Query, R013[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR013QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R013[]> Handle(GetAllR013Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R013.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R013));
                }

                return result;
            }
        }
    }
}
