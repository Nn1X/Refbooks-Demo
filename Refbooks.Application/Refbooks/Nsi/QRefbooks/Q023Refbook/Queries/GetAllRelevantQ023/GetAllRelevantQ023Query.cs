
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q023Refbook.Queries.GetAllRelevantQ023
{
    public class GetAllRelevantQ023Query : IRequest<Q023[]>
    {
        public DateTime Date { get; set; }
    }
}
