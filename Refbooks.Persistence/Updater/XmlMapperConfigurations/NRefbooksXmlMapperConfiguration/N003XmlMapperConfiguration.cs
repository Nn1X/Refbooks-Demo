using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N003XmlMapperConfiguration
{
    public static XmlMapper<N003> AddN003RefbookConfiguration(this XmlMapper<N003> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_T")?.Value))
            .MapWith((element, model) => model.MkbDiagnosis = NullableConvert.ConvertToNullableString(element.Element("DS_T")?.Value))
            .MapWith((element, model) => model.TCode = NullableConvert.ConvertToNullableString(element.Element("KOD_T")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("T_NAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}