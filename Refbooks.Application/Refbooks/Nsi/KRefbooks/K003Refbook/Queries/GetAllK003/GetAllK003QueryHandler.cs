
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.KRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.KRefbooks.K003Refbook.Queries.GetAllK003
{
    public class GetAllK003QueryHandler : IRequestHandler<GetAllK003Query, K003[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllK003QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<K003[]> Handle(GetAllK003Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.K003.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(K003));
                }

                return result;
            }
        }
    }
}
