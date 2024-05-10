using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V017XmlMapperConfiguration
{
    public static XmlMapper<V017> AddV017RefbookConfiguration(this XmlMapper<V017> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDDR")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("DRNAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}