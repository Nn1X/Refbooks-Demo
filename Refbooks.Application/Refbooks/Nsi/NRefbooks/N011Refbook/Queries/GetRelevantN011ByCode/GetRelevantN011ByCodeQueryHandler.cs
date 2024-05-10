
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetRelevantN011ByCode
{
    public class GetRelevantN011ByCodeQueryHandler : IRequestHandler<GetRelevantN011ByCodeQuery, N011>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN011ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N011> Handle(GetRelevantN011ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N011.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N011), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
