using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.ORefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class O004XmlMapperConfiguration
{
    public static XmlMapper<O004> AddO004RefbookConfiguration(this XmlMapper<O004> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("KOD")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME1")?.Value))
            .MapWith((element, model) => model.CollectionAlgorithm = NullableConvert.ConvertToNullableString(element.Element("ALG")?.Value))
            .MapWith((element, model) => model.LastEditNumber = NullableConvert.ConvertToNullableString(element.Element("NOMAKT")?.Value))
            .MapWith((element, model) => model.LastEditType = NullableConvert.ConvertToNullableString(element.Element("STATUS")?.Value))
            .MapWith((element, model) => model.DateEdit = NullableConvert.ConvertToNullableDateTime(element.Element("DATEUTV")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEVVED")?.Value));

        return mapper;
    }
}