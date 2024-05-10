using MediatR;
using Microsoft.EntityFrameworkCore;
using Refbooks.Application.Interfaces;
using Refbooks.Domain.Yamed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refbooks.Application.Refbooks.Yamed.Mkb10Refbook.Queries.GetAll
{
    public class GetAllMkb10QueryHandler
        : IRequestHandler<GetAllMkb10Query, List<Mkb10>>
    {
        private readonly IRefbooksDbContextFactory _dbFactory;

        public GetAllMkb10QueryHandler(IRefbooksDbContextFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<Mkb10>> Handle(GetAllMkb10Query request, CancellationToken cancellationToken)
        {
            using(var context = await _dbFactory.CreateDbContextAsync(cancellationToken)) 
            {
                return await context.Mkb10
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
