
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetAllRelevantR012
{
    public class GetAllRelevantR012Query : IRequest<R012[]>
    {
        public DateTime Date { get; set; }
    }
}
