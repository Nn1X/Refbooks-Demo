
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetAllQ018
{
    public class GetAllQ018QueryHandler : IRequestHandler<GetAllQ018Query, Q018[]>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllQ018QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<Q018[]> Handle(GetAllQ018Query request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var result = await context.Q018.ToArrayAsync(cancellationToken);

                if (!result.Any())
                {
                    throw new NotFoundException(nameof(Q018));
                }

                return result;
            }
        }
    }
}
