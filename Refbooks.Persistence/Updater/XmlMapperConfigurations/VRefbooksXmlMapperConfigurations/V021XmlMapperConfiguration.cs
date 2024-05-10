using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V021XmlMapperConfiguration
{
    public static XmlMapper<V021> AddV021RefbookConfiguration(this XmlMapper<V021> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDSPEC")?.Value))
            .MapWith((element, model) => model.SpecialityName = NullableConvert.ConvertToNullableString(element.Element("SPECNAME")?.Value))
            .MapWith((element, model) => model.PositionName = NullableConvert.ConvertToNullableString(element.Element("POSTNAME")?.Value))
            .MapWith((element, model) => model.PositionCode = NullableConvert.ConvertToNullableInt32(element.Element("IDPOST_MZ")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}