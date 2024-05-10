using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F002Refbook.Queries.GetF002ByCode;

public class GetF002ByCodeQueryHandler : IRequestHandler<GetF002ByCodeQuery, F002>
{
    private readonly IRefbooksDbContextFactory _dbFactory;

    public GetF002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<F002> Handle(GetF002ByCodeQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
        {
            var entity = await context.F002.Where(x => x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                throw new NotFoundException(nameof(F002), request.Code);
            }

            return entity;
        }
    }
}