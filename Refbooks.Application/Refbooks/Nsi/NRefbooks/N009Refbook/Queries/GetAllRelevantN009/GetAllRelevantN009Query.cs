
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N009Refbook.Queries.GetAllRelevantN009
{
    public class GetAllRelevantN009Query : IRequest<N009[]>
    {
        public DateTime Date { get; set; }
    }
}
