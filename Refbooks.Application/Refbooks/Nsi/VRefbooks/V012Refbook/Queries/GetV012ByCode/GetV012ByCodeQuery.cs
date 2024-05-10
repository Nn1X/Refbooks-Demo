
using MediatR;
using Refbooks.Domain.Nsi.VRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.VRefbooks.V012Refbook.Queries.GetV012ByCode
{
    public class GetV012ByCodeQuery : IRequest<V012[]>
    {
        public int Code { get; set; }
    }
}
