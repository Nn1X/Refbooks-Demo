using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetAllRelevantF006;

public class GetAllRelevantF006QueryHandler : IRequestHandler<GetAllRelevantF006Query, F006[]>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetAllRelevantF006QueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F006[]> Handle(GetAllRelevantF006Query request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var result = await context.F006.Where(x => x.DateBegin <= request.Date
                                                 && (x.DateEnd >= request.Date || x.DateEnd == null))
                .ToArrayAsync(cancellationToken);

            if (!result.Any())
            {
                throw new NotFoundException(nameof(F006));
            }

            return result;
        }
    }
}