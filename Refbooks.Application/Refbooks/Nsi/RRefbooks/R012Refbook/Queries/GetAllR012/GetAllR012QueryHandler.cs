
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetAllR012
{
    public class GetAllR012QueryHandler : IRequestHandler<GetAllR012Query, R012[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllR012QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<R012[]> Handle(GetAllR012Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.R012.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(R012));
                }

                return result;
            }
        }
    }
}
