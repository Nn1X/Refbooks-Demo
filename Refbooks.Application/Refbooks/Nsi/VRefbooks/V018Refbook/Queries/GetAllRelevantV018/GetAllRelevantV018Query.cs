
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V018Refbook.Queries.GetAllRelevantV018
{
    public class GetAllRelevantV018Query : IRequest<V018[]>
    {
        public DateTime Date { get; set; }
    }
}
