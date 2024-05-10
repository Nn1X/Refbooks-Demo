
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N005Refbook.Queries.GetRelevantN005ByCode
{
    public class GetRelevantN005ByCodeQuery : IRequest<N005>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
