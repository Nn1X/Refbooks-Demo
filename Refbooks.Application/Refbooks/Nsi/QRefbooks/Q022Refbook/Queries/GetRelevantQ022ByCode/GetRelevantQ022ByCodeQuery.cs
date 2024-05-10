
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q022Refbook.Queries.GetRelevantQ022ByCode
{
    public class GetRelevantQ022ByCodeQuery : IRequest<Q022>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
