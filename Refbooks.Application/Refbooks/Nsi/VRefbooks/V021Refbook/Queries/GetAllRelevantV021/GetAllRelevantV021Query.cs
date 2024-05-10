
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V021Refbook.Queries.GetAllRelevantV021
{
    public class GetAllRelevantV021Query : IRequest<V021[]>
    {
        public DateTime Date { get; set; }
    }
}
