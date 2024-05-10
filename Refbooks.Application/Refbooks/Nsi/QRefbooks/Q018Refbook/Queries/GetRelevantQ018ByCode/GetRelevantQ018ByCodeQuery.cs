
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetRelevantQ018ByCode
{
    public class GetRelevantQ018ByCodeQuery : IRequest<Q018>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
