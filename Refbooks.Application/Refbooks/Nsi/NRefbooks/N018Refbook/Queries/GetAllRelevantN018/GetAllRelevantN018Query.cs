
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N018Refbook.Queries.GetAllRelevantN018
{
    public class GetAllRelevantN018Query : IRequest<N018[]>
    {
        public DateTime Date { get; set; }
    }
}
