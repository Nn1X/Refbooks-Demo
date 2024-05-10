
using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Common.Exceptions;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O002Refbook.Queries.GetO002ByCode
{
    public class GetO002ByCodeQueryHandler : IRequestHandler<GetO002ByCodeQuery, O002>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetO002ByCodeQueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }


        public async Task<O002> Handle(GetO002ByCodeQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                var entity = await context.O002.Where(x =>
                        x.TerritoryCode == request.TerritoryCode
                        && x.AreaCityCode == request.AreaCityCode
                        && x.VillageCouncilCode == request.VillageCouncilCode
                        && x.VillageCode == request.VillageCode
                        && x.SectionCode == request.SectionCode)
                    .FirstOrDefaultAsync(cancellationToken);

                if (entity is null)
                {
                    throw new NotFoundException(nameof(O002),
                        $"'{request.TerritoryCode}' & '{request.AreaCityCode}' & '{request.VillageCouncilCode}' " +
                        $"& '{request.VillageCode}' & '{request.SectionCode}'");
                }

                return entity;
            }
        }
    }
}
