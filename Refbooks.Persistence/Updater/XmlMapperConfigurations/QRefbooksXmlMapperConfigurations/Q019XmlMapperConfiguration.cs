using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class Q019XmlMapperConfiguration
{
    public static XmlMapper<Q019> AddQ019RefbookConfiguration(this XmlMapper<Q019> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("IDTYPED")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAMETYPED")?.Value))

            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEEND")?.Value));

        return mapper;
    }
}