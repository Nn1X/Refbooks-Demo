using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F010Refbook.Queries.GetAllRelevantF010
{
    public class GetAllRelevantF010Query : IRequest<F010[]>
    {
        public DateTime Date { get; set; }
    }
}
