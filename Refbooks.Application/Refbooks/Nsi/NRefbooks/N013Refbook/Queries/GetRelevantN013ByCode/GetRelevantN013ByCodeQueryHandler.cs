
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N013Refbook.Queries.GetRelevantN013ByCode
{
    public class GetRelevantN013ByCodeQueryHandler : IRequestHandler<GetRelevantN013ByCodeQuery, N013>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN013ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N013> Handle(GetRelevantN013ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N013.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N013), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
