using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N006XmlMapperConfiguration
{
    public static XmlMapper<N006> AddN006RefbookConfiguration(this XmlMapper<N006> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_gr")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DS_gr")?.Value))
            .MapWith((element, model) => model.StageCode = NullableConvert.ConvertToNullableInt32(element.Element("ID_St")?.Value))
            .MapWith((element, model) => model.TCode = NullableConvert.ConvertToNullableInt32(element.Element("ID_T")?.Value))
            .MapWith((element, model) => model.NCode = NullableConvert.ConvertToNullableInt32(element.Element("ID_N")?.Value))
            .MapWith((element, model) => model.MCode = NullableConvert.ConvertToNullableInt32(element.Element("ID_M")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}