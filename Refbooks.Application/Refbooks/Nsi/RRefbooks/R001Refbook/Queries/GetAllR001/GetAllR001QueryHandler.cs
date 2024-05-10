
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R001Refbook.Queries.GetAllR001
{
    public class GetAllR001QueryHandler : IRequestHandler<GetAllR001Query, R001[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR001QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R001[]> Handle(GetAllR001Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R001.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R001));
                }

                return result;
            }
        }
    }
}
