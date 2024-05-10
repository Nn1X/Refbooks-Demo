
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q019Refbook.Queries.GetAllRelevantQ019
{
    public class GetAllRelevantQ019Query : IRequest<Q019[]>
    {
        public DateTime Date { get; set; }
    }
}
