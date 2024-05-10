using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N010XmlMapperConfiguration
{
    public static XmlMapper<N010> AddN010RefbookConfiguration(this XmlMapper<N010> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_Igh")?.Value))
            .MapWith((element, model) => model.Marker = NullableConvert.ConvertToNullableString(element.Element("KOD_Igh")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("Igh_NAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}