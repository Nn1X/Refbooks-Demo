
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetRelevantQ017ByCode
{
    public class GetRelevantQ017ByCodeQuery : IRequest<Q017>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
