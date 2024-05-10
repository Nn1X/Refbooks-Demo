using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetAllRelevantF002;

public class GetAllRelevantF002QueryHandler : IRequestHandler<GetAllRelevantF002Query, F002[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllRelevantF002QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F002[]> Handle(GetAllRelevantF002Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F002.Where(x => x.DateBegin <= request.Date
                                                 && (x.DateEnd >= request.Date || x.DateEnd == null))
                .ToArrayAsync(cancellationToken);

            if (!result.Any())
            {
                throw new NotFoundException(nameof(F002));
            }

            return result;
        }
    }
}