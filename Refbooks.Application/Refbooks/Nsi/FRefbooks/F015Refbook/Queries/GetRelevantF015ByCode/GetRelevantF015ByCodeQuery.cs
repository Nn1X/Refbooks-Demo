
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetRelevantF015ByCode
{
    public class GetRelevantF015ByCodeQuery : IRequest<F015>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
