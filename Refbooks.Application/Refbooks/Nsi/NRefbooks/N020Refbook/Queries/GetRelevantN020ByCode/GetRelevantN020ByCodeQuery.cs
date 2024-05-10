
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N020Refbook.Queries.GetRelevantN020ByCode
{
    public class GetRelevantN020ByCodeQuery : IRequest<N020>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
