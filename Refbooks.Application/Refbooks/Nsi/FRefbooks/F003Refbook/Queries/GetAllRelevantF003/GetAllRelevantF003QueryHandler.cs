using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F003Refbook.Queries.GetAllRelevantF003;

public class GetAllRelevantF003QueryHandler : IRequestHandler<GetAllRelevantF003Query, F003[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllRelevantF003QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F003[]> Handle(GetAllRelevantF003Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F003.Where(x => x.DateBegin <= request.Date
                                                 && (x.DateEnd >= request.Date || x.DateEnd == null))
                .ToArrayAsync(cancellationToken);

            if (!result.Any())
            {
                throw new NotFoundException(nameof(F003));
            }

            return result;
        }
    }
}