using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class O002XmlMapperConfiguration
{
    public static XmlMapper<O002> AddO002RefbookConfiguration(this XmlMapper<O002> mapper)
    {
        mapper.MapWith((element, model) => model.TerritoryCode = NullableConvert.ConvertToNullableString(element.Element("TER")?.Value))
            .MapWith((element, model) => model.AreaCityCode = NullableConvert.ConvertToNullableString(element.Element("KOD1")?.Value))
            .MapWith((element, model) => model.VillageCouncilCode = NullableConvert.ConvertToNullableString(element.Element("KOD2")?.Value))
            .MapWith((element, model) => model.VillageCode = NullableConvert.ConvertToNullableString(element.Element("KOD3")?.Value))
            .MapWith((element, model) => model.SectionCode = NullableConvert.ConvertToNullableInt32(element.Element("RAZDEL")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME1")?.Value))
            .MapWith((element, model) => model.AdditionalData = NullableConvert.ConvertToNullableString(element.Element("CENTRUM")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("NOMDESCR")?.Value))
            .MapWith((element, model) => model.LastEditNumber = NullableConvert.ConvertToNullableString(element.Element("NOMAKT")?.Value))
            .MapWith((element, model) => model.LastEditType = NullableConvert.ConvertToNullableString(element.Element("STATUS")?.Value))
            .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(element.Element("DATEUTV")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEVVED")?.Value));

        return mapper;
    }
}