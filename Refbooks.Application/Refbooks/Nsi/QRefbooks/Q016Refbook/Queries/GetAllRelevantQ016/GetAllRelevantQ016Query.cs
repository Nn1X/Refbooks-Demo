
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q016Refbook.Queries.GetAllRelevantQ016
{
    public class GetAllRelevantQ016Query : IRequest<Q016[]>
    {
        public DateTime Date { get; set; }
    }
}
