
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q022Refbook.Queries.GetAllRelevantQ022
{
    public class GetAllRelevantQ022Query : IRequest<Q022[]>
    {
        public DateTime Date { get; set; }
    }
}
