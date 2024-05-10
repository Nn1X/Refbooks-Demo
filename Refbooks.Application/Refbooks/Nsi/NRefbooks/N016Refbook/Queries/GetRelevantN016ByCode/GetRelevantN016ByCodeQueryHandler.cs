
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N016Refbook.Queries.GetRelevantN016ByCode
{
    public class GetRelevantN016ByCodeQueryHandler : IRequestHandler<GetRelevantN016ByCodeQuery, N016>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN016ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N016> Handle(GetRelevantN016ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N016.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N016), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
