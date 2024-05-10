using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.QRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.NRefbooksXmlMapperConfiguration;

public static class Q020XmlMapperConfiguration
{
    public static XmlMapper<Q020> AddQ020RefbookConfiguration(this XmlMapper<Q020> mapper)
    {
        mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableString(element.Element("IDTYPE")?.Value))
            .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("NAMETYPE")?.Value))
            .MapWith((element, model) => model.Comment = NullableConvert.ConvertToNullableString(element.Element("COMMENT")?.Value))

            .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEBEG")?.Value))
            .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                element.Element("DATEEND")?.Value));

        return mapper;
    }
}