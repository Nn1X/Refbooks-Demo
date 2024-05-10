using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V030XmlMapperConfiguration
{
    public static XmlMapper<V030> AddV030RefbookConfiguration(this XmlMapper<V030> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("SchemCode")?.Value))
            .MapWith((element, model) => model.Scheme = NullableConvert.ConvertToNullableString(element.Element("Scheme")?.Value))
            .MapWith((element, model) => model.SeverityCode = NullableConvert.ConvertToNullableInt32(element.Element("DegreeSeverity")?.Value))
            .MapWith((element, model) => model.Comment = NullableConvert.ConvertToNullableString(element.Element("COMMENT")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}