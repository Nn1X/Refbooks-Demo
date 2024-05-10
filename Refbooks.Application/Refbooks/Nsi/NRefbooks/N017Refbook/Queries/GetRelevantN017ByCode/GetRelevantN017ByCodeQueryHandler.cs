
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetRelevantN017ByCode
{
    public class GetRelevantN017ByCodeQueryHandler : IRequestHandler<GetRelevantN017ByCodeQuery, N017>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetRelevantN017ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<N017> Handle(GetRelevantN017ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.N017.Where(x => x.DateBegin <= request.Date
                                                           && (x.DateEnd >= request.Date || x.DateEnd == null)
                                                           && x.Code == request.Code)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(N017), request.Code, request.Date);
                }

                return entity;
            }
        }
    }
}
