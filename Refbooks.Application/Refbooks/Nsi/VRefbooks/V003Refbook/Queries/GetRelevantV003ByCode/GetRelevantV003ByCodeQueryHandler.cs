
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V003Refbook.Queries.GetRelevantV003ByCode
{
    public class GetRelevantV003ByCodeQueryHandler : IRequestHandler<GetRelevantV003ByCodeQuery, V003>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V003> Handle(GetRelevantV003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V003.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V003), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
