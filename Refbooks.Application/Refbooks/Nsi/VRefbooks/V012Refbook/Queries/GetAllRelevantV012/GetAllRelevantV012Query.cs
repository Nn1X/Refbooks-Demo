
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetAllRelevantV012
{
    public class GetAllRelevantV012Query : IRequest<V012[]>
    {
        public DateTime Date { get; set; }
    }
}
