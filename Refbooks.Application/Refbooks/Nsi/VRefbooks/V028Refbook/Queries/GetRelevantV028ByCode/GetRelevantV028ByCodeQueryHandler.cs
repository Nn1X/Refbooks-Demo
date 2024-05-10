
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V028Refbook.Queries.GetRelevantV028ByCode
{
    public class GetRelevantV028ByCodeQueryHandler : IRequestHandler<GetRelevantV028ByCodeQuery, V028>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantV028ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<V028> Handle(GetRelevantV028ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.V028.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(V028), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
