
using MediatR;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Application.Refbooks.Nsi.QRefbooks.Q018Refbook.Queries.GetAllRelevantQ018
{
    public class GetAllRelevantQ018Query : IRequest<Q018[]>
    {
        public DateTime Date { get; set; }
    }
}
