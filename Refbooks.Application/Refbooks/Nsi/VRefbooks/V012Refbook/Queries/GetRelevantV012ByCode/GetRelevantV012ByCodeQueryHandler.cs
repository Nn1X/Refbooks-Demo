
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetRelevantV012ByCode
{
    public class GetRelevantV012ByCodeQueryHandler : IRequestHandler<GetRelevantV012ByCodeQuery, V012>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV012ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V012> Handle(GetRelevantV012ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V012.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V012), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
