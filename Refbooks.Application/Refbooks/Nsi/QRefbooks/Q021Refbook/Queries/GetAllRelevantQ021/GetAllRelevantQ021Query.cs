
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q021Refbook.Queries.GetAllRelevantQ021
{
    public class GetAllRelevantQ021Query : IRequest<Q021[]>
    {
        public DateTime Date { get; set; }
    }
}
