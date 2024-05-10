using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N012XmlMapperConfiguration
{
    public static XmlMapper<N012> AddN012RefbookConfiguration(this XmlMapper<N012> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_I_D")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DS_Igh")?.Value))
            .MapWith((element, model) => model.N010Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_Igh")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}