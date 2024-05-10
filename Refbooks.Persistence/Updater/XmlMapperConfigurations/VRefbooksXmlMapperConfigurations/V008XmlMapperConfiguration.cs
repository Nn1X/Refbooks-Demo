using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V008XmlMapperConfiguration
{
    public static XmlMapper<V008> AddV008RefbookConfiguration(this XmlMapper<V008> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDVMP")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("VMPNAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}