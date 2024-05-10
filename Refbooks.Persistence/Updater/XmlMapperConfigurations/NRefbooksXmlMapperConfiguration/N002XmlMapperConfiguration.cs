using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N002XmlMapperConfiguration
{
    public static XmlMapper<N002> AddN002RefbookConfiguration(this XmlMapper<N002> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_St")?.Value))
            .MapWith((element, model) => model.SchemeCode = NullableConvert.ConvertToNullableString(element.Element("DS_St")?.Value))
            .MapWith((element, model) => model.MedicamentId = NullableConvert.ConvertToNullableString(element.Element("KOD_St")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}