using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.MobileTeamsMedicalExaminationCoefficients.Queries.GetAll
{
    public class GetAllMobileTeamsMedicalExaminationCoefficientsQueryHandler
        : IRequestHandler<GetAllMobileTeamsMedicalExaminationCoefficientsQuery,
            List<Domain.Yamed.KsgCalculation.MobileTeamsMedicalExaminationCoefficient>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllMobileTeamsMedicalExaminationCoefficientsQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<MobileTeamsMedicalExaminationCoefficient>> Handle(
            GetAllMobileTeamsMedicalExaminationCoefficientsQuery request, CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.MobileTeamsMedicalExaminationCoefficients
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
