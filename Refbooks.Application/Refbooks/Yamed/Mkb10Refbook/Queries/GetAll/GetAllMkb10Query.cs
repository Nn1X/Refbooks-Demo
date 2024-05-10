using MediatR;
using Refbooks.Domain.Yamed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refbooks.Application.Refbooks.Yamed.Mkb10Refbook.Queries.GetAll
{
    public class GetAllMkb10Query : IRequest<List<Mkb10>>
    {
    }
}
