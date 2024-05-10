using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.ManagementKsgCoefficients.Queries.GetAll
{
    public class GetAllManagementKsgCoefficientsQueryHandler
        : IRequestHandler<GetAllManagementKsgCoefficientsQuery,
            List<Domain.Yamed.KsgCalculation.ManagementKsgCoefficient>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllManagementKsgCoefficientsQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<ManagementKsgCoefficient>> Handle(GetAllManagementKsgCoefficientsQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.ManagementKsgCoefficients
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
