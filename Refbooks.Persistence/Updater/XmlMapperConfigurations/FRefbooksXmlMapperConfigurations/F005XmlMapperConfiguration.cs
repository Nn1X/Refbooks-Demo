using Refbooks.Application.Common;
using Refbooks.Domain.Nsi.FRefbooks;

namespace Refbooks.Persistence.Updater.XmlMapperConfigurations.FRefbooksXmlMapperConfigurations
{
    public static class F005XmlMapperConfiguration
    {
        public static XmlMapper<F005> AddF005RefbookConfiguration(this XmlMapper<F005> mapper)
        {
            mapper.MapWith((element, model) => model.Code = NullableConvert.ConvertToNullableInt32(element.Element("IDIDST")?.Value))
                .MapWith((element, model) => model.Name = NullableConvert.ConvertToNullableString(element.Element("STNAME")?.Value))
                .MapWith((element, model) => model.DateBegin = NullableConvert.ConvertToNullableDateTime(element.Element("DATEBEG")?.Value))
                .MapWith((element, model) => model.DateEnd = NullableConvert.ConvertToNullableDateTime(element.Element("DATEEND")?.Value));

            return mapper;
        }
    }
}
