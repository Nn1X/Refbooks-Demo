using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F007Refbook.Queries.GetF007ByCode;

public class GetF007ByCodeQuery : IRequest<F007[]>
{
    public int Code { get; set; }
}