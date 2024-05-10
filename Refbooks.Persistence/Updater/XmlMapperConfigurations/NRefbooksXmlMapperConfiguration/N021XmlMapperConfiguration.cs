using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N021XmlMapperConfiguration
{
    public static XmlMapper<N021> AddN021RefbookConfiguration(this XmlMapper<N021> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_ZAP")?.Value))
            .MapWith((element, model) => model.SchemeCode = NullableConvert.ConvertToNullableString(element.Element("CODE_SH")?.Value))
            .MapWith((element, model) => model.MedicamentId = NullableConvert.ConvertToNullableString(element.Element("ID_LEKP")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}