
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N008Refbook.Queries.GetAllRelevantN008
{
    public class GetAllRelevantN008Query : IRequest<N008[]>
    {
        public DateTime Date { get; set; }
    }
}
