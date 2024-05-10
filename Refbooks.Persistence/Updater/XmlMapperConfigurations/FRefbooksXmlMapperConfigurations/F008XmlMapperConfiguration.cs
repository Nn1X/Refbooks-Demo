using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F008XmlMapperConfiguration
    {
        public static XmlMapper<F008> AddF008RefbookConfiguration(this XmlMapper<F008> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(
                element.Element("IDDOC")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("DOCNAME")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(
                    element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
