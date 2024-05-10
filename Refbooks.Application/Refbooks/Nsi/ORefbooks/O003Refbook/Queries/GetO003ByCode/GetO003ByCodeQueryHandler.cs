
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O003Refbook.Queries.GetO003ByCode
{
    public class GetO003ByCodeQueryHandler : IRequestHandler<GetO003ByCodeQuery, O003>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetO003ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<O003> Handle(GetO003ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.O003.Where(x =>
                        x.SectionCode == request.SectionCode
                        && x.PositionCode == request.PositionCode)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(O003),
                        $"'{request.SectionCode}' & '{request.PositionCode}'");
                }

                return entity;
            }
        }
    }
}
