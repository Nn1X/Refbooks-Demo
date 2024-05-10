
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q020Refbook.Queries.GetAllRelevantQ020
{
    public class GetAllRelevantQ020Query : IRequest<Q020[]>
    {
        public DateTime Date { get; set; }
    }
}
