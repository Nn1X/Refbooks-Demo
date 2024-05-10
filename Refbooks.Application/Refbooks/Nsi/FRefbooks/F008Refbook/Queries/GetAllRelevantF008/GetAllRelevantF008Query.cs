using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F008Refbook.Queries.GetAllRelevantF008
{
    public class GetAllRelevantF008Query : IRequest<F008[]>
    {
        public DateTime Date { get; set; }
    }
}
