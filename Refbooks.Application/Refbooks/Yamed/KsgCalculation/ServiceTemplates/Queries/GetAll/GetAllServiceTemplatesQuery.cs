using MediatR;
using Refbooks.Domain.Yamed.KsgCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refbooks.Application.Refbooks.Yamed.KsgCalculation.ServiceTemplates.Queries.GetAll
{
    public class GetAllServiceTemplatesQuery
        : IRequest<List<ServiceTemplate>>
    {
    }
}
