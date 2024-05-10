using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V037XmlMapperConfiguration
{
    public static XmlMapper<V037> AddV037RefbookConfiguration(this XmlMapper<V037> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("CODE")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME")?.Value))
            .MapWith((element, model) => model.MandatoryParametr = NullableConvert.ConvertToNullableInt32(element.Element("Parameter")?.Value))
            .MapWith((element, model) => model.Comment = NullableConvert.ConvertToNullableString(element.Element("COMMENT")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}