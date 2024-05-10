
using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F015Refbook.Queries.GetAllRelevantF015
{
    public class GetAllRelevantF015Query : IRequest<F015[]>
    {
        public DateTime Date { get; set; }
    }
}
