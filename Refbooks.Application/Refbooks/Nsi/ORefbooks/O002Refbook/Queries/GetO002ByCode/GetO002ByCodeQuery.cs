
using MediatR;
using Refbooks.Domain.Nsi.ORefbooks;
namespace Refbooks.Application.Refbooks.Nsi.ORefbooks.O002Refbook.Queries.GetO002ByCode
{
    public class GetO002ByCodeQuery : IRequest<O002>
    {
        public string TerritoryCode { get; set; }
        public string AreaCityCode { get; set; }
        public string VillageCouncilCode { get; set; }
        public string VillageCode { get; set; }
        public int SectionCode { get; set; }
    }
}
