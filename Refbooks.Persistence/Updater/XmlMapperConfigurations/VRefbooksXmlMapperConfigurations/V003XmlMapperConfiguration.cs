using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V003XmlMapperConfiguration
{
    public static XmlMapper<V003> AddV003RefbookConfiguration(this XmlMapper<V003> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDRL")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("LICNAME")?.Value))
            .MapWith((element, model) => model.ElementCode = NullableConvert.ConvertToNullableInt32(element.Element("IERARH")?.Value))
            .MapWith((element, model) => model.AdmissibilitySign = NullableConvert.ConvertToNullableInt32(element.Element("PRIM")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}