
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N021Refbook.Queries.GetAllRelevantN021
{
    public class GetAllRelevantN021Query : IRequest<N021[]>
    {
        public DateTime Date { get; set; }
    }
}
