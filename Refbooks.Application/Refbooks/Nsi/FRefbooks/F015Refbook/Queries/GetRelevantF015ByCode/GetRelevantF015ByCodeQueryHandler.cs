
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetRelevantF015ByCode
{
    public class GetRelevantF015ByCodeQueryHandler : IRequestHandler<GetRelevantF015ByCodeQuery, F015>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantF015ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<F015> Handle(GetRelevantF015ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.F015.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(F015), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
