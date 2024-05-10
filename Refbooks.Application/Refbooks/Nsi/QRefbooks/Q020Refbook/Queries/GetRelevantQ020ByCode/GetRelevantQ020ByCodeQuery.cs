
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q020Refbook.Queries.GetRelevantQ020ByCode
{
    public class GetRelevantQ020ByCodeQuery : IRequest<Q020>
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
    }
}
