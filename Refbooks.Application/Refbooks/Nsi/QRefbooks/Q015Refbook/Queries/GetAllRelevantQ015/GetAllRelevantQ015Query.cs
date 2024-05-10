
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q015Refbook.Queries.GetAllRelevantQ015
{
    public class GetAllRelevantQ015Query : IRequest<Q015[]>
    {
        public DateTime Date { get; set; }
    }
}
