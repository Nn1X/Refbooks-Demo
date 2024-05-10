using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class O001XmlMapperConfiguration
{
    public static XmlMapper<O001> AddO001RefbookConfiguration(this XmlMapper<O001> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("KOD")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME11")?.Value))
            .MapWith((element, model) => model.ContinuationName = NullableConvert.ConvertToNullableString(element.Element("NAME12")?.Value))
            .MapWith((element, model) => model.Alpha2Code = NullableConvert.ConvertToNullableString(element.Element("ALFA2")?.Value))
            .MapWith((element, model) => model.Alpha3Code = NullableConvert.ConvertToNullableString(element.Element("ALFA3")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("NOMDESCR")?.Value))
            .MapWith((element, model) => model.LastEditNumber = NullableConvert.ConvertToNullableString(element.Element("NOMAKT")?.Value))
            .MapWith((element, model) => model.LastEditType = NullableConvert.ConvertToNullableString(element.Element("STATUS")?.Value))
            .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(element.Element("DATEUTV")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEVVED")?.Value));

        return mapper;
    }
}