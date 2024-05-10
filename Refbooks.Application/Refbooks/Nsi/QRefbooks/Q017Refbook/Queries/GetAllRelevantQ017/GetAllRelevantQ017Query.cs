
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q017Refbook.Queries.GetAllRelevantQ017
{
    public class GetAllRelevantQ017Query : IRequest<Q017[]>
    {
        public DateTime Date { get; set; }
    }
}
