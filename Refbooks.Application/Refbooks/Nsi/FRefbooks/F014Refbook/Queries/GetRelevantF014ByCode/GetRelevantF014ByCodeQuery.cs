using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F014Refbook.Queries.GetRelevantF014ByCode
{
    public class GetRelevantF014ByCodeQuery : IRequest<F014>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
