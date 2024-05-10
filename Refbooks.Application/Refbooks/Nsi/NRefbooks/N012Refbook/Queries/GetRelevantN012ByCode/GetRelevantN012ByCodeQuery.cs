
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N012Refbook.Queries.GetRelevantN012ByCode
{
    public class GetRelevantN012ByCodeQuery : IRequest<N012>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
