
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N004Refbook.Queries.GetRelevantN004ByCode
{
    public class GetRelevantN004ByCodeQuery : IRequest<N004>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
