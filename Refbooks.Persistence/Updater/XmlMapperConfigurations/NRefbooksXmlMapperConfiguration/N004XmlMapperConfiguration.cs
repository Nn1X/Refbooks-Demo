using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N004XmlMapperConfiguration
{
    public static XmlMapper<N004> AddN004RefbookConfiguration(this XmlMapper<N004> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_N")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DS_N")?.Value))
            .MapWith((element, model) => model.NCode = NullableConvert.ConvertToNullableString(element.Element("KOD_N")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("N_NAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}