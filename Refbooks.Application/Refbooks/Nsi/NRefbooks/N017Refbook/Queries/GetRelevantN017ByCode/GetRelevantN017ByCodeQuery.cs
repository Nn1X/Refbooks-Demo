
using MediatR;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.NRefbooks.N017Refbook.Queries.GetRelevantN017ByCode
{
    public class GetRelevantN017ByCodeQuery : IRequest<N017>
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
