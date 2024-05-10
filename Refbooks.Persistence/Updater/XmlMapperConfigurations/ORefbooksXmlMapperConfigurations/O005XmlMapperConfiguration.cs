using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class O005XmlMapperConfiguration
{
    public static XmlMapper<O005> AddO005RefbookConfiguration(this XmlMapper<O005> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("KOD")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME1")?.Value))
            .MapWith((element, model) => model.Description = NullableConvert.ConvertToNullableString(element.Element("NOMDESCR")?.Value))
            .MapWith((element, model) => model.LastEditNumber = NullableConvert.ConvertToNullableString(element.Element("NOMAKT")?.Value))
            .MapWith((element, model) => model.LastEditType = NullableConvert.ConvertToNullableString(element.Element("STATUS")?.Value))
            .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(element.Element("DATEUTV")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEVVED")?.Value));

        return mapper;
    }
}