
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R003Refbook.Queries.GetAllR003
{
    public class GetAllR003QueryHandler : IRequestHandler<GetAllR003Query, R003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R003[]> Handle(GetAllR003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R003.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R003));
                }

                return result;
            }
        }
    }
}
