using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.NRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class N001XmlMapperConfiguration
{
    public static XmlMapper<N001> AddN001RefbookConfiguration(this XmlMapper<N001> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("ID_PrOt")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("PrOt_NAME")?.Value))
            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

        return mapper;
    }
}