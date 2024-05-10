
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N011Refbook.Queries.GetRelevantN011ByCode
{
    public class GetRelevantN011ByCodeQuery : IRequest<N011>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
