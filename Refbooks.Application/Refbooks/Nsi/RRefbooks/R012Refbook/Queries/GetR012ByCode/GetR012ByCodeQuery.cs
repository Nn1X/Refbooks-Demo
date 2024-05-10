
using MediatR;
using Refbooks.Domain.Nsi.RRefbooks;
namespace Refbooks.Application.Refbooks.Nsi.RRefbooks.R012Refbook.Queries.GetR012ByCode
{
    public class GetR012ByCodeQuery : IRequest<R012[]>
    {
        public int Code { get; set; }
    }
}
