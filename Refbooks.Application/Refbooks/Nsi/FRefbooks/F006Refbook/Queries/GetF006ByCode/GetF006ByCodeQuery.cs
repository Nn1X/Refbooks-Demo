using MediatR;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.FRefbooks.F006Refbook.Queries.GetF006ByCode;

public class GetF006ByCodeQuery : IRequest<F006[]>
{
    public int Code { get; set; }
}