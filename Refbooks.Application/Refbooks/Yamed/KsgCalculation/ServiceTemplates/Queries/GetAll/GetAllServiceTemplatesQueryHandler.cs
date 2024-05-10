using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed.KsgCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.ServiceTemplates.Queries.GetAll
{
    public class GetAllServiceTemplatesQueryHandler
        : IRequestHandler<GetAllServiceTemplatesQuery, List<ServiceTemplate>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllServiceTemplatesQueryHandler(
            IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<ServiceTemplate>> Handle(GetAllServiceTemplatesQuery request,
            CancellationToken cancellationToken)
        {
            using (var context = await _dbFactory.CreateDbContextAsync(cancellationToken))
            {
                return await context.ServiceTemplates
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
