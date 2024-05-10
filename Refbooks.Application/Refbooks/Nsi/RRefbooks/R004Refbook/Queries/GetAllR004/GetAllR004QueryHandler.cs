
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R004Refbook.Queries.GetAllR004
{
    public class GetAllR004QueryHandler : IRequestHandler<GetAllR004Query, R004[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR004QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R004[]> Handle(GetAllR004Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R004.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R004));
                }

                return result;
            }
        }
    }
}
