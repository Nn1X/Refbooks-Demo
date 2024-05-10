using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N009XmlMapperConfiguration
{
    public static XmlMapper<N009> AddN009RefbookConfiguration(this XmlMapper<N009> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_M_D")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DS_Mrf")?.Value))
            .MapWith((element, model) => model.N007Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_Mrf")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}