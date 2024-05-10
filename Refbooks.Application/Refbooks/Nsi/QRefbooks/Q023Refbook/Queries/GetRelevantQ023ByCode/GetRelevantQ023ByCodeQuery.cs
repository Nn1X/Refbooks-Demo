
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetRelevantQ023ByCode
{
    public class GetRelevantQ023ByCodeQuery : IRequest<Q023>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
