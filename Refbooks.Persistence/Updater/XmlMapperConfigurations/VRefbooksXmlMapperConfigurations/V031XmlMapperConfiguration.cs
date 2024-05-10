using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V031XmlMapperConfiguration
{
    public static XmlMapper<V031> AddV031RefbookConfiguration(this XmlMapper<V031> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("DrugGroupCode")?.Value))
            .MapWith((element, model) => model.Group = NullableConvert.ConvertToNullableString(element.Element("DrugGroup")?.Value))
            .MapWith((element, model) => model.MnnSign = NullableConvert.ConvertToNullableInt32(element.Element("ManIndMNN")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}