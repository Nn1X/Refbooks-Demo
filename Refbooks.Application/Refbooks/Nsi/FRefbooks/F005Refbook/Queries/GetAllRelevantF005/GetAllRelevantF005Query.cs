using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F005Refbook.Queries.GetAllRelevantF005
{
    public class GetAllRelevantF005Query : IRequest<F005[]>
    {
        public DateTime Date { get; set; }
    }
}
