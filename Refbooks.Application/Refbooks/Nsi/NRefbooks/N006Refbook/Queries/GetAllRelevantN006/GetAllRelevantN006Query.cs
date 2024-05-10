
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N006Refbook.Queries.GetAllRelevantN006
{
    public class GetAllRelevantN006Query : IRequest<N006[]>
    {
        public DateTime Date { get; set; }
    }
}
