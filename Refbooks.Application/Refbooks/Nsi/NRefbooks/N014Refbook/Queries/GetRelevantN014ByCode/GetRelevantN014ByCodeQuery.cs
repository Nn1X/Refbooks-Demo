
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N014Refbook.Queries.GetRelevantN014ByCode
{
    public class GetRelevantN014ByCodeQuery : IRequest<N014>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
