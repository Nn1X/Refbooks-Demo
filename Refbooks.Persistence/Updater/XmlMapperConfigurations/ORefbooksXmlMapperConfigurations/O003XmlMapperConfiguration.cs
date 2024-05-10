using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class O003XmlMapperConfiguration
{
    public static XmlMapper<O003> AddO003RefbookConfiguration(this XmlMapper<O003> mapper)
    {
        mapper.MapWith((element, model) => model.SectionCode = NullableConvert.ConvertToNullableString(element.Element("RAZDEL")?.Value))
            .MapWith((element, model) => model.PositionCode = NullableConvert.ConvertToNullableString(element.Element("KOD")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME11")?.Value))
            .MapWith((element, model) => model.AdditionalData = NullableConvert.ConvertToNullableString(element.Element("NAME12")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("NOMDESCR")?.Value))
            .MapWith((element, model) => model.LastEditNumber = NullableConvert.ConvertToNullableString(element.Element("NOMAKT")?.Value))
            .MapWith((element, model) => model.LastEditType = NullableConvert.ConvertToNullableString(element.Element("STATUS")?.Value))
            .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(element.Element("DATEUTV")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEVVED")?.Value));

        return mapper;
    }
}