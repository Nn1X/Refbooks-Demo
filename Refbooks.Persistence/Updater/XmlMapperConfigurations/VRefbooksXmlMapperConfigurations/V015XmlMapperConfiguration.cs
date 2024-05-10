using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.VRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class V015XmlMapperConfiguration
{
    public static XmlMapper<V015> AddV015RefbookConfiguration(this XmlMapper<V015> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("RECID")?.Value))
            .MapWith((element, model) => model.SpecialityCode = NullableConvert.ConvertToNullableInt32(element.Element("CODE")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAME")?.Value))
            .MapWith((element, model) => model.Hierarchy = NullableConvert.ConvertToNullableInt32(element.Element("HIGH")?.Value))
            .MapWith((element, model) => model.Okso = NullableConvert.ConvertToNullableInt32(element.Element("OKSO")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}