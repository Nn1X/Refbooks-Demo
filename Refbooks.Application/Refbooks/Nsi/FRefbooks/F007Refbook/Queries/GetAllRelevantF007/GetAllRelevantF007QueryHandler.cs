using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetAllRelevantF007;

public class GetAllRelevantF007QueryHandler : IRequestHandler<GetAllRelevantF007Query, F007[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllRelevantF007QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }


    public async Task<F007[]> Handle(GetAllRelevantF007Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F007.Where(x => x.DateBegin <= request.Date
                                                 && (x.DateEnd >= request.Date || x.DateEnd == null))
                .ToArrayAsync(cancellationToken);

            if (!result.Any())
            {
                throw new NotFoundException(nameof(F007));
            }

            return result;
        }
    }
}